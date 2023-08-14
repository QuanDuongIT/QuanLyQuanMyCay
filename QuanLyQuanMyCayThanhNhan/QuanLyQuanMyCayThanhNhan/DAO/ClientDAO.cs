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

        //public List<Food> GetFoodByCategoryID(int id)
        //{
        //    List<Food> list = new List<Food>();

        //    string query = "select * from Food where idCategory="+id;

        //    DataTable data = DataProvider.Instance.ExexuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        Food food = new Food(item);
        //        list.Add(food);
        //    }

        //    return list;
        //}

        public List<Client> GetListClient()
        {
            List<Client> list = new List<Client>();

            string query = "select * from Client";

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Client client = new Client(item);
                list.Add(client);
            }

            return list;
        }

        public List<Client> GetClientByIDTable(int idTAble)
        {
           
            List<Client> list = new List<Client>();
            string query = "select f.id,f.name,f.address,f.phone from Client as f,Bill,TableFood where f.id=Bill.idclient and Bill.idTable=TableFood.id and Bill.DateCheckOut is NULL and TableFood.id="+idTAble.ToString();
     
            DataTable data = DataProvider.Instance.ExexuteQuery(query);
           
            foreach (DataRow item in data.Rows)
            {
                Client client = new Client(item);
                list.Add(client);
            }
            
            return list;
        }


        public bool InsertClient(string name, string address, string phone)
        {
        //    string query = string.Format("insert dbo.Client (name,address,phone) values ( N'{0}' , N'{1}' , N'{2}' ) ", name, address,phone);
            string query = string.Format("exec USP_InsertClient  N'{0}' , N'{1}' , N'{2}'  ", name, address, phone);

            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }

        

        public bool UpdateClient(int id, string newname, string address, string phone)
        {
         //   string query = string.Format("update dbo.Client set  name=N'{1}',address=N'{2}' , phone=N'{3}'  where id={0} ", id, newname, address, phone);
            string query = string.Format("exec USP_EditClient {0} , N'{1}' , N'{2}' , N'{3}' ", id, newname, address, phone);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;

        }

        public bool DeleteClent(int id)
        {
            //    MessageBox.Show(""+name);
            string query = string.Format("exec USP_DeleteClient {0} ", id);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }



    }
}
