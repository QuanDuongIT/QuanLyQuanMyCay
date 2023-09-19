
using QuanLyQuanMyCayThanhNhan.DAO;
using QuanLyQuanMyCayThanhNhan.DTO;
using QuanLyQuanMyCayThanhNhan.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
//using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QuanLyQuanMyCayThanhNhan
{
    public partial class fManagaer : Form
    {

        public fManagaer(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadClient();

          
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
            set { loginAccount = value; ChangeAccount(loginAccount.Role); }

        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCaterogy.DataSource = listCategory;
            cbCaterogy.DisplayMember = "Name";
        }

        void LoadClient()
        {
            List<Account> listClient = ClientDAO.Instance.GetListClient();
            cbClient.DataSource = listClient;
            cbClient.DisplayMember = "DisplayName";
        }

        private int LoadFoodListByCategory(int id)
        {

            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
            return CategoryDAO.Instance.GetCountCategory(id);
        }



        

        void LoadTable()
        {
            //SetTimeout(() => {
            //    MessageBox.Show("sgsd");
            //}, 1000);
            flpTable.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.LoadTableList();

            foreach (Table item in tablelist)
            {
                Button btn = new Button()
                {
                    Width = TableDAO.TableWith,
                    Height = TableDAO.TableHeigh
                };
                btn.Name = item.Name;
                btn.Text = item.Name + Environment.NewLine + item.Status;
                
                btn.Click += Btn_Click;
                //btn.MouseDown += Btn_MouseDown;
                //btn.MouseMove += Btn_MouseMove;
                
                btn.Tag = item;
                //btn.ForeColor = System.Drawing.Color.Red;
                btn.Location= new System.Drawing.Point(item.Id/5*200, item.Id % 5 * 200);
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = new AColor(5, 226, 255).ToColor();
                        break;
                    default:
                        btn.BackColor = new AColor(88, 242, 17).ToColor();
                        break;
                }

                flpTable.Controls.Add(btn);
                //   flpTable.Controls[0].Controls.
            }
        }

       

        private void SetTimeout(Action value, int v)
        {
            Task.Delay(v).ContinueWith((task) =>
            {
                //
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            
            //lbxTable.Controls.Add(button);
            //lbT.Text = "(" + e.Location.X + "," + e.Location.Y + ")";
            if (e.Button == MouseButtons.Left)
            {
               
                button.Location = new System.Drawing.Point(button.Location.X + e.X - button.Width / 2, button.Location.Y + e.Y - button.Height / 2);
                
                //int zIndex = flpTable.Controls.GetChildIndex(button);
                //button.BringToFront();
                //flpTable.Controls.SetChildIndex(button, zIndex);

            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            
            Button button = sender as Button;
            
            if (e.Button == MouseButtons.Left)
            {
                Btn_MouseMove(sender, e);
                
            }
        }

        void LoadOneTable(Table clicked)
        {

            foreach (Button item in flpTable.Controls)
            {
                if (item.Name.Equals(clicked.Name))
                {
                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = System.Drawing.Color.Red;
                    item.FlatAppearance.BorderSize = 3;
                    
                }
                else
                {
                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
                    item.FlatAppearance.BorderSize = 1;
                    
                }
            }
        }
        
        void LoadOneTableChange(int id)
        {
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            Button btn = new Button()
            {
                Width = TableDAO.TableWith,
                Height = TableDAO.TableHeigh
            };
            foreach (Table item in tablelist)
            {
                if (item.Id == id)
                {
                    btn.Name = item.Name;
                    btn.Text = item.Name + Environment.NewLine + item.Status;

                    btn.Click += Btn_Click;

                    btn.Tag = item;
                    switch (item.Status)
                    {
                        case "Trống":
                            btn.BackColor = new AColor(5, 226, 255).ToColor();
                            break;
                        default:
                            btn.BackColor = new AColor(88, 242, 17).ToColor();
                            break;
                    }
                    
                    break;
                }


            }
            
            foreach (Button item in flpTable.Controls)
            {
                if (item.Name.Equals(btn.Name))
                {
                    item.Name = btn.Name;
                    item.Text = btn.Text;

                    item.Tag = btn.Tag;
                    
                    switch ((item.Tag as Table).Status)
                    {
                        case "Trống":
                            item.BackColor = new AColor(5, 226, 255).ToColor();
                            break;
                        default:
                            item.BackColor = new AColor(88, 242, 17).ToColor();
                            break;
                    }

                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = new AColor(247, 2, 76).ToColor();
                    item.FlatAppearance.BorderSize = 3;
                }
                else
                {
                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = new AColor(245, 132, 2).ToColor();
                    item.FlatAppearance.BorderSize = 1;

                }
            }
        }

        void LoadTwoTable(int id1, int id2)
        {
            
            foreach (Button item in flpTable.Controls)
            {
                if ((item.Tag as Table).Id==id1 || (item.Tag as Table).Id == id2)
                {
                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = new AColor(255, 116, 3).ToColor();
                    item.FlatAppearance.BorderSize = 3;
                    

                }
                else
                {
                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = new AColor(228, 241, 255).ToColor();
                    item.FlatAppearance.BorderSize = 1;
                    
                }
            }
        }

        void LoadTwoTable(Table clicked1, Table clicked2)
        {

            foreach (Button item in flpTable.Controls)
            {
                if (item.Name.Equals(clicked1.Name)|| item.Name.Equals(clicked2.Name))
                {
                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = new AColor(255, 116, 3).ToColor();
                    item.FlatAppearance.BorderSize = 3;
                    

                }
                else
                {
                    item.FlatStyle = FlatStyle.Flat;
                    item.FlatAppearance.BorderColor = new AColor(228, 241, 255).ToColor();
                    item.FlatAppearance.BorderSize = 1;
                    
                }
            }
        }


        void ChangeAccount(string role)
        {

            adminToolStripMenuItem.Visible = role.Equals("Quản lý");

            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + loginAccount.DisplayName + ")";
        }


        float ShowBill(int id)// id : idTableFood từ Bill
        {
            int discount = (int)nmDisCount.Value;
            //MessageBox.Show("ID="+id);
            int a = BillDAO.Instance.GetUnCheckBillIDByTableID(id);
            //  MessageBox.Show("##"+a);
            lsvBill.Items.Clear();
            //   List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUnCheckBillIDByTableID(id));
            List<QuanLyQuanMyCayThanhNhan.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;

            ListViewItem header = new ListViewItem(new string[] {
                    "Hóa đơn bán"},
                    -1, Color.Empty,
                    Color.Empty,
                    new Font(
                        "Microsoft Sans Serif", 14.25F,
                        FontStyle.Bold,
                        System.Drawing.GraphicsUnit.Point, ((byte)(0)))
            );
            header.SubItems.Add("");
            header.SubItems.Add("");
            header.SubItems.Add("");
            

            lsvBill.Items.Add(header);

            ListViewItem headeritem = new ListViewItem("Tên món");
            headeritem.SubItems.Add("Số lượng ");
            headeritem.SubItems.Add("Đơn giá");
            headeritem.SubItems.Add("Thành tiền");
            lsvBill.Items.Add(headeritem);

            foreach (QuanLyQuanMyCayThanhNhan.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Foodname.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lsvBill.Items.Add(lsvItem);
                totalPrice += item.TotalPrice;
            }


            ListViewItem lsvItemTrim = new ListViewItem(" ");
            lsvItemTrim.SubItems.Add(" ");
            lsvItemTrim.SubItems.Add(" ");
            lsvItemTrim.SubItems.Add(" ");
            lsvBill.Items.Add(lsvItemTrim);
            //
            
            ListViewItem lsvItemF = new ListViewItem("Tổng tiền");
            lsvItemF.SubItems.Add(totalPrice.ToString());
            lsvItemF.SubItems.Add(discount.ToString() + "%");
            lsvItemF.SubItems.Add(((float)(100 - discount) / 100 * totalPrice).ToString());
            lsvBill.Items.Add(lsvItemF);
            //

            ListViewItem lsvItemidss = new ListViewItem(" ");
            lsvItemidss.SubItems.Add("");
            lsvItemidss.SubItems.Add("");
            lsvItemidss.SubItems.Add("");
            lsvBill.Items.Add(lsvItemidss);


            CultureInfo culture = new CultureInfo("vi-VN");
            //   Thread.CurrentThread.CurrentCulture=culture;

            float sum = totalPrice;

            //txbSumPrice.Text = sum.ToString("c", culture); MessageBox.Show("tt" + txbSumPrice.Text);
            txbSumPrice.Text = sum.ToString();
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
            else
            {
                MessageBox.Show("Bàn "+id1+" Trống");
            }
        }

        void LoadClientWhereTagTable(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBill.Tag = (sender as Button).Tag;

            if (((sender as Button).Tag as Table).Status.Equals("Có người"))
            {
                List<Account> listClient = ClientDAO.Instance.GetClientByIDTable(tableID);
                cbClient.DataSource = listClient;
                cbClient.DisplayMember = "Name";

            }
            else
            {
                LoadClient();
            }
        }

        void LoadFood(int id)
        {
            if (LoadFoodListByCategory(id) > 0)
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
                cbFood.Text = "";
                //   cbClient.Text="";
                lb1.Text = "Không có món ăn nào thuộc loại này \n phải có món ăn để thêm món\n hãy chọn loại món ăn khác";
                lb1.Show();
            }
        }

        void AddFood(int x)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null) return;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = ((int)nmAddcount.Value) * x;
            string clientid = (cbClient.SelectedItem as Account).UserName.ToString();

            // idBill == -1&&x>0 nghĩa là Table nếu trống, không người thì không xóa đựợc món ăn vì không có

            if (idBill == -1 && x > 0)
            {
                BillDAO.Instance.InsertBill(table.Id, clientid);
                BillInfoDAO.Instance.IsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
                LoadOneTableChange(table.Id);
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
            float sumprice = float.Parse(txbSumPrice.Text); 
            int discount = (int)nmDisCount.Value;
            float sum = ShowBill(table.Id);

            CultureInfo culture = new CultureInfo("vi-VN");
            //txbSumPrice.Text = sum.ToString("c", culture);
            txbSumPrice.Text = sum.ToString();
        }


        private void cbCaterogy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cần chọn vào cbCategory + F4 + <chọn dấu tia sét trên đầu> +  SelectedIndexChanged<đúp chuột> để khởi động


            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            int id = selected.ID;
            LoadFood(id);

        }



        private int a, b;
        void Btn_Click(object sender, EventArgs e)
        {
            //this.flpTable.Size = new System.Drawing.Size(561, 667);
            //panel1.Show();
            //panel2.Show();
            //panel3.Show();
            //     this.ClientSize = new System.Drawing.Size(1189, 722);
            
            lbTAble.Text = ((sender as Button).Tag as Table).Name;
            int tableID = ((sender as Button).Tag as Table).Id;
            a = b;b = tableID;
            LoadClientWhereTagTable(sender, e);
            LoadOneTable(((sender as Button).Tag as Table));
            ShowBill(tableID);
            //       throw new NotImplementedException();
            if (btnSwithTable.BackColor == Color.Blue)
            {
                LoadTwoTable(a, b);
            }
            pnBill.Size = new Size(759, 699);
        }
        private void F_fUpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
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
            
        }


        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.fUpdateAccount += F_fUpdateAccount;//Chuyển dữ liệu từ form con(fAcconutProfile_đổi thông tin tài khoản) đến form cha(fManager_Form chinh)
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = loginAccount;
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadTable();
            LoadCategory();
            LoadClient();
            

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
            
            //btnSwithTable.Text= "Chuyển Bàn";

            int id1 = a;
            
            int id2 = b;

            if (btnSwithTable.BackColor ==Color.Blue)
            {
                LoadTwoTable(a, b);
                if (MessageBox.Show(string.Format("Bạn có chắc chuyển bàn {0} sang bàn {1}", id1, id2), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    SwichTable(id1, id2);
                    LoadOneTableChange(id1);
                    LoadOneTableChange(id2);
                }
                btnSwithTable.BackColor = Color.Gainsboro;
                btnSwithTable.FlatStyle = btnAddFood.FlatStyle;
                btnSwithTable.FlatAppearance.BorderColor = btnAddFood.FlatAppearance.BorderColor;
                btnSwithTable.FlatAppearance.BorderSize = 1;
            }
            else
            {
                btnSwithTable.BackColor = Color.Blue;
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

            
            float sumprice = float.Parse(txbSumPrice.Text);
            int discount = (int)nmDisCount.Value;
            float sum = sumprice - (sumprice / 100) * discount;

           
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\n Tổng tiền - (Tông tiền /100)* Giảm giá =\n{1} -({1}/100)*{2} = {3}", table.Name, sumprice, discount, sum), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {

                    CheckBill(idBill, sum, discount);

                    if (table == null) return;
                    ShowBill(table.Id);
                    table.Status = "Có người";
                    LoadOneTableChange(table.Id);

                }

            }
        }
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null) return;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            float sumprice = float.Parse(txbSumPrice.Text);
            int discount = (int)nmDisCount.Value;
            float sum = sumprice - (sumprice / 100) * discount;
            if (idBill != -1)
            {
                if (BillDAO.Instance.Changediscount(discount, idBill))
                {
                    PrintBill f = new PrintBill(table.Id, idBill, sum, discount);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    LoadOneTableChange(table.Id);
                    LoadCategory();
                    LoadClient();
                   
                }

            }
        }
        private void btnDeleteTableBill_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null) return;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc Hủy hóa đơn cho bàn {0}", table.Id), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    DeleteTableBill(idBill);
                    if (table == null) return;
                    ShowBill(table.Id);
                    //table.Status="Có người";
                    LoadOneTableChange(table.Id);
                }

            }
        }


        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                List<Category> listCategory = CategoryDAO.Instance.GetListCategoryByFoodName(lsvBill.SelectedItems[0].SubItems[0].Text);
                cbCaterogy.DataSource = listCategory;
                cbCaterogy.DisplayMember = "Name";
                List<Food> listFood = FoodDAO.Instance.GetFoodByName(lsvBill.SelectedItems[0].SubItems[0].Text);
                cbFood.DataSource = listFood;
                cbFood.DisplayMember = "Name";


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



        #region TestColor
        //void ChangeColor()
        //{

        //    NumericUpDown nm1 = new NumericUpDown();

        //    nm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(63)));
        //    nm1.Location = new System.Drawing.Point(491, 13);
        //    nm1.Name = "nmAddcount1";
        //    nm1.ReadOnly = true;
        //    nm1.Size = new System.Drawing.Size(58, 17);
        //    nm1.TabIndex = 3;
        //    nm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        //    nm1.Maximum = 300;
        //    nm1.Value = new decimal(new int[] {
        //    1,
        //    0,
        //    0,
        //    0});
        //    NumericUpDown nm2 = new NumericUpDown();

        //    nm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(13)));
        //    nm2.Location = new System.Drawing.Point(491, 13);
        //    nm2.Name = "nmAddcount2";
        //    nm2.ReadOnly = true;
        //    nm2.Size = new System.Drawing.Size(58, 17);
        //    nm2.TabIndex = 3;
        //    nm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        //    nm2.Maximum = 300;
        //    nm2.Value = new decimal(new int[] {
        //    1,
        //    0,
        //    0,
        //    0});
        //    NumericUpDown nm3 = new NumericUpDown();

        //    nm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(13)));
        //    nm3.Location = new System.Drawing.Point(491, 13);
        //    nm3.Name = "nmAddcount3";
        //    nm3.ReadOnly = true;
        //    nm3.Size = new System.Drawing.Size(58, 17);
        //    nm3.TabIndex = 3;
        //    nm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        //    nm3.Maximum = 300;
        //    nm3.Value = new decimal(new int[] {
        //    1,
        //    0,
        //    0,
        //    0});

        //    nm1.ValueChanged += Nm1_ValueChanged;
        //    nm2.ValueChanged += Nm2_ValueChanged;
        //    nm3.ValueChanged += Nm3_ValueChanged;


        //    if (flT.Controls.Count < 1)
        //    {
        //        nm1.Value = 255;
        //        nm2.Value = 128;
        //        nm3.Value = 192;
        //        flT.Controls.Add(nm1); flT.Controls.Add(nm3); flT.Controls.Add(nm2);
        //    }

        //nm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)((int)nm1.Value)))), ((int)(((byte)((int)nm2.Value)))), ((int)(((byte)((int)nm2.Value)))));
        //nm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)((int)nm1.Value)))), ((int)(((byte)((int)nm2.Value)))), ((int)(((byte)((int)nm2.Value)))));
        //nm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)((int)nm1.Value)))), ((int)(((byte)((int)nm2.Value)))), ((int)(((byte)((int)nm2.Value)))));
        //flT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)((int)nm1.Value)))), ((int)(((byte)((int)nm2.Value)))), ((int)(((byte)((int)nm2.Value)))));

        //}



        //void LoadColor()
        //{
        //    int[] a = new int[3];
        //    int i = 0;
        //    foreach (NumericUpDown item in flT.Controls)
        //    {

        //        a[i] = (int)item.Value;
        //        i++;
        //    }
        //    if (a.Length == 3)
        //    {
        //        flT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(a[2])))), ((int)(((byte)(a[1])))), ((int)(((byte)(a[0])))));
        //    }

        //}
        //private void Nm3_ValueChanged(object sender, EventArgs e)
        //{
        //    LoadColor();
        //}

        //private void Nm2_ValueChanged(object sender, EventArgs e)
        //{
        //    LoadColor();
        //}

        //private void Nm1_ValueChanged(object sender, EventArgs e)
        //{
        //    LoadColor();
        //}

        #endregion

    }
}
