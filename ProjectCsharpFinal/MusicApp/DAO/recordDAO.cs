using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApp.DTO;
using System.Data;

namespace MusicApp.DAO
{
    public class recordDAO
    {
        private static recordDAO instance;

        public static recordDAO Instance
        {
            get { if (instance == null) instance = new recordDAO(); return recordDAO.instance; }
            private set { recordDAO.instance = value; }
        }

        private recordDAO() { }


        public List<record> getrecordbyquery(string query)
        {
            List<record> lstrecord = new List<record>();
            string query_database = "select * from dbo.recordanddownload where name like N'%" + query + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                record _record = new record(item);
                lstrecord.Add(_record);
            }

            return lstrecord;
        }

        public List<record> getrecordbyname(string query)
        {
            List<record> lstrecord = new List<record>();
            string query_database = "select * from dbo.recordanddownload where name = N'" + query + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                record _record = new record(item);
                lstrecord.Add(_record);
            }

            return lstrecord;
        }

        public List<record> getrecord()
        {
            List<record> lstrecord = new List<record>();
            string query_database = "select * from dbo.recordanddownload";
            DataTable data = DataProvider.Instance.ExecuteQuery(query_database);
            //Console.WriteLine(data);
            foreach (DataRow item in data.Rows)
            {
                record _record = new record(item);
                lstrecord.Add(_record);
            }

            return lstrecord;
        }

    }
}
