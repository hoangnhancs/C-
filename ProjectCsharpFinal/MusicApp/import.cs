using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using YoutubeExtractor;
using System.IO;
using MusicApp.DAO;
using MusicApp.DTO;
using MediaToolkit;
using VideoLibrary;
using System.Data.SqlClient;

namespace MusicApp
{
    public partial class import : Form
    {
        public import()
        {
            InitializeComponent();
        }

        private void import_Load(object sender, EventArgs e)
        {
            button_addPC.FlatAppearance.BorderSize = 0;
        }

        private void label_importPC_Click(object sender, EventArgs e)
        {

        }

        private void button_download_Click(object sender, EventArgs e)
        {
            var source = @"download\";
            var youtube = YouTube.Default;
            if (richTextBox_urlDownload.Text != "")
            {
                try
                {

                    var vid = youtube.GetVideo(richTextBox_urlDownload.Text);
                    File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

                    var inputFile = new MediaToolkit.Model.MediaFile { Filename = source + vid.FullName };
                    var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{source + vid.FullName}.mp3" };

                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);

                        engine.Convert(inputFile, outputFile);
                    }

                    // add dtb
                    // dduongwf daanx $"{source + vid.FullName}.mp3"
                    string path = $"{source + vid.FullName}.mp3";
                    string[] pathSplit = path.Split('\\');
                    string title = pathSplit[pathSplit.Length - 1].Split('#')[0];
                    string singer = "youtube";
                    string query = "insert into dbo.song (song_path,lyric_path, image_path, name, singer, name_album, id_album ) values (N'" + path + @"',N'nonelyric.txt',N'pll_and_al_image\playlist.png', N'"
                    + title + "',N'" + singer + "', N'Other', 6);";
                    //Console.WriteLine(query);
                    string connectionSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\nghegihomnay.mdf;Integrated Security=True";
                    DataTable data = new DataTable();
                    using (SqlConnection connection = new SqlConnection(connectionSTR))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        //Console.WriteLine("success");
                        connection.Close();
                    }
                    MessageBox.Show("Hoàn tất!!!", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    //MessageBox.Show("Đường dẫn không tồn tại", "Lỗi", MessageBoxButtons.OK);
                }
            }

        }

        private void button_addPC_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";
            string sSelectedPath = "";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sSelectedPath = fbd.SelectedPath;
            }
            try
            {
                string[] paths = Directory.GetFiles(@sSelectedPath, "*.mp3");
                foreach (string path in paths)
                {
                    var taglib_File = TagLib.File.Create(@path);
                    string singer;
                    string title = taglib_File.Tag.Title;
                    if (title == null)
                    {
                        string[] pathSplit = path.Split('\\');
                        title = pathSplit[pathSplit.Length - 1].Split('#')[0];
                    }

                    try
                    {
                        singer = taglib_File.Tag.Performers[0];
                    }
                    catch
                    {
                        singer = "You tube";
                    }
                    //taglib_File.Tag.Artists = new[] { translateDict[author] };
                    //string singer2 = taglib_File.Tag.Artists[0];
                    //string album = taglib_File.Tag.Album;

                    string query = "insert into dbo.song (song_path, lyric_path, image_path, name, singer ,	name_album, id_album, name_playlist, id_playlist, song_type, song_type_id) values (N'" 
                            + path + @"','nonelyric.txt',N'pll_and_al_image\playlist.png', N'" + title + "',N'" + singer + "',N'Other', 6, N'NULL', 5, N'Nhạc trẻ', 2);";
                    //Console.WriteLine(query);
                    // thêm data vao dtb

                    //song newData = new song() { }
                    //DBMusic NewData = new DBMusic() { FileName = title, Path = path, Singer = singer, Album = album };
                    //foreach (DBMusic file in files)
                    //{
                    //    if (NewData != file)
                    //    {
                    //        files.Add(NewData);
                    //    }
                    //}
                    string connectionSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\nghegihomnay.mdf;Integrated Security=True";
                    DataTable data = new DataTable();
                    using (SqlConnection connection = new SqlConnection(connectionSTR))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show("Hoàn tất!!!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

            }
            
        }
    }
}
