using QuanLyQuanMyCayThanhNhan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanMyCayThanhNhan.DAO
{
    public class ClientDAO
    {
        private static ClientDAO instance;

        public static ClientDAO Instance
        {
            get { if (instance==null) instance=new ClientDAO(); return ClientDAO.instance; }
            set => instance=value;
        }
        private ClientDAO() { }

       
        public List<Account> GetListClient()
        {
            List<Account> list = new List<Account>();

            string query = "select UserName,DisPlayName,Role,Address,Phone,Gender from Account where Role=N'Khách hàng'";

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account client = new Account(item);
                list.Add(client);
            }

            return list;
        }

        public List<Account> GetClientByIDTable(int idTAble)
        {
           
            List<Account> list = new List<Account>();
            string query = "exec GetClientByIDTable " + idTAble.ToString();

            DataTable data = DataProvider.Instance.ExexuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account client = new Account(item);
                list.Add(client);
            }
           
            return list;
        }


        public bool InsertClient(string name, string address, string phone , string gender)
        {
        //    string query = string.Format("insert dbo.Client (name,address,phone) values ( N'{0}' , N'{1}' , N'{2}' ) ", name, address,phone);
            string query = string.Format("exec USP_InsertClient  N'{0}' , N'{1}' , N'{2}' , N'{3}' ", name, address, phone,gender);

            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }

        

        public bool UpdateClient(string id, string newname, string address, string phone, string gender)
        {
            string query = string.Format("exec USP_EditClient N'{0}' , N'{1}' , N'{2}' , N'{3}', N'{4}' ", id, newname, address, phone,gender);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;

        }

        public bool DeleteClent(string id)
        {
            //    MessageBox.Show(""+name);
            string query = string.Format("exec USP_DeleteClient N'{0}' ", id);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }



    }
}
