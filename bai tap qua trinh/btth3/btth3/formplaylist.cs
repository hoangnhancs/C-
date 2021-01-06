using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btth3.DTO;
using btth3.DAO;

namespace btth3
{
    public partial class formplaylist : Form
    {
        int delete_song_id = -1;
        //int add_cat;
        int add_pll;
        Form1 f = new Form1();
        //int _getid;
        //private Form1 _form1;
        public formplaylist()
        {
            InitializeComponent();
            loadplaylist();
            loadplaylist2();
            //loadcategorybox();
            //_form1 = ParentForm;
        }

        private void formplaylist_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            int delete_song_id_index = dataGridViewSong.CurrentRow.Index;
            delete_song_id = (int)dataGridViewSong.Rows[delete_song_id_index].Cells["id"].Value;
            string selected_song = dataGridViewSong.Rows[delete_song_id_index].Cells["name"].Value.ToString();
            //Console.WriteLine(delete_song_id);
            textBox_deletesong.Text = delete_song_id.ToString() + "." + selected_song;
        }
        void loadplaylist()
        {
            List<playlist> lstplaylist = playlistDAO.Instance.getplaylist();
            comboBoxPlaylist.DataSource = lstplaylist;
            comboBoxPlaylist.DisplayMember = "Name";
        }
        void loadplaylist2()
        {
            List<playlist> lstplaylist = playlistDAO.Instance.getplaylist();
            comboBox1.DataSource = lstplaylist;
            comboBox1.DisplayMember = "Name";
        }
        /*
        void loadcategorybox()
        {
            List<song_category> lstctgr = categoryDAO.Instance.getsongctgr();
            comboBox2.DataSource = lstctgr;
            comboBox2.DisplayMember = "Name";
            
        }
        */
        /*
        void loadsongbyidplaylist(int id)
        {
            List<song> lstsong = songDAO.Instance.getsongbyplaylistid(id);

        }
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*
            DataTable dt = new DataTable();
            playlist pll = comboBoxPlaylist.SelectedItem as playlist;
            dt = playlistDAO.Instance.getplaylistbyid(pll.ID);
            dataGridViewSong.DataSource = dt;
            */
            load_datagridview_song();
           
        }

        public void load_datagridview_song()
        {
            DataTable dt = new DataTable();
            playlist pll = comboBoxPlaylist.SelectedItem as playlist;
            dt = playlistDAO.Instance.getplaylistbyid(pll.ID);
            dataGridViewSong.DataSource = dt;
            if (dataGridViewSong.Rows.Count>=2)
            {
                delete_song_id = (int)dataGridViewSong.Rows[0].Cells["id"].Value;
                textBox_deletesong.Text = dataGridViewSong.Rows[0].Cells["id"].Value.ToString()
                         +"."+ dataGridViewSong.Rows[0].Cells["name"].Value.ToString();
            }
  

        }
        public void load_datagridview_song2()
        {
            DataTable dt = new DataTable();
            playlist pll = comboBox1.SelectedItem as playlist;
            dt = playlistDAO.Instance.getplaylistbyid(pll.ID);
            dataGridViewSong.DataSource = dt;
            if (dataGridViewSong.Rows.Count > 2)
            {
                delete_song_id = (int)dataGridViewSong.Rows[0].Cells["id"].Value;
                textBox_deletesong.Text = dataGridViewSong.Rows[0].Cells["id"].Value.ToString()
                                            + dataGridViewSong.Rows[0].Cells["name"].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            f.DtGridView = dataGridViewSong;
            f.DtGridView.DataSource = dataGridViewSong.DataSource;

            this.Close();

            
        }
        //private DataGridView dgv;
        
        public DataGridView Dgv 
        { get { return dataGridViewSong; }
          set {dataGridViewSong = value; } 
        }

        //public DataGridView 

        void getdatatable()
        {
           
            DataTable dt = new DataTable();

        }

        private void button_addplaylist_Click(object sender, EventArgs e)
        {
            if (textBox_addsong.Text != "")
            {
                int check=1;
                List<playlist> lstplaylist = playlistDAO.Instance.getplaylist();
                //comboBoxPlaylist.DataSource = lstplaylist;

                foreach (playlist item in lstplaylist)
                {
                    if (item.Name == textBox_addsong.Text)
                    {
                        string message = "This playlist has exist!!!";
                        string title = "Error";
                        MessageBox.Show(message, title);
                        check = 0;
                    }
                }
                if (check == 1)
                {

                    string query = @"insert into dbo.playlist (name) values (N'" + textBox_addsong.Text + @"')";
                    //Console.WriteLine(query);
                    string connectionSTR = @"Data Source=DESKTOP-SVOS4R1\SQLEXPRESSSSS;Initial Catalog=my_songss;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionSTR);
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    string message = "Complete!!!";
                    string title = "Note";
                    MessageBox.Show(message, title);
                    check = 1;
                }
            }
            loadplaylist();
            loadplaylist2();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = @"C:\Downloads";
            openFileDialog1.Title = "Browse Mp3 Files";
            openFileDialog1.DefaultExt = "mp3";
            openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            textBox_path.Text = openFileDialog1.FileName;
        }

        private void button_addsong_Click(object sender, EventArgs e)
        {
            
            /*
            List<song_category> lstctgr = categoryDAO.Instance.getsongctgr();
            foreach (song_category item in lstctgr)
            {
                //Console.WriteLine(item.Name, item.ID);
                //Console.WriteLine(comboBox2.SelectedItem);
                //song_category a = comboBox2.SelectedItem as song_category;
                //Console.WriteLine(a.Name.ToString());
                if (item.Name == a.Name.ToString())
                {
                    add_cat = item.ID;
                    //Console.WriteLine(add_cat);
                }
            }
            */

            List<playlist> lstplaylist = playlistDAO.Instance.getplaylist();
            foreach (playlist item in lstplaylist)
            {
                //Console.WriteLine(item.Name);
                playlist a = comboBox1.SelectedItem as playlist;
                //Console.WriteLine(a.Name.ToString());
                
                if (item.Name == a.Name.ToString())
                {
                    add_pll = item.ID;

                }
                
            }

            string query = @"insert into dbo.song (name, song_path, id_playlist) values (N'"
                            + textBox_songname.Text + @"',N'" + textBox_path.Text + @"'," +
                            add_pll.ToString() + @")";
            Console.WriteLine(query);
            Console.WriteLine(textBox_path.Text);
            
            string connectionSTR = @"Data Source=DESKTOP-SVOS4R1\SQLEXPRESSSSS;Initial Catalog=my_songss;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            
            load_datagridview_song2();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_deletesong_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_deletesong_Click(object sender, EventArgs e)
        {
            if (delete_song_id != -1)
            {
                string message = "Do you want delete this song?";
                string title = "Note";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    string query = "delete from dbo.song where id=" + delete_song_id;
                    string connectionSTR = @"Data Source=DESKTOP-SVOS4R1\SQLEXPRESSSSS;Initial Catalog=my_songss;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionSTR);
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                load_datagridview_song();

            }
            if (dataGridViewSong.Rows.Count >= 2)
            {
                delete_song_id = (int)dataGridViewSong.Rows[0].Cells["id"].Value;
                textBox_deletesong.Text = dataGridViewSong.Rows[0].Cells["id"].Value.ToString() +"."+ dataGridViewSong.Rows[0].Cells["Name"].Value.ToString();

            }
            else
            {
                textBox_deletesong.Text = "";
                delete_song_id = -1;

            }
        }
    }
}
