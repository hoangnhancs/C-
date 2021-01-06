using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouTubeSearch;
using System.Net;
using System.IO;
using MusicApp.static_class;

namespace MusicApp
{
    public partial class Karaoke : Form
    {
        public Karaoke()
        {
            InitializeComponent();
        }

        private void Karaoke_Load(object sender, EventArgs e)
        {
            panel_videosSearch.Visible = false;
            if(MusicApp.songNameKaraoke != "")
            {
                textBox_titleVideo.Text = MusicApp.songNameKaraoke;
                searchVideos(true);
                MusicApp.songNameKaraoke = "";
            }
        }

        // các biến toàn cục
        public static string choseUrl;
        List<video> list;

        // thêm form vào panel main
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_mainKaraoke.Controls.Add(childForm);
            panel_mainKaraoke.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // hàm định dạng đúng chữ tiếng việt
        private static string DecodeFromUtf8(string utf8_String)
        {
            byte[] bytes = Encoding.Default.GetBytes(utf8_String);
            utf8_String = Encoding.UTF8.GetString(bytes);
            return utf8_String;
        }

        // hàm mở form record
        private void showRecordForm(int indexItem)
        {
            choseUrl = list[indexItem].Url;
            if (choseUrl != "")
            {
                panel_videosSearch.Visible = false;
                Form record = new Karaoke_record();
                openChildForm(record);
            }
        }
        // hàm tìm kiếm
        private async void searchVideos(bool checkHasName = false)
        {
            // tắt form record nếu đang hoạt động
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // lấy câu truy vấn
            string querySong;
            if (checkHasName)
                querySong = MusicApp.songNameKaraoke;
            else
                querySong = textBox_titleVideo.Text;

            // tạo list data mới
            list = new List<video>();

            // lấy video thông qua youtube search
            VideoSearch videos = new VideoSearch();
            var items = await videos.GetVideos(querySong, 1);

            // lấy 10 video đầu , lười sửa code nên chơi cục súc vậy :v 
            int i = 1;
            foreach (var item in items)
            {
                if (i > 10)
                    break;
                video vd = new video();
                string title_utf8 = DecodeFromUtf8(item.getTitle());
                vd.Title = title_utf8;
                vd.Author = item.getAuthor();
                vd.Url = item.getUrl();
                byte[] imageBytes = new WebClient().DownloadData(item.getThumbnail());
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    vd.Thumbnail = Image.FromStream(ms);
                }
                list.Add(vd);
                i++;
            }

            // gán data cho cho các pic, label, cũng lười nên chơi cục súc
            pictureBox_item1.Image = list[0].Thumbnail;
            label_item1.Text = list[0].Title;

            pictureBox_item2.Image = list[1].Thumbnail;
            label_item2.Text = list[1].Title;

            pictureBox_item3.Image = list[2].Thumbnail;
            label_item3.Text = list[2].Title;

            pictureBox_item4.Image = list[3].Thumbnail;
            label_item4.Text = list[3].Title;

            pictureBox_item5.Image = list[4].Thumbnail;
            label_item5.Text = list[4].Title;

            pictureBox_item6.Image = list[5].Thumbnail;
            label_item6.Text = list[5].Title;

            pictureBox_item7.Image = list[6].Thumbnail;
            label_item7.Text = list[6].Title;

            pictureBox_item8.Image = list[7].Thumbnail;
            label_item8.Text = list[7].Title;

            pictureBox_item9.Image = list[8].Thumbnail;
            label_item9.Text = list[8].Title;

            pictureBox_item10.Image = list[9].Thumbnail;
            label_item10.Text = list[9].Title;

            // show panel chứa data
            panel_videosSearch.Visible = true;
        }
        // nút tìm kiếm
        private void button_searchVideo_Click(object sender, EventArgs e)
        {
            searchVideos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_videosSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // nút item
        private void button_item7_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item", ""));
            showRecordForm(indexItem-1);
        }

        private void button_item1_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item",""));
            showRecordForm(indexItem-1);
        }

        private void button_item2_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item", ""));
            showRecordForm(indexItem-1);
        }

        private void button_item3_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item", ""));
            showRecordForm(indexItem-1);
        }

        private void button_item4_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item", ""));
            showRecordForm(indexItem-1);
        }

        private void button_item5_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item", ""));
            showRecordForm(indexItem-1);
        }

        private void button_item6_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item", ""));
            showRecordForm(indexItem-1);
        }

        private void button_item8_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item", ""));
            showRecordForm(indexItem-1);
        }

        private void button_item9_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item", ""));
            showRecordForm(indexItem-1);
        }

        private void button_item10_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            int indexItem = int.Parse(button.Name.Replace("button_item", ""));
            showRecordForm(indexItem - 1);
        }
    }
}
