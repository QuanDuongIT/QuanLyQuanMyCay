using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DTO
{
    public class Client
    {
        public Client(int id, string name, string address, string phone)
        {
            this.ID = id;
            this.Name = name;
            this.Address=address;
            this.phone = phone;
        }

        public Client(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Address=row["address"].ToString();
            this.phone =row["phone"].ToString();
        }

        private string phone;

        private string address;

        private string name;

        private int iD;

        public int ID { get => iD; set => iD=value; }
        public string Name { get => name; set => name=value; }
        public string Address { get => address; set => address=value; }
        public string Phone { get => phone; set => phone=value; }
    }
}
