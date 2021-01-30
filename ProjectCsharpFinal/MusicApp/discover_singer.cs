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
    public partial class discover_singer : Form
    {
        public static event EventHandler<passSongToPlayBarEventArgs> PassSong;
        List<singer> lst_allsinger = new List<singer>();
        List<singer> lst_singerVN = new List<singer>();
        List<singer> lst_singerNN = new List<singer>();
        List<song> lstsongofsinger = new List<song>();
        int page_allsinger = 0;
        int page_singerVN = 0;
        int page_singerNN = 0;
        int allsinger_count;
        int singerVN_count;
        int singerNN_count;
        string recent = "all";
        public discover_singer()
        {
            InitializeComponent();
        }
        private void passSongToParentForm(song slectedSong, bool addtoplaylist = false)
        {
            if (PassSong != null)
            {
                PassSong.Invoke(this, new passSongToPlayBarEventArgs(slectedSong, addtoplaylist));
            }
        }
        public void loaddata()
        {
            lst_allsinger = DAO.singerDAO.Instance.getsinger();
            allsinger_count = lst_allsinger.Count();
            lst_singerVN = DAO.singerDAO.Instance.getsingerbycat("Việt Nam");
            singerVN_count = lst_singerVN.Count();
            lst_singerNN = DAO.singerDAO.Instance.getsingerbycat("Nước ngoài");
            singerNN_count = lst_singerNN.Count();
        }
        public void load_allsinger()
        {
            enablepanel();
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            button_all.FlatAppearance.BorderSize = 1;
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            for (int i = 0; i < 9; i++)
            {
                if (page_allsinger * 9 + i < allsinger_count)
                {

                    lstpanel1[i].BackgroundImage = Image.FromFile(lst_allsinger[page_allsinger * 9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(lst_allsinger[page_allsinger * 9 + i].Image_path);
                    if (lst_allsinger[page_allsinger * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = lst_allsinger[page_allsinger * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = lst_allsinger[page_allsinger * 9 + i].Name;
                    }
                    //lstlabelsinger[i].Text = albumVN[page_allsinger_albumvietnam * 9 + i].Singer;
                }
                else
                {
                    lstpanel1[i].Visible = false;
                    //lstlabelsinger[i].Visible = false;
                    lstlabeltitle[i].Visible = false;
                }
            }
        }
        void load_singerVN()
        {
            enablepanel();
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 1;
            button_all.FlatAppearance.BorderSize = 0;
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            for (int i = 0; i < 9; i++)
            {
                if (page_singerVN * 9 + i < singerVN_count)
                {

                    lstpanel1[i].BackgroundImage = Image.FromFile(lst_singerVN[page_singerVN * 9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(lst_singerVN[page_singerVN * 9 + i].Image_path);
                    if (lst_singerVN[page_singerVN * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = lst_singerVN[page_singerVN * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = lst_singerVN[page_singerVN * 9 + i].Name;
                    }
                    //lstlabelsinger[i].Text = albumVN[page_allsinger_albumvietnam * 9 + i].Singer;
                }
                else
                {
                    lstpanel1[i].Visible = false;
                    //lstlabelsinger[i].Visible = false;
                    lstlabeltitle[i].Visible = false;
                }
            }
        }

        void load_singerNN()
        {
            enablepanel();
            button_AmericaSongs.FlatAppearance.BorderSize = 1;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            button_all.FlatAppearance.BorderSize = 0;
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            for (int i = 0; i < 9; i++)
            {
                if (page_singerNN * 9 + i < singerNN_count)
                {

                    lstpanel1[i].BackgroundImage = Image.FromFile(lst_singerNN[page_singerNN * 9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(lst_singerNN[page_singerNN * 9 + i].Image_path);
                    if (lst_singerNN[page_singerNN * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = lst_singerNN[page_singerNN * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = lst_singerNN[page_singerNN * 9 + i].Name;
                    }
                    //lstlabelsinger[i].Text = albumVN[page_allsinger_albumvietnam * 9 + i].Singer;
                }
                else
                {
                    lstpanel1[i].Visible = false;
                    //lstlabelsinger[i].Visible = false;
                    lstlabeltitle[i].Visible = false;
                }
            }
        }
        private void discover_singer_Load(object sender, EventArgs e)
        {
            // ẩn vùng bao của nút
            /*
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            button_all.FlatAppearance.BorderSize = 0;
            */
            loaddata();
            load_allsinger();
        }

        private void panel_item_1_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = false;
        }

        private void panel_item_2_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_2_2.Visible = false;
        }

        private void panel_item_3_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_3_2.Visible = false;
        }

        private void _panelitem42_MouseLeave(object sender, EventArgs e)
        {
            _panelitem42.Visible = false;
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

        private void panel_item_1_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = true;
        }

        private void panel_item_2_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_2_2.Visible = true;
        }

        private void panel_item_3_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_3_2.Visible = true;
        }

        private void _panelitem41_MouseHover(object sender, EventArgs e)
        {
            _panelitem42.Visible = true;
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (recent == "all")
            {
                if (page_allsinger * 9 + 9 < allsinger_count)
                {
                    page_allsinger += 1;
                    load_allsinger();
                }
            }
            if (recent == "VN")
            {
                if (page_singerVN * 9 + 9 < singerVN_count)
                {
                    page_singerVN += 1;
                    load_singerVN();
                }
            }
            if (recent == "NN")
            {
                if (page_singerNN * 9 + 9 < singerNN_count)
                {
                    page_singerNN += 1;
                    load_singerNN();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (recent == "all")
            {
                if (page_allsinger > 0)
                {
                    page_allsinger--;
                    load_allsinger();
                }
            }
            if (recent == "VN")
            {
                if (page_singerVN > 0)
                {
                    page_singerVN--;
                    load_singerVN();
                }
            }
            if (recent == "NN")
            {
                if (page_singerNN > 0)
                {
                    page_singerNN--;
                    load_singerNN();
                }
            }
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            recent = "all";
            load_allsinger();
        }

        private void button_VNSongs_Click(object sender, EventArgs e)
        {
            recent = "VN";
            load_singerVN();
        }

        private void button_AmericaSongs_Click(object sender, EventArgs e)
        {
            recent = "NN";
            load_singerNN();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            playSongOfSinger(3);
        }
        public void playSongOfSinger(int i, bool addtoplaylist = false)
        {
            if (recent == "VN")
            {
                lstsongofsinger = DAO.singerDAO.Instance.getsongbynamesinger(lst_singerVN[page_singerVN * 9 + i].Name);
                passSongToParentForm(lstsongofsinger[0], addtoplaylist);
            }
            if (recent == "all")
            {
                lstsongofsinger = DAO.singerDAO.Instance.getsongbynamesinger(lst_allsinger[page_allsinger * 9 + i].Name);
                passSongToParentForm(lstsongofsinger[0], addtoplaylist);
            }
            if (recent == "NN")
            {

                lstsongofsinger = DAO.singerDAO.Instance.getsongbynamesinger(lst_singerNN[page_singerNN * 9 + i].Name);
                passSongToParentForm(lstsongofsinger[0], addtoplaylist);

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            playSongOfSinger(0);
        }

        private void pictureBox_item2_Click(object sender, EventArgs e)
        {
            playSongOfSinger(1);
        }

        private void pictureBox_item3_Click(object sender, EventArgs e)
        {
            playSongOfSinger(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            playSongOfSinger(4);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            playSongOfSinger(5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            playSongOfSinger(6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            playSongOfSinger(7);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            playSongOfSinger(8);
        }

        private void panel_item_1_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_addItem1_1_Click(object sender, EventArgs e)
        {
            playSongOfSinger(0, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playSongOfSinger(1, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playSongOfSinger(5, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playSongOfSinger(2, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playSongOfSinger(3, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playSongOfSinger(4, true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            playSongOfSinger(6, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            playSongOfSinger(7, true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            playSongOfSinger(8, true);
        }
    }
}
