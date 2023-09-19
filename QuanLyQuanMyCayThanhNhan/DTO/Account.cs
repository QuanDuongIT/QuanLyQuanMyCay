using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanMyCayThanhNhan.DTO
{
    public class Account
    {
       
        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName =row["displayName"].ToString();
            this.Role = row["role"].ToString();
            
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            this.Gender = row["gender"].ToString();
        }

        public Account(string password, string displayName, string userName, string role, string address, string phone, string gender)
        {
            this.password = password;
            this.displayName = displayName;
            this.userName = userName;
            this.role = role;
            this.address = address;
            this.phone = phone;
            this.gender = gender;
        }

        private string password;
        private string displayName;
        private string userName;
        private string role;
        private string address;
        private string phone;
        private string gender;

        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Role { get => role; set => role = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
