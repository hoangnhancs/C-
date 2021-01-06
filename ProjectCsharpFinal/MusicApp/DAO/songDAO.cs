using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApp.DTO;
using System.Data;

namespace MusicApp.DAO
{
    public class songDAO
    {
        private static songDAO instance;

        public static songDAO Instance
        {
            get { if (instance == null) instance = new songDAO(); return songDAO.instance; }
            private set { songDAO.instance = value; }
        }

        private songDAO() { }

        public List<song> getsongbyplaylistid(int id)
        {
            List<song> lstsong = new List<song>();

            string query = "select * from song where id_playlist = " + id.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }

            return lstsong;

        }

        public List<song> getsongbyquery(string query)
        {
            List<song> lstsong = new List<song>();

            string query_database = "select * from dbo.song where name like N'%" + query + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }

            return lstsong;

        }

<<<<<<< HEAD
       
=======
        public List<song> getsongbyCategory(string cat)
        {
            List<song> lstsong = new List<song>();

            string query_database = "select * from dbo.song where song_type = N'" + cat + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }

            return lstsong;

        }
>>>>>>> d60705bbee92b35a32eb48fe55ef61378c42beef
    }
}
