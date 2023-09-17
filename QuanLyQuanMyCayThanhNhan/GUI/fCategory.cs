using QuanLyQuanMyCayThanhNhan.DAO;
using QuanLyQuanMyCayThanhNhan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanMyCayThanhNhan
{
    public partial class fCategory : Form
    {
        BindingSource FoodCategoryList = new BindingSource();
        BindingSource FoodList = new BindingSource();
        BindingSource ClientList = new BindingSource();

        public fCategory()
        {
            InitializeComponent();
            Load();
        }

        #region Method
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodListByName(name);
            return listFood;
        }


        void Load()
        {
            dtgvFoodCategory.DataSource=FoodCategoryList;
            AddFoodCategoryBinding();
            LoadFoodCategory();

            dtgvFood.DataSource=FoodList;
            dtgvFood.Columns["Column8"].Visible= false;
            dtgvFood.Columns["Column9"].Visible= false;
            AddFoodBinding();
            LoadFood();
            LoadCategoryIntoCombobox(cbCategory);

            dtgvClient.DataSource = ClientList;
            AddClientBinding();
            LoadClient();
            dtgvClient.Columns["Column3"].Visible = false;
            dtgvClient.Columns["Column13"].Visible = false;
            dtgvClient.Columns["Column4"].Visible = false;
            panel6.Size = new System.Drawing.Size(0, 0);
        }

        void AddFoodCategoryBinding()
        {
            txbIDFoodCategory.DataBindings.Add(new Binding("Text", dtgvFoodCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbFoodCategoryName.DataBindings.Add(new Binding("Text", dtgvFoodCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            

        }
        void LoadFoodCategory()
        {
            FoodCategoryList.DataSource=CategoryDAO.Instance.GetListCategory();

        }

        void AddFoodBinding()
        {
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            //    cbCategory.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "CategoryId", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));
           nmQuantity.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Quantity1", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox comboBox)
        {
            cbCategory.DataSource=CategoryDAO.Instance.GetListCategory();
            comboBox.DisplayMember="Name";
            
        }

        void LoadFood()
        {
            FoodList.DataSource=FoodDAO.Instance.GetListFood();

            LoadFoodCategory();
        }

        void AddClientBinding()
        {
            txbClientID.DataBindings.Add(new Binding("Text", dtgvClient.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbClientName.DataBindings.Add(new Binding("Text", dtgvClient.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txbClientAddress.DataBindings.Add(new Binding("Text", dtgvClient.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txbClientPhone.DataBindings.Add(new Binding("Text", dtgvClient.DataSource, "phone", true, DataSourceUpdateMode.Never));
            cbGender.DataBindings.Add(new Binding("Text", dtgvClient.DataSource, "gender", true, DataSourceUpdateMode.Never));
            
        }



        void LoadClient()
        {
            ClientList.DataSource=ClientDAO.Instance.GetListClient();
        }

        #endregion MeThod


        #region Event
        
        private void btnAddFoodCategory_Click(object sender, EventArgs e)
        {
            string name = txbFoodCategoryName.Text;
            if (CategoryDAO.Instance.InsertFoodCategory(name))
            {
                MessageBox.Show("Thêm thành công");
                LoadCategoryIntoCombobox(cbCategory);
                LoadFood();
            }
            else
            {
                MessageBox.Show("Thêm thất bại\n Không được trùng  tên");
            }
            LoadFoodCategory();
        }

        private void btnDeleteFoodCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDFoodCategory.Text);
            if (CategoryDAO.Instance.DeleteFoodCategory(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadCategoryIntoCombobox(cbCategory);
                LoadFood();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            LoadFoodCategory();

        }

        private void btnEditFoodCategory_Click(object sender, EventArgs e)
        {
            string name = txbFoodCategoryName.Text;
            int id = Convert.ToInt32(txbIDFoodCategory.Text);
            if (CategoryDAO.Instance.UpdateFoodCategory(id, name))
            {
                MessageBox.Show("Sửa thành công");
                LoadCategoryIntoCombobox(cbCategory);
                LoadFood();
            }
            else
            {
                MessageBox.Show("Sửa thất bại\n Không được trùng  tên");
            }
            LoadFoodCategory();

        }

       
        private void btnAddFood_Click(object sender, EventArgs e)
        {

            string name = txbFoodName.Text;
            int idCategory = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int quantity = (int)nmQuantity.Value;
            if (FoodDAO.Instance.InsertFood(name, idCategory, price, quantity ))
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Thêm thất bại\n Không được trùng  tên");
            }
            LoadFood();
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);
            string name = txbFoodName.Text;
            int idCategory = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int quantity = (int)nmQuantity.Value;
            if (FoodDAO.Instance.UpdateFood(id, name, idCategory, price, quantity))
            {
                MessageBox.Show("Sửa thành công");
                
            }
            else
            {
                MessageBox.Show("Sửa thất bại\n Không được trùng  tên");
            }
            LoadFood();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Xóa thất bại\n Đã đưa lên hóa đơn");
            }
        }




       
        private void btnSeachFood_Click(object sender, EventArgs e)
        {
            dtgvFood.DataSource=SearchFoodByName(txbSearchFoodName.Text);
        }

       
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string name = txbClientName.Text;
            string address = txbClientAddress.Text;
            string phone = txbClientPhone.Text;
            string gender= cbGender.Text;   
            if (funtion.Instance.checkName(txbClientName.Text))
                if (funtion.Instance.checkPhone(txbClientPhone.Text))
                    if (ClientDAO.Instance.InsertClient(name, address, phone,gender))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadClient();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại không được trùng số điện thoại");
                    }
                else
                MessageBox.Show("Thêm thất bại số điện thoại có kí tự đặc biệt hoặc chữ");
            else
            MessageBox.Show("Thêm thất bại tên có kí tự đặc biệt hoặc số");

        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            string id = txbClientID.Text;
            string name = txbClientName.Text;
            string address = txbClientAddress.Text;
            string phone = txbClientPhone.Text;
            string gender = cbGender.Text;
            if (funtion.Instance.checkName(txbClientName.Text))
                if (funtion.Instance.checkPhone(txbClientPhone.Text))
                    if (ClientDAO.Instance.UpdateClient(id, name, address, phone,gender))
                    {
                        MessageBox.Show("Sửa thành công");
                        LoadClient();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại không được trùng số điện thoại");
                    }
                else
                    MessageBox.Show("Sửa thất bại số điện thoại có kí tự đặc biệt hoặc chữ");
            else
                MessageBox.Show("Sửa thất bại tên có kí tự đặc biệt hoặc số");

            
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            string id = txbClientID.Text;
            if (ClientDAO.Instance.DeleteClent(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadClient();
            }
            else
            {
                MessageBox.Show("Xóa thất bại\n Đã đưa lên hóa đơn");
            }
        }


        private void cbCategory_MouseClick(object sender, MouseEventArgs e)
        {
            LoadCategoryIntoCombobox(cbCategory);
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            cbCategory.DataSource=CategoryDAO.Instance.GetCategoryByFoodName(txbFoodName.Text);
            cbCategory.DisplayMember="Name";
        }

        private void cbGender_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("Nam"); list.Add("Nữ");
            cbGender.DataSource = list;
        }

        #endregion Event

       
        
        
    }
}
