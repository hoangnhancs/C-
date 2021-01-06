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
    }
}
