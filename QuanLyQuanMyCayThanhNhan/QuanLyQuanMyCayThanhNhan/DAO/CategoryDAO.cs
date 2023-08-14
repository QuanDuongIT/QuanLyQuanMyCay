
using QuanLyQuanMyCayThanhNhan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyQuanMyCayThanhNhan.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance==null) instance=new CategoryDAO(); return CategoryDAO.instance; }
            set => instance=value;
        }
        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from FoodCategory";

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public List<Category> GetCategoryByFoodName(string foodname)
        {
            List<Category> list = new List<Category>();

            string query = "select f.id,f.name from FoodCategory as f,Food where  Food.name=N'"+foodname+"'  and Food.idCategory=f.id ";

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public List<Category> GetListCategoryByFoodName(String FoodName)
        {
            List<Category> list = new List<Category>();

            string query = "select f.id,f.name from FoodCategory as f,Food where f.id =Food.idCategory and Food.name=N'"+FoodName.ToString()+"'";

            DataTable data = DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public int GetCountCategory(int id)
        {
            string query = "exec USP_CountFoodByCategpry "+id;

            DataTable data = DataProvider.Instance.ExexuteQuery(query);

            return data.Rows.Count;

        }
       

        public bool InsertFoodCategory(string name)
        {
            string query = string.Format("exec USP_InsertFoodCategory N'{0}'", name);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }

        public bool UpdateFoodCategory(int id,string newname)
        {
            string query = string.Format("exec USP_EditFoodCategor N'{1}' , {0} ", id,newname);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;

        }

        public bool DeleteFoodCategory(int id)
        {
            //    MessageBox.Show(""+name);
            string query = string.Format("exec USP_DeleteFoodCategory {0}", id);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }


    }
}
