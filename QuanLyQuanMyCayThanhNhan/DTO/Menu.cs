using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DTO
{
    public class Menu
    {
        public Menu(string foodName,int count, float price,float totalPrice)
        {
            this.Foodname= foodName;
            this.Count= count;
            this.Price= price;
            this.totalPrice= totalPrice;
        }

        public Menu(DataRow row)
        {
            this.Foodname= row["Name"].ToString();
            this.Count= (int)row["count"];
            this.Price= (float)Convert.ToDouble(row["price"].ToString());
            this.totalPrice= (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private string foodname;
        private int count;
        private float price;
        private float totalPrice;

        public string Foodname { get { return foodname;} set{ this.foodname=value;} }
        public int Count { get { return count; } set { this.count=value; } }
        public float Price { get { return price; } set { this.price=value; } }
        public float TotalPrice { get { return totalPrice; } set { totalPrice=value; } }
    }
}
