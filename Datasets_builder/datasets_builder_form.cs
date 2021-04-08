using System;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace Arduino_to_Csharp_to_excel
{
    public partial class datasets_builder_form : Form
    {
        String port_name = "";
        char separator = ';';
        int[] bauds_rates = new int[] { 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 74880, 115200, 230400 };
        int baud_rate;

        public datasets_builder_form()
        {
            InitializeComponent();
            Serialports.DataSource = SerialPort.GetPortNames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baud_rate.ToString() != "")
            {
                if ((string)Serialports.SelectedItem != "")
                {
                    baud_rate = bauds_rates[baudrates.SelectedIndex];
                    Console.WriteLine("Baud rate : " + baud_rate);
                    port_name = (string)Serialports.SelectedItem;
                    Console.WriteLine("COM port : " + port_name);
                    _serialPort = new SerialPort(port_name, baud_rate);
                    _serialPort.Open();
                    baudrates.Enabled = false;
                    Serialports.Enabled = false;
                    if (_serialPort.IsOpen)
                    {
                        Console.WriteLine("Connected !");
                        disconnect_btn.Enabled = true;
                        connect_btn.Enabled = false;
                        Record.Enabled = true;
                        status.Text = "Status : Connected";
                    }
                }
                else
                {
                    MessageBox.Show("COM port not selected !", "Error");
                }
            }
            else
            {
                MessageBox.Show("Baud rate not selected !", "Error");
            }
            Console.WriteLine("Well connected !");
        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
                baudrates.Text = "";
                connect_btn.Enabled = true;
                disconnect_btn.Enabled = false;
                Console.WriteLine("Disconnected !");
                status.Text = "Status : Disconnected";
                baudrates.Enabled = true;
                Serialports.Enabled = true;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Stop recording !");
            status.Text = "Status : Stopped";
            recording_worker.WorkerSupportsCancellation = true;
            recording_worker.CancelAsync();
            Stop.Enabled = false;
            Record.Enabled = true;
            save_btn.Enabled = true;
            disconnect_btn.Enabled = true;
            Clear_btn.Enabled = true;
        }

        private void Excel_writing_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                Console.WriteLine("Start recording !");
                //status.Text = "Status : Recording...";
                _serialPort.Write("1");//Send one that mean the software is waiting for the headers
                String line = _serialPort.ReadLine();
                line = line.Replace("\r\n", string.Empty);
                line = line.Replace("\r", string.Empty);
                String[] column_array;
                //reading the header of the data
                if (line.Contains(separator.ToString()))
                {
                    Console.WriteLine("Current line : " + line);
                    column_array = line.Split(separator);
                    if (cb_date.Checked)
                    {
                        Data_watcher.Invoke(new MethodInvoker(delegate
                        {
                            Data_watcher.ColumnCount = column_array.Length + 1;
                            Data_watcher.ColumnHeadersVisible = true;
                            Data_watcher.Columns[0].Name = "Timestamp";
                        }));
                        for (int i = 0; i < column_array.Length; i++)
                        {
                            Data_watcher.Invoke(new MethodInvoker(delegate
                            {
                                Data_watcher.Columns[i + 1].Name = column_array[i];
                            }));
                        }
                    }
                    else
                    {
                        Data_watcher.Invoke(new MethodInvoker(delegate
                        {
                            Data_watcher.ColumnCount = column_array.Length;
                            Data_watcher.ColumnHeadersVisible = true;
                        }));
                        for (int i = 0; i < column_array.Length; i++)
                        {
                            Data_watcher.Invoke(new MethodInvoker(delegate
                            {
                                Data_watcher.Columns[i].Name = column_array[i];
                            }));
                        }
                    }
                }
                else
                {
                    if (cb_date.Checked)
                    {
                        Data_watcher.Invoke(new MethodInvoker(delegate
                        {
                            Data_watcher.ColumnCount = 2;
                            Data_watcher.ColumnHeadersVisible = true;
                            Data_watcher.Columns[0].Name = "Timestamp";
                            Data_watcher.Columns[1].Name = line;
                        }));
                    }
                    else
                    {
                        Data_watcher.Invoke(new MethodInvoker(delegate
                        {
                            Data_watcher.ColumnCount = 1;
                            Data_watcher.ColumnHeadersVisible = true;
                            Data_watcher.Columns[0].Name = line;
                        }));
                    }
                }
                //reading serial's content until the user click on stop that cancels the background worker
                while (!recording_worker.CancellationPending)
                {
                    _serialPort.Write("2"); //send 2 that mean the software is waiting for the data.
                    line = _serialPort.ReadLine();
                    line = line.Replace("\r\n", string.Empty);
                    line = line.Replace("\r", string.Empty);
                    if (line.Contains(separator.ToString()))
                    {
                        Console.WriteLine("Current line : " + line);
                        if (cb_date.Checked)
                        {
                            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
                            line = timestamp + separator + line;
                        }
                        column_array = line.Split(separator);
                        Data_watcher.Invoke(new MethodInvoker(delegate
                        {
                            this.Data_watcher.Rows.Add(column_array);
                        }));
                        Console.WriteLine("Capture in progress...");
                    }
                    else
                    {
                        if (cb_date.Checked)
                        {
                            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
                            line = timestamp + ";" + line;
                            Data_watcher.Invoke(new MethodInvoker(delegate
                            {
                                this.Data_watcher.Rows.Add(line.Split(';'));
                            }));
                            Console.WriteLine("Current line : " + line);
                            Console.WriteLine("Capture in progress...");
                        }
                        else
                        {
                            Data_watcher.Invoke(new MethodInvoker(delegate
                            {
                                this.Data_watcher.Rows.Add(line);
                            }));
                            Console.WriteLine("Current line : " + line);
                            Console.WriteLine("Capture in progress...");
                        }
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException)
            {

            }
        }

        private void Record_Click_2(object sender, EventArgs e)
        {
            separator = Convert.ToChar(cb_separator.SelectedItem);
            Console.WriteLine("Spliting character : " + separator);
            if (_serialPort != null && _serialPort.IsOpen && separator.Equals(null) == false)
            {
                Stop.Enabled = true;
                Record.Enabled = false;
                status.Text = "Status : Recording...";
                save_btn.Enabled = false;
                Clear_btn.Enabled = false;
                disconnect_btn.Enabled = false;
                cb_separator.Enabled = false;
                cb_date.Enabled = false;
                recording_worker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Open a serial port !", "Error");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC_z_SHFipTRltrwM6T_KsFg");
        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            if (Data_watcher.Rows.Count > 0)
            {
                saveFileDialog1.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog1.FileName = "Output.csv";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FilterIndex = 1;
                bool fileError = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog1.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            Console.WriteLine("Extension " + saveFileDialog1.AddExtension.ToString());
                            int columnCount = Data_watcher.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[Data_watcher.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += Data_watcher.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;
                            for (int i = 1; (i - 1) < Data_watcher.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    if (Data_watcher.Rows[i - 1].Cells[j].Value != null)
                                    {
                                        if (j == columnCount - 1)
                                        {
                                            outputCsv[i] += Data_watcher.Rows[i - 1].Cells[j].Value.ToString();
                                        }
                                        else
                                        {
                                            outputCsv[i] += Data_watcher.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                        }
                                    }
                                }
                            }
                            File.WriteAllLines(saveFileDialog1.FileName, outputCsv, Encoding.UTF8);
                            status.Text = "Status : File saved";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Data_watcher.Rows.Clear();
            Data_watcher.Columns.Clear();
            cb_date.Enabled = true;
            cb_separator.Enabled = true;
            status.Text = "Status : Grid cleared";
        }

        private void cb_date_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Data_watcher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
