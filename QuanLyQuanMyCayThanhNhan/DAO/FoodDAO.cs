
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
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance==null) instance=new FoodDAO(); return FoodDAO.instance; }
            set => instance=value;
        }
        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where idCategory="+id;

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetFoodByCategoryName(String name)
        {
            List<Food> list = new List<Food>();

            string query = "exec GetFoodByCategoryName N'"+name+"'";

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetFoodByName(String name)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where name=N'"+name.ToString()+"'";

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food";

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

       

        public bool InsertFood(string name, int idCategory, float price,int quantity)
        {
          
            string query = string.Format("exec USP_InsertFood N'{0}' , {1} , {2} , {3}",name, idCategory, price,quantity);
          
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }

        public bool UpdateFood(int id, string newname, int newidCategory, float newprice,int quantity)
        {
            string query = string.Format("exec USP_EditFood N'{0}',{1},{2},{3},{4}",  newname, newidCategory, newprice, id, quantity);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;

        }

        public bool DeleteFood(int id)
        {
            //    MessageBox.Show(""+name);
            string query = string.Format("exec USP_DeleteFood {0} ", id);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }

        public List<Food> SearchFoodListByName(string name)
        {
            List<Food> list = new List<Food>();

            string query = string.Format("select * from Food where name like N'%{0}%'", name);

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public int GetIDFoodByCategoryNAme(String name)
        {
            string query = string.Format("");
            
            return (int)DataProvider.Instance.ExexuteScalar(" select * from FoodCategory where name=N'"+name.ToString()+"'");

        }
    }
}
