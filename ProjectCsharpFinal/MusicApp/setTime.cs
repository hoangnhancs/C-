using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApp.static_class;


namespace MusicApp
{
    public partial class setTime : Form
    {
        public static event EventHandler<passTimeToMainEvenArgs> PassTime;

        public setTime()
        {
            InitializeComponent();
        }

        // hàm truyền data về main
        private void passTimeToMain(int time, bool reset = false,string mode = "stopMusic")
        {
            if (PassTime != null)
            {
                PassTime.Invoke(this, new passTimeToMainEvenArgs(time, reset,mode));
            }
        }
        private void calcTime()
        {
            int hour = 0;
            int minute = 0;
            int second = 0;

            if (textBox_hour.Text != "")
                hour = Convert.ToInt32(textBox_hour.Text);
            if (textBox_minute.Text != "")
                minute = Convert.ToInt32(textBox_minute.Text);
            if (textBox_second.Text != "")
                second = Convert.ToInt32(textBox_second.Text);

            timeStop = (hour * 3600) + (minute * 60) + second;
            if (timeStop != 0)
            {
                if (comboBox1.Text == "Tắt nhạc")
                    passTimeToMain(timeStop);
                else
                    passTimeToMain(timeStop,false,"stopApp");
            }
        }



        private void button_setTime_Click(object sender, EventArgs e)
        {
            calcTime();
            if (timeStop != 0)
            {
                button_reset.Enabled = true;
                button_start.Enabled = false;
                timer.Start();
            }

        }
        int countTime = 0;
        int timeStop = 0;

        private void updateLabelCountTime()
        {

        }

        private void setTime_Load(object sender, EventArgs e)
        {
            button_start.FlatAppearance.BorderSize = 0;
            button_reset.FlatAppearance.BorderSize = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            button_start.Enabled = true;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            button_start.Enabled = true;
            button_reset.Enabled = false;
            textBox_hour.Text = "00";
            textBox_minute.Text = "00";
            textBox_second.Text = "00";

            passTimeToMain(timeStop, true);
            countTime = 0;
            timeStop = 0;
            timer.Stop();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_hour_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countTime++;
            if (countTime == timeStop)
            {
                countTime = 0;
                timeStop = 0;
                timer.Stop();
                button_start.Enabled = true;
                button_reset.Enabled = false;
                textBox_hour.Text = "00";
                textBox_minute.Text = "00";
                textBox_second.Text = "00";
            }
        }
    }
}
