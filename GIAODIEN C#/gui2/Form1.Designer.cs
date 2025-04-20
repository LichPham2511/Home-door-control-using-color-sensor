namespace gui2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DISCONNECT = new System.Windows.Forms.Button();
            this.CONNECT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.THONGBAO = new System.Windows.Forms.TextBox();
            this.COMPORT = new System.Windows.Forms.ComboBox();
            this.BAUDRATE = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorblue = new System.Windows.Forms.FlowLayoutPanel();
            this.colorgreen = new System.Windows.Forms.FlowLayoutPanel();
            this.colorred = new System.Windows.Forms.FlowLayoutPanel();
            this.THONGBAOMAU = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.soreceive = new System.Windows.Forms.TextBox();
            this.sosend = new System.Windows.Forms.TextBox();
            this.checkBox_DataSend = new System.Windows.Forms.CheckBox();
            this.TEXTSEND = new System.Windows.Forms.TextBox();
            this.TEXTRECEIVE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SEND = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.testnhanh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DISCONNECT);
            this.groupBox1.Controls.Add(this.CONNECT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.THONGBAO);
            this.groupBox1.Controls.Add(this.COMPORT);
            this.groupBox1.Controls.Add(this.BAUDRATE);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup Uart";
            // 
            // DISCONNECT
            // 
            this.DISCONNECT.Location = new System.Drawing.Point(202, 285);
            this.DISCONNECT.Name = "DISCONNECT";
            this.DISCONNECT.Size = new System.Drawing.Size(215, 47);
            this.DISCONNECT.TabIndex = 4;
            this.DISCONNECT.Text = "DISCONNECT";
            this.DISCONNECT.UseVisualStyleBackColor = true;
            this.DISCONNECT.Click += new System.EventHandler(this.DISCONNECT_Click);
            // 
            // CONNECT
            // 
            this.CONNECT.Location = new System.Drawing.Point(6, 285);
            this.CONNECT.Name = "CONNECT";
            this.CONNECT.Size = new System.Drawing.Size(178, 47);
            this.CONNECT.TabIndex = 3;
            this.CONNECT.Text = "CONNECT";
            this.CONNECT.UseVisualStyleBackColor = true;
            this.CONNECT.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM port";
            // 
            // THONGBAO
            // 
            this.THONGBAO.BackColor = System.Drawing.Color.Brown;
            this.THONGBAO.Location = new System.Drawing.Point(81, 199);
            this.THONGBAO.Name = "THONGBAO";
            this.THONGBAO.Size = new System.Drawing.Size(236, 38);
            this.THONGBAO.TabIndex = 1;
            this.THONGBAO.Text = "DISCONNECTED!";
            // 
            // COMPORT
            // 
            this.COMPORT.FormattingEnabled = true;
            this.COMPORT.Location = new System.Drawing.Point(170, 56);
            this.COMPORT.Name = "COMPORT";
            this.COMPORT.Size = new System.Drawing.Size(162, 39);
            this.COMPORT.TabIndex = 0;
            this.COMPORT.SelectedIndexChanged += new System.EventHandler(this.COMPORT_SelectedIndexChanged);
            // 
            // BAUDRATE
            // 
            this.BAUDRATE.FormattingEnabled = true;
            this.BAUDRATE.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "7200",
            "7800",
            "9600",
            "19200",
            "38400"});
            this.BAUDRATE.Location = new System.Drawing.Point(170, 107);
            this.BAUDRATE.Name = "BAUDRATE";
            this.BAUDRATE.Size = new System.Drawing.Size(162, 39);
            this.BAUDRATE.TabIndex = 0;
            this.BAUDRATE.SelectedIndexChanged += new System.EventHandler(this.BAUDRATE_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorblue);
            this.groupBox2.Controls.Add(this.colorgreen);
            this.groupBox2.Controls.Add(this.colorred);
            this.groupBox2.Controls.Add(this.THONGBAOMAU);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(451, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 256);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Led color";
            // 
            // colorblue
            // 
            this.colorblue.BackColor = System.Drawing.Color.Blue;
            this.colorblue.Location = new System.Drawing.Point(283, 59);
            this.colorblue.Name = "colorblue";
            this.colorblue.Size = new System.Drawing.Size(105, 90);
            this.colorblue.TabIndex = 2;
            // 
            // colorgreen
            // 
            this.colorgreen.BackColor = System.Drawing.Color.Green;
            this.colorgreen.Location = new System.Drawing.Point(154, 59);
            this.colorgreen.Name = "colorgreen";
            this.colorgreen.Size = new System.Drawing.Size(105, 90);
            this.colorgreen.TabIndex = 2;
            // 
            // colorred
            // 
            this.colorred.BackColor = System.Drawing.Color.IndianRed;
            this.colorred.Location = new System.Drawing.Point(22, 59);
            this.colorred.Name = "colorred";
            this.colorred.Size = new System.Drawing.Size(100, 88);
            this.colorred.TabIndex = 1;
            // 
            // THONGBAOMAU
            // 
            this.THONGBAOMAU.Location = new System.Drawing.Point(107, 199);
            this.THONGBAOMAU.Name = "THONGBAOMAU";
            this.THONGBAOMAU.Size = new System.Drawing.Size(174, 38);
            this.THONGBAOMAU.TabIndex = 0;
            this.THONGBAOMAU.Text = "COLOR RED";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.soreceive);
            this.groupBox3.Controls.Add(this.sosend);
            this.groupBox3.Controls.Add(this.checkBox_DataSend);
            this.groupBox3.Controls.Add(this.TEXTSEND);
            this.groupBox3.Controls.Add(this.TEXTRECEIVE);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(908, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 338);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Data";
            // 
            // soreceive
            // 
            this.soreceive.Location = new System.Drawing.Point(53, 285);
            this.soreceive.Name = "soreceive";
            this.soreceive.Size = new System.Drawing.Size(127, 38);
            this.soreceive.TabIndex = 6;
            // 
            // sosend
            // 
            this.sosend.Location = new System.Drawing.Point(53, 224);
            this.sosend.Name = "sosend";
            this.sosend.Size = new System.Drawing.Size(127, 38);
            this.sosend.TabIndex = 5;
            // 
            // checkBox_DataSend
            // 
            this.checkBox_DataSend.AutoSize = true;
            this.checkBox_DataSend.Location = new System.Drawing.Point(230, 42);
            this.checkBox_DataSend.Name = "checkBox_DataSend";
            this.checkBox_DataSend.Size = new System.Drawing.Size(18, 17);
            this.checkBox_DataSend.TabIndex = 4;
            this.checkBox_DataSend.UseVisualStyleBackColor = true;
            this.checkBox_DataSend.CheckedChanged += new System.EventHandler(this.checkBox_DataSend_CheckedChanged);
            // 
            // TEXTSEND
            // 
            this.TEXTSEND.Location = new System.Drawing.Point(110, 69);
            this.TEXTSEND.Name = "TEXTSEND";
            this.TEXTSEND.ReadOnly = true;
            this.TEXTSEND.Size = new System.Drawing.Size(160, 38);
            this.TEXTSEND.TabIndex = 0;
            this.TEXTSEND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TEXTRECEIVE
            // 
            this.TEXTRECEIVE.Location = new System.Drawing.Point(110, 115);
            this.TEXTRECEIVE.Name = "TEXTRECEIVE";
            this.TEXTRECEIVE.ReadOnly = true;
            this.TEXTRECEIVE.Size = new System.Drawing.Size(160, 38);
            this.TEXTRECEIVE.TabIndex = 0;
            this.TEXTRECEIVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "RECEIVE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "SEND";
            // 
            // SEND
            // 
            this.SEND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEND.Location = new System.Drawing.Point(908, 356);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(171, 49);
            this.SEND.TabIndex = 1;
            this.SEND.Text = "SEND";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.SEND_Click);
            // 
            // EXIT
            // 
            this.EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(1085, 357);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(218, 48);
            this.EXIT.TabIndex = 2;
            this.EXIT.Text = "EXIT PROGRAM";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1275, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 54);
            this.label5.TabIndex = 3;
            this.label5.Text = "T2L";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "có ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "được truyền đi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-4, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "có ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "được nhận về";
            // 
            // testnhanh
            // 
            this.testnhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.testnhanh.Location = new System.Drawing.Point(711, 293);
            this.testnhanh.Name = "testnhanh";
            this.testnhanh.Size = new System.Drawing.Size(191, 51);
            this.testnhanh.TabIndex = 4;
            this.testnhanh.Text = "test nhanh";
            this.testnhanh.UseVisualStyleBackColor = true;
            this.testnhanh.Click += new System.EventHandler(this.testnhanh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 457);
            this.Controls.Add(this.testnhanh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.SEND);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox COMPORT;
        private System.Windows.Forms.ComboBox BAUDRATE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox THONGBAO;
        private System.Windows.Forms.FlowLayoutPanel colorred;
        private System.Windows.Forms.TextBox THONGBAOMAU;
        private System.Windows.Forms.TextBox TEXTRECEIVE;
        private System.Windows.Forms.TextBox TEXTSEND;
        private System.Windows.Forms.Button DISCONNECT;
        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SEND;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_DataSend;
        private System.Windows.Forms.TextBox soreceive;
        private System.Windows.Forms.TextBox sosend;
        private System.Windows.Forms.FlowLayoutPanel colorblue;
        private System.Windows.Forms.FlowLayoutPanel colorgreen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button testnhanh;
    }
}

