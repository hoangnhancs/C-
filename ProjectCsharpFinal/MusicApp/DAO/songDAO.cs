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

            string query = "select * from song where id_album<>6 id_playlist = " + id.ToString();
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
            string query_database = "select * from dbo.song where id_album<>6 and name like N'%" + query + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }
            
            return lstsong;
        }

        public List<song> getsongbyname(string query)
        {
            List<song> lstsong = new List<song>();
            string query_database = "select * from dbo.song where id_album<>6 and name = N'" + query + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }

            return lstsong;
        }

        public List<song> getsongbyCategory(string cat)
        {
            List<song> lstsong = new List<song>();

            string query_database = "select * from dbo.song where id_album<>6 and song_type = N'" + cat + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }

            return lstsong;
        }
        public List<song> clearRepeatSong(List<song> lstsong)
        {
            List<string> check = new List<string>();
            for (int i=0; i<lstsong.Count; i++)
            {
                if (check.Contains(lstsong[i].Song_path))
                {
                    lstsong.RemoveAt(i);
                    i--;
                }
                else
                {
                    check.Add(lstsong[i].Song_path);
                }
            }
            return lstsong;
        }
        public List<song> getsongbyalbumid(int i)
        {
            List<song> lstsong = new List<song>();

            string query_database = "select * from dbo.song where id_album="+i;
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }

            return lstsong;
        }
        public List<song> getothersong(string query)
        {
            List<song> lstsong = new List<song>();

            string query_database = "select * from dbo.song where id_album=6 and name like N'%" + query+"%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }

            return lstsong;
        }
        /*
        public List<song> getsonginsls()
        {
            List<song> lstsong = new List<song>();

            string query_database = "select * from dbo.song where id_album=6 and name like N'%" + query + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                song _song = new song(item);
                lstsong.Add(_song);
            }

            return lstsong;
        }
        */
    }
}
