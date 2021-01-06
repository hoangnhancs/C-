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
        public singer(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            //this.Username = username;
        }
        public singer(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
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




    }
}
