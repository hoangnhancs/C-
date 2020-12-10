using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace btth3.DTO
{
    public class song_category
    {
        public song_category(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public song_category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
