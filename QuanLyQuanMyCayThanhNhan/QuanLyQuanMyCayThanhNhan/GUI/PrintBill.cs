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

namespace QuanLyQuanMyCayThanhNhan.GUI
{
    public partial class PrintBill : Form
    {
        
        public PrintBill(int idTable, int idBill, float sum, int discount)
        {
            InitializeComponent();
            id =idTable;
            idbill=idBill;
            Sum=sum;
            dis=discount;

        }

        #region MeThod

        private int id;
        private int idbill;
        private float Sum;
        private int dis;
        private void PrintBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanMyCayThanhNhanDataSet4.USP_ReportBill' table. You can move, or remove it, as needed.
            this.uSP_ReportBillTableAdapter.Fill(this.quanLyQuanMyCayThanhNhanDataSet4.USP_ReportBill, id);


            this.reportViewer1.RefreshReport();
        }

        #endregion MeThod


        #region Event

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}", id), "Thông báo", MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                if (BillDAO.Instance.CheckOut(idbill, Sum, dis))
                {
                    MessageBox.Show("Thanh toán thành công");
                    this.Close();

                }
            }
        }
        #endregion Event


    }
}
