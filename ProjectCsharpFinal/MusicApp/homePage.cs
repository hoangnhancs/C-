﻿using System;
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
using MusicApp.static_class;

namespace MusicApp
{
    public partial class homePage : Form
    {
        // sự kiện để truyền data về main
        public static event EventHandler<passSongToPlayBarEventArgs> PassSong;
        List<song> lstsongsls = new List<song>();
        // lưu trữ vị trí các bài nhạc
        int nhactre = 0;
        int nhacnuocngoai = 0;
        int nhacremix = 0;
   
        string Dirpath;

        int imgindex;

        public homePage()
        {
            InitializeComponent();
        }

        // hàm truyền data về main
        private void passSongToParentForm(song slectedSong, bool addPlaylist = false)
        {
            if (PassSong != null)
            {
                PassSong.Invoke(this, new passSongToPlayBarEventArgs(slectedSong, addPlaylist));
            }
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

        private void loaddata()
        {
            string query1 = "nhạc trẻ";
            lstSongNhactre = new List<song>();
            lstSongNhactre = songDAO.Instance.getsongbyCategory(query1);

            string query2 = "nhạc nước ngoài";
            lstSongNhacNuocNgoai = new List<song>();
            lstSongNhacNuocNgoai = songDAO.Instance.getsongbyCategory(query2);

            string query3 = "nhạc remix";
            lstSongNhacRemix = new List<song>();
            lstSongNhacRemix = songDAO.Instance.getsongbyCategory(query3);
        }

        private void addDataNhacViet()
        {

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
                panels_1[i].BackgroundImage = Image.FromFile(lstSongNhactre[nhactre+i].Image_path);
                panels_1[i].BackgroundImageLayout = ImageLayout.Stretch;
                panels_2[i].BackgroundImage = Image.FromFile(lstSongNhactre[nhactre+i].Image_path);
                panels_2[i].BackgroundImageLayout = ImageLayout.Stretch;
                label_titel[i].Text = lstSongNhactre[nhactre+i].Name;
                label_singer[i].Text = lstSongNhactre[nhactre+i].Singer;
            }
        }

        private void addDataNhacNuocNgoai()
        {
            

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
                panels_1[i].BackgroundImage = Image.FromFile(lstSongNhacNuocNgoai[i+nhacnuocngoai].Image_path);
                panels_1[i].BackgroundImageLayout = ImageLayout.Stretch;
                panels_2[i].BackgroundImage = Image.FromFile(lstSongNhacNuocNgoai[i+nhacnuocngoai].Image_path);
                panels_2[i].BackgroundImageLayout = ImageLayout.Stretch;
                label_titel[i].Text = lstSongNhacNuocNgoai[i+nhacnuocngoai].Name;
                label_singer[i].Text = lstSongNhacNuocNgoai[i+nhacnuocngoai].Singer;
            }
        }

        private void addDataRemix()
        {
            

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
                panels_1[i].BackgroundImage = Image.FromFile(lstSongNhacRemix[i+nhacremix].Image_path);
                panels_1[i].BackgroundImageLayout = ImageLayout.Stretch;
                panels_2[i].BackgroundImage = Image.FromFile(lstSongNhacRemix[i+nhacremix].Image_path);
                panels_2[i].BackgroundImageLayout = ImageLayout.Stretch;
                label_titel[i].Text = lstSongNhacRemix[i+nhacremix].Name;
                label_singer[i].Text = lstSongNhacRemix[i+nhacremix].Singer;
            }
        }


        private void homePage_Load(object sender, EventArgs e)
        {
            loaddata();

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

            Dirpath = @"slideShow";
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
            imgindex += 1;
            if (imgindex == listBox1.Items.Count)
            {
                imgindex = 0;
            }
            pic_Sile.ImageLocation = Convert.ToString(listBox1.Items[imgindex]);
            timer1.Stop();
            timer1.Interval = 2 * 1000;
            timer1.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pic_Sile.ImageLocation = Convert.ToString(listBox1.Items[imgindex]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_Prev.PerformClick();
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
            timer1.Interval = 2 * 1000;
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

        private void btn_Home_2_1_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhactre[nhactre]);
        }

        private void btn_Home_4_1_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacRemix[nhacremix]);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (nhactre <= lstSongNhactre.Count - 4)
            {
                nhactre += 1;
                addDataNhacViet();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nhacremix <= lstSongNhacRemix.Count - 4)
            {
                nhacremix += 1;
                addDataRemix();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nhactre >= 1)
            {
                nhactre -= 1;
                addDataNhacViet();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nhacnuocngoai <= lstSongNhacNuocNgoai.Count - 4)
            {
                nhacnuocngoai += 1;
                addDataNhacNuocNgoai();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nhacnuocngoai >= 1)
            {
                nhacnuocngoai -= 1;
                addDataNhacNuocNgoai();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (nhacremix >= 1)
            {
                nhacremix -= 1;
                addDataRemix();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacNuocNgoai[nhacnuocngoai]);
        }

        private void btn_Home_2_2_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhactre[nhactre+1]);
        }

        private void panel_Home_2_3_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Home_2_3_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhactre[nhactre+2]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacNuocNgoai[nhacnuocngoai+1]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacNuocNgoai[nhacnuocngoai + 2]);
        }

        private void btn_Home_4_2_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacRemix[nhacremix+1]);
        }

        private void btn_Home_4_3_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacRemix[nhacremix+2]);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhactre[nhactre],true);
        }

        private void button_addItem1_2_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhactre[nhactre + 1], true);
        }

        private void button_addItem1_3_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhactre[nhactre + 2], true);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacNuocNgoai[nhacnuocngoai], true);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacNuocNgoai[nhacnuocngoai + 1], true);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacNuocNgoai[nhacnuocngoai + 2], true);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacRemix[nhacremix], true);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacRemix[nhacremix + 2], true);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            passSongToParentForm(lstSongNhacRemix[nhacremix + 1], true);
        }

        private void pic_Sile_Click(object sender, EventArgs e)
        {
            if (imgindex==0)
            {
                passSongToParentForm(songDAO.Instance.getsongbyname("Em yêu người khác mà")[0]);
            }
            if (imgindex == 3)
            {
                passSongToParentForm(songDAO.Instance.getsongbyname("Đàn ông không khóc")[0]);
            }
            if (imgindex == 2)
            {
                passSongToParentForm(songDAO.Instance.getsongbyname("Thương anh")[0]);
            }
            if (imgindex == 1)
            {
                passSongToParentForm(songDAO.Instance.getsongbyname("Sinh ra đã là thứ đối lập nhau")[0]);
            }
        }
    }
}
