using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DTO
{
    public class Table
    {
        public Table(int id,string name,string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        public Table (DataRow row)
        {
            this.id=(int)row["id"];
            this.Name=row["name"].ToString();
            this.status=row["status"].ToString();
        }

        private string status;
        public string Status { get => status; set => status=value; }

        private string name;

        public string Name { get => name; set => name=value; }
        

        private int id;

        public int Id { get => id; set => id=value; }

       
    }
}
