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
        private void discover_songs_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel5.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            // ẩn vùng bao của nút
            button_AmericaSongs.FlatAppearance.BorderSize = 0;
            button_AsianSongs.FlatAppearance.BorderSize = 0;
            button_differentSongs.FlatAppearance.BorderSize = 0;
            button_VNSongs.FlatAppearance.BorderSize = 0;
            button_newSongs.FlatAppearance.BorderSize = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel_behindList1_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.Visible = false;
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.Visible = false;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel13.Visible = true;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel14.Visible = true;
        }

        private void panel_title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_MoiVsHot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
