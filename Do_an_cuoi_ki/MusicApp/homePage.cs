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

        private void homePage_Load(object sender, EventArgs e)
        {
            panel_home_1_1_2.Visible = false;
            panel_home_1_2_2.Visible = false;
            panel_home_1_3_2.Visible = false;
            panel_home_4_3_2.Visible = false;
            panel_home_2_3_2.Visible = false;
            panel_home_2_2_2.Visible = false;
            panel_2_1_2.Visible = false;
            Dirpath = @"C:\Users\quang\OneDrive\Máy tính\MusicApp (1)\MusicApp\Sile_Show\";
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
            panel_Neumai_detail.Visible = false;
            panel_home_3_2_pt_2.Visible = false;
            timer1.Interval = 2 * 1000;
            timer2.Interval = 4 * 1000;

            timer1.Start();
            timer2.Start();
        }

        private void panel_slideShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pic_Sile.ImageLocation = Convert.ToString(listBox1.Items[imgindex]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_Next.PerformClick();
        }

        private void btn_Next_Click(object sender, EventArgs e)
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

        private void btn_Prev_Click(object sender, EventArgs e)
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

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel_home_1_1_2.Visible = true;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel_home_1_2_2.Visible = true;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel_home_1_3_2.Visible = true;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel_home_4_3_2.Visible = true;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel_home_1_1_2.Visible = false;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel_home_1_2_2.Visible = false;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel_home_1_3_2.Visible = false;
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel_home_4_3_2.Visible = false;
        }

        private void panel17_MouseHover(object sender, EventArgs e)
        {
            panel_2_1_2.Visible = true;
        }

        private void panel18_MouseLeave(object sender, EventArgs e)
        {
            panel_2_1_2.Visible = false;
        }

        private void panel13_MouseHover(object sender, EventArgs e)
        {
            panel_home_2_3_2.Visible = true;
        }

        private void panel12_MouseHover(object sender, EventArgs e)
        {
        }

        private void panel15_MouseHover(object sender, EventArgs e)
        {
            panel_home_2_2_2.Visible = true;
        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            panel_home_2_2_2.Visible = false;
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel_home_2_3_2.Visible = false;
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panel_Sleep_MouseHover(object sender, EventArgs e)
        {
            timer2.Stop();
            panel_Sleep_detail.Visible = true;
            panel_home_3_2_pt_1.Visible = true;
            panel_home_3_2_pt_2.Visible = false;
            panel_Neumai_detail.Visible = false;
            
        }

        private void panel_sleep1_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btn_NextPhHanh_Click(object sender, EventArgs e)
        {
            phhanhindex += 1;
            Console.WriteLine(phhanhindex);
            if (phhanhindex == 2)
            {
                phhanhindex = 0;
            }
            if (phhanhindex == 1)
            {
                panel_Sleep_detail.Visible = false;
                panel_home_3_2_pt_1.Visible = false;
                panel_home_3_2_pt_2.Visible = true;
                panel_Neumai_detail.Visible = true; 
            }
            else
            {
                panel_Sleep_detail.Visible = true;
                panel_home_3_2_pt_1.Visible = true;
                panel_home_3_2_pt_2.Visible = false;
                panel_Neumai_detail.Visible = false;
            }
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btn_NextPhHanh.PerformClick();
        }

        private void panel_Ngaymai_MouseHover(object sender, EventArgs e)
        {
            timer2.Stop();
            panel_Sleep_detail.Visible = false;
            panel_home_3_2_pt_1.Visible = false;
            panel_home_3_2_pt_2.Visible = true;
            panel_Neumai_detail.Visible = true;
            
            
        }

        private void panel_ngaymai1_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
