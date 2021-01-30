using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace MusicApp
{
    public partial class Karaoke_record : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        public Karaoke_record()
        {
            InitializeComponent();
        }

        public string html;
        public int time = 0;
        public string urlVideo = Karaoke.choseUrl;
        private void Karaoke_record_Load(object sender, EventArgs e)
        {
            html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}?autoplay={1}' width='775' height='400' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, urlVideo.Split('=')[1], 0);
            button_stopRecord.Enabled = false;

        }

        private void button_playVideo_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = string.Format(html, urlVideo.Split('=')[1], 1);
        }

        private void button_stopRecord_Click(object sender, EventArgs e)
        {
            countTime.Stop();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"E:\hoangnhancs\C-\Recorded";
            saveFileDialog1.Filter = "MP3|*.mp3|WAV|*.wav";
            saveFileDialog1.Title = "Lưu file ghi âm";
            saveFileDialog1.ShowDialog();
            

            if (saveFileDialog1.FileName != "")
            {
                mciSendString("save recsound " + saveFileDialog1.FileName, "", 0, 0);
                mciSendString("close recsound", "", 0, 0);
                countTime.Enabled = false;
                time = 0;
                label_timeRecording.Text = "00:00 Giây";
                button_stopRecord.Enabled = false;
                Console.WriteLine(saveFileDialog1.FileName);
                string[] items = saveFileDialog1.FileName.Split('\\');
                string query = @"insert into dbo.song (name, song_path,name_album, id_album,lyric_path, image_path) values (N'"+items[items.Length-1].Split('.')[0]+"', N'"+saveFileDialog1.FileName+ "',N'Other',6,N'nonelyric.txt', N'pll_and_al_image\\playlist.png')";
                Console.WriteLine(query);
                string connectionSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\nghegihomnay.mdf;Integrated Security=True";
                
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine("success");
                    connection.Close();
                }
                
                
                
                //SqlConnection connection = new SqlConnection(connectionSTR);
                //connection.Open();
                //SqlCommand command = new SqlCommand(query, connection);
                //command.ExecuteNonQuery();

                //connection.Close();

            }
            else
            {
                countTime.Start();
            }
        }

        private void button_recording_Click(object sender, EventArgs e)
        {
            button_stopRecord.Enabled = true;
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
            countTime.Enabled = true;
        }

        private void countTime_Tick(object sender, EventArgs e)
        {
            time++;
            TimeSpan result = TimeSpan.FromSeconds(time);
            string fromTimeString = result.ToString("mm':'ss");
            label_timeRecording.Text = fromTimeString + " Giây";
        }
    }
}
