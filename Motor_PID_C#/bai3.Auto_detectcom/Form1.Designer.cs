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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CBSecCom = new System.Windows.Forms.ComboBox();
            this.pbconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBsatus = new System.Windows.Forms.Label();
            this.com = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtKp = new System.Windows.Forms.TextBox();
            this.PbSend = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.txtKd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtsetpoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbquaythuan = new System.Windows.Forms.CheckBox();
            this.pbquaynghich = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PbST_TIMER2 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBSecCom
            // 
            this.CBSecCom.FormattingEnabled = true;
            this.CBSecCom.Location = new System.Drawing.Point(280, 27);
            this.CBSecCom.Margin = new System.Windows.Forms.Padding(6);
            this.CBSecCom.Name = "CBSecCom";
            this.CBSecCom.Size = new System.Drawing.Size(216, 33);
            this.CBSecCom.TabIndex = 0;
            this.CBSecCom.Text = "COM11";
            this.CBSecCom.SelectedIndexChanged += new System.EventHandler(this.CBSecCom_SelectedIndexChanged);
            // 
            // pbconnect
            // 
            this.pbconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbconnect.Location = new System.Drawing.Point(280, 97);
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
            this.label1.Font = new System.Drawing.Font("TUV Montserrat", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 298);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(554, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LBsatus
            // 
            this.LBsatus.AutoSize = true;
            this.LBsatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsatus.Location = new System.Drawing.Point(10, 106);
            this.LBsatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBsatus.Name = "LBsatus";
            this.LBsatus.Size = new System.Drawing.Size(237, 48);
            this.LBsatus.TabIndex = 4;
            this.LBsatus.Text = "Disconnect";
            // 
            // com
            // 
            this.com.BaudRate = 115200;
            this.com.ReceivedBytesThreshold = 4;
            this.com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Oncom);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtKp
            // 
            this.txtKp.Enabled = false;
            this.txtKp.Location = new System.Drawing.Point(158, 27);
            this.txtKp.Margin = new System.Windows.Forms.Padding(6);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(229, 31);
            this.txtKp.TabIndex = 6;
            this.txtKp.Text = "0.0";
            this.txtKp.TextChanged += new System.EventHandler(this.txtKp_TextChanged);
            // 
            // PbSend
            // 
            this.PbSend.Enabled = false;
            this.PbSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbSend.Location = new System.Drawing.Point(158, 316);
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
            this.pbExit.Location = new System.Drawing.Point(665, 691);
            this.pbExit.Margin = new System.Windows.Forms.Padding(6);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(196, 117);
            this.pbExit.TabIndex = 8;
            this.pbExit.Text = "Exit";
            this.pbExit.UseVisualStyleBackColor = true;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ki";
            // 
            // txtKi
            // 
            this.txtKi.Enabled = false;
            this.txtKi.Location = new System.Drawing.Point(158, 77);
            this.txtKi.Margin = new System.Windows.Forms.Padding(6);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(229, 31);
            this.txtKi.TabIndex = 6;
            this.txtKi.Text = "0.0";
            this.txtKi.TextChanged += new System.EventHandler(this.txtKi_TextChanged);
            // 
            // txtKd
            // 
            this.txtKd.Enabled = false;
            this.txtKd.Location = new System.Drawing.Point(158, 127);
            this.txtKd.Margin = new System.Windows.Forms.Padding(6);
            this.txtKd.Name = "txtKd";
            this.txtKd.Size = new System.Drawing.Size(229, 31);
            this.txtKd.TabIndex = 6;
            this.txtKd.Text = "0.0";
            this.txtKd.TextChanged += new System.EventHandler(this.txtKd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kd";
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 5;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(950, 350);
            this.chart1.Margin = new System.Windows.Forms.Padding(6);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1000, 500);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtsetpoint
            // 
            this.txtsetpoint.Enabled = false;
            this.txtsetpoint.Location = new System.Drawing.Point(158, 177);
            this.txtsetpoint.Margin = new System.Windows.Forms.Padding(6);
            this.txtsetpoint.Name = "txtsetpoint";
            this.txtsetpoint.Size = new System.Drawing.Size(229, 31);
            this.txtsetpoint.TabIndex = 6;
            this.txtsetpoint.Text = "150";
            this.txtsetpoint.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Setpoint";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(615, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(755, 73);
            this.label7.TabIndex = 12;
            this.label7.Text = "BÁO CÁO BÀI TẬP LỚN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pbquaythuan
            // 
            this.pbquaythuan.AutoSize = true;
            this.pbquaythuan.Enabled = false;
            this.pbquaythuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbquaythuan.Location = new System.Drawing.Point(158, 261);
            this.pbquaythuan.Margin = new System.Windows.Forms.Padding(6);
            this.pbquaythuan.Name = "pbquaythuan";
            this.pbquaythuan.Size = new System.Drawing.Size(172, 30);
            this.pbquaythuan.TabIndex = 13;
            this.pbquaythuan.Text = "Quay Thuan";
            this.pbquaythuan.UseVisualStyleBackColor = true;
            this.pbquaythuan.CheckedChanged += new System.EventHandler(this.pbquaythuan_CheckedChanged_1);
            // 
            // pbquaynghich
            // 
            this.pbquaynghich.AutoSize = true;
            this.pbquaynghich.Enabled = false;
            this.pbquaynghich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbquaynghich.Location = new System.Drawing.Point(360, 261);
            this.pbquaynghich.Margin = new System.Windows.Forms.Padding(6);
            this.pbquaynghich.Name = "pbquaynghich";
            this.pbquaynghich.Size = new System.Drawing.Size(177, 30);
            this.pbquaynghich.TabIndex = 13;
            this.pbquaynghich.Text = "Quay nghich";
            this.pbquaynghich.UseVisualStyleBackColor = true;
            this.pbquaynghich.CheckedChanged += new System.EventHandler(this.pbquaynghich_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(618, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(748, 55);
            this.label8.TabIndex = 12;
            this.label8.Text = "GVHD : NGUYỄN HOÀNG GIÁP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(613, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(757, 48);
            this.label9.TabIndex = 12;
            this.label9.Text = "SVTH : VÕ TRUNG - MSSV: 1713725";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.pbquaynghich);
            this.groupBox2.Controls.Add(this.pbquaythuan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PbSend);
            this.groupBox2.Controls.Add(this.txtsetpoint);
            this.groupBox2.Controls.Add(this.txtKd);
            this.groupBox2.Controls.Add(this.txtKi);
            this.groupBox2.Controls.Add(this.txtKp);
            this.groupBox2.Location = new System.Drawing.Point(24, 514);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(558, 377);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PbST_TIMER2
            // 
            this.PbST_TIMER2.Enabled = false;
            this.PbST_TIMER2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbST_TIMER2.Location = new System.Drawing.Point(665, 501);
            this.PbST_TIMER2.Margin = new System.Windows.Forms.Padding(6);
            this.PbST_TIMER2.Name = "PbST_TIMER2";
            this.PbST_TIMER2.Size = new System.Drawing.Size(196, 117);
            this.PbST_TIMER2.TabIndex = 15;
            this.PbST_TIMER2.Text = "Start";
            this.PbST_TIMER2.UseVisualStyleBackColor = true;
            this.PbST_TIMER2.Click += new System.EventHandler(this.PbST_TIMER2_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(767, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(695, 48);
            this.label5.TabIndex = 16;
            this.label5.Text = "TRẦN TUẤN VŨ - MSSV: 1710392";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "RPM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2002, 934);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PbST_TIMER2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBSecCom;
        private System.Windows.Forms.Button pbconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort com;
        private System.Windows.Forms.Label LBsatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.Button PbSend;
        private System.Windows.Forms.Button pbExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.TextBox txtKd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtsetpoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox pbquaythuan;
        private System.Windows.Forms.CheckBox pbquaynghich;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PbST_TIMER2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
    }
}

