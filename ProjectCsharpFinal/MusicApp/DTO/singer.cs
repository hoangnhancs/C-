using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicApp.DTO
{
    public class singer
    {
        public singer(int id, string name, string cat, string iamge_path)
        {
            this.ID = id;
            this.Name = name;
            this.Cat = cat;
            this.Image_path = image_path;
            //this.Username = username;
        }
        public singer(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Cat = row["cat"].ToString();
            this.Image_path = row["image_path"].ToString();
            //this.Username = row["username"].ToString();
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

        private string cat;
        public string Cat
        {
            get { return cat; }
            set { cat = value; }
        }
        private string image_path;
        public string Image_path
        {
            get { return image_path; }
            set { image_path = value; }
        }

    }
}
