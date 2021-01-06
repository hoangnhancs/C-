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
    }
}
