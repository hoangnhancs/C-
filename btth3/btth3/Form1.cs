using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btth3
{
    
    public partial class Form1 : Form
    {
        int change = 0;
        int playing_id;
        int playing_row;
        int next_id;
        string playing_path;
        //int idd;
        //int selected_row;
        DataGridView dtg = new DataGridView();
        //formplaylist fpll = new formplaylist();
        //private formplaylist _formplaylist;
        public Form1()
        {

            InitializeComponent();
            //dtg.Columns.Add("id" );
        }

        private void myPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formplaylist _from_playlist = new formplaylist();
            dataGridView1 = _from_playlist.Dgv;
            dtg = _from_playlist.Dgv;
            //dataGridView_main.DataSource = _from_playlist.Dgv.DataSource;
            _from_playlist.ShowDialog();
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //selected_row = dataGridView_main.SelectedRows[0].Index;
            //playing_row = (int)dataGridView_main.Rows[e.RowIndex].Cells["id"].Value;
            playing_row = (int)dataGridView_main.CurrentRow.Index;
            playing_id = (int)dataGridView_main.Rows[playing_row].Cells["id"].Value;
            //Console.WriteLine(playing_row);
            textBox_selected.Text = playing_id.ToString() + "." + dataGridView_main.Rows[playing_row].Cells["name"].Value.ToString();
            change = 1;

        }
        public void load_dtg()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }


        //private DataGridView _dttable;
        public DataGridView DtGridView
        {
            get;
            set;
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView_main.DataSource = dataGridView1.DataSource;
    
            if (change == 0)
            {
                if (dataGridView_main.Rows.Count > 1)
                {
                    playing_path = dataGridView_main.Rows[0].Cells["song_path"].Value.ToString();
                    playing_id = (int)dataGridView_main.Rows[0].Cells["id"].Value;
                    playing_row = 0;
                    if (dataGridView_main.Rows.Count > 2)
                    {
                        next_id = (int)dataGridView_main.Rows[1].Cells["id"].Value;
                        textBox_nextplay.Text = (next_id).ToString() + "." + dataGridView_main.Rows[playing_row + 1].Cells["name"].Value.ToString();
                    }
                    else
                    {
                        textBox_nextplay.Text = "";
                    }
                    //idd = (int)dataGridView_main.Rows[0].Cells["id"].Value;
                    textBox_selected.Text = playing_id.ToString() + "." + dataGridView_main.Rows[playing_row].Cells["name"].Value.ToString();
                    
                    textBox_playing.Text = playing_id.ToString() + "." + dataGridView_main.Rows[playing_row].Cells["name"].Value.ToString();
                    //change = 1;
                }
                else
                {
                    string message = "This playlist doesn't have any song!!!";
                    string title = "Error";
                    MessageBox.Show(message, title);
                    
                }
            }
            if (change == 1)
            {
                textBox_playing.Text = textBox_selected.Text;
                if (playing_row >= dataGridView_main.Rows.Count-2)
                {
                    textBox_nextplay.Text = "";
                    playing_id = (int)dataGridView_main.Rows[playing_row].Cells["id"].Value;
                    playing_path = dataGridView_main.Rows[playing_row].Cells["song_path"].Value.ToString();
                }
                else
                {
                    next_id = (int)dataGridView_main.Rows[playing_row+1].Cells["id"].Value;
                    textBox_nextplay.Text = (next_id).ToString() + "." + dataGridView_main.Rows[playing_row + 1].Cells["name"].Value.ToString();
                    playing_id = (int)dataGridView_main.Rows[playing_row].Cells["id"].Value;
                    playing_path = dataGridView_main.Rows[playing_row].Cells["song_path"].Value.ToString();
                }
                //for i i
            }
            axWindowsMediaPlayer1.URL = playing_path;

        }

        public void load()
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button_playnext_Click(object sender, EventArgs e)
        {
            
            
            
            //playing_row = playing_row + 1;
            if (playing_row+1 >= dataGridView_main.Rows.Count - 1)
            {
                playing_row = playing_row + 1;
                textBox_nextplay.Text = "";
                //playing_id = (int)dataGridView_main.Rows[playing_row-1].Cells["id"].Value;
                
            }
            else
            {
                textBox_playing.Text = textBox_nextplay.Text;
                playing_row = playing_row + 1;
                
                if (playing_row <= dataGridView_main.Rows.Count - 3)
                {
                    next_id = (int)dataGridView_main.Rows[playing_row + 1].Cells["id"].Value;
                    textBox_nextplay.Text = (next_id).ToString() + "." + dataGridView_main.Rows[playing_row + 1].Cells["name"].Value.ToString();
                }
                else
                {
                    textBox_nextplay.Text = "";
                }
                playing_id = (int)dataGridView_main.Rows[playing_row].Cells["id"].Value;
                playing_path = dataGridView_main.Rows[playing_row].Cells["song_path"].Value.ToString();
                axWindowsMediaPlayer1.URL = playing_path;
            }
        }

        private void textBox_playing_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = playing_path;
        }
    }
}
