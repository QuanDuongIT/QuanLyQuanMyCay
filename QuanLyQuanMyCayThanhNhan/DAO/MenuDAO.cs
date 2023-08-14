
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
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance {
            get { if (instance==null) instance=new MenuDAO(); return MenuDAO.instance; }
            set => instance=value;
        }
        private MenuDAO() { }

        public List<Menu>GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "  select f.name,bi.count,f.price,bi.count*f.price as totalPrice from dbo.BillInfo as bi,dbo.Bill as b, dbo.Food as f\r\n  where bi.idBill=b.id and bi.idFood=f.id and b.status=0 and b.idTable="+id;

            DataTable data=DataProvider.Instance.ExexuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
