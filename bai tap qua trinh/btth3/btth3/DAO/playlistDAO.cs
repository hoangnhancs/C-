using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btth3.DTO;
using System.Data;

namespace btth3.DAO
{
    public class playlistDAO
    {
        private static playlistDAO instance;

        public static playlistDAO Instance
        {
            get { if (instance == null) instance = new playlistDAO(); return playlistDAO.instance; }
            private set { playlistDAO.instance = value; }
        }

        private playlistDAO() { }

        public List<playlist> getplaylist()
        {
            List<playlist> playlst = new List<playlist>();
            string query = "select * from playlist";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                //Console.WriteLine(item);
                playlist pll = new playlist(item);
                playlst.Add(pll);
            }
            return playlst;
        }

        public DataTable getplaylistbyid(int id)
        {
            //playlist pll = null;
            string query = "select * from song where id_playlist =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
       
    }
}
