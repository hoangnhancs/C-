using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicApp
{
    public partial class homePage : Form
    {

        string Dirpath;

        int imgindex;
        int phhanhindex;
        public homePage()
        {
            InitializeComponent();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Home_2_1_1_MouseHover(object sender, EventArgs e)
        {
            panel_Home_2_1_2.Visible = true;
        }

        private void panel_Home_2_1_2_MouseLeave(object sender, EventArgs e)
        {
            panel_Home_2_1_2.Visible = false;
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            panel_Home_2_1_2.Visible = false;
            panel_Home_2_2_2.Visible = false;
            panel_Home_2_3_2.Visible = false;
            panel_Home_3_1_2.Visible = false;
            panel_Home_3_2_2.Visible = false;
            panel_Home_3_3_2.Visible = false;
            panel_Home_4_1_2.Visible = false;
            panel_Home_4_2_2.Visible = false;
            panel_Home_4_3_2.Visible = false;

            Dirpath = @"E:\hoangnhancs\C-\ProjectCsharpFinal\slideShow";
            string[] files = Directory.GetFiles(Dirpath, "*.jpg");
            foreach (string file in files)
            {

                int pos = file.LastIndexOf("||");

                string FName = file.Substring(pos + 1);

                listBox1.Items.Add(FName);

            }
            //pic_Sile.Height = Convert.ToInt32(pic_Sile.Width * 9 / 16);
            //listBox1.SelectedIndex = imgindex = 0;

            btn_Prev.Enabled = true;

            btn_Next.Enabled = true;
            imgindex = 0;
            pic_Sile.ImageLocation = Convert.ToString(listBox1.Items[imgindex]);
            phhanhindex = 0;
            panel_Home_5_2.Visible = false;
            panel_Home_5_1.Visible = false;
            panel_Home_5_3.Visible = false;
            timer1.Interval = 2 * 1000;
            timer2.Interval = 4 * 1000;

            timer1.Start();
            timer2.Start();
        }

        private void panel_Home_2_2_1_MouseHover(object sender, EventArgs e)
        {
            panel_Home_2_2_2.Visible = true;
        }

        private void panel_Home_2_2_2_MouseLeave(object sender, EventArgs e)
        {
            panel_Home_2_2_2.Visible = false;
        }

        private void panel_Home_2_3_2_MouseLeave(object sender, EventArgs e)
        {
            panel_Home_2_3_2.Visible = false;
        }

        private void panel_Home_2_3_1_MouseHover(object sender, EventArgs e)
        {
            panel_Home_2_3_2.Visible = true;
        }

        private void panel_Home_3_1_1_MouseHover(object sender, EventArgs e)
        {
            panel_Home_3_1_2.Visible = true;
        }

        private void panel_Home_3_1_2_MouseLeave(object sender, EventArgs e)
        {
            panel_Home_3_1_2.Visible = false;
        }

        private void panel_Home_3_2_1_MouseHover(object sender, EventArgs e)
        {
            panel_Home_3_2_2.Visible = true;
        }

        private void panel_Home_3_2_2_MouseLeave(object sender, EventArgs e)
        {
            panel_Home_3_2_2.Visible = false;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel_Home_3_3_2.Visible = true;
        }

        private void panel_Home_3_3_2_MouseLeave(object sender, EventArgs e)
        {
            panel_Home_3_3_2.Visible = false;
        }

        private void panel_Home_4_1_1_MouseHover(object sender, EventArgs e)
        {
            panel_Home_4_1_2.Visible = true;
        }

        private void panel_Home_4_1_2_MouseLeave(object sender, EventArgs e)
        {
            panel_Home_4_1_2.Visible = false;
        }

        private void panel_Home_4_2_1_MouseHover(object sender, EventArgs e)
        {
            panel_Home_4_2_2.Visible = true;
        }

        private void panel_Home_4_2_2_MouseLeave(object sender, EventArgs e)
        {
            panel_Home_4_2_2.Visible = false;
        }

        private void panel_Home_4_3_1_MouseHover(object sender, EventArgs e)
        {
            panel_Home_4_3_2.Visible = true;
        }

        private void panel_Home_4_3_2_MouseLeave(object sender, EventArgs e)
        {
            panel_Home_4_3_2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgindex -= 1;
            if (imgindex < 0)
            {
                imgindex = listBox1.Items.Count - 1;
            }
            pic_Sile.ImageLocation = Convert.ToString(listBox1.Items[imgindex]);
            timer1.Stop();
            timer1.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pic_Sile.ImageLocation = Convert.ToString(listBox1.Items[imgindex]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_Next.PerformClick();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            imgindex += 1;
            if (imgindex == listBox1.Items.Count)
            {
                imgindex = 0;
            }
            pic_Sile.ImageLocation = Convert.ToString(listBox1.Items[imgindex]);
            timer1.Stop();
            timer1.Start();
        }

        private void panel_Home_5_1_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Home_5_m1_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void panel_Home_5_1_1_MouseHover(object sender, EventArgs e)
        {
            timer2.Stop();
            panel_Home_5_m1.Visible = true;
            panel_Home_5_1_1.Visible = true;
            panel_Home_5_m2.Visible = false;
            panel_Home_5_2_1.Visible = false;
            panel_Home_5_m3.Visible = false;
            panel_Home_5_3_1.Visible = false;
        }

        private void btn_Next_PH_Click(object sender, EventArgs e)
        {
            phhanhindex += 1;
            Console.WriteLine(phhanhindex);
            if (phhanhindex == 3)
            {
                phhanhindex = 0;
            }
            if (phhanhindex == 1)
            {
                panel_Home_5_m1.Visible = true;
                panel_Home_5_1_1.Visible = true;
                panel_Home_5_m2.Visible = false;
                panel_Home_5_2_1.Visible = false;
                panel_Home_5_m3.Visible = false;
                panel_Home_5_3_1.Visible = false;
            }
            else if (phhanhindex == 2)
            {
                panel_Home_5_m1.Visible = false;
                panel_Home_5_1_1.Visible = false;
                panel_Home_5_m2.Visible = true;
                panel_Home_5_2_1.Visible = true;
                panel_Home_5_m3.Visible = false;
                panel_Home_5_3_1.Visible = false;
            }
            else
            {
                panel_Home_5_m1.Visible = false;
                panel_Home_5_1_1.Visible = false;
                panel_Home_5_m2.Visible = false;
                panel_Home_5_2_1.Visible = false;
                panel_Home_5_m3.Visible = true;
                panel_Home_5_3_1.Visible = true;

            }    
            timer2.Start();
        }

        private void panel_Home_5_m2_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void panel_Home_5_m3_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btn_Next_PH.PerformClick();
        }

        private void panel_Home_5_m3_MouseHover(object sender, EventArgs e)
        {
            timer2.Stop();
            panel_Home_5_m1.Visible = false;
            panel_Home_5_1_1.Visible = false;
            panel_Home_5_m2.Visible = false;
            panel_Home_5_2_1.Visible = false;
            panel_Home_5_m3.Visible = true;
            panel_Home_5_3_1.Visible = true;
        }

        private void panel_Home_5_m2_MouseMove(object sender, MouseEventArgs e)
        {
            timer2.Stop();
            panel_Home_5_m1.Visible = false;
            panel_Home_5_1_1.Visible = false;
            panel_Home_5_m2.Visible = true;
            panel_Home_5_2_1.Visible = true;
            panel_Home_5_m3.Visible = false;
            panel_Home_5_3_1.Visible = false;
        }
    }
}
