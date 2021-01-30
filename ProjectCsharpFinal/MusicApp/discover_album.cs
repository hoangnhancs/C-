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
    public partial class discover_album : Form
    {
        public static event EventHandler<passSongToPlayBarEventArgs> PassSong;
        int albumvietnam_count;
        int albumchaumy_count;
        //int nhacnuocngoai_count;
        //int record_count = 0;
        int page_albumvietnam = 0;
        int page_albumchaumy = 0;
        //int page_nhacremix = 0;
        //int page_record = 0;
        string recent = "viet nam";
        List<song> lstsongofalbum = new List<song>();
        public discover_album()
        {
            InitializeComponent();
        }

        private void discover_album_Load(object sender, EventArgs e)
        {
            // ẩn vùng bao của nút
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            loaddata();
            loadalbumVietNam();
            //button_newSongs.FlatAppearance.BorderSize = 0;
        }
        private void passSongToParentForm(song slectedSong,bool addPlaylist = false)
        {
            if (PassSong != null)
            {
                PassSong.Invoke(this, new passSongToPlayBarEventArgs(slectedSong, addPlaylist));
            }
        }
        List<album> albumVN = new List<album>();
        List<album> albumChauMy = new List<album>();
        public void loaddata()
        {
            albumVN = DAO.albumDAO.Instance.getalbumwithcategory("Việt Nam");
            albumChauMy = DAO.albumDAO.Instance.getalbumwithcategory("Châu Mỹ");
            albumvietnam_count = albumVN.Count();
            albumchaumy_count = albumChauMy.Count();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_menuBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_differentSongs_Click(object sender, EventArgs e)
        {

        }

        private void button_AsianSongs_Click(object sender, EventArgs e)
        {

        }
        void loadalbumchaumy()
        {
            button_AmericaSongs.FlatAppearance.BorderSize = 1;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            for (int i = 0; i < 9; i++)
            {
                if (page_albumchaumy * 9 + i < albumchaumy_count)
                {

                    lstpanel1[i].BackgroundImage = Image.FromFile(albumChauMy[page_albumchaumy * 9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(albumChauMy[page_albumchaumy * 9 + i].Image_path);
                    if (albumChauMy[page_albumchaumy * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = albumChauMy[page_albumchaumy * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = albumChauMy[page_albumchaumy * 9 + i].Name;
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
        private void button_AmericaSongs_Click(object sender, EventArgs e)
        {
            recent = "chau my";
            loadalbumchaumy();
        }
        void loadalbumVietNam()
        {
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 1;
            var lstpanel1 = new List<Panel> { panel_item_1_1, panel_item_2_1, panel_item_3_1, _panelitem41, panelitem51, panelitem61, panelitem71, panelitem81, panelitem91 };
            var lstpanel2 = new List<Panel> { panel_item_1_2, panel_item_2_2, panel_item_3_2, _panelitem42, panelitem52, panelitem62, panelitem72, panelitem82, panelitem92 };
            var lstlabeltitle = new List<Label> { label_item1_title, label_item2_title, label_item3_title, labelitem4title, labelitem5title, labelitem6title, labelitem7title, labelitem8title, labelitem9title };
            for (int i = 0; i < 9; i++)
            {
                if (page_albumvietnam * 9 + i < albumvietnam_count)
                {

                    lstpanel1[i].BackgroundImage = Image.FromFile(albumVN[page_albumvietnam * 9 + i].Image_path);
                    lstpanel2[i].BackgroundImage = Image.FromFile(albumVN[page_albumvietnam * 9 + i].Image_path);
                    if (albumVN[page_albumvietnam * 9 + i].Name.Length >= 22)
                    {
                        lstlabeltitle[i].Text = albumVN[page_albumvietnam * 9 + i].Name.Substring(0, 21);
                    }
                    else
                    {
                        lstlabeltitle[i].Text = albumVN[page_albumvietnam * 9 + i].Name;
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
        private void button_VNSongs_Click(object sender, EventArgs e)
        {
            recent = "viet nam";
            loadalbumVietNam();
        }

        private void button_newSongs_Click(object sender, EventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_item_2_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_item2_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[1].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[1].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[1].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0],true);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[1].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0],true);
            }
        }

        private void panel_item_2_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_item_1_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[0].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[0].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            
        }

        private void button_addItem1_1_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[0].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0],true);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[0].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0],true);
            }
        }

        private void panel_item_1_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_item3_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[2].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[2].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[2].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0],true);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[2].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0],true);
            }
        }

        private void panel_item_3_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_item_3_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_item_1_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = false;
        }

        private void panel_item_1_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = true;
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

        private void panel_item_2_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_2_2.Visible = false;
        }

        private void panel_item_2_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_2_2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[3].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[3].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[3].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[3].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[4].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[4].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[4].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[4].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[5].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[5].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[5].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[5].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[6].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[6].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[6].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[6].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[7].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[7].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[7].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[7].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[8].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[8].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (recent == "viet nam")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumVN[8].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
            if (recent == "chau my")
            {
                lstsongofalbum = DAO.albumDAO.Instance.getsongwithnamealbum(albumChauMy[8].Name);
                //Console.WriteLine(lstsongofalbum.Count());
                passSongToParentForm(lstsongofalbum[0], true);
            }
        }
    }
}
