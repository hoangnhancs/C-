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
    public partial class discover_playlist : Form
    {
        public discover_playlist()
        {
            InitializeComponent();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void discover_playlist_Load(object sender, EventArgs e)
        {
            // ẩn vùng bao của nút
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            button_newSongs.FlatAppearance.BorderSize = 0;
        }
    }
}
