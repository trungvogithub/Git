using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.Serialization;

namespace bai3.Auto_detectcom
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
            
        }
        int t = 0;
        double setpoint;
        float temp_sp;
        double tocdo;
        int byte_count;
        int ack=0;
        byte[] data;
        List<double> yr = new List<double>();
        List<double> sp = new List<double>();
        int tongsocom = 0;
        delegate void SetTextCallBack(String Text);//khai bao thu tuc delegate
        byte[] package = new byte[24];

        UInt16 mode=0, start=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Press OK to continue,then choose port and press button Connect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CBSecCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // lay ra tat ca cac cong port
            if(tongsocom != ports.Length)
            {
                tongsocom = ports.Length;
                CBSecCom.Items.Clear();
                for(int j=0;j<tongsocom;j++)
                {
                    CBSecCom.Items.Add(ports[j]);
                }

            }
        }
          private void pbconnect_Click(object sender, EventArgs e)
        {
            if(LBsatus.Text == "Disconnect")
            {
                com.PortName = CBSecCom.Text;
                com.Open();
                LBsatus.Text = "Connect";
                pbconnect.Text = "Disconnect";
                PbST_TIMER2.Text = "Start";
                pbquaythuan.Enabled = true;
                pbquaynghich.Enabled = true;
                txtKp.Enabled = true;
                txtKd.Enabled = true;
                txtKi.Enabled = true;
                PbSend.Enabled = true;
                txtsetpoint.Enabled = true;
                PbST_TIMER2.Enabled = true;

            }
            else
            {
                com.Close();
                LBsatus.Text = "Disconnect";
                pbconnect.Text = "Connect";
                pbquaythuan.Enabled = false;
                pbquaynghich.Enabled = false;
                txtKp.Enabled = false;
                txtKd.Enabled = false;
                txtKi.Enabled = false;
                PbSend.Enabled = false;
                txtsetpoint.Enabled = false;

                pbquaythuan.Checked = false;
                pbquaynghich.Checked = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
                PbST_TIMER2.Enabled = false;
                MessageBox.Show("Serial port is closed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // send data

        private void PbSend_Click(object sender, EventArgs e)
        {
           
            if (LBsatus.Text == "Connect")
            {
                package[0] = Convert.ToByte('d');
                package[1] = Convert.ToByte('v');
                package[2] = Convert.ToByte('r');
                package[3] = Convert.ToByte('c');
                if (start == 1)  package[4] = Convert.ToByte('r'); 
                else package[4] = Convert.ToByte('s');
                if (mode == 1) package[5] = Convert.ToByte('n');
                else package[5] = Convert.ToByte('t');
                package[6] = Convert.ToByte('o');
                package[7] = Convert.ToByte('o');
                byte[] temp;
                temp_sp = Convert.ToSingle(txtsetpoint.Text);
                temp = System.BitConverter.GetBytes(Convert.ToSingle(txtsetpoint.Text));
                for (int c = 8; c <= 11; c++)
                {
                    package[c] = temp[c - 8];
                }
                temp = System.BitConverter.GetBytes(Convert.ToSingle(txtKp.Text));
                for (int c = 12; c <= 15; c++)
                {
                    package[c] = temp[c - 12];
                }
                temp = System.BitConverter.GetBytes(Convert.ToSingle(txtKi.Text));
                for (int c = 16; c <= 19; c++)
                {
                    package[c] = temp[c - 16];
                }
                temp = System.BitConverter.GetBytes(Convert.ToSingle(txtKd.Text));
                for (int c = 20; c <= 23; c++)
                {
                    package[c] = temp[c - 20];
                }
                com.Write(package, 0, 24);
                timer3.Enabled = true;
                ack = 1;
            }
           

        }

         

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtKp_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (LBsatus.Text == "Connect")
            {

                yr.Add(tocdo);
                if (mode == 0) setpoint = temp_sp;
                else setpoint = -temp_sp;

                sp.Add(setpoint);
                t = t + 1;


            }

            drawchart();
        }
        public void drawchart()
        {
            int init_tmp;
            this.chart1.Series.Clear();
            Series response = this.chart1.Series.Add("Speed");
            Series reference = this.chart1.Series.Add("Setpoint");
            reference.ChartType = SeriesChartType.Line;
            response.ChartType = SeriesChartType.Line;
            reference.Color = Color.Red;
            double[] yr_val = yr.ToArray();
            double[] sp_val = sp.ToArray();
            if (t > 500) init_tmp = t - 500;
            else init_tmp = 0;
            for (int i = init_tmp; i < t; i++)
            {
               response.Points.AddXY(0.001 * i, yr_val[i]);
               reference.Points.AddXY(0.001 * i,sp_val[i]);
               

            }
        }
        
        private void txtKi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKd_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pbquaythuan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (LBsatus.Text == "Connect")
            {
                //    //pbquaythuan.Enabled = false;
                //    //txtKp.Enabled = true;
                //    //txtKd.Enabled = true;
                //    //txtKi.Enabled = true;

                //    //PbST_TIMER2.Enabled = true;
                //    //txtsetpoint.Enabled = true;
                if (pbquaythuan.Checked == true)
                {
                    mode = 0;
                    start = 1;
                    pbquaynghich.Checked = false;
                    
                }
                if (pbquaynghich.Checked == false && pbquaythuan.Checked == false)
                {
                    start = 0;
                }

            }
    }

        private void Oncom(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (com.IsOpen)
                {
                    byte_count = com.BytesToRead;
                    data = new byte[byte_count];
                    com.Read(data, 0, byte_count);
                    if (data[0] == 'd' && data[1] == 'k' && data[2] == 'm' && data[3] == 't' && data[4] == 'r') ack = 0;
                    else if (data[0] == 'd' && data[1] == 'k' && data[2] == 'm' && data[3] == 't' && data[4] == 'v') 
                    { 
                        tocdo= System.BitConverter.ToSingle(data, 8);
                    }
                }
            }
            catch
            {

            }

            //string s;
            //s = com.ReadExisting();
            //SetTextFeedBack(s);
            //double.TryParse(s, out tocdo);
            //drawchart();


        }
        private void SetTextFeedBack(string text)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (ack == 1)
            {
                if (LBsatus.Text == "Connect")
                {
                    MessageBox.Show("Please check your Driver", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else timer3.Enabled = false;
           /// 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void pbquaynghich_CheckedChanged(object sender, EventArgs e)
        {

            if (LBsatus.Text == "Connect")
            {
                if (pbquaynghich.Checked == true)
                {
                    mode = 1;
                    start = 1;
                    pbquaythuan.Checked = false;
                    
                }
                if (pbquaynghich.Checked == false && pbquaythuan.Checked == false)
                {
                    start = 0;
                }

                //    //pbquaythuan.Enabled = false;
                //    //txtKp.Enabled = true;
                //    //txtKd.Enabled = true;
                //    //txtKi.Enabled = true;

                    //    //PbST_TIMER2.Enabled = true;
                    //    //txtsetpoint.Enabled = true;
                    //MessageBox.Show("If you want change status,please press reset  on Chip,and disconnect serialport  then connect again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //mode = 0;
                    //pbquaythuan.Checked = false;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PbST_TIMER2_Click(object sender, EventArgs e)
        {
            if (LBsatus.Text == "Connect")
            {
                if (PbST_TIMER2.Text == "Stop")
                {
                    PbST_TIMER2.Text = "Start";
                    timer2.Enabled = false;
                    //PbSend.Enabled = false;
                    //setpoint_ = "000";

                }
                else
                {
                     PbST_TIMER2.Text = "Stop";
                     timer2.Enabled = true;
                    //PbSend.Enabled = true;

                }
            }
        }

    }
}
