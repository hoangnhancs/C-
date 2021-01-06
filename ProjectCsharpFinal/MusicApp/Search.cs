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


namespace MusicApp
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // tắt borded size button
            button_album.FlatAppearance.BorderSize = 0;
            button_all.FlatAppearance.BorderSize = 0;
            button_recorded.FlatAppearance.BorderSize = 0;
            button_song.FlatAppearance.BorderSize = 0;
        }

        private void button_searchVideo_Click(object sender, EventArgs e)
        {
            var labels = new List<Label> { label_item1, label_item2, label_item3, label_item4, label_item5, label_item6, label_item7, label_item8 };
            var pictureboxs = new List<PictureBox> { pictureBox_item1, pictureBox_item2, pictureBox_item3, pictureBox_item4, pictureBox_item5, pictureBox_item6, pictureBox_item7, pictureBox_item8 };
            var panels = new List<Panel> { panel_item1, panel_item2, panel_item3, panel_item4, panel_item5, panel_item6, panel_item7, panel_item8 };
            label_noHasItem.Visible = false;
            foreach(var pn in panels)
            {
                pn.Visible = false;
            }


            string query = textBox_titleSong.Text;
            List<song> lstsong = new List<song>();
            lstsong = songDAO.Instance.getsongbyquery(query);

            //panel_item1.Visible = true;
            //panel_item2.Visible = true;
            //pictureBox_item1.Image = Image.FromFile(lstsong[0].Image_path);
            //label_item1.Text = lstsong[0].Name;
            
            if (lstsong.Count == 0)
            {
                label_noHasItem.Visible = true;
            }
            for (int i=0; i<8; i++)
            {
                if (lstsong.Count -1 < i)
                {
                    break;
                }
                else
                {
                    labels[i].Text = lstsong[i].Name;
                    pictureboxs[i].Image = Image.FromFile(lstsong[i].Image_path);
                    panels[i].Visible = true;
                }


            }

            //string query_search = textBox_titleSong.Text;
        }
    }
}
