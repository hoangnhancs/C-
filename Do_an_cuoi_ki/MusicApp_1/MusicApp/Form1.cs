using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class MusicApp : Form
    {
        public MusicApp()
        {
            InitializeComponent();
        }
        // biến lưu giữ trạng thái của main panel



        // thêm form vào panel main
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void groupBox_Song_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_play_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {

        }

        private void MusicApp_Load(object sender, EventArgs e)
        {
            // ẩn vùng bao quanh bút
            // menu button
            button_search.FlatAppearance.BorderSize = 0;
            button_album.FlatAppearance.BorderSize = 0;
            button_home.FlatAppearance.BorderSize = 0;
            button_playlistSongs.FlatAppearance.BorderSize = 0;
            button_singer.FlatAppearance.BorderSize = 0;
            button_discover.FlatAppearance.BorderSize = 0;
            button_Songs.FlatAppearance.BorderSize = 0;
            button_importMusic.FlatAppearance.BorderSize = 0;

            // moreTool button
            button_addPlaylist.FlatAppearance.BorderSize = 0;
            button_moveToSong.FlatAppearance.BorderSize = 0;
            button_setTime.FlatAppearance.BorderSize = 0;
            Form homePage = new homePage();
            openChildForm(homePage);
        }

        private void panel_MenuBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel_Music.Visible)
            {
                panel_Music.Visible = false;
                panel_spaceListDis.Visible = false;
            }
            else
            {
                panel_Music.Visible = true;
                panel_spaceListDis.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (panel_Music.Visible)
            {
                panel_Music.Visible = false;
                panel_spaceListDis.Visible = false;
            }
            else
            {
                panel_Music.Visible = true;
                panel_spaceListDis.Visible = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (panel_moreToolButton.Visible)
            {
                panel_moreToolButton.Visible = false;
                panel_moreToolButton.BackColor = Color.FromArgb(33, 42, 53);
            }
            else
            {
                panel_moreToolButton.Visible = true;
                panel_moreToolButton.BackColor = Color.FromArgb(29, 38, 49);
            }    
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Songs_Click(object sender, EventArgs e)
        {
            Form discover_songsButton = new discover_songs();
            openChildForm(discover_songsButton);
            //axWindowsMediaPlayerMusic.URL = ConnectionDB.SelectedPath;
            //axWindowsMediaPlayerMusic.Ctlcontrols.play();
        }

        private void button_importMusic_Click(object sender, EventArgs e)
        {
            Form import = new import();
            openChildForm(import);
        }

        private void button_playlistSongs_Click(object sender, EventArgs e)
        {
            Form discover_playlist = new discover_playlist();
            openChildForm(discover_playlist);
        }

        private void button_album_Click(object sender, EventArgs e)
        {
            Form discover_album = new discover_album();
            openChildForm(discover_album);
        }

        private void button_singer_Click(object sender, EventArgs e)
        {
            Form discover_singer = new discover_singer();
            openChildForm(discover_singer);
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Form homePage = new homePage();
            openChildForm(homePage);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Form search = new Search();
            openChildForm(search);
        }

        private void pic_stop_Click(object sender, EventArgs e)
        {
            pictureBox_buttonPlayer.Visible = true;
            pic_stop.Visible = false;
        }

        private void pictureBox_buttonPlayer_Click(object sender, EventArgs e)
        {
            pictureBox_buttonPlayer.Visible = false;
            pic_stop.Visible = true;
        }
    }
}
