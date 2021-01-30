using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MusicApp.DAO;

namespace MusicApp.DTO
{
    public class record
    {
        public record(int id, string name, string song_path, string lyric_path, int id_playlist, string image_path, string singer
            , string name_album, int id_album, string name_playlist, string song_type, int song_type_id)
        {
            this.ID = id;
            this.Song_path = song_path;
            this.Lyric_path = lyric_path;
            this.Image_path = image_path;
            this.Name = name;
            this.Singer = singer;
            this.Name_album = name_album;
            this.ID_album = id_album;
            this.Name_playlist = name_playlist;
            this.ID_playlist = id_playlist;
            this.Song_type = song_type;
            this.Song_type_ID = song_type_id;
        }

        public record(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Song_path = row["song_path"].ToString();
            this.Image_path = row["image_path"].ToString();
            this.Lyric_path = row["lyric_path"].ToString();
            this.Singer = row["singer"].ToString();
            this.ID_playlist = (int)row["id_playlist"];
            this.Name_playlist = row["name_playlist"].ToString();
            this.Song_type = row["song_type"].ToString();
            this.Song_type_ID = (int)row["song_type_id"];
            this.Name_album = row["name_album"].ToString();
            this.ID_album = (int)row["id_album"];
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

        private string song_path;
        public string Song_path
        {
            get { return song_path; }
            set { song_path = value; }
        }

        private string image_path;
        public string Image_path
        {
            get { return image_path; }
            set { image_path = value; }
        }

        private string lyric_path;
        public string Lyric_path
        {
            get { return lyric_path; }
            set { lyric_path = value; }
        }

        private string singer;
        public string Singer
        {
            get { return singer; }
            set { singer = value; }
        }

        private string name_album;
        public string Name_album
        {
            get { return name_album; }
            set { name_album = value; }
        }

        private int id_album;
        public int ID_album
        {
            get { return id_album; }
            set { id_album = value; }
        }

        private int id_playlist;
        public int ID_playlist
        {
            get { return id_playlist; }
            set { id_playlist = value; }
        }

        private string name_playlist;

        public string Name_playlist
        {
            get { return name_playlist; }
            set { name_playlist = value; }
        }

        private int song_type_id;

        public int Song_type_ID
        {
            get { return song_type_id; }
            set { song_type_id = value; }
        }

        private string song_type;
        public string Song_type
        {
            get { return song_type; }
            set { song_type = value; }
        }

    }
}
