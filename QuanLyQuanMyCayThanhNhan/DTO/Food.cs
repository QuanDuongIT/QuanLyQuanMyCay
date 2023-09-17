using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DTO
{
    public class Food
    {



        

        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Quantity = (int)row["quantity"];
        }

        public Food(float price, int categoryID, string name, int iD, int quantity)
        {
            this.price = price;
            this.categoryID = categoryID;
            this.name = name;
            this.iD = iD;
            Quantity = quantity;
        }

        private float price;

        private int categoryID;

        private string name;

        private int iD;
        private int Quantity;
        public int ID { get => iD; set => iD=value; }
        public string Name { get => name; set => name=value; }
        public int CategoryID { get => categoryID; set => categoryID=value; }
        public float Price { get => price; set => price=value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
    }
}
