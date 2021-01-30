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
    public partial class Search : Form
    {
        List<album> lstalbum = new List<album>();
        List<song> lstsongofalbum = new List<song>();
        // sự kiện click button để truyền data về main
        public static event EventHandler<passSongToPlayBarEventArgs> PassSong;
        int page_song = 0;
        int page_album = 0;
        int page_other = 0;
        int max_page_song;
        int max_page_album;
        int max_page_other;
        bool check_song = false;
        bool check_album = false;
        bool check_other = false;
        bool recal = false;
        string check = "song";
        int search = 0;
        public Search()
        {
            InitializeComponent();
        }

        // hàm truyền data về main
        private void passSongToParentForm(song slectedSong, bool playlist=false, bool album=false)
        {
            if (PassSong != null)
            {
                PassSong.Invoke(this, new passSongToPlayBarEventArgs(slectedSong, playlist, album));
            }
        }

        // biến list song search được
        private List<song> lstsong;
        List<song> lstother = new List<song>();
        private void Search_Load(object sender, EventArgs e)
        {
            // tắt borded size button
            button_album.FlatAppearance.BorderSize = 0;
            //button_all.FlatAppearance.BorderSize = 0;
            button_recorded.FlatAppearance.BorderSize = 0;
            button_song.FlatAppearance.BorderSize = 0;

            //
            //pictureBox1.FlatAppearance.BorderSize = 0;
            button_playItem1.FlatAppearance.BorderSize = 0;
            button_playItem2.FlatAppearance.BorderSize = 0;
            button_playItem3.FlatAppearance.BorderSize = 0;
            button_playItem4.FlatAppearance.BorderSize = 0;
            button_playItem5.FlatAppearance.BorderSize = 0;
            button_playItem6.FlatAppearance.BorderSize = 0;
            button_playItem7.FlatAppearance.BorderSize = 0;
            button_playItem8.FlatAppearance.BorderSize = 0;

        }

        private void button_searchVideo_Click(object sender, EventArgs e)
        {
            string query = textBox_titleSong.Text.Replace("\n", "").Trim();
            if (textBox_titleSong.Text.Replace("\n", "").Trim() == "")
            {
                button_searchSong.Enabled = false;
                search = 0;
            }
            else
            {
                search = 1;
                recal = true;
                //Console.WriteLine(query);
                if (check == "song")
                {
                    showsongbyquery(query, recal);
                }
                if (check == "album")
                {
                    showalbumbyquery(query, recal);
                }
                if (check == "other")
                {
                    showotherbyquery(query, recal);
                }
            }
        }
            //string query_search = textBox_titleSong.Text;

        private void button_all_Click(object sender, EventArgs e)
        {

        }
        void showsongbyquery(string query, bool checkrecal)
        {
            enableall();
            var labels = new List<Label> { label_item1, label_item2, label_item3, label_item4, label_item5, label_item6, label_item7, label_item8 };
            var pictureboxs = new List<PictureBox> { pictureBox_item1, pictureBox_item2, pictureBox_item3, pictureBox_item4, pictureBox_item5, pictureBox_item6, pictureBox_item7, pictureBox_item8 };
            var panels = new List<Panel> { panel_item1, panel_item2, panel_item3, panel_item4, panel_item5, panel_item6, panel_item7, panel_item8 };
            label_noHasItem.Visible = false;
            foreach (var pn in panels)
            {
                pn.Visible = false;
            }

            query = textBox_titleSong.Text;

            lstsong = new List<song>();
            //List<song> fin_lstsong = new List<song>();
            lstsong = songDAO.Instance.getsongbyquery(query);
            lstsong = songDAO.Instance.clearRepeatSong(lstsong);
            //Console.WriteLine(lstsong.Count);
            if (checkrecal == true)
            {
                max_page_song = lstsong.Count/8;
                if (lstsong.Count % 8 == 0)
                {
                    max_page_song --;
                }
                page_song = 0;
            }
            //Console.WriteLine(max_page_song);
           // Console.WriteLine(page_song);
            //panel_item1.Visible = true;
            //panel_item2.Visible = true;
            //pictureBox_item1.Image = Image.FromFile(lstsong[0].Image_path);
            //label_item1.Text = lstsong[0].Name;

            if (lstsong.Count == 0)
            {
                label_noHasItem.Visible = true;
            }
            for (int i = 0; i < 8; i++)
            {
                if (page_song*8+i<lstsong.Count)
                {
                    labels[i].Text = lstsong[page_song * 8 + i].Name;
                    pictureboxs[i].Image = Image.FromFile(lstsong[page_song * 8 + i].Image_path);
                    panels[i].Visible = true;
                }
                else
                {
                    panels[i].Visible = false;
                    labels[i].Visible = false;
                    pictureboxs[i].Visible = false;
                }
            }
            recal = false;
        }
        void enableall()
        {
            var labels = new List<Label> { label_item1, label_item2, label_item3, label_item4, label_item5, label_item6, label_item7, label_item8 };
            var pictureboxs = new List<PictureBox> { pictureBox_item1, pictureBox_item2, pictureBox_item3, pictureBox_item4, pictureBox_item5, pictureBox_item6, pictureBox_item7, pictureBox_item8 };
            var panels = new List<Panel> { panel_item1, panel_item2, panel_item3, panel_item4, panel_item5, panel_item6, panel_item7, panel_item8 };
            for(int i=0; i<8;i++)
            {
                labels[i].Visible = true;
                panels[i].Visible = true;
                pictureboxs[i].Visible = true;
            }
        }
        void showotherbyquery(string query, bool checkrecal)
        {
            enableall();
            var labels = new List<Label> { label_item1, label_item2, label_item3, label_item4, label_item5, label_item6, label_item7, label_item8 };
            var pictureboxs = new List<PictureBox> { pictureBox_item1, pictureBox_item2, pictureBox_item3, pictureBox_item4, pictureBox_item5, pictureBox_item6, pictureBox_item7, pictureBox_item8 };
            var panels = new List<Panel> { panel_item1, panel_item2, panel_item3, panel_item4, panel_item5, panel_item6, panel_item7, panel_item8 };
            label_noHasItem.Visible = false;
            foreach (var pn in panels)
            {
                pn.Visible = false;
            }

            query = textBox_titleSong.Text;

            lstother = new List<song>();
            //List<song> fin_lstsong = new List<song>();
            lstother = songDAO.Instance.getothersong(query);

            if (checkrecal==true)
            {
                max_page_other = lstother.Count / 8;
                if (lstother.Count % 8 == 0)
                    max_page_other--;
                page_other = 0;
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.Write(lstother.Count);
            Console.WriteLine(max_page_other);
            Console.WriteLine(page_other);
            //panel_item1.Visible = true;
            //panel_item2.Visible = true;
            //pictureBox_item1.Image = Image.FromFile(lstsong[0].Image_path);
            //label_item1.Text = lstsong[0].Name;

            if (lstother.Count == 0)
            {
                label_noHasItem.Visible = true;
            }
            for (int i = 0; i < 8; i++)
            {
                if (page_other*8+i<lstother.Count)
                {
                    labels[i].Text = lstother[page_other * 8 + i].Name;
                    pictureboxs[i].Image = Image.FromFile(lstother[page_other * 8 + i].Image_path);
                    panels[i].Visible = true;
                }
                else
                {
                    labels[i].Visible = false;
                    pictureboxs[i].Visible = false;
                    panels[i].Visible = false;
                }
            }
            recal = false;
        }
        private void button_song_Click(object sender, EventArgs e)
        {
            
            string query = textBox_titleSong.Text.Replace("\n","").Trim();
            if (search == 1)
            {
                check = "song";
                showsongbyquery(query, recal);
            }
        }

        void showalbumbyquery(string query, bool checkrecal)
        {
            enableall();
            var labels = new List<Label> { label_item1, label_item2, label_item3, label_item4, label_item5, label_item6, label_item7, label_item8 };
            var pictureboxs = new List<PictureBox> { pictureBox_item1, pictureBox_item2, pictureBox_item3, pictureBox_item4, pictureBox_item5, pictureBox_item6, pictureBox_item7, pictureBox_item8 };
            var panels = new List<Panel> { panel_item1, panel_item2, panel_item3, panel_item4, panel_item5, panel_item6, panel_item7, panel_item8 };
            label_noHasItem.Visible = false;
            foreach (var pn in panels)
            {
                pn.Visible = false;
            }
            
            lstalbum = albumDAO.Instance.getalbumbyqueryname(query);
            if (checkrecal==true)
            {
                max_page_album = lstalbum.Count / 8;
                if (lstalbum.Count%8==0)
                {
                    max_page_album--;
                }
                page_album = 0;
            }


            if (lstalbum.Count == 0)
            {
                label_noHasItem.Visible = true;
            }
            for (int i = 0; i < 8; i++)
            {
                if (page_album*8+i<lstalbum.Count)
                {
                    labels[i].Text = lstalbum[page_album * 8 + i].Name;
                    pictureboxs[i].Image = Image.FromFile(lstalbum[page_album * 8 + i].Image_path);
                    panels[i].Visible = true;
                }
                else
                {
                    labels[i].Visible = false;
                    pictureboxs[i].Visible = false;
                    panels[i].Visible = false;
                    //panels[i].BackgroundImage = Image.FromFile(lstalbum[i].Image_path);
                }
            }
            recal = false;
        }
        private void button_album_Click(object sender, EventArgs e)
        {

            string query = textBox_titleSong.Text.Replace("\n","").Trim();
            if (search == 1)
            {
                showalbumbyquery(query, recal);
                check = "album";
            }

            
        }

        private void textBox_titleSong_TextChanged(object sender, EventArgs e)
        {
            if (textBox_titleSong.Text.Replace("\n", "").Trim() == "")
            {
                button_searchSong.Enabled = false;
                var panels = new List<Panel> { panel_item1, panel_item2, panel_item3, panel_item4, panel_item5, panel_item6, panel_item7, panel_item8 };
                foreach (var pn in panels)
                {
                    pn.Visible = false;
                }
                //search = 0;
            }
            else
            {
                button_searchSong.Enabled = true;
                if (textBox_titleSong.Text.Contains("\n"))
                {
                    search = 1;
                    textBox_titleSong.Text = textBox_titleSong.Text.Replace("\n", "").Trim();
                    textBox_titleSong.Focus();
                    textBox_titleSong.SelectionStart = textBox_titleSong.Text.Length;
                    button_searchSong.PerformClick();
                }
                recal = true;
            }

            if (textBox_titleSong.Text.Replace("\n", "").Trim() != "" && search == 1)
            {

                button_searchSong.Enabled = true;
                //search = 0;
                string query = textBox_titleSong.Text.Replace("\n", "").Trim();
                //Console.WriteLine(query);
                if (check == "song")
                {
                    showsongbyquery(query, recal);
                }
                if (check == "album")
                {
                    showalbumbyquery(query, recal);
                }
                if (check == "other")
                {
                    showotherbyquery(query, recal);
                }
                if (textBox_titleSong.Text.Contains("\n"))
                {
                    textBox_titleSong.Text = textBox_titleSong.Text.Replace("\n", "").Trim();
                    button_searchSong.PerformClick();
                }
            }

        }

        private void panel_item1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel_item1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        
        private void button_playItem1_Click(object sender, EventArgs e)
        {
            if (check=="song")
            {
                passSongToParentForm(lstsong[0]);
            }
            if (check=="album")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item1.Text);
                passSongToParentForm(lstsongofalbum[0],false, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[0]);
            }

        }
        
        private void button_item2_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[1]);
            }
            if (check == "album")
            {
                //Console.WriteLine(lstsong[1].Name);
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item2.Text);
                passSongToParentForm(lstsongofalbum[1], false, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[1]);
            }
        }

        private void button_item3_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[2]);
            }
            if (check == "album")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item3.Text);
                passSongToParentForm(lstsongofalbum[2], false, true);

            }
            if (check == "other")
            {
                passSongToParentForm(lstother[2]);
            }
        }

        private void button_item4_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[3]);
            }
            if (check == "album")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item4.Text);
                passSongToParentForm(lstsongofalbum[0], false, true);

            }
            if (check == "other")
            {
                passSongToParentForm(lstother[3]);
            }
        }

        private void button_item5_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[4]);
            }
            if (check == "album")
            {
                //lstsongofalbum
                passSongToParentForm(lstsong[4], false, true);

            }
            if (check == "other")
            {
                passSongToParentForm(lstother[4]);
            }
        }

        private void button_item6_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[5]);
            }
            if (check == "album")
            {
                passSongToParentForm(lstsong[5], false, true);

            }
            if (check == "other")
            {
                passSongToParentForm(lstother[5]);
            }
        }

        private void button_item7_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[6]);
            }
            if (check == "album")
            {
                passSongToParentForm(lstsong[6], false, true);

            }
            if (check == "other")
            {
                passSongToParentForm(lstother[6]);
            }
        }

        private void button_item8_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[7]);
            }
            if (check == "album")
            {
                passSongToParentForm(lstsong[7], false, true);

            }
            if (check == "other")
            {
                passSongToParentForm(lstother[7]);
            }
        }

        private void button_addItem1_1_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[0],true);
            }
            if (check == "album")
            {
                passSongToParentForm(lstsong[0],true,true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[0], true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[1], true);
            }
            if (check == "album")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item2.Text);
                passSongToParentForm(lstsongofalbum[0], true, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[1], true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[2], true);
            }
            if (check == "album")
            {

                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item3.Text);
                passSongToParentForm(lstsongofalbum[0], true, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[2], true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[3], true);
            }
            if (check == "album")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item4.Text);
                passSongToParentForm(lstsongofalbum[0], true, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[3], true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[4], true);
            }
            if (check == "album")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item5.Text);
                passSongToParentForm(lstsongofalbum[0], true, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[4], true);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[5], true);
            }
            if (check == "album")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item6.Text);
                passSongToParentForm(lstsongofalbum[0], true, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[5], true);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[6], true);
            }
            if (check == "album")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item7.Text);
                passSongToParentForm(lstsongofalbum[0], true, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[6], true);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[7], true);
            }
            if (check == "album")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item8.Text);
                passSongToParentForm(lstsongofalbum[0], true, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[7], true);
            }
        }

        private void button_recorded_Click(object sender, EventArgs e)
        {
            string query = textBox_titleSong.Text.Replace("\n","").Trim();
            if (search == 1)
            {
                check = "other";
                showotherbyquery(query, recal);
            }
        }

        private void button_playItem1_Click_1(object sender, EventArgs e)
        {
            if (check == "song")
            {
                passSongToParentForm(lstsong[0]);
            }
            if (check == "album")
            {
                //Console.WriteLine(lstsong[1].Name);
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(label_item1.Text);
                passSongToParentForm(lstsongofalbum[0], false, true);
            }
            if (check == "other")
            {
                passSongToParentForm(lstother[0]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check=="song")
            {
                if(page_song<max_page_song)
                {
                    page_song++;
                    
                    showsongbyquery(textBox_titleSong.Text.Replace("\n", "").Trim(), recal);
                }
                
            }
            if (check == "album")
            {
                if (page_album < max_page_album)
                {
                    page_album++;
                    showalbumbyquery(textBox_titleSong.Text.Replace("\n", "").Trim(), recal);
                }

            }
            if (check == "other")
            {
                if (page_other < max_page_other)
                {
                    page_other++;
                    showotherbyquery(textBox_titleSong.Text.Replace("\n", "").Trim(), recal);
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (check == "song")
            {
                if (page_song >0)
                {
                    page_song--;
                    showsongbyquery(textBox_titleSong.Text.Replace("\n", "").Trim(), recal);
                }

            }
            if (check == "album")
            {
                if (page_album >0)
                {
                    page_album--;
                    showalbumbyquery(textBox_titleSong.Text.Replace("\n", "").Trim(), recal);
                }

            }
            if (check == "other")
            {
                if (page_other >0)
                {
                    page_other--;
                    showotherbyquery(textBox_titleSong.Text.Replace("\n", "").Trim(), recal);
                }

            }
        }
    }
}
