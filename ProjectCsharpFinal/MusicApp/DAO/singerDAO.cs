using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApp.DTO;
using System.Data;

namespace MusicApp.DAO
{
    public class singerDAO
    {
        private static singerDAO instance;

        public static singerDAO Instance
        {
            get { if (instance == null) instance = new singerDAO(); return singerDAO.instance; }
            private set { singerDAO.instance = value; }
        }

        private singerDAO() { }

        public List<singer> getsinger()
        {
            List<singer> lstsinger = new List<singer>();
            string query = "select * from singer";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                singer _singer = new singer(item);
                lstsinger.Add(_singer);
            }

            return lstsinger;
        }

        public List<singer> getsingerbycat(string cat)
        {
            List<singer> lstsinger = new List<singer>();
            string query = "select * from singer where cat=N'" + cat + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                singer _singer = new singer(item);
                lstsinger.Add(_singer);
            }

            return lstsinger;
        }
        public List<song> getsongbynamesinger(string singer)
        {
            List<song> lstsong = new List<song>();
            string query = "select * from song where singer=N'" + singer + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }

            return lstsong;
        }
    }
}
