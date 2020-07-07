namespace bai3.Auto_detectcom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CBSecCom = new System.Windows.Forms.ComboBox();
            this.pbconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBsatus = new System.Windows.Forms.Label();
            this.com = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.PbSend = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtf1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtf2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbSin = new System.Windows.Forms.CheckBox();
            this.CbTri = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CbTriMode2 = new System.Windows.Forms.CheckBox();
            this.CbTriMode1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CbSinMode2 = new System.Windows.Forms.CheckBox();
            this.CbSinMode1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtf2_receive = new System.Windows.Forms.TextBox();
            this.txtA2_receive = new System.Windows.Forms.TextBox();
            this.txtf1_receive = new System.Windows.Forms.TextBox();
            this.txtA1_receive = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBSecCom
            // 
            this.CBSecCom.FormattingEnabled = true;
            this.CBSecCom.Location = new System.Drawing.Point(372, 45);
            this.CBSecCom.Margin = new System.Windows.Forms.Padding(6);
            this.CBSecCom.Name = "CBSecCom";
            this.CBSecCom.Size = new System.Drawing.Size(216, 33);
            this.CBSecCom.TabIndex = 0;
            this.CBSecCom.Text = "COM5";
            this.CBSecCom.SelectedIndexChanged += new System.EventHandler(this.CBSecCom_SelectedIndexChanged);
            // 
            // pbconnect
            // 
            this.pbconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbconnect.Location = new System.Drawing.Point(372, 104);
            this.pbconnect.Margin = new System.Windows.Forms.Padding(6);
            this.pbconnect.Name = "pbconnect";
            this.pbconnect.Size = new System.Drawing.Size(216, 77);
            this.pbconnect.TabIndex = 1;
            this.pbconnect.Text = "Connect";
            this.pbconnect.UseVisualStyleBackColor = true;
            this.pbconnect.Click += new System.EventHandler(this.pbconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select com";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbconnect);
            this.groupBox1.Controls.Add(this.CBSecCom);
            this.groupBox1.Controls.Add(this.LBsatus);
            this.groupBox1.Location = new System.Drawing.Point(106, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(640, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LBsatus
            // 
            this.LBsatus.AutoSize = true;
            this.LBsatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsatus.Location = new System.Drawing.Point(65, 126);
            this.LBsatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBsatus.Name = "LBsatus";
            this.LBsatus.Size = new System.Drawing.Size(272, 55);
            this.LBsatus.TabIndex = 4;
            this.LBsatus.Text = "Disconnect";
            this.LBsatus.Click += new System.EventHandler(this.LBsatus_Click);
            // 
            // com
            // 
            this.com.BaudRate = 115200;
            this.com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Oncom);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // txtA1
            // 
            this.txtA1.Enabled = false;
            this.txtA1.Location = new System.Drawing.Point(111, 36);
            this.txtA1.Margin = new System.Windows.Forms.Padding(6);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(74, 31);
            this.txtA1.TabIndex = 6;
            this.txtA1.Text = "0.0";
            this.txtA1.TextChanged += new System.EventHandler(this.txtA1_TextChanged);
            // 
            // PbSend
            // 
            this.PbSend.Enabled = false;
            this.PbSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbSend.Location = new System.Drawing.Point(160, 352);
            this.PbSend.Margin = new System.Windows.Forms.Padding(6);
            this.PbSend.Name = "PbSend";
            this.PbSend.Size = new System.Drawing.Size(229, 52);
            this.PbSend.TabIndex = 7;
            this.PbSend.Text = "Send";
            this.PbSend.UseVisualStyleBackColor = true;
            this.PbSend.Click += new System.EventHandler(this.PbSend_Click);
            // 
            // pbExit
            // 
            this.pbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbExit.Location = new System.Drawing.Point(789, 173);
            this.pbExit.Margin = new System.Windows.Forms.Padding(6);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(152, 96);
            this.pbExit.TabIndex = 8;
            this.pbExit.Text = "Exit";
            this.pbExit.UseVisualStyleBackColor = true;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "A1";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "f1";
            // 
            // txtf1
            // 
            this.txtf1.Enabled = false;
            this.txtf1.Location = new System.Drawing.Point(111, 86);
            this.txtf1.Margin = new System.Windows.Forms.Padding(6);
            this.txtf1.Name = "txtf1";
            this.txtf1.Size = new System.Drawing.Size(74, 31);
            this.txtf1.TabIndex = 6;
            this.txtf1.Text = "0.0";
            this.txtf1.TextChanged += new System.EventHandler(this.txtf1_TextChanged);
            // 
            // txtA2
            // 
            this.txtA2.Enabled = false;
            this.txtA2.Location = new System.Drawing.Point(399, 36);
            this.txtA2.Margin = new System.Windows.Forms.Padding(6);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(74, 31);
            this.txtA2.TabIndex = 6;
            this.txtA2.Text = "0.0";
            this.txtA2.TextChanged += new System.EventHandler(this.txtA2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "A2";
            // 
            // txtf2
            // 
            this.txtf2.Enabled = false;
            this.txtf2.Location = new System.Drawing.Point(399, 86);
            this.txtf2.Margin = new System.Windows.Forms.Padding(6);
            this.txtf2.Name = "txtf2";
            this.txtf2.Size = new System.Drawing.Size(74, 31);
            this.txtf2.TabIndex = 6;
            this.txtf2.Text = "0,0";
            this.txtf2.TextChanged += new System.EventHandler(this.txtf2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "f2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(49, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(569, 55);
            this.label7.TabIndex = 12;
            this.label7.Text = "BÁO CÁO BÀI TẬP LỚN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CbSin
            // 
            this.CbSin.AutoSize = true;
            this.CbSin.Enabled = false;
            this.CbSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSin.Location = new System.Drawing.Point(75, 149);
            this.CbSin.Margin = new System.Windows.Forms.Padding(6);
            this.CbSin.Name = "CbSin";
            this.CbSin.Size = new System.Drawing.Size(147, 30);
            this.CbSin.TabIndex = 13;
            this.CbSin.Text = "Sin_wave";
            this.CbSin.UseVisualStyleBackColor = true;
            this.CbSin.CheckedChanged += new System.EventHandler(this.CbSin_CheckedChanged_1);
            // 
            // CbTri
            // 
            this.CbTri.AutoSize = true;
            this.CbTri.Enabled = false;
            this.CbTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTri.Location = new System.Drawing.Point(327, 149);
            this.CbTri.Margin = new System.Windows.Forms.Padding(6);
            this.CbTri.Name = "CbTri";
            this.CbTri.Size = new System.Drawing.Size(197, 30);
            this.CbTri.TabIndex = 13;
            this.CbTri.Text = "Triangle_wave";
            this.CbTri.UseVisualStyleBackColor = true;
            this.CbTri.CheckedChanged += new System.EventHandler(this.CbTri_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(67, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(527, 42);
            this.label8.TabIndex = 12;
            this.label8.Text = "GVHD : NGUYỄN VĨNH HẢO";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(211, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 37);
            this.label9.TabIndex = 12;
            this.label9.Text = "SVTH: Nhóm 2";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.CbTriMode2);
            this.groupBox2.Controls.Add(this.CbTriMode1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.CbSinMode2);
            this.groupBox2.Controls.Add(this.CbSinMode1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CbTri);
            this.groupBox2.Controls.Add(this.CbSin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PbSend);
            this.groupBox2.Controls.Add(this.txtf2);
            this.groupBox2.Controls.Add(this.txtA2);
            this.groupBox2.Controls.Add(this.txtf1);
            this.groupBox2.Controls.Add(this.txtA1);
            this.groupBox2.Location = new System.Drawing.Point(106, 381);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(558, 427);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Data";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(322, 202);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "Choose Mode";
            // 
            // CbTriMode2
            // 
            this.CbTriMode2.AutoSize = true;
            this.CbTriMode2.Enabled = false;
            this.CbTriMode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTriMode2.Location = new System.Drawing.Point(327, 272);
            this.CbTriMode2.Margin = new System.Windows.Forms.Padding(6);
            this.CbTriMode2.Name = "CbTriMode2";
            this.CbTriMode2.Size = new System.Drawing.Size(122, 30);
            this.CbTriMode2.TabIndex = 22;
            this.CbTriMode2.Text = "Mode 2";
            this.CbTriMode2.UseVisualStyleBackColor = true;
            this.CbTriMode2.CheckedChanged += new System.EventHandler(this.CbTriMode2_CheckChange);
            // 
            // CbTriMode1
            // 
            this.CbTriMode1.AutoSize = true;
            this.CbTriMode1.Enabled = false;
            this.CbTriMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTriMode1.Location = new System.Drawing.Point(327, 235);
            this.CbTriMode1.Margin = new System.Windows.Forms.Padding(6);
            this.CbTriMode1.Name = "CbTriMode1";
            this.CbTriMode1.Size = new System.Drawing.Size(122, 30);
            this.CbTriMode1.TabIndex = 21;
            this.CbTriMode1.Text = "Mode 1";
            this.CbTriMode1.UseVisualStyleBackColor = true;
            this.CbTriMode1.CheckedChanged += new System.EventHandler(this.CbTriMode1_CheckChange);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(70, 202);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Choose Mode";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // CbSinMode2
            // 
            this.CbSinMode2.AutoSize = true;
            this.CbSinMode2.Enabled = false;
            this.CbSinMode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSinMode2.Location = new System.Drawing.Point(75, 272);
            this.CbSinMode2.Margin = new System.Windows.Forms.Padding(6);
            this.CbSinMode2.Name = "CbSinMode2";
            this.CbSinMode2.Size = new System.Drawing.Size(122, 30);
            this.CbSinMode2.TabIndex = 19;
            this.CbSinMode2.Text = "Mode 2";
            this.CbSinMode2.UseVisualStyleBackColor = true;
            this.CbSinMode2.CheckedChanged += new System.EventHandler(this.CbSinMode2_CheckChange);
            // 
            // CbSinMode1
            // 
            this.CbSinMode1.AutoSize = true;
            this.CbSinMode1.Enabled = false;
            this.CbSinMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSinMode1.Location = new System.Drawing.Point(75, 235);
            this.CbSinMode1.Margin = new System.Windows.Forms.Padding(6);
            this.CbSinMode1.Name = "CbSinMode1";
            this.CbSinMode1.Size = new System.Drawing.Size(122, 30);
            this.CbSinMode1.TabIndex = 18;
            this.CbSinMode1.Text = "Mode 1";
            this.CbSinMode1.UseVisualStyleBackColor = true;
            this.CbSinMode1.CheckedChanged += new System.EventHandler(this.CbSinMode1_CheckChange);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "V";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(498, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "V";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Hz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(498, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Hz";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(193, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Võ Trung - MSSV: 1713725";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txtf2_receive);
            this.groupBox3.Controls.Add(this.txtA2_receive);
            this.groupBox3.Controls.Add(this.txtf1_receive);
            this.groupBox3.Controls.Add(this.txtA1_receive);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(701, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 427);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receive Data";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtf2_receive
            // 
            this.txtf2_receive.Enabled = false;
            this.txtf2_receive.Location = new System.Drawing.Point(102, 329);
            this.txtf2_receive.Margin = new System.Windows.Forms.Padding(6);
            this.txtf2_receive.Name = "txtf2_receive";
            this.txtf2_receive.Size = new System.Drawing.Size(74, 31);
            this.txtf2_receive.TabIndex = 27;
            this.txtf2_receive.Text = "0.0";
            // 
            // txtA2_receive
            // 
            this.txtA2_receive.Enabled = false;
            this.txtA2_receive.Location = new System.Drawing.Point(102, 247);
            this.txtA2_receive.Margin = new System.Windows.Forms.Padding(6);
            this.txtA2_receive.Name = "txtA2_receive";
            this.txtA2_receive.Size = new System.Drawing.Size(74, 31);
            this.txtA2_receive.TabIndex = 26;
            this.txtA2_receive.Text = "0.0";
            // 
            // txtf1_receive
            // 
            this.txtf1_receive.Enabled = false;
            this.txtf1_receive.Location = new System.Drawing.Point(102, 162);
            this.txtf1_receive.Margin = new System.Windows.Forms.Padding(6);
            this.txtf1_receive.Name = "txtf1_receive";
            this.txtf1_receive.Size = new System.Drawing.Size(74, 31);
            this.txtf1_receive.TabIndex = 25;
            this.txtf1_receive.Text = "0.0";
            // 
            // txtA1_receive
            // 
            this.txtA1_receive.Enabled = false;
            this.txtA1_receive.Location = new System.Drawing.Point(102, 75);
            this.txtA1_receive.Margin = new System.Windows.Forms.Padding(6);
            this.txtA1_receive.Name = "txtA1_receive";
            this.txtA1_receive.Size = new System.Drawing.Size(74, 31);
            this.txtA1_receive.TabIndex = 23;
            this.txtA1_receive.Text = "0.0";
            this.txtA1_receive.TextChanged += new System.EventHandler(this.txtA1_receive_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 329);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 36);
            this.label18.TabIndex = 23;
            this.label18.Text = "f2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 162);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 36);
            this.label16.TabIndex = 23;
            this.label16.Text = "f1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 247);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 36);
            this.label19.TabIndex = 24;
            this.label19.Text = "A2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 75);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 36);
            this.label17.TabIndex = 24;
            this.label17.Text = "A1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(994, 381);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(644, 427);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(115, 286);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(422, 31);
            this.label22.TabIndex = 19;
            this.label22.Text = "Đặng Anh Tuấn - MSSV: 1713774";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(123, 326);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(414, 31);
            this.label21.TabIndex = 18;
            this.label21.Text = "Trần Minh Tiến - MSSV: 1713493";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(134, 373);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(403, 31);
            this.label20.TabIndex = 17;
            this.label20.Text = "Ngô Quốc Chí - MSSV: 1710679";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1175, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(185, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 25);
            this.label23.TabIndex = 24;
            this.label23.Text = "V";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(185, 165);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 25);
            this.label24.TabIndex = 23;
            this.label24.Text = "Hz";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(185, 250);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(26, 25);
            this.label25.TabIndex = 29;
            this.label25.Text = "V";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(185, 332);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 25);
            this.label26.TabIndex = 28;
            this.label26.Text = "Hz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 842);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBSecCom;
        private System.Windows.Forms.Button pbconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort com;
        private System.Windows.Forms.Label LBsatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.Button PbSend;
        private System.Windows.Forms.Button pbExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtf1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtf2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CbSin;
        private System.Windows.Forms.CheckBox CbTri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CbSinMode2;
        private System.Windows.Forms.CheckBox CbSinMode1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox CbTriMode2;
        private System.Windows.Forms.CheckBox CbTriMode1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtf2_receive;
        private System.Windows.Forms.TextBox txtA2_receive;
        private System.Windows.Forms.TextBox txtf1_receive;
        private System.Windows.Forms.TextBox txtA1_receive;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}

