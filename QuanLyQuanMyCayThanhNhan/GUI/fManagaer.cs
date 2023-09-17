
using QuanLyQuanMyCayThanhNhan.DAO;
using QuanLyQuanMyCayThanhNhan.DTO;
using QuanLyQuanMyCayThanhNhan.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QuanLyQuanMyCayThanhNhan
{
    public partial class fManagaer : Form
    {
       
        public fManagaer(Account acc)
        {
            InitializeComponent();
            
            this.LoginAccount= acc;
            LoadTable();
            LoadCategory();
            LoadClient();
            LoadTableIntoCombobox();

            //panel1.Hide();
            //panel2.Hide();
            //panel3.Hide();
            //    this.ClientSize = new System.Drawing.Size(600, 722);
        }


        #region Method

        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set { loginAccount=value; ChangeAccount(loginAccount.Role); }

        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCaterogy.DataSource = listCategory;
            cbCaterogy.DisplayMember="Name";
        }

        void LoadClient()
        {
            List<Client> listClient = ClientDAO.Instance.GetListClient();
            cbClient.DataSource = listClient;
            cbClient.DisplayMember="Name";
        }

        private int LoadFoodListByCategory(int id)
        {

            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource=listFood;
            cbFood.DisplayMember="Name";
            return CategoryDAO.Instance.GetCountCategory(id);
        }

       

        void LoadTableIntoCombobox()
        {

            List<Table> listFood = TableDAO.Instance.LoadTableList();
            cbSwithTable.DataSource=listFood;
            cbSwithTable.DisplayMember="Name";
        }


        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.LoadTableList();

            foreach (Table item in tablelist)
            {
                Button btn = new Button()
                {
                    Width=TableDAO.TableWith,
                    Height=TableDAO.TableHeigh
                };
                btn.Text=item.Name + Environment.NewLine+item.Status;
                //btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                //btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Click+=Btn_Click;
                btn.Tag= item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua; break;
                    default:
                        btn.BackColor=Color.DarkOrange; break;
                }
                flpTable.Controls.Add(btn);
                //   flpTable.Controls[0].Controls.
            }
        }


        void ChangeAccount(string role)
        {
           
            adminToolStripMenuItem.Visible = role.Equals("Quản lý");
           
            thôngTinTàiKhoảnToolStripMenuItem.Text+="("+loginAccount.DisplayName+")";
        }
       

        float ShowBill(int id)// id : idTableFood từ Bill
        {
            //MessageBox.Show("ID="+id);
            int a = BillDAO.Instance.GetUnCheckBillIDByTableID(id);
            //  MessageBox.Show("##"+a);
            lsvBill.Items.Clear();
            //   List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUnCheckBillIDByTableID(id));
            List<QuanLyQuanMyCayThanhNhan.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLyQuanMyCayThanhNhan.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Foodname.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lsvBill.Items.Add(lsvItem);
                totalPrice += item.TotalPrice;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //   Thread.CurrentThread.CurrentCulture=culture;
            int discount = (int)nmDisCount.Value;
            float sum = totalPrice;
            txbSumPrice.Text=sum.ToString("c",culture);
            return totalPrice;
        }

        
        private void CheckBill(int id, float sumprice, int discount)
        {
           

            if (BillDAO.Instance.CheckOut(id, sumprice, discount))
            {
                MessageBox.Show("Thanh toán thành công");

            }
        }

        private void DeleteTableBill(int id)
        {
            if (BillDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Hủy Bàn thành công");
            }
        }


        private void SwichTable(int id1, int id2)
        {

            if (TableDAO.Instance.SwithTable(id1, id2))
            {
                MessageBox.Show("Chuyển bàn thành công");
            }
        }

        void LoadClientWhereTagTable(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBill.Tag=(sender as Button).Tag;

            if (((sender as Button).Tag as Table).Status.Equals("Có người"))
            {
                List<Client> listClient = ClientDAO.Instance.GetClientByIDTable(tableID);
                cbClient.DataSource = listClient;
                cbClient.DisplayMember="Name";

            }
            else
            {
                LoadClient();
            }
        }

        void LoadFood(int id)
        {
            if (LoadFoodListByCategory(id)>0)
            {
                btnDeleteFood.Show();
                btnAddFood.Show();
                nmAddcount.Show();
                lb1.Hide();
            }
            else
            {
                btnDeleteFood.Hide();
                btnAddFood.Hide();
                nmAddcount.Hide();
                cbFood.Text="";
                //   cbClient.Text="";
                lb1.Text="Không có món ăn nào thuộc loại này \n phải có món ăn để thêm món\n hãy chọn loại món ăn khác";
                lb1.Show();
            }
        }
       
        void AddFood(int x)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null) return;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = ((int)nmAddcount.Value)*x;
            int clientid = (cbClient.SelectedItem as Client).ID;

            // idBill == -1&&x>0 nghĩa là Table nếu trống, không người thì không xóa đựợc món ăn vì không có
            if (idBill == -1&&x>0)
            {
                BillDAO.Instance.InsertBill(table.Id, clientid);
                BillInfoDAO.Instance.IsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
                LoadTable();
            }
            else
            {
                BillInfoDAO.Instance.IsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.Id);

           
        }

        #endregion MeThod

        #region Event

        private void nmDisCount_ValueChanged(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null) return;
            float sumprice = float.Parse(txbSumPrice.Text.Split(',')[0]);
            int discount = (int)nmDisCount.Value;
            float sum = ShowBill(table.Id);

            CultureInfo culture = new CultureInfo("vi-VN");
            txbSumPrice.Text=sum.ToString("c", culture);
        }


        private void cbCaterogy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cần chọn vào cbCategory + F4 + <chọn dấu tia sét trên đầu> +  SelectedIndexChanged<đúp chuột> để khởi động


            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem==null)
                return;
            Category selected = cb.SelectedItem as Category;
            int id = selected.ID;
            LoadFood(id);

        }

        void Btn_Click(object sender, EventArgs e)
        {
            //this.flpTable.Size = new System.Drawing.Size(561, 667);
            //panel1.Show();
            //panel2.Show();
            //panel3.Show();
            //     this.ClientSize = new System.Drawing.Size(1189, 722);
            lbTAble.Text=((sender as Button).Tag as Table).Name;
            int tableID = ((sender as Button).Tag as Table).Id;
            LoadClientWhereTagTable(sender, e);

            ShowBill(tableID);
            //       throw new NotImplementedException();
        }
        private void F_fUpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text="Thông tin tài khoản ("+e.Acc.DisplayName+")";
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCategory f = new fCategory();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadTable();
            LoadCategory();
            LoadClient();
            LoadTableIntoCombobox();
        }


        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.fUpdateAccount+=F_fUpdateAccount;//Chuyển dữ liệu từ form con(fAcconutProfile_đổi thông tin tài khoản) đến form cha(fManager_Form chinh)
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount= loginAccount;
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadTable();
            LoadCategory();
            LoadClient();
            LoadTableIntoCombobox();

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFood(1);
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            AddFood(-1);
        }


        private void btnSwithTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).Id;
            int id2 = (cbSwithTable.SelectedItem as Table).Id;
            if (MessageBox.Show(string.Format("Bạn có chắc chuyển bàn {0} sang bàn {1}",id1,id2), "Thông báo", MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                SwichTable(id1, id2);
                LoadTable();

            }
        }

        //Tạo phím tắt
        
        private void thanhToánToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnCheckOut_Click(this, new EventArgs());
        }
        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood_Click(this, new EventArgs());
           
        }

        private void xóaMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteFood_Click(this, new EventArgs());
        }

       
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null) return;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);

            
            float sumprice = float.Parse(txbSumPrice.Text.Split(',')[0]);
            int discount = (int)nmDisCount.Value;
            float sum = sumprice-(sumprice/100)*discount;
            if (idBill!=-1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\n Tổng tiền - (Tông tiền /100)* Giảm giá =\n{1} -({1}/100)*{2} = {3}", table.Name, sumprice, discount, sum), "Thông báo", MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
                {
                  
                    CheckBill(idBill, sum, discount);
                   
                    if (table == null) return;
                    ShowBill(table.Id);
                    table.Status="Có người";
                    LoadTable();
 
                }

            }
        }
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null) return;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            float sumprice = float.Parse(txbSumPrice.Text.Split(',')[0]);
            int discount = (int)nmDisCount.Value;
            float sum = sumprice-(sumprice/100)*discount;
            if (idBill!=-1)
            {
                if (BillDAO.Instance.Changediscount(discount, idBill))
                {
                    PrintBill f = new PrintBill(table.Id,idBill, sum, discount);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    LoadTable();
                    LoadCategory();
                    LoadClient();
                    LoadTableIntoCombobox();
                }

            }
        }
        private void btnDeleteTableBill_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null) return;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            
            if (idBill!=-1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc Hủy hóa đơn cho bàn {0}", table.Id), "Thông báo", MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
                {
                    DeleteTableBill(idBill);
                    if (table == null) return;
                    ShowBill(table.Id);
                    //table.Status="Có người";
                    LoadTable();
                }

            }
        }


        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvBill.SelectedItems.Count>0)
            {
                List<Category> listCategory = CategoryDAO.Instance.GetListCategoryByFoodName(lsvBill.SelectedItems[0].SubItems[0].Text);
                cbCaterogy.DataSource = listCategory;
                cbCaterogy.DisplayMember="Name";
                List<Food> listFood = FoodDAO.Instance.GetFoodByName(lsvBill.SelectedItems[0].SubItems[0].Text);
                cbFood.DataSource=listFood;
                cbFood.DisplayMember="Name";
                

            }
            else
            {
             
                LoadCategory();
            }

        }

        private void cbCaterogy_MouseClick(object sender, MouseEventArgs e)
        {
            LoadCategory();
        }

        private void lsvBill_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddFood(-1);
        }


        private void cbFood_MouseClick(object sender, MouseEventArgs e)
        {
            LoadFood(FoodDAO.Instance.GetIDFoodByCategoryNAme(cbCaterogy.Text));

        }

        #endregion Eventn


    }
}
