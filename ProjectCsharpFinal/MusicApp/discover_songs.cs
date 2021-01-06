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
    public partial class discover_songs : Form
    {
        public discover_songs()
        {
            InitializeComponent();
        }

        private void discover_songs_Load(object sender, EventArgs e)
        {
            // ẩn vùng bao của nút
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
        }

        //private Form activeForm = null;
        //private void openChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panel_Main.Controls.Add(childForm);
        //    panel_Main.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

        private void panel_behindList1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_item_1_1_MouseHover(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = true;
        }

        private void panel_item_1_2_MouseLeave(object sender, EventArgs e)
        {
            panel_item_1_2.Visible = false;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
