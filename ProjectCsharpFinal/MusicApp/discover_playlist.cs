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
using MusicApp.DAO;
using MusicApp.DTO;

namespace MusicApp
{
    public partial class discover_playlist : Form
    {
        public static event EventHandler<passSongToPlayBarEventArgs> PassSong;
        List<playlist> lstplaylist = new List<playlist>();
        List<song> lstsongofplaylist = new List<song>();
        int count;
        int page = 0;
        public discover_playlist()
        {
            InitializeComponent();
        }


        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loaddata()
        {
            lstplaylist = DAO.playlistDAO.Instance.getplaylist();
            count = lstplaylist.Count();
        }
        private void passSongToParentForm(song slectedSong, bool addPlaylist = false)
        {
            if (PassSong != null)
            {
                PassSong.Invoke(this, new passSongToPlayBarEventArgs(slectedSong,addPlaylist));
            }
        }
        public void load_playlist()
        {
            enablepanel();
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            for (int i = 0; i < 9; i++)
            {
                if (page * 9 + i < count)
                {

                    lstpanel1[i].BackgroundImage = Image.FromFile(lstplaylist[page * 9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(lstplaylist[page * 9 + i].Image_path);
                    if (lstplaylist[page * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = lstplaylist[page * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = lstplaylist[page * 9 + i].Name;
                    }
                    //lstlabelsinger[i].Text = albumVN[page_albumvietnam * 9 + i].Singer;
                }
                else
                {
                    lstpanel1[i].Visible = false;
                    //lstlabelsinger[i].Visible = false;
                    lstlabeltitle[i].Visible = false;
                }
            }
        }
        private void discover_playlist_Load(object sender, EventArgs e)
        {
            // ẩn vùng bao của nút
            /*
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            button_newSongs.FlatAppearance.BorderSize = 0;
            */
            loaddata();
            load_playlist();
        }

        private void panel_main_playlist_Paint(object sender, PaintEventArgs e)
        {

        }
        void enablepanel()
        {
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            //var lstlabelsinger = new List<Label> { label_item1_singer, label_item2_singer, label_item3_singer, labelitem4singer, labelitem5singer, labelitem6singer, labelitem7singer, labelitem8singer, labelitem9singer };
            for (int i = 0; i < 9; i++)
            {
                lstpanel2[i].Visible = false;
                lstpanel1[i].Visible = true;
                lstlabeltitle[i].Visible = true;
                //lstlabelsinger[i].Visible = true;

            }
        }

        private void panel_item_1_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = false;
        }

        private void panel_item_1_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = true;
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

        private void _panelitem42_MouseLeave(object sender, EventArgs e)
        {
            _panelitem42.Visible = false;
        }

        private void _panelitem41_MouseHover(object sender, EventArgs e)
        {
            _panelitem42.Visible = true;
        }

        private void panelitem52_MouseLeave(object sender, EventArgs e)
        {
            panelitem52.Visible = false;
        }

        private void panelitem62_MouseLeave(object sender, EventArgs e)
        {
            panelitem62.Visible = false;
        }

        private void panelitem72_MouseLeave(object sender, EventArgs e)
        {
            panelitem72.Visible = false;
        }

        private void panelitem82_MouseLeave(object sender, EventArgs e)
        {
            panelitem82.Visible = false;
        }

        private void panelitem92_MouseLeave(object sender, EventArgs e)
        {
            panelitem92.Visible = false;
        }

        private void panelitem51_MouseHover(object sender, EventArgs e)
        {
            panelitem52.Visible = true;
        }

        private void panelitem61_MouseHover(object sender, EventArgs e)
        {
            panelitem62.Visible = true;
        }

        private void panelitem71_MouseHover(object sender, EventArgs e)
        {
            panelitem72.Visible = true;
        }

        private void panelitem81_MouseHover(object sender, EventArgs e)
        {
            panelitem82.Visible = true;
        }

        private void panelitem91_MouseHover(object sender, EventArgs e)
        {
            panelitem92.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 0].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0]);
        }

        private void pictureBox_item2_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 1].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0]);
        }

        private void pictureBox_item3_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 2].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 3].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0]);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 4].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 5].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0]);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 6].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0]);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 7].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0]);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 8].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (page * 9 + 9 < count)
            {
                page += 1;
                load_playlist();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                load_playlist();
            }
        }

        private void button_addItem1_1_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 0].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0],true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 1].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0],true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 2].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0],true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 3].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0],true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 4].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0],true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 5].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0],true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 6].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0],true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 7].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0], true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstsongofplaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(lstplaylist[page * 9 + 8].Name);
            if (lstsongofplaylist.Count > 0)
                passSongToParentForm(lstsongofplaylist[0], true);
        }
    }
}
