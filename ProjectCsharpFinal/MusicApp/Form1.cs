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

        

        //string path;
        homePage hp = new homePage();
        public MusicApp()
        {
            //label_nameSong.Text = hp.Name;
            
            InitializeComponent();
            //load();
            label_nameSong.Text = hp.text;
            //path = homePage.SongNowPlaying;
            
            //label_nameSong.Text = homePage.SongNowPlaying;
        }
        //public static void 
        public void reload()
        {
            
        }
        /*
        public string songplaying
        {
            set { label_nameSong.Text = value; }
        }
        */
        // biến lưu giữ trạng thái của main panel

        public static string songNameKaraoke = "";

        // thêm form vào panel main
        private Form activeForm = null;
        private void openChildForm(Form childForm, bool karaokeForm=false)
        {
            if (karaokeForm)
            {
                panel_PlayBar.Visible = false;
            }
            else
            {
                panel_PlayBar.Visible = true;
            }
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
            button_karaoke.FlatAppearance.BorderSize = 0;

            // moreTool button
            button_addPlaylist.FlatAppearance.BorderSize = 0;
            button_moveToSong.FlatAppearance.BorderSize = 0;
            button_setTime.FlatAppearance.BorderSize = 0;

            // login button
            button_login.FlatAppearance.BorderSize = 0;
            button_signUp.FlatAppearance.BorderSize = 0;

            //karaoke
            button_recorded.FlatAppearance.BorderSize = 0;
            button_recording.FlatAppearance.BorderSize = 0;

            // load form vào panel main
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
            //homePage.
            openChildForm(homePage);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Form search = new Search();
            openChildForm(search);
        }

        private void label_login_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        private Form activeFormLogin = null;
        private void button_login_Click(object sender, EventArgs e)
        {
            if (activeFormLogin == null)
            {
                Form loginForm = new Login();
                activeFormLogin = loginForm;
                loginForm.Show();
            }
            else
            {
                activeFormLogin.Close();
                activeFormLogin = null;
            }

        }

        private Form activeFormSignUp = null;
        private void button_signUp_Click(object sender, EventArgs e)
        {
            if (activeFormSignUp == null)
            {
                Form signUpForm = new SignUp();
                activeFormLogin = signUpForm;
                signUpForm.Show();
            }
            else
            {
                activeFormSignUp.Close();
                activeFormSignUp = null;
            }
        }

        private void button_karaoke_Click(object sender, EventArgs e)
        {
            if (panel_karaoke.Visible == false)
            {
                panel_karaoke.Visible = true;
            }
            else
            {
                panel_karaoke.Visible = false;
            }
        }

        private void button_recording_Click(object sender, EventArgs e)
        {
            Form karaoke = new Karaoke();
            openChildForm(karaoke,true);
        }

        private void button_recorded_Click(object sender, EventArgs e)
        {
            Form recorded = new Recorded();
            openChildForm(recorded);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            songNameKaraoke = label_nameSong.Text + " karaoke";

            Form karaoke = new Karaoke();
            openChildForm(karaoke, true);
        }

        private void pictureBox_pictureSong_Click(object sender, EventArgs e)
        {

        }

        private void label_nameSong_Click(object sender, EventArgs e)
        {

        }
    }
}
