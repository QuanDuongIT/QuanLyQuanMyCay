using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace QuanLyQuanMyCayThanhNhan.DTO
{
    public class AllCode
    {
        private int id;
        private string keyCode;
        private string typeCode;
        private string valueCode;
        
        public AllCode(DataRow row)
        {
            this.Id = (int)row["id"];
            this.KeyCode = row["name"].ToString();
            this.TypeCode = row["name"].ToString();
            this.ValueCode = row["name"].ToString();
        }

        public AllCode(int id, string keyCode, string typeCode, string valueCode)
        {
            this.Id = id;
            this.KeyCode = keyCode;
            this.TypeCode = typeCode;
            this.ValueCode = valueCode;
        }

        public int Id { get => id; set => id = value; }
        public string KeyCode { get => keyCode; set => keyCode = value; }
        public string TypeCode { get => TypeCode; set => TypeCode = value; }
        public string ValueCode { get => valueCode; set => valueCode = value; }
    }
}
