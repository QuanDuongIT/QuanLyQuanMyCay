using QuanLyQuanMyCayThanhNhan.DAO;
using QuanLyQuanMyCayThanhNhan.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanMyCayThanhNhan
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
          //  this.panel2.Location = new System.Drawing.Point(3, 147);
            //btnLogin.Hide();
            //btnExit.Hide();
        }

        #region Method

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        #endregion Method

        #region Event


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel)    !=  System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string password = txbPassWord.Text;

            if (Login(userName, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUsername(userName);
                fManagaer f = new fManagaer(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu!");
            }
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            //     this.panel2.Location = new System.Drawing.Point(3, 101);
            btnExit.Show();
            btnLogin.Show();
        }


        #endregion Event

    }

}