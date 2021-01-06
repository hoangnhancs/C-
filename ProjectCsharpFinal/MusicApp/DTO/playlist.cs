using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicApp.DTO
{
    public class playlist
    {
        public playlist (int id, string name, string username, string image_path)
        {
            this.ID = id;
            this.Name = name;
            this.Username = username;
            this.Image_path = image_path;
        }
        public playlist (DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Username = row["username"].ToString();
            this.Image_path = row["image_path"].ToString();
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

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string image_path;
        public string Image_path
        {
            get { return image_path; }
            set { image_path = value; }
        }

    }
}
