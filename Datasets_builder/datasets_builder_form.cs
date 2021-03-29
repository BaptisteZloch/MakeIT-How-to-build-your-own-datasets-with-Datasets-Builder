using System;
using System.IO.Ports;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Arduino_to_Csharp_to_excel
{
    public partial class datasets_builder_form : Form
    {
        String port_name = "";
        int[] bauds_rates = new int[] { 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 74880, 115200, 230400 };
        int baud_rate;
        SerialPort _serialPort;

        Excel.Application objApp;
        Excel.Workbook objBook;
        Excel.Worksheet objSheet;

        String file_name = "";
        String file_path = "";
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
                status.Text = "Status : Connected";
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Stop recording !");
            status.Text = "Status : Stopped";
            Excel_writing.WorkerSupportsCancellation = true;
            Excel_writing.CancelAsync();
            object misValue = System.Reflection.Missing.Value;
            if (file_path != "")
            {
                if (filename.Text != "")
                {
                    file_name = filename.Text;
                    Console.WriteLine("Writing file at : " + file_path + "\\" + file_name + ".xlsx");
                    objBook.SaveAs(file_path + "\\" + file_name, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    objBook.Close(true, misValue, misValue);
                    objApp.Quit();
                    Stop.Enabled = false;
                    Record.Enabled = true;
                }
                else
                {
                    MessageBox.Show("File name empty !", "Error");
                }
            }
            else
            {
                MessageBox.Show("File path not selected !", "Error");
            }

        }

        private void Excel_writing_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                Console.WriteLine("Start recording !");
                //status.Text = "Status : Recording...";
                _serialPort.Write("1");//Send one that mean the software is waiting for the headers
                int j = 1;
                String line = _serialPort.ReadLine();
                String[] column_array;
                //reading the header of the data
                if (line.Contains(";"))
                {
                    Console.WriteLine("Current line : " + line);
                    column_array = line.Split(';');
                    for (int i = 0; i < column_array.Length; i++)
                    {
                        objSheet.Cells[1, i + 1] = column_array[i];
                    }
                }
                Console.WriteLine("Before while");
                //reading serial's content until the user click on stop that cancels the background worker
                while (!Excel_writing.CancellationPending)
                {
                    _serialPort.Write("2"); //send 2 that mean the software is waiting for the data.
                    line = _serialPort.ReadLine();
                    if (line.Contains(";"))
                    {
                        Console.WriteLine("Current line : " + line);
                        column_array = line.Split(';');
                        for (int i = 0; i < column_array.Length; i++)
                        {
                            objSheet.Cells[j + 1, i + 1] = column_array[i];
                        }
                        Console.WriteLine("Capture in progress...");
                        j++;
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException)
            {

            }
        }

        private void Record_Click_2(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                if (filename.Text != null)
                {
                    file_name = filename.Text;
                    Console.WriteLine("Opening excel app !");
                    objApp = new Excel.Application();
                    if (objApp == null)
                    {
                        MessageBox.Show("Excel not installed on your computer !", "Error");
                        return;
                    }
                    object misValue = System.Reflection.Missing.Value;
                    objBook = objApp.Workbooks.Add(misValue);
                    objSheet = (Excel.Worksheet)objBook.Worksheets.get_Item(1);
                    Stop.Enabled = true;
                    Record.Enabled = false;
                    status.Text = "Status : Recording...";
                    Excel_writing.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Put a filename !", "Error");
                }
            }
            else
            {
                MessageBox.Show("Open a serial port !", "Error");
            }
        }

        private void browse_btn_Click_1(object sender, EventArgs e)
        {
            if (openFolderDialog.ShowDialog() == DialogResult.OK)
            {
                file_path = openFolderDialog.SelectedPath;
                Console.WriteLine("File path : " + file_path);//14 char
                if (file_path.Length > 20)
                {
                    path.Text = file_path.Substring(0, 7) + "..." + file_path.Substring(file_path.Length - 10, 10);
                    Console.WriteLine("Short file path : " + path.Text);//20 char
                    status.Text = "Status : folder loaded";
                }
                else
                {
                    path.Text = file_path;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC_z_SHFipTRltrwM6T_KsFg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.arduino.cc/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.microsoft.com/fr-fr/microsoft-365/excel");
        }
    }
}
