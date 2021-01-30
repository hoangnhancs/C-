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
using MusicApp.Properties;
using WMPLib;
using MusicApp.Properties;
using MusicApp.static_class;
using System.Data.SqlClient;

namespace MusicApp
{
    public partial class MusicApp : Form
    {
        //now playing playlist
        public static List<song> nowPlayingPlaylist;
        List<song> backUpNowPlayingPlaylist;
        public static int indexSongNowPlaying;
        
        public MusicApp()
        {
            InitializeComponent();
        }

        // biến kiểm tra có phải là lần đầu mở form
        bool loadSongFist = true;
        public static bool loadKaraokeFormButton = false;

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

        private void pictureBox_logo_Click(object sender, EventArgs e) { }
        

        // load form
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

            //karaoke
            button_recording.FlatAppearance.BorderSize = 0;

            // load form vào panel main
            homePage homePageForm = new homePage();
            homePage.PassSong += HomePage_PassSong;
            openChildForm(homePageForm);

            // playbar
            trackBar_volume.Value = axWindowsMediaPlayer.settings.volume;
            button_playKaraoke.FlatAppearance.BorderSize = 0;
            button_volume.FlatAppearance.BorderSize = 0;
            button_moreTools.FlatAppearance.BorderSize = 0;
            button_playlist.FlatAppearance.BorderSize = 0;
            button_play.FlatAppearance.BorderSize = 0;
            button_next.FlatAppearance.BorderSize = 0;
            button_previous.FlatAppearance.BorderSize = 0;
            button_mix.FlatAppearance.BorderSize = 0;
            button_repeat.FlatAppearance.BorderSize = 0;
            button_trash.FlatAppearance.BorderSize = 0;

            // load bài gốc
            nowPlayingPlaylist = new List<song>();
            nowPlayingPlaylist = songDAO.Instance.getsongbyname(label_nameSong.Text);
            indexSongNowPlaying = 0;
        }

        // hàm đổi data bài đang phát
        private void changeDataSongPlaying(song slectedSong)
        {
            pictureBox_pictureSong.Image = Image.FromFile(slectedSong.Image_path);
            label_nameSong.Text = slectedSong.Name;
            label_authorSong.Text = slectedSong.Singer;
        }

        // hàm chơi nhạc 
        private void playMusic(song slectedSong)
        {
            axWindowsMediaPlayer.URL = slectedSong.Song_path;
            axWindowsMediaPlayer.Ctlcontrols.play();
            button_play.BackgroundImage = Resources.Picture1;
        }

        // hàm pass song từ homepage về playbar
        private void HomePage_PassSong(object sender, static_class.passSongToPlayBarEventArgs e)
        {
            if (loadSongFist == false && e.checkAdd == true)
            {
                nowPlayingPlaylist.Add(e.slectedSong);

                // thêm nhạc vào playlist backup nên đang ở chế độ shuffle
                if (shuffled)
                {
                    backUpNowPlayingPlaylist.Add(e.slectedSong);
                }
            }
            else
            {
                nowPlayingPlaylist = new List<song>();
                changeDataSongPlaying(e.slectedSong);
                indexSongNowPlaying = 0;
                playMusic(e.slectedSong);
                nowPlayingPlaylist.Add(e.slectedSong);
                // cập nhật lại không phải load lần đầu
                loadSongFist = false;
            }
            showPlaylist();
        }

        // show playlist
        private void showPlaylist()
        {
            if (listBox_playlist.DataSource != null)
                listBox_playlist.DataSource = null;
            listBox_playlist.DataSource = nowPlayingPlaylist;
            listBox_playlist.DisplayMember = "name";
        }

        private void panel_MenuBar_Paint(object sender, PaintEventArgs e)
        {

        }

        // show/hide các mục trong discover
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

        // show/hide các mục trong discover
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

        // show / hide moreButtonTools
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

        // hàm show form discover_song
        private void button_Songs_Click(object sender, EventArgs e)
        {
            Form discover_songsButton = new discover_songs();
            discover_songs.PassSong += Discover_songs_PassSong;
            openChildForm(discover_songsButton);
        }

        // pass song từ form discover_song về playbar
        private void Discover_songs_PassSong(object sender, static_class.passSongToPlayBarEventArgs e)
        { 
            // kiểm tra xem phải add playlist không 
            if (loadSongFist == false && e.checkAdd == true)
            {
                // add song to playlist
                nowPlayingPlaylist.Add(e.slectedSong);

                // thêm nhạc vào playlist backup nên đang ở chế độ shuffle
                if (shuffled)
                {
                    backUpNowPlayingPlaylist.Add(e.slectedSong);
                }
            }
            else
            {
                // tạo playlist mới 
                nowPlayingPlaylist = new List<song>();

                // thay đổi dữ liệu của playbar 
                changeDataSongPlaying(e.slectedSong);

                // update lại vị trí 
                indexSongNowPlaying = 0;

                // chơi nhạc
                playMusic(e.slectedSong);

                // add bài nhạc vào playlist hiện tại
                nowPlayingPlaylist.Add(e.slectedSong);

                // cập nhật lại không phải load lần đầu
                loadSongFist = false;
            }
            // show playlist
            showPlaylist();
        }

        // show form import
        private void button_importMusic_Click(object sender, EventArgs e)
        {
            Form import = new import();
            openChildForm(import);
        }

        // show form discover_playlist
        private void button_playlistSongs_Click(object sender, EventArgs e)
        {
            Form _discover_playlist = new discover_playlist();
            discover_playlist.PassSong += Discover_playlist_PassSong;
            openChildForm(_discover_playlist);
        }

        // pass song từ discover_playlist to main
        private void Discover_playlist_PassSong(object sender, passSongToPlayBarEventArgs e)
        {
            // kiểm tra nút play hay nút add 
            if (loadSongFist == false && e.checkAdd == true)
            {
                // tạo playlist mới
                List<song> playlist = new List<song>();

                // tìm list album thông qua tên album
                playlist = DAO.playlistDAO.Instance.getsongwithnameplaylist(e.slectedSong.Name_playlist);

                // add album vào nowplaylist
                nowPlayingPlaylist.AddRange(playlist);

                // kiểm tra có đang shuffle
                if (shuffled)
                {
                    backUpNowPlayingPlaylist.AddRange(playlist);
                }
            }
            else
            {
                // tạo mới nowplaylist
                nowPlayingPlaylist = new List<song>();

                // lấy list qua tên playlist
                nowPlayingPlaylist = DAO.playlistDAO.Instance.getsongwithnameplaylist(e.slectedSong.Name_playlist);

                // thay đổi dữ liệu của playbar 
                changeDataSongPlaying(nowPlayingPlaylist[0]);

                // update lại vị trí 
                indexSongNowPlaying = 0;

                // chơi nhạc
                playMusic(nowPlayingPlaylist[0]);

                // add bài nhạc vào playlist hiện tại
                //nowPlayingPlaylist.Add(nowPlayingPlaylist[0]);

                // cập nhật lại không phải load lần đầu
                loadSongFist = false;
            }
            // show playlist
            showPlaylist();
        }

        // hàm show form discover_album
        private void button_album_Click(object sender, EventArgs e)
        {
            Form _discover_album = new discover_album();
            discover_album.PassSong += Discover_album_PassSong;
            openChildForm(_discover_album);
        }

        // hàm pass song từ discover_album về main
        private void Discover_album_PassSong(object sender, passSongToPlayBarEventArgs e)
        {
            // kiểm tra nút add hay nút play
            if (loadSongFist == false && e.checkAdd == true)
            {
                // tạo playlist mới
                List<song> addAlbum = new List<song>();

                // tìm list album thông qua tên album
                addAlbum = DAO.albumDAO.Instance.getsongwithnamealbum(e.slectedSong.Name_album);

                // add album vào nowplaylist
                nowPlayingPlaylist.AddRange(addAlbum);

                // kiểm tra có đang shuffle
                if (shuffled)
                {
                    backUpNowPlayingPlaylist.AddRange(addAlbum);
                }
            }
            else
            {
                // tạo playlist mới
                nowPlayingPlaylist = new List<song>();

                // lấy list bài nhặc trong album
                nowPlayingPlaylist = DAO.albumDAO.Instance.getsongwithnamealbum(e.slectedSong.Name_album);

                // đổi dữ liệu thành bài đầu trong playlist
                changeDataSongPlaying(nowPlayingPlaylist[0]);

                // chơi nhạc 
                playMusic(nowPlayingPlaylist[0]);

                // show playlist ra listbox
                showPlaylist();

                // bỏ load lần đầu
                loadSongFist = false;
            }

            // show playlist
            showPlaylist();
        }

        // hàm show form discover
        private void button_singer_Click(object sender, EventArgs e)
        {
            Form _discover_singer = new discover_singer();
            discover_singer.PassSong += Discover_singer_PassSong;
            openChildForm(_discover_singer);
        }

        // pass song từ discover_singer to main
        private void Discover_singer_PassSong(object sender, passSongToPlayBarEventArgs e)
        {
            // kiểm tra nút add hay nút play
            if (loadSongFist == false && e.checkAdd == true)
            {
                // tạo playlist mới
                List<song> addSongOfSinger = new List<song>();

                // tìm list album thông qua tên album
                addSongOfSinger = DAO.singerDAO.Instance.getsongbynamesinger(e.slectedSong.Singer);

                // add album vào nowplaylist
                nowPlayingPlaylist.AddRange(addSongOfSinger);

                // kiểm tra có đang shuffle
                if (shuffled)
                {
                    backUpNowPlayingPlaylist.AddRange(addSongOfSinger);
                }
            }
            else
            {
                // tạo playlist mới
                nowPlayingPlaylist = new List<song>();

                // lấy list bài nhặc trong album
                nowPlayingPlaylist = DAO.singerDAO.Instance.getsongbynamesinger(e.slectedSong.Singer);

                // đổi dữ liệu thành bài đầu trong playlist
                changeDataSongPlaying(nowPlayingPlaylist[0]);

                // chơi nhạc 
                playMusic(nowPlayingPlaylist[0]);

                // show playlist ra listbox
                showPlaylist();

                // bỏ load lần đầu
                loadSongFist = false;
            }

            // show playlist
            showPlaylist();
        }

        // hàm show form homePage
        private void button_home_Click(object sender, EventArgs e)
        {
            Form homePage = new homePage();
            openChildForm(homePage);
        }

        // hàm show form tìm kiếm
        private void button_search_Click(object sender, EventArgs e)
        {
            Form search = new Search();
            Search.PassSong += Search_PassSong;
            openChildForm(search);
        }

        // hàm pass song từ search về playbar
        private void Search_PassSong(object sender, static_class.passSongToPlayBarEventArgs e)
        {
            // kiểm tra xem search có phải album
            if (loadSongFist == false && e.checkAdd == true)
            {
                // kiểm tra có phải đang add album
                if (e.checkAlbum)
                {
                    // tạo playlist mới
                    List<song> albumPlaylsist = new List<song>();

                    // tìm list album thông qua tên album
                    albumPlaylsist = DAO.albumDAO.Instance.getsongwithnamealbum(e.slectedSong.Name_album);

                    // add album vào nowplaylist
                    nowPlayingPlaylist.AddRange(albumPlaylsist);

                    // kiểm tra có đang shuffle
                    if (shuffled)
                    {
                        backUpNowPlayingPlaylist.AddRange(albumPlaylsist);
                    }
                }
                else
                {
                    // add song to playlist
                    nowPlayingPlaylist.Add(e.slectedSong);

                    // thêm nhạc vào playlist backup nên đang ở chế độ shuffle
                    if (shuffled)
                    {
                        backUpNowPlayingPlaylist.Add(e.slectedSong);
                    }
                }
            }
            else if (e.checkAlbum == true)
            {
                // tạo playlist mới
                nowPlayingPlaylist = new List<song>();
                
                // tìm list album thông qua tên album
                nowPlayingPlaylist = DAO.albumDAO.Instance.getsongwithnamealbum(e.slectedSong.Name_album);

                // đổi dữ liệu song ở playbar là bài 1 trong playlist
                changeDataSongPlaying(nowPlayingPlaylist[0]);

                // set giá trị nhạc đang phát là bài 1 trong list
                indexSongNowPlaying = 0;

                // phát nhạc và đổi icon play/pause
                playMusic(nowPlayingPlaylist[0]);

                // bỏ load lần đầu
                loadSongFist = false;

            }
            else
            {
                // tạo playlist mới khi bấm vào nút play
                nowPlayingPlaylist = new List<song>();

                // đổi dữ liệu song ở playbar
                changeDataSongPlaying(e.slectedSong);

                // set giá trị nhạc đang phát là bài 1 trong list
                indexSongNowPlaying = 0;

                // phát nhạc và đổi icon
                playMusic(e.slectedSong);

                // add bài nhạc vào playlist đang phát
                nowPlayingPlaylist.Add(e.slectedSong);

                // cập nhật lại không phải load lần đầu
                loadSongFist = false;
            }
            // show playlist 
            showPlaylist();
        }

        private void label_login_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        // hàm đăng nhập
        //private Form activeFormLogin = null;
        private void button_login_Click(object sender, EventArgs e)
        {
            //if (activeFormLogin == null)
            //{
            //    Form loginForm = new Login();
            //    activeFormLogin = loginForm;
            //    loginForm.Show();
            //}
            //else
            //{
            //    activeFormLogin.Close();
            //    activeFormLogin = null;
            //}

        }

        // hàm đăng ký
        //private Form activeFormSignUp = null;
        private void button_signUp_Click(object sender, EventArgs e)
        {
            //if (activeFormSignUp == null)
            //{
            //    Form signUpForm = new SignUp();
            //    activeFormLogin = signUpForm;
            //    signUpForm.Show();
            //}
            //else
            //{
            //    activeFormSignUp.Close();
            //    activeFormSignUp = null;
            //}
        }

        // show các nút trong karaoke
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

        // hàm show form karaoke
        private void button_recording_Click(object sender, EventArgs e)
        {
            // dừng nhạc đang phát
            axWindowsMediaPlayer.Ctlcontrols.pause();
            button_play.BackgroundImage = Resources.music_play;

            Form karaoke = new Karaoke();
            openChildForm(karaoke,true);
        }

        // hàm show form recorded
        private void button_recorded_Click(object sender, EventArgs e)
        {
            //Form recorded = new Recorded();
            //openChildForm(recorded);
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

        }

        private void pictureBox_pictureSong_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_buttonPlayer_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
        }

        private void trackBar2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
        }

        private void button_setTime_Click(object sender, EventArgs e)
        {
            
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        // hàm show form karaoke
        private void button_playKaraoke_Click(object sender, EventArgs e)
        {
            // dừng nhạc đang phát
            axWindowsMediaPlayer.Ctlcontrols.pause();
            button_play.BackgroundImage = Resources.music_play;

            // cho form karaoke biết là đang load từ playbar
            loadKaraokeFormButton = true;

            Form karaoke = new Karaoke();
            openChildForm(karaoke, true);
        }

        // show/hide volume trackbar
        private void button_volume_Click(object sender, EventArgs e)
        {
            if (trackBar_volume.Visible == false)
                trackBar_volume.Visible = true;
            else
                trackBar_volume.Visible = false;
        }

        // hide trackbar voulume
        private void trackBar_volume_MouseLeave(object sender, EventArgs e)
        {
            trackBar_volume.Visible = false;
        }

        // change visiable moretoolbutton
        private void button_moreTools_Click(object sender, EventArgs e)
        {
            if (panel_moreToolButton.Visible == false)
                panel_moreToolButton.Visible = true;
            else
                panel_moreToolButton.Visible = false;
        }

        // change image button play
        private void button_play_Click(object sender, EventArgs e)
        {
            if (loadSongFist)
            {
                showPlaylist();
                axWindowsMediaPlayer.URL = nowPlayingPlaylist[0].Song_path;
                axWindowsMediaPlayer.Ctlcontrols.play();
                button_play.BackgroundImage = Resources.Picture1;
                loadSongFist = false;
            }
            else
            {
                if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer.Ctlcontrols.pause();
                    Image playPicture = Resources.music_play;
                    button_play.BackgroundImage = playPicture;
                }
                else if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    axWindowsMediaPlayer.Ctlcontrols.play();
                    Image pausePicture = Resources.Picture1;
                    button_play.BackgroundImage = pausePicture;
                }
                else
                {
                    playMusic(nowPlayingPlaylist[indexSongNowPlaying]);
                }
            }
            
        }

        // setting trackbar voulume 
        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.settings.volume = trackBar_volume.Value;
        }

        // button next
        private void button_next_Click(object sender, EventArgs e)
        {
            if (indexSongNowPlaying < nowPlayingPlaylist.Count - 1)
            {
                indexSongNowPlaying++;
                changeDataSongPlaying(nowPlayingPlaylist[indexSongNowPlaying]);
                playMusic(nowPlayingPlaylist[indexSongNowPlaying]);
                listBox_playlist.SetSelected(indexSongNowPlaying, true);
            }
        }

        // button previous
        private void button_previous_Click(object sender, EventArgs e)
        {
            if (indexSongNowPlaying >= 1)
            {
                indexSongNowPlaying--;
                changeDataSongPlaying(nowPlayingPlaylist[indexSongNowPlaying]);
                playMusic(nowPlayingPlaylist[indexSongNowPlaying]);
                //int(listBox_playlist.SelectedIndexChanged -= 1;
                listBox_playlist.SetSelected(indexSongNowPlaying, true);
            }
        }

        // button shufffled
        private bool shuffled = false;
        private void button_mix_Click(object sender, EventArgs e)
        {
            if (nowPlayingPlaylist != null)
            {
                if (nowPlayingPlaylist.Count > 1 )
                {
                    if (shuffled == false)
                    {
                        // tạo playlist backup
                        backUpNowPlayingPlaylist = new List<song>();

                        // tạo playlist shuffed
                        var shuffledPlaying = nowPlayingPlaylist.OrderBy(x => Guid.NewGuid()).ToList();

                        // tìm vị trí của bài mới
                        int newIndex = shuffledPlaying.FindIndex(a => a.Song_path == nowPlayingPlaylist[indexSongNowPlaying].Song_path);
                        indexSongNowPlaying = newIndex;

                        // backup playlist
                        backUpNowPlayingPlaylist = nowPlayingPlaylist;

                        // gán playlist hiện tại bằng playlist shuffled
                        nowPlayingPlaylist = shuffledPlaying;

                        // đổi hình shuffled
                        button_mix.BackgroundImage = Resources.mixed;
                        shuffled = true;
                    }
                    else
                    {
                        // tìm vị trí
                        int newIndex = backUpNowPlayingPlaylist.FindIndex(a => a.Song_path == nowPlayingPlaylist[indexSongNowPlaying].Song_path);
                        indexSongNowPlaying = newIndex;

                        // tạo now playlist
                        nowPlayingPlaylist = new List<song>();

                        // gán now playlist bằng playlist đã backup
                        nowPlayingPlaylist = backUpNowPlayingPlaylist;

                        // thay đổi ảnh
                        button_mix.BackgroundImage = Resources.mix;
                        shuffled = false;
                    }
                    showPlaylist();
                }
            }
        }

        // buttom repeat
        // 0 : không repeat, 1 : repeat 1 bài , 2 : repeat tất cả
        private int stateRepeat = 0;
        private void button_repeat_Click(object sender, EventArgs e)
        {
            if (stateRepeat == 2)
            {
                stateRepeat = -1;
            }

            stateRepeat++;
            if (stateRepeat == 0)
            {
                button_repeat.BackgroundImage = Resources.repeat;
            }
            else if (stateRepeat == 1)
            {
                button_repeat.BackgroundImage = Resources.repeat1;
            }
            else
            {
                button_repeat.BackgroundImage = Resources.repeatAll;
            }
        }

        private void axWindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        // wmp changed 
        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer.playState == WMPPlayState.wmppsMediaEnded)
            {
                if (stateRepeat == 0)
                {
                    if (indexSongNowPlaying < nowPlayingPlaylist.Count - 1)
                    {
                        indexSongNowPlaying++;
                        changeDataSongPlaying(nowPlayingPlaylist[indexSongNowPlaying]);
                        BeginInvoke(new Action(() =>
                        {
                            playMusic(nowPlayingPlaylist[indexSongNowPlaying]);
                        }));
                    }
                    else
                    {
                        button_play.BackgroundImage = Resources.music_play;
                        indexSongNowPlaying = 0;
                    }
                }
                else if(stateRepeat == 1)
                {
                    changeDataSongPlaying(nowPlayingPlaylist[indexSongNowPlaying]);
                    BeginInvoke(new Action(() =>
                    {
                        playMusic(nowPlayingPlaylist[indexSongNowPlaying]);
                    }));
                }
                else
                {
                    if(indexSongNowPlaying == nowPlayingPlaylist.Count - 1)
                    {
                        indexSongNowPlaying = 0;
                        changeDataSongPlaying(nowPlayingPlaylist[indexSongNowPlaying]);
                        BeginInvoke(new Action(() =>
                        {
                            playMusic(nowPlayingPlaylist[indexSongNowPlaying]);
                        }));
                    }
                }
            }
        }
        

        private void listBox_playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox_playlist_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        // hàm show form setTime
        private void button_setTime_Click_1(object sender, EventArgs e)
        {
            Form settime = new setTime();
            setTime.PassTime += SetTime_PassTime;
            settime.Show();
        }

        // update countTime
        int countTime = 0;
        int timeStop = 0;
        private void updateLabelCountTime()
        {
            int secondLeft = timeStop - countTime;

            if (secondLeft == 0)
            {
                timeStop = 0;
                countTime = 0;
                label_countDown.Text = "00:00:00";
                panel_countDownTime.Visible = false;
            }
            else
            {
                TimeSpan time = TimeSpan.FromSeconds(secondLeft);

                string str = time.ToString(@"hh\:mm\:ss");

                label_countDown.Text = str;
            }
        }

        // pass setTime to main
        private void SetTime_PassTime(object sender, static_class.passTimeToMainEvenArgs e)
        {
            mode = e.mode;
            if (e.resetTime)
            {
                timeStop = 0;
                countTime = 0;
                updateLabelCountTime();
                timer_pasuePlaying.Stop();
            }
            else
            {
                timer_pasuePlaying.Start();
                timeStop = e.time;
                updateLabelCountTime();
                panel_countDownTime.Visible = true;
            }
        }

        private string mode;
        // time change 
        private void timer_pasuePlaying_Tick(object sender, EventArgs e)
        {
            countTime++;
            updateLabelCountTime();
            if (countTime == timeStop)
            {
                if (mode == "stopMusic")
                {
                    if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        axWindowsMediaPlayer.Ctlcontrols.pause();
                        Image playPicture = Resources.music_play;
                        button_play.BackgroundImage = playPicture;
                    }
                    timer_pasuePlaying.Stop();
                }
                else
                {
                    Application.Exit();
                }

            }
        }

        private void panel_Main_Paint_1(object sender, PaintEventArgs e)
        {

        }

        // đi đến bài hát
        private void button_moveToSong_Click(object sender, EventArgs e)
        {
            Form OneSong = new Song();
            openChildForm(OneSong);
        }
        
        // đi đến bài hát 
        private void label_nameSong_Click(object sender, EventArgs e)
        {
            Console.WriteLine(nowPlayingPlaylist[0].Lyric_path);
  
            Form OneSong = new Song();
            openChildForm(OneSong);

            
        }

        // doubel click vào listbox
        private void listBox_playlist_DoubleClick(object sender, EventArgs e)
        {
            song selectedSong = listBox_playlist.SelectedItem as song;
            if (selectedSong != null)
            {
                // tìm vị trí của bài mới
                int newIndex = nowPlayingPlaylist.FindIndex(a => a.Song_path == selectedSong.Song_path);
                indexSongNowPlaying = newIndex;

                changeDataSongPlaying(selectedSong);

                playMusic(selectedSong);

            }
        }

        private void listBox_playlist_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        // xóa tất cả bài hát
        private void button_playlist_Click(object sender, EventArgs e)
        {
            if (nowPlayingPlaylist != null)
            {
                axWindowsMediaPlayer.Ctlcontrols.stop();
                Image playPicture = Resources.music_play;
                button_play.BackgroundImage = playPicture;

                nowPlayingPlaylist = null;
                showPlaylist();
                nowPlayingPlaylist = new List<song>();
                nowPlayingPlaylist = songDAO.Instance.getsongbyname(label_nameSong.Text);
                indexSongNowPlaying = 0;
                loadSongFist = true;
            }
            button_trash.Visible = false;
            //nowPlayingPlaylist = new List<song>();
        }

        private void panel_moreToolButton_MouseLeave(object sender, EventArgs e)
        {
        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        // add to my playlist 
        private void button_addPlaylist_Click(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\nghegihomnay.mdf;Integrated Security=True";
            if (nowPlayingPlaylist.Count != 0)
            {
                string namePlaylist = "";
                if (InputBox("Chọn playlist", "Tên playlist:", ref namePlaylist) == DialogResult.OK)
                {
                    Name = namePlaylist;
                }
                List<playlist> lstpllcheck = new List<playlist>();
                lstpllcheck = DAO.playlistDAO.Instance.getplaylist();
                bool check=false;
                foreach (var pll in lstpllcheck)
                {
                    if (pll.Name.ToLower() == Name.ToLower())
                        check = true;
                }
                if(check==false)
                {
                    string query = "insert into dbo.playlist (name, image_path) values (N'" + Name + @"',N'pll_and_al_image\playlist.png');";
                    
                    //DataTable data = new DataTable();

                    using (SqlConnection connection = new SqlConnection(connectionSTR))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        //Console.WriteLine("success");
                        connection.Close();
                    }


                }
                //string query = "insert into dbo.playlist (name, image_path) values (N'" + Name + @"',N'pll_and_al_image\playlist.png');";
                //string connectionSTR = @"Data Source=DESKTOP-SVOS4R1\SQLEXPRESSSSS;Initial Catalog=nghegihomnay;Integrated Security=True";
                //DataTable data = new DataTable();
                /*
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    //Console.WriteLine("success");
                    connection.Close();
                }
                */
                foreach (var s in nowPlayingPlaylist)
                {
                    string querysong = "insert into dbo.song (song_path, lyric_path, image_path, name, singer ,	name_album, id_album, name_playlist) values (N'" +
                        s.Song_path + "',N'" + s.Lyric_path + "',N'" + s.Image_path + "',N'" + s.Name + "',N'" + s.Singer + "',N'N', 5, N'" + Name + "');";
                    using (SqlConnection connection = new SqlConnection(connectionSTR))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(querysong, connection);
                        command.ExecuteNonQuery();
                        //Console.WriteLine("success");
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bài hát nào để thêm!!!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void listBox_playlist_DataSourceChanged(object sender, EventArgs e)
        {
            if (listBox_playlist.DataSource != null)
            {
                button_trash.Visible = true;
            }
        }

        private void button_trash_Click(object sender, EventArgs e)
        {
            if (nowPlayingPlaylist.Count == 1)
            {
                axWindowsMediaPlayer.Ctlcontrols.stop();
                Image playPicture = Resources.music_play;
                button_play.BackgroundImage = playPicture;

                nowPlayingPlaylist = null;
                showPlaylist();
                nowPlayingPlaylist = new List<song>();
                nowPlayingPlaylist = songDAO.Instance.getsongbyname(label_nameSong.Text);
                indexSongNowPlaying = 0;
                loadSongFist = true;
                button_trash.Visible = false;
            }
            else
            {
                song selectedSong = listBox_playlist.SelectedItem as song;
                int newIndex = nowPlayingPlaylist.FindIndex(a => a.Song_path == selectedSong.Song_path);

                if (newIndex == indexSongNowPlaying)
                {
                    axWindowsMediaPlayer.Ctlcontrols.stop();
                    Image playPicture = Resources.music_play;
                    button_play.BackgroundImage = playPicture;

                    if (nowPlayingPlaylist.Count-1 == newIndex)
                    {
                        indexSongNowPlaying = 0;
                    }
                }
                nowPlayingPlaylist.RemoveAt(newIndex);
                showPlaylist();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thông báo", "Bạn thực sự muốn cập nhật", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string _p = nowPlayingPlaylist[0].Name_playlist;
                string query1 = "delete from song where name_playlist=N'" + _p + "'";
                string connectionSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\nghegihomnay.mdf;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query1, connection);
                    command.ExecuteNonQuery();
                    //Console.WriteLine("success");
                    connection.Close();
                }
                if (nowPlayingPlaylist.Count > 0)
                {
                    foreach (var item in nowPlayingPlaylist)
                    {
                        string tmpquery = "insert into dbo.song (song_path, lyric_path, image_path, name, singer ,	name_album, id_album, name_playlist, id_playlist, song_type, song_type_id) values (N'" +
                                        item.Song_path + "',N'" + item.Lyric_path + "',N'" + item.Image_path + "',N'" + item.Name + "',N'" + item.Singer + "',N'" + item.Name_album + "'," +
                                        item.ID_album + ",N'" + item.Name_playlist + "'," + item.ID_playlist + ",N'" + item.Song_type + "'," + item.Song_type_ID + ");";
                        using (SqlConnection connection = new SqlConnection(connectionSTR))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(tmpquery, connection);
                            command.ExecuteNonQuery();
                            //Console.WriteLine("success");
                            connection.Close();
                        }
                    }
                }
            }
            
        }
    }
}
