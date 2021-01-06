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
    public partial class Karaoke_search : Form
    {
        public Karaoke_search()
        {
            InitializeComponent();
        }

        private void Karaoke_search_Load(object sender, EventArgs e)
        {

        }

        private static string DecodeFromUtf8(string utf8_String)
        {
            byte[] bytes = Encoding.Default.GetBytes(utf8_String);
            utf8_String = Encoding.UTF8.GetString(bytes);
            return utf8_String;
        }



    }
}
