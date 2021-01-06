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
            // load video từ youtube
            string link = richTextBox_urlDownload.Text;

            /*
             * Get the available video formats.
             * We'll work with them in the video and audio download examples.
             */
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);


            // tải audio track
            /*
            * Select the first .mp4 video with 360p resolution
                */
            VideoInfo video = videoInfos
                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the video downloader.
             * The first argument is the video to download.
             * The second argument is the path to save the video file.
             */
            var videoDownloader = new VideoDownloader(video, Path.Combine("D:/Downloads", video.Title + video.VideoExtension));

            //// Register the ProgressChanged event and print the current progress
            //videoDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);

            /*
             * Execute the video downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            videoDownloader.Execute();

        }
    }
}
