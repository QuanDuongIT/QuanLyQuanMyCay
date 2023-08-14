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
    public partial class fAccountProfile : Form
    {
        
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            loginAccount=acc; ChangeAccount(loginAccount);

        }

        #region MeThod
        void ChangeAccount(Account acc)
        {
            txbUserName.Text=acc.UserName;
            txbDisPlayName.Text=acc.DisplayName;

        }

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount=value; ChangeAccount(loginAccount); }


        }
        void UpdateAccount()
        {
            string displayName = txbDisPlayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPassWord.Text;
            string reenterpass = txbReEnterPass.Text;
            string userName = txbUserName.Text;
            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu đúng với mật khẩu mớ!");
            }
            else
            {
                if (newpass!="")
                {
                    if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        if (updateAccount!=null)
                            updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUsername(userName)));
                    }
                    else
                    {
                        MessageBox.Show("Vui lồng đièn dungd mật khẩu");
                    }
                }
                else
                {
                    if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, password))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        if (updateAccount!=null)
                            updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUsername(userName)));
                    }
                    else
                    {
                        MessageBox.Show("Vui lồng đièn dungd mật khẩu");
                    }
                }
            }
        }
        #endregion MeThod

        #region Event
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> fUpdateAccount
        {
            add { updateAccount += value; } remove { updateAccount -= value; }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUplate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
    public class AccountEvent:EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc=value; }

        public AccountEvent (Account acc)
        {
            this.Acc = acc;
        }
    }
    #endregion Event
}
