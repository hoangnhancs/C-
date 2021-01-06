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
    public partial class discover_singer : Form
    {
        public discover_singer()
        {
            InitializeComponent();
        }

        private void discover_singer_Load(object sender, EventArgs e)
        {
            // ẩn vùng bao của nút
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            button_newSongs.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
