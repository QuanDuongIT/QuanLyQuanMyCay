
using QuanLyQuanMyCayThanhNhan.DAO;
using QuanLyQuanMyCayThanhNhan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DAO
{

    public class BillDAO
    {
        private static BillDAO instance;
        

        //thành công Bill id 
        //Thất bại Bill -1
        public static BillDAO Instance {
            get { if (instance==null) instance=new BillDAO(); return instance; }
            private set { instance = value; } 
        }
        private BillDAO() { }

        public int GetUnCheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExexuteQuery("select * from dbo.Bill where idTable = "+id+" and status=0");
           
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);

                return bill.ID;
            }
            return -1;
        }



        public void InsertBill(int idtable,string idclient)      
        {
           
            DataProvider.Instance.ExexuteQuery("exec USP_InsertBill\r\n @idTable , @idClient ", new object[] {idtable,idclient});
        }
        public int GetMaxIDBill()
        {
              
            try
            {
                int max= (int)DataProvider.Instance.ExexuteScalar("select MAX(id) from dbo.Bill");
               
                return max;
            }
            catch
            {
                return 1;
            }

        }
        public bool CheckOut(int id,float sumprice,int discount)
        {
            string query = string.Format("exec USP_CheckOut {0},{1},{2}", id,sumprice,discount);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
            return true;
        }

        public bool DeleteTable(int id)
        {
            string query = string.Format("exec USP_DeleteTableBill {0}", id);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
            return true;
        }
        public DataTable GetBillListByDate(DateTime checkIn,DateTime checkOut)
        {
            return DataProvider.Instance.ExexuteQuery("USP_GetListBillByDate\r\n @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }

        public DataTable GetBillListByDatePage(DateTime checkIn, DateTime checkOut,int pageNum)
        {
            return  DataProvider.Instance.ExexuteQuery("USP_GetListBillByDateAndPage\r\n @checkIn , @checkOut , @page ", new object[] { checkIn, checkOut ,pageNum });
        }

        public int GetNumBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExexuteScalar("USP_GetNumBillByDate\r\n @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }

        public bool Changediscount(int discount,int idBill)
        {
            string query = string.Format("exec  USP_Changediscount {0} , {1} ", discount, idBill);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;

        }
    }
}
