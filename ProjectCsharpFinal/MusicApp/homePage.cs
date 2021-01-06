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
using MusicApp.DAO;
using MusicApp.DTO;

namespace MusicApp
{
    public partial class homePage : Form
    {
        //MusicApp f = new MusicApp();
        public Label label1;
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

        public List<song> lstSongNhactre;
        public List<song> lstSongNhacNuocNgoai;
        public List<song> lstSongNhacRemix;
        public int indexCurrentNhacTre = 0; 

        private void addDataNhacViet()
        {
            string query = "nhạc trẻ";
            lstSongNhactre = new List<song>();
            lstSongNhactre = songDAO.Instance.getsongbyCategory(query);

            //panel_item1.Visible = true;
            //panel_item2.Visible = true;
            //pictureBox_item1.Image = Image.FromFile(lstsong[0].Image_path);
            //label_item1.Text = lstsong[0].Name;
            var panels_1 = new List<Panel> {panel_Home_2_1_1,panel_Home_2_2_1,panel_Home_2_3_1};
            var panels_2 = new List<Panel> { panel_Home_2_1_2, panel_Home_2_2_2, panel_Home_2_3_2 };
            var label_titel = new List<Label> { label_Home_2_1, label_Home_2_2, label_Home_2_3 };
            var label_singer = new List<Label> { label_home_2_1_singer, label_home_2_2_signer, label_home_2_3_singer };

            for (int i = 0; i < 3; i++)
            {
                panels_1[i].BackgroundImage = Image.FromFile(lstSongNhactre[i].Image_path);
                panels_1[i].BackgroundImageLayout = ImageLayout.Stretch;
                panels_2[i].BackgroundImage = Image.FromFile(lstSongNhactre[i].Image_path);
                panels_2[i].BackgroundImageLayout = ImageLayout.Stretch;
                label_titel[i].Text = lstSongNhactre[i].Name;
                label_singer[i].Text = lstSongNhactre[i].Singer;
            }
        }

        private void addDataNhacNuocNgoai()
        {
            string query = "nhạc nước ngoài";
            lstSongNhacNuocNgoai = new List<song>();
            lstSongNhacNuocNgoai = songDAO.Instance.getsongbyCategory(query);

            //panel_item1.Visible = true;
            //panel_item2.Visible = true;
            //pictureBox_item1.Image = Image.FromFile(lstsong[0].Image_path);
            //label_item1.Text = lstsong[0].Name;
            var panels_1 = new List<Panel> { panel_Home_3_1_1, panel_Home_3_2_1, panel_Home_3_3_1 };
            var panels_2 = new List<Panel> { panel_Home_3_1_2, panel_Home_3_2_2, panel_Home_3_3_2 };
            var label_titel = new List<Label> { label_Home_3_1, label_Home_3_2, label_Home_3_3 };
            var label_singer = new List<Label> { label_home_3_1_singer, label_home_3_2_singer , label_home_3_3_singer };

            for (int i = 0; i < 3; i++)
            {
                panels_1[i].BackgroundImage = Image.FromFile(lstSongNhacNuocNgoai[i].Image_path);
                panels_1[i].BackgroundImageLayout = ImageLayout.Stretch;
                panels_2[i].BackgroundImage = Image.FromFile(lstSongNhacNuocNgoai[i].Image_path);
                panels_2[i].BackgroundImageLayout = ImageLayout.Stretch;
                label_titel[i].Text = lstSongNhacNuocNgoai[i].Name;
                label_singer[i].Text = lstSongNhacNuocNgoai[i].Singer;
            }
        }

        private void addDataRemix()
        {
            string query = "nhạc remix";
            lstSongNhacRemix = new List<song>();
            lstSongNhacRemix = songDAO.Instance.getsongbyCategory(query);

            //panel_item1.Visible = true;
            //panel_item2.Visible = true;
            //pictureBox_item1.Image = Image.FromFile(lstsong[0].Image_path);
            //label_item1.Text = lstsong[0].Name;
            var panels_1 = new List<Panel> { panel_Home_4_1_1, panel_Home_4_2_1, panel_Home_4_3_1 };
            var panels_2 = new List<Panel> { panel_Home_4_1_2, panel_Home_4_2_2, panel_Home_4_3_2 };
            var label_titel = new List<Label> { label_Home_4_1, label_Home_4_2, label_Home_4_3 };
            var label_singer = new List<Label> { label_home_4_1_singer, label_home_4_2_singer, label_home_4_3_singer };

            for (int i = 0; i < 3; i++)
            {
                panels_1[i].BackgroundImage = Image.FromFile(lstSongNhacRemix[i].Image_path);
                panels_1[i].BackgroundImageLayout = ImageLayout.Stretch;
                panels_2[i].BackgroundImage = Image.FromFile(lstSongNhacRemix[i].Image_path);
                panels_2[i].BackgroundImageLayout = ImageLayout.Stretch;
                label_titel[i].Text = lstSongNhacRemix[i].Name;
                label_singer[i].Text = lstSongNhacRemix[i].Singer;
            }
        }


        private void homePage_Load(object sender, EventArgs e)
        {
            addDataNhacViet();
            addDataNhacNuocNgoai();
            addDataRemix();

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
            timer1.Interval = 2 * 1000;

            timer1.Start();
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
        }

        private void panel_Home_5_1_1_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_Next_PH_Click(object sender, EventArgs e)
        {
           
        }

        private void panel_Home_5_m2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void panel_Home_5_m3_MouseLeave(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void panel_Home_5_m3_MouseHover(object sender, EventArgs e)
        {
        }

        private void panel_Home_5_m2_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void label_Home_2_2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //private string songplaying = LinkStat
        /*
        public string _songplaying
        {
            get { return label_Home_2_1.Text; }
            
        }
        */
        public string text;
        private void btn_Home_2_1_Click(object sender, EventArgs e)
        {

            //MusicApp ms = new MusicApp();
            //ms.songplaying = _songplaying;
            //ms.Show();

            //this.text = label_Home_2_1.Text;
            //MusicApp parent = (MusicApp) Owner;
            //parent.reload(label_Home_2_1.Text);
            

        }

        private void panel_Home_2_1_2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
