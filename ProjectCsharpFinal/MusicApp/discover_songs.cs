using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApp.DAO;
using MusicApp.DTO;
using MusicApp.static_class;

namespace MusicApp
{
    public partial class discover_songs : Form
    {
        // sự kiện để truyền data về main
        public static event EventHandler<passSongToPlayBarEventArgs> PassSong;

        int nhactre_count ;
        int nhacremix_count ;
        int nhacnuocngoai_count;
        int record_count = 0;
        int page_nhactre = 0;
        int page_nhacnuocngoai = 0;
        int page_nhacremix = 0;
        int page_record = 0;
        string recent = "nhac tre";
        public discover_songs()
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

        List<song> lstSongNhactre;
        List<song> lstSongNhacremix;
        List<song> lstSongNhacnuocngoai;
        List<song> lstRecord;

        private void loadData()
        {
            string query1 = "nhạc trẻ";
            lstSongNhactre = new List<song>();
            lstSongNhactre = songDAO.Instance.getsongbyCategory(query1);
            lstSongNhactre = songDAO.Instance.clearRepeatSong(lstSongNhactre);
            string query2 = "nhạc remix";
            lstSongNhacremix = new List<song>();
            lstSongNhacremix = songDAO.Instance.getsongbyCategory(query2);
            lstSongNhacremix = songDAO.Instance.clearRepeatSong(lstSongNhacremix);
            string query3 = "nhạc nước ngoài";
            lstSongNhacnuocngoai = new List<song>();
            lstSongNhacnuocngoai = songDAO.Instance.getsongbyCategory(query3);
            lstSongNhacnuocngoai = songDAO.Instance.clearRepeatSong(lstSongNhacnuocngoai);
            lstRecord = new List<song>();
            lstRecord = songDAO.Instance.getsongbyalbumid(6);
            nhactre_count = lstSongNhactre.Count;
            nhacremix_count = lstSongNhacremix.Count;
            nhacnuocngoai_count = lstSongNhacnuocngoai.Count;
            record_count = lstRecord.Count();
            //Console.WriteLine(nhacnuocngoai_count);
            //Console.WriteLine(nhactre_count);
            //Console.WriteLine(nhacremix_count);
            
        }

        private void discover_songs_Load(object sender, EventArgs e)
        {
            // ẩn vùng bao của nút
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            //enablepanel();
            loadData();
            //enablepanel();
            loadsongnhactre();
            button_VNSongs.FlatAppearance.BorderSize = 1;
         
        }



        private void panel_behindList1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_item_1_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = true;
        }

        private void panel_item_1_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = false;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel_item_2_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_item_2_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_2_2.Visible = false;
        }

        private void panel_item_2_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_2_2.Visible = true;
        }

        private void panel_item_3_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_3_2.Visible = false;
        }

        private void panel_item_3_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_3_2.Visible = true;
        }



        private void panel_item_5_1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void loadsong(int i)
        {
            if (recent == "nhac tre")
            {
                passSongToParentForm(lstSongNhactre[i]);
            }
            if (recent == "nhac nuoc ngoai")
            {
                passSongToParentForm(lstSongNhacnuocngoai[i]);
            }
            if (recent == "nhac remix")
            {
                //button_AsianSongs.PerformClick();
            }
            if (recent == "record")
            {
                //passDataMain(lstRecord[0]);
                loadsongrecord();
            }
        }

        private void playSong(int indexSlectedSong, bool addPlaylist = false)
        {
            if (recent == "nhac tre")
            {
                passSongToParentForm(lstSongNhactre[indexSlectedSong+9*page_nhactre], addPlaylist);
            }
            if (recent == "nhac nuoc ngoai")
            {
                passSongToParentForm(lstSongNhacnuocngoai[indexSlectedSong+9*page_nhacnuocngoai], addPlaylist);
            }
            if (recent == "nhac remix")
            {
                passSongToParentForm(lstSongNhacremix[indexSlectedSong+9*page_nhacremix], addPlaylist);
            }
            if (recent == "record")
            {
                passSongToParentForm(lstRecord[indexSlectedSong + 9 * page_record], addPlaylist);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            playSong(0);
        }

        private void panel_item_1_2_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadsongnhacnuocngoai()
        {
            enablepanel();
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, _panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            var lstlabelsinger = new List<Label> { label_item1_singer, label_item2_singer, label_item3_singer, labelitem4singer, labelitem5singer, labelitem6singer, labelitem7singer, labelitem8singer, labelitem9singer };
            //nhacnuocngoai_count = lstSongNhacnuocngoai.Count;
            for (int i = 0; i < 9; i++)
            {
                if (page_nhacnuocngoai * 9 + i < nhacnuocngoai_count)
                {
                    lstpanel1[i].BackgroundImage = Image.FromFile(lstSongNhacnuocngoai[page_nhacnuocngoai*9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(lstSongNhacnuocngoai[page_nhacnuocngoai * 9 + i].Image_path);
                    if (lstSongNhacnuocngoai[page_nhacnuocngoai * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = lstSongNhacnuocngoai[page_nhacnuocngoai * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = lstSongNhacnuocngoai[page_nhacnuocngoai * 9 + i].Name;
                    }
                    lstlabelsinger[i].Text = lstSongNhacnuocngoai[page_nhacnuocngoai*9 + i].Singer;
                }
                else
                {
                    lstpanel1[i].Visible = false;
                    lstlabelsinger[i].Visible = false;
                    lstlabeltitle[i].Visible = false;
                }
            }
        }
        private void button_AmericaSongs_Click(object sender, EventArgs e)
        {
            
            recent = "nhac nuoc ngoai";
            loadsongnhacnuocngoai();
        }
        void loadsongnhacremix()
        {
            enablepanel();
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, _panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            var lstlabelsinger = new List<Label> { label_item1_singer, label_item2_singer, label_item3_singer, labelitem4singer, labelitem5singer, labelitem6singer, labelitem7singer, labelitem8singer, labelitem9singer };
            //nhacremix_count = lstSongNhacremix.Count;
            for (int i = 0; i < 9; i++)
            {
                if (page_nhacremix  * 9 + i < nhacremix_count)
                {
                    lstpanel1[i].BackgroundImage = Image.FromFile(lstSongNhacremix[page_nhacremix * 9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(lstSongNhacremix[page_nhacremix * 9 + i].Image_path);
                    if (lstSongNhacremix[page_nhacremix * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = lstSongNhacremix[page_nhacremix * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = lstSongNhacremix[page_nhacremix * 9 + i].Name;
                    }
                    lstlabelsinger[i].Text = lstSongNhacremix[page_nhacremix * 9 + i].Singer;
                }
                else
                {
                    lstpanel1[i].Visible = false;
                    lstlabelsinger[i].Visible = false;
                    lstlabeltitle[i].Visible = false;
                }
            }
        }
        private void button_AsianSongs_Click(object sender, EventArgs e)
        {
            
            loadsongnhacremix();
            recent = "nhac remix";
        }
        void loadsongnhactre()
        {
            enablepanel();
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, _panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            var lstlabelsinger = new List<Label> { label_item1_singer, label_item2_singer, label_item3_singer, labelitem4singer, labelitem5singer, labelitem6singer, labelitem7singer, labelitem8singer, labelitem9singer };
            
            for (int i = 0; i < 9; i++)
            {
                if (page_nhactre * 9 + i < nhactre_count)
                {
                    
                    lstpanel1[i].BackgroundImage = Image.FromFile(lstSongNhactre[page_nhactre * 9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(lstSongNhactre[page_nhactre * 9 + i].Image_path);
                    if (lstSongNhactre[page_nhactre * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = lstSongNhactre[page_nhactre * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = lstSongNhactre[page_nhactre * 9 + i].Name;
                    }
                    lstlabelsinger[i].Text = lstSongNhactre[page_nhactre * 9 + i].Singer;
                }
                else
                {
                    lstpanel1[i].Visible = false;
                    lstlabelsinger[i].Visible = false;
                    lstlabeltitle[i].Visible = false;
                }
            }
        }
        private void button_VNSongs_Click(object sender, EventArgs e)
        {
            
            recent = "nhac tre";
            loadsongnhactre();
        }

        private void panel_subMenuBar_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadsongrecord()
        {

            enablepanel();
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, _panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            var lstlabelsinger = new List<Label> { label_item1_singer, label_item2_singer, label_item3_singer, labelitem4singer, labelitem5singer, labelitem6singer, labelitem7singer, labelitem8singer, labelitem9singer };

            for (int i = 0; i < 9; i++)
            {
                if (page_record * 9 + i < record_count)
                {

                    lstpanel1[i].BackgroundImage = Image.FromFile(lstRecord[page_record * 9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(lstRecord[page_record * 9 + i].Image_path);
                    if (lstRecord[page_record * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = lstRecord[page_record * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = lstRecord[page_record * 9 + i].Name;
                    }
                    lstlabelsinger[i].Text = lstRecord[page_record * 9 + i].Singer;
                }
                else
                {
                    lstpanel1[i].Visible = false;
                    lstlabelsinger[i].Visible = false;
                    lstlabeltitle[i].Visible = false;
                }
            }
        }
        void enablepanel()
        {
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, _panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            var lstlabelsinger = new List<Label> { label_item1_singer, label_item2_singer, label_item3_singer, labelitem4singer, labelitem5singer, labelitem6singer, labelitem7singer, labelitem8singer, labelitem9singer };
            for (int i = 0; i < 9; i++)
            {
                lstpanel2[i].Visible = false;
                lstpanel1[i].Visible = true;
                lstlabeltitle[i].Visible = true;
                lstlabelsinger[i].Visible = true;

            }
        }
        /*
        private void button_differentSongs_Click(object sender, EventArgs e)
        {
            enablepanel();
            recent = "record";
            loadsongrecord();
        }
        */
        private void pictureBox_item2_Click(object sender, EventArgs e)
        {
            playSong(1);
        }

        private void button_AmericaSongs_Click_1(object sender, EventArgs e)
        {
            //enablepanel();
            //label_title.Text = "Nhạc nước ngoài";
            //button_AmericaSongs.FlatAppearance.BorderSize = 0;
            recent = "nhac nuoc ngoai";
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            button_AmericaSongs.FlatAppearance.BorderSize = 1;
            loadsongnhacnuocngoai();
        }

        private void button_AsianSongs_Click_1(object sender, EventArgs e)
        {
            //label_title.Text = "Nhạc remix";
            //enablepanel();
            recent = "nhac remix";
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 1;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            loadsongnhacremix();
        }

        private void button_differentSongs_Click_1(object sender, EventArgs e)
        {
            //label_title.Text = "Ghi âm";
            recent = "record";
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 1;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            loadsongrecord();
        }

        private void button_VNSongs_Click_1(object sender, EventArgs e)
        {
            //label_title.Text = "Nhạc trẻ";
            //enablepanel();
            recent = "nhac tre";
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 1;
            loadsongnhactre();
        }

        private void panel_MoiVsHot_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelitem61_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelitem42_MouseLeave(object sender, EventArgs e)
        {
            _panelitem42.Visible = false;
        }

        private void panelitem41_MouseHover(object sender, EventArgs e)
        {
            _panelitem42.Visible = true;
        }

        private void panelitem52_MouseLeave(object sender, EventArgs e)
        {
            panelitem52.Visible = false;
        }

        private void panelitem51_MouseHover(object sender, EventArgs e)
        {
            panelitem52.Visible = true;
        }

        private void panelitem62_MouseLeave(object sender, EventArgs e)
        {
            panelitem62.Visible = false;
        }

        private void panelitem61_MouseHover(object sender, EventArgs e)
        {
            panelitem62.Visible = true;
        }

        private void panelitem72_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelitem72_MouseLeave(object sender, EventArgs e)
        {
            _panelitem72.Visible = false;
        }

        private void panelitem71_MouseHover(object sender, EventArgs e)
        {
            _panelitem72.Visible = true;
        }

        private void pictureBox_item3_Click(object sender, EventArgs e)
        {
            playSong(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (recent=="nhac tre")
            {
                if (page_nhactre * 9 + 9< nhactre_count)
                {
                    page_nhactre += 1;
                    loadsongnhactre();
                }

            }
            if (recent == "nhac nuoc ngoai")
            {
                if (page_nhacnuocngoai * 9 + 9< nhacnuocngoai_count)
                {
                    page_nhacnuocngoai += 1;
                    loadsongnhacnuocngoai();
                }

            }
            if (recent == "nhac remix")
            {
                if (page_nhacremix * 9 + 9< nhacremix_count)
                {
                    page_nhacremix += 1;
                    loadsongnhacremix();
                }

            }
            if (recent == "record")
            {
                if (page_record * 9 + 9< record_count)
                {
                    page_record += 1;
                    loadsongrecord();
                }

            }
        }

        private void panelitem82_MouseLeave(object sender, EventArgs e)
        {
            panelitem82.Visible = false;
        }

        private void panelitem81_MouseHover(object sender, EventArgs e)
        {
            panelitem82.Visible = true;
        }

        private void panelitem92_MouseLeave(object sender, EventArgs e)
        {
            panelitem92.Visible = false;
        }

        private void panelitem91_MouseHover(object sender, EventArgs e)
        {
            panelitem92.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(recent=="nhac remix")
            {
                if(page_nhacremix>0)
                {
                    page_nhacremix--;
                    loadsongnhacremix();
                }
            }
            if (recent == "nhac nuoc ngoai")
            {
                if (page_nhacnuocngoai > 0)
                {
                    page_nhacnuocngoai--;
                    loadsongnhacnuocngoai();
                }
            }
            if (recent == "nhac tre")
            {
                if (page_nhactre > 0)
                {
                    page_nhactre--;
                    loadsongnhactre();
                }
            }
            if (recent == "record")
            {
                if (page_record>0)
                {
                    page_record--;
                    loadsongrecord();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            playSong(3);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            playSong(4);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            playSong(5);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            playSong(6);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            playSong(7);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            playSong(8);
        }

        private void button_addItem1_1_Click(object sender, EventArgs e)
        {
            playSong(0, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playSong(1, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playSong(2, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playSong(3, true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            playSong(4, true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            playSong(5, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            playSong(6, true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            playSong(7, true);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            playSong(8, true);
        }
    }
}