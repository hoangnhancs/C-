using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace btth3.DTO
{
    public class song
    {
        public song(int id, string name, string path, string author,
                    int id_playlist, int id_song_category)
        {
            this.ID = id;
            this.Name = name;
            this.Path = path;
            this.Author = author;
            this.ID_Playlist = id_playlist;
            this.ID_Song_Category = id_song_category;
        }

        public song(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Path = row["song_path"].ToString();
            this.Author = row["author"].ToString();
            this.ID_Playlist = (int)row["id_playlist"];
            this.ID_Song_Category = (int)row["id_category"];
        }


        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string path;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        private string author;
        private string Author
        {
            get { return author; }
            set { author = value; }
        }

        private int id_playlist;
        private int ID_Playlist
        {
            get { return id_playlist; }
            set { id_playlist = value; }
        }

        private int id_song_category;

        public int ID_Song_Category
        {
            get { return id_song_category; }
            set { id_song_category = value; }
        }

    }
}
