
namespace Arduino_to_Csharp_to_excel
{
    partial class datasets_builder_form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datasets_builder_form));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.baudrates = new System.Windows.Forms.ComboBox();
            this.Serialports = new System.Windows.Forms.ComboBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.recording_worker = new System.ComponentModel.BackgroundWorker();
            this.status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_date = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_separator = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Data_watcher = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this._serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_watcher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datasets Builder";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.disconnect_btn);
            this.groupBox1.Controls.Add(this.baudrates);
            this.groupBox1.Controls.Add(this.Serialports);
            this.groupBox1.Controls.Add(this.connect_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select baud rate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select COM port :";
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.disconnect_btn.Enabled = false;
            this.disconnect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect_btn.Location = new System.Drawing.Point(190, 119);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(90, 25);
            this.disconnect_btn.TabIndex = 3;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // baudrates
            // 
            this.baudrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrates.FormattingEnabled = true;
            this.baudrates.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400"});
            this.baudrates.Location = new System.Drawing.Point(130, 82);
            this.baudrates.Name = "baudrates";
            this.baudrates.Size = new System.Drawing.Size(121, 24);
            this.baudrates.TabIndex = 1;
            // 
            // Serialports
            // 
            this.Serialports.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serialports.FormattingEnabled = true;
            this.Serialports.Location = new System.Drawing.Point(130, 34);
            this.Serialports.Name = "Serialports";
            this.Serialports.Size = new System.Drawing.Size(121, 24);
            this.Serialports.TabIndex = 0;
            // 
            // connect_btn
            // 
            this.connect_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.connect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_btn.Location = new System.Drawing.Point(7, 119);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(90, 25);
            this.connect_btn.TabIndex = 2;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Record
            // 
            this.Record.Enabled = false;
            this.Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record.Location = new System.Drawing.Point(17, 59);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(80, 35);
            this.Record.TabIndex = 3;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click_2);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(190, 59);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(80, 35);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // recording_worker
            // 
            this.recording_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Excel_writing_DoWork);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(83, 429);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 20);
            this.status.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.status);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 557);
            this.panel1.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cb_date);
            this.groupBox4.Controls.Add(this.Record);
            this.groupBox4.Controls.Add(this.Stop);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 106);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Capture";
            // 
            // cb_date
            // 
            this.cb_date.AutoSize = true;
            this.cb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_date.Location = new System.Drawing.Point(89, 21);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(123, 21);
            this.cb_date.TabIndex = 5;
            this.cb_date.Text = "Add timestamp";
            this.cb_date.UseVisualStyleBackColor = true;
            this.cb_date.CheckedChanged += new System.EventHandler(this.cb_date_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Clear_btn);
            this.groupBox3.Controls.Add(this.save_btn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 104);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(89, 69);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(110, 29);
            this.Clear_btn.TabIndex = 1;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(89, 21);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(110, 31);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save file";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_separator);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 68);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select separator :";
            // 
            // cb_separator
            // 
            this.cb_separator.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_separator.FormattingEnabled = true;
            this.cb_separator.Items.AddRange(new object[] {
            ",",
            ";",
            "|",
            "!"});
            this.cb_separator.Location = new System.Drawing.Point(130, 27);
            this.cb_separator.Name = "cb_separator";
            this.cb_separator.Size = new System.Drawing.Size(121, 25);
            this.cb_separator.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Credit : Baptiste ZLOCH (MakeIT owner) March 2021 v1.0";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Data_watcher
            // 
            this.Data_watcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_watcher.Location = new System.Drawing.Point(319, 19);
            this.Data_watcher.Name = "Data_watcher";
            this.Data_watcher.RowHeadersWidth = 51;
            this.Data_watcher.RowTemplate.Height = 24;
            this.Data_watcher.Size = new System.Drawing.Size(576, 539);
            this.Data_watcher.TabIndex = 10;
            this.Data_watcher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_watcher_CellContentClick);
            // 
            // datasets_builder_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(902, 583);
            this.Controls.Add(this.Data_watcher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximumSize = new System.Drawing.Size(920, 630);
            this.MinimumSize = new System.Drawing.Size(920, 630);
            this.Name = "datasets_builder_form";
            this.Text = "MakeIT - Datasets Builder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_watcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.ComboBox baudrates;
        private System.Windows.Forms.ComboBox Serialports;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Button Stop;
        private System.ComponentModel.BackgroundWorker recording_worker;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Data_watcher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_separator;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.CheckBox cb_date;
        private System.IO.Ports.SerialPort _serialPort;
    }
}

