using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanMyCayThanhNhan.DTO
{
    public class Bill
    {
        public Bill(int id,DateTime? dateCheckin,DateTime? dateCheckout,int status,float sumprice=0,int discount=0) 
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckout;
            this.Status= status;
            this.Sumprice= sumprice;
            this.discount= discount;
        }

        public Bill(DataRow row) 
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];
            var dateCheckOutTemp = row["dateCheckout"];
            if (dateCheckOutTemp.ToString()!= "")//Giải quyết null
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.status= (int)row["status"];
            this.Sumprice = (float)Convert.ToDouble(row["sumprice"].ToString());
            this.discount=(int)row["discount"];
        }

        private int discount;
        private float sumprice;
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;

        public int Status
        {
            get { return status; }
            set { status=value; }
        }
        public DateTime? DateCheckOut {
            get { return dateCheckOut; } 
            set { dateCheckOut = value; } 
        }
        public DateTime? DateCheckIn {
            get { return dateCheckIn; } 
            set { dateCheckIn=value; }
        }
        public int ID{
            get { return iD; }
            set { iD=value; }
        }

        public int Discount { get => discount; set => discount=value; }
        public float Sumprice { get => sumprice; set => sumprice=value; }
    }
}
