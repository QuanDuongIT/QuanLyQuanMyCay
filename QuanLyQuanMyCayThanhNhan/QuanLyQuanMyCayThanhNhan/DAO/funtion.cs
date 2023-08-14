using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DAO
{
    internal class funtion
    {
        private static funtion instance;
        public static funtion Instance
        {
            get { if (instance == null) instance = new funtion(); return funtion.instance; }
            private set { funtion.instance = value; }
        }
        //Liên kết với server Sqlserver
        private funtion() { }


        
        public bool checkDigit(string s)
        {
            for (int i = 0; i<s.Length; i++)
            {
               if (char.IsDigit(s[i]) == true)
                    return true;
            }
            return false;
        }

        public bool checkLetterOrDigit(string s)
        {
            for (int i = 0; i<s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]) == true)
                    return true;
            }
            return false;
        }

        //Kiểm tra xem có kí tự đặc biệt 
        public bool checkNotLetterOrDigit(string s)
        {
            for (int i = 0; i<s.Length; i++)
            {
                if (!char.IsLetterOrDigit(s[i]) == true)
                    return true;
            }
            return false;
        }

        public bool checkLetter(string s)
        {
            for (int i = 0; i<s.Length; i++)
            {
                if (char.IsLetter(s[i]) == true)
                    return true;
            }
            return false;
        }


        public bool checkName(string s)
        {
            for (int i = 0; i<s.Length; i++)
            {
                if (!char.IsLetter(s[i])&&!s[i].Equals(' '))
                    return false;
            }
            return true;
        }
        public bool checkPhone(string s)
        {
            for (int i = 0; i<s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                    return false;
            }
            return true;
        }

    }
}
