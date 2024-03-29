﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btth3.DTO;
using System.Data;

namespace btth3.DAO
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

        public List<song> getsong()
        {
            List<song> lstsong = new List<song>();

            string query = "select * from song";
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
