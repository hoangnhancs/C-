using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApp.DTO;
using System.Data;

namespace MusicApp.DAO
{
    public class albumDAO
    {
        private static albumDAO instance;

        public static albumDAO Instance
        {
            get { if (instance == null) instance = new albumDAO(); return albumDAO.instance; }
            private set { albumDAO.instance = value; }
        }

        private albumDAO() { }

        public List<album> getalbum()
        {
            List<album> lstalbum = new List<album>();
            string query = "select * from album";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                album _album = new album(item);
                lstalbum.Add(_album);
            }

            return lstalbum;
        }
        public List<album> getalbumbyqueryname(string queryname)
        {
            List<album> lstalbum = new List<album>();
            string query = "select * from album where name like N'%"+queryname+"%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                album _album = new album(item);
                lstalbum.Add(_album);
            }

            return lstalbum;
        }
    }
}
