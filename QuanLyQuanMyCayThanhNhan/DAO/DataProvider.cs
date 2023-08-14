using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DAO
{
    //Singleton
    internal class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance {
            get { if (instance == null) instance = new DataProvider();return  DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        //Liên kết với server Sqlserver
        private DataProvider() { }
        /// <summary>
        ///  server name= .\sqlexpress
        /// </summary>
        /// 
        private string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyQuanMyCayThanhNhan;Integrated Security=True";
        //private string connectionSTR = @"Data Source=DESKTOP-LI3E1NS\SQLEXPRESS;Initial Catalog=QuanLyQuanMyCayThanhNhan;Integrated Security=True";



        //chuỗi xác định kết nối với server
        public DataTable ExexuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            // using tự giải phóng bộ nhớ
            using (SqlConnection connection = new SqlConnection(connectionSTR))//Kết nối từ client - server
            {
                connection.Open();//Mở connection ra

                SqlCommand command = new SqlCommand(query, connection);//Câu truy vấn để  thực thi

                if (parameter !=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                //   command.Parameters.AddWithValue("@userName", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);//Trung gian lấy dữ liệu ra

                adapter.Fill(data);// đổ dl ra

                connection.Close();// Dữ liệu connection lại

            }

            return data;

        }

        public int ExexuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            // using tự giải phóng bộ nhớ
            using (SqlConnection connection = new SqlConnection(connectionSTR))//Kết nối từ client - server
            {
                connection.Open();//Mở connection ra

                SqlCommand command = new SqlCommand(query, connection);//Câu truy vấn để  thực thi

                if (parameter !=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data=command.ExecuteNonQuery();

                connection.Close();// Dữ liệu connection lại

            }

            return data;

        }

        public object ExexuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            // using tự giải phóng bộ nhớ
            using (SqlConnection connection = new SqlConnection(connectionSTR))//Kết nối từ client - server
            {
                connection.Open();//Mở connection ra

                SqlCommand command = new SqlCommand(query, connection);//Câu truy vấn để  thực thi

                if (parameter !=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data=command.ExecuteScalar();

                connection.Close();
            }

            return data;

        }

        //public ListBox ExexuteQuery(object value)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
