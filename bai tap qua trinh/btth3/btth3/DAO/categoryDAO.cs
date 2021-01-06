using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btth3.DTO;
using System.Data;

namespace btth3.DAO
{
    
    public class categoryDAO
    {
        private static categoryDAO instance;

        public static categoryDAO Instance
        {
            get { if (instance == null) instance = new categoryDAO(); return categoryDAO.instance; }
            private set { categoryDAO.instance = value; }
        }

        private categoryDAO() { }


        public List<song_category> getsongctgrbyctgrlistid(int id)
        {
            List<song_category> lstsongctgr = new List<song_category>();

            string query = "select * from category where id_category = " + id.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                song_category _song = new song_category(item);
                lstsongctgr.Add(_song);
            }

            return lstsongctgr;

        }

        public List<song_category> getsongctgr()
        {
            List<song_category> lstsongctgr = new List<song_category>();

            string query = "select * from category ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                song_category _song = new song_category(item);
                lstsongctgr.Add(_song);
            }

            return lstsongctgr;

        }
    }
}
