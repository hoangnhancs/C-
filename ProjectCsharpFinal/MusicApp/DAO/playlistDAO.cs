using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApp.DTO;
using System.Data;

namespace MusicApp.DAO
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
            List<playlist> lstpll = new List<playlist>();
            string query = "select * from playlist";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                playlist _pll = new playlist(item);
                lstpll.Add(_pll);
            }

            return lstpll;
        }
    }
}
