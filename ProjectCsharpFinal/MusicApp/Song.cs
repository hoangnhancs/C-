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
using System.IO;

namespace MusicApp
{
    public partial class Song : Form
    {
        public Song()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label_detail.Text == "Xem chi tiết")
            {
                panel_lyricSong.Visible = true;
                label_detail.Text = "Ẩn bớt";
            }
            else
            {
                panel_lyricSong.Visible = false;
                label_detail.Text = "Xem chi tiết";
            }
        }

        private void Song_Load(object sender, EventArgs e)
        {
            int index = MusicApp.indexSongNowPlaying;
            song songPlaying = MusicApp.nowPlayingPlaylist[index];
            pictureBox_song.Image = Image.FromFile(songPlaying.Image_path);
            label_nameSong.Text = songPlaying.Name;
            label_author.Text = songPlaying.Singer;
            
            if (songPlaying.Lyric_path != "NULL") {
                string lyric = File.ReadAllText(songPlaying.Lyric_path);
                textBox_lyric.Text = lyric;
            }
    
         
            //string lyric = File.ReadAllText(songPlaying.Lyric_path);

        }
    }
}
