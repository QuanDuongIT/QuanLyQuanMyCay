
using QuanLyQuanMyCayThanhNhan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance==null) instance =new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWith = 100;
        public static int TableHeigh = 100;


        private TableDAO() { }
        public List<Table> LoadTableList()
        {
            List<Table> tablelist =new List<Table> ();
            DataTable data = DataProvider.Instance.ExexuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);

            }
            return tablelist;
        }
        public bool SwithTable(int id1,int id2)
        {
            string query = string.Format("exec USP_SwichTable {0},{1} ", id1,id2);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
            return true;
        }
    }
    
}
