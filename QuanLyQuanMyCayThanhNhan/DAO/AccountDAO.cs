using QuanLyQuanMyCayThanhNhan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanMyCayThanhNhan.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        { 
            get { 
                if (instance==null) 
                    instance=new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public string Encode(string passWord)
        {
            //Mã hóa mật khẩu
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass+=item;
            }

            return hasPass;
        }
        public bool Login(string userName, string passWord)
        {
            
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExexuteQuery(query,new object[] {userName,Encode(passWord)});
            
            return result.Rows.Count>0;
        }

        public bool UpdateAccount(string userName,string displayName, string pass,string newpass)
        {
            int result = DataProvider.Instance.ExexuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newpassword ",new object[] { userName, displayName, Encode(pass), Encode(newpass) });
            return result>0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExexuteQuery("select UserName, DisPlayName,Type from dbo.Account");
        }

        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExexuteQuery("select * from account where userName ='"+username+"'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item); 
            }
            return null;
        }

        public bool InsertAccount(string name,string displayName,int type)
        {
            //   MessageBox.Show(""+DataProvider.Instance.ExexuteQuery("select * from Account where userName = '"+name+"'").Rows.Count);

            if (DataProvider.Instance.ExexuteQuery("select * from Account where userName = '"+name+"'").Rows.Count==0)
            {
                string query = string.Format("insert dbo.Account ( UserName, DisplayName,Password, Type ) values ( N'{0}' , N'{1}',N'1962026656160185351301320480154111117132155' ,{2} )", name, displayName, type);
                int result = DataProvider.Instance.ExexuteNonQuery(query);
                return result>0;
            }

            return false;

        }
        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("update dbo.Account set  DisplayName=N'{1}' ,  Type={2}  where UserName=N'{0}' ", name, displayName, type);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
            
        }

        public bool DeleteAccount(string name)
        {
          //    MessageBox.Show(""+name);
            string query = string.Format("Delete Account where UserName = N'{0}' ", name);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }

        public bool RessetpassAccount(string name)
        {
            string query = string.Format("update dbo.Account set  PassWord=N'1962026656160185351301320480154111117132155'  where UserName=N'{0}' ", name);
            int result = DataProvider.Instance.ExexuteNonQuery(query);
            return result>0;
        }

       
        
    }
}
