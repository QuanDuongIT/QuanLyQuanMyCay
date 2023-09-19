using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanMyCayThanhNhan
{
    partial class fManagaer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phímTắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBill = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSumPrice = new System.Windows.Forms.TextBox();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnSwithTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTAble = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.nmDisCount = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteTableBill = new System.Windows.Forms.Button();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.nmAddcount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCaterogy = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.pnBill.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddcount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.phímTắtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1353, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(132, 21);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // phímTắtToolStripMenuItem
            // 
            this.phímTắtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thêmMónToolStripMenuItem,
            this.xóaMónToolStripMenuItem});
            this.phímTắtToolStripMenuItem.Name = "phímTắtToolStripMenuItem";
            this.phímTắtToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.phímTắtToolStripMenuItem.Text = "Phím tắt";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh Toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click_1);
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thêmMónToolStripMenuItem.Text = "Thêm Món";
            this.thêmMónToolStripMenuItem.Click += new System.EventHandler(this.thêmMónToolStripMenuItem_Click);
            // 
            // xóaMónToolStripMenuItem
            // 
            this.xóaMónToolStripMenuItem.Name = "xóaMónToolStripMenuItem";
            this.xóaMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.xóaMónToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.xóaMónToolStripMenuItem.Text = "Xóa món";
            this.xóaMónToolStripMenuItem.Click += new System.EventHandler(this.xóaMónToolStripMenuItem_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flpTable.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.flpTable.Location = new System.Drawing.Point(43, 43);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(534, 677);
            this.flpTable.TabIndex = 4;
            // 
            // pnBill
            // 
            this.pnBill.Controls.Add(this.panel3);
            this.pnBill.Controls.Add(this.panel1);
            this.pnBill.Location = new System.Drawing.Point(594, 43);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(759, 699);
            this.pnBill.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Location = new System.Drawing.Point(34, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 411);
            this.panel3.TabIndex = 9;
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.SystemColors.Window;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(22, 15);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(657, 393);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSumPrice);
            this.panel1.Controls.Add(this.btnPrintBill);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnSwithTable);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbTAble);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.nmDisCount);
            this.panel1.Controls.Add(this.btnDeleteTableBill);
            this.panel1.Controls.Add(this.cbClient);
            this.panel1.Controls.Add(this.btnDeleteFood);
            this.panel1.Controls.Add(this.nmAddcount);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.cbFood);
            this.panel1.Controls.Add(this.cbCaterogy);
            this.panel1.Location = new System.Drawing.Point(34, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 247);
            this.panel1.TabIndex = 8;
            // 
            // txbSumPrice
            // 
            this.txbSumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSumPrice.Location = new System.Drawing.Point(659, 200);
            this.txbSumPrice.Name = "txbSumPrice";
            this.txbSumPrice.ReadOnly = true;
            this.txbSumPrice.Size = new System.Drawing.Size(10, 31);
            this.txbSumPrice.TabIndex = 7;
            this.txbSumPrice.Visible = false;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Location = new System.Drawing.Point(456, 198);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(96, 34);
            this.btnPrintBill.TabIndex = 8;
            this.btnPrintBill.Text = "In Hóa đơn";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(579, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giảm giá (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên món";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(318, 198);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(96, 34);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnSwithTable
            // 
            this.btnSwithTable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSwithTable.Location = new System.Drawing.Point(25, 197);
            this.btnSwithTable.Name = "btnSwithTable";
            this.btnSwithTable.Size = new System.Drawing.Size(96, 34);
            this.btnSwithTable.TabIndex = 6;
            this.btnSwithTable.Text = "Chuyển Bàn";
            this.btnSwithTable.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loại món";
            // 
            // lbTAble
            // 
            this.lbTAble.AutoSize = true;
            this.lbTAble.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTAble.ForeColor = System.Drawing.Color.Red;
            this.lbTAble.Location = new System.Drawing.Point(346, 101);
            this.lbTAble.Name = "lbTAble";
            this.lbTAble.Size = new System.Drawing.Size(0, 33);
            this.lbTAble.TabIndex = 8;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Red;
            this.lb1.Location = new System.Drawing.Point(349, 42);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 20);
            this.lb1.TabIndex = 7;
            // 
            // nmDisCount
            // 
            this.nmDisCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nmDisCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nmDisCount.Location = new System.Drawing.Point(588, 198);
            this.nmDisCount.Name = "nmDisCount";
            this.nmDisCount.ReadOnly = true;
            this.nmDisCount.Size = new System.Drawing.Size(64, 35);
            this.nmDisCount.TabIndex = 4;
            this.nmDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeleteTableBill
            // 
            this.btnDeleteTableBill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteTableBill.Location = new System.Drawing.Point(168, 198);
            this.btnDeleteTableBill.Name = "btnDeleteTableBill";
            this.btnDeleteTableBill.Size = new System.Drawing.Size(96, 34);
            this.btnDeleteTableBill.TabIndex = 6;
            this.btnDeleteTableBill.Text = "Hủy bàn";
            this.btnDeleteTableBill.UseVisualStyleBackColor = false;
            // 
            // cbClient
            // 
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(82, 146);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(212, 21);
            this.cbClient.TabIndex = 5;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteFood.Location = new System.Drawing.Point(474, 50);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(64, 36);
            this.btnDeleteFood.TabIndex = 4;
            this.btnDeleteFood.Text = "Xóa món";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            // 
            // nmAddcount
            // 
            this.nmAddcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nmAddcount.Location = new System.Drawing.Point(554, 50);
            this.nmAddcount.Name = "nmAddcount";
            this.nmAddcount.ReadOnly = true;
            this.nmAddcount.Size = new System.Drawing.Size(45, 35);
            this.nmAddcount.TabIndex = 3;
            this.nmAddcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmAddcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddFood.Location = new System.Drawing.Point(605, 49);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(64, 36);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = false;
            // 
            // cbFood
            // 
            this.cbFood.BackColor = System.Drawing.SystemColors.Window;
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(82, 98);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(212, 21);
            this.cbFood.TabIndex = 1;
            // 
            // cbCaterogy
            // 
            this.cbCaterogy.BackColor = System.Drawing.SystemColors.Window;
            this.cbCaterogy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaterogy.FormattingEnabled = true;
            this.cbCaterogy.Location = new System.Drawing.Point(82, 50);
            this.cbCaterogy.Name = "cbCaterogy";
            this.cbCaterogy.Size = new System.Drawing.Size(212, 21);
            this.cbCaterogy.TabIndex = 0;
            // 
            // fManagaer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1353, 754);
            this.Controls.Add(this.pnBill);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fManagaer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán mì cay Thanh Nhàn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnBill.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem phímTắtToolStripMenuItem;
        private ToolStripMenuItem thanhToánToolStripMenuItem;
        private ToolStripMenuItem thêmMónToolStripMenuItem;
        private ToolStripMenuItem xóaMónToolStripMenuItem;
        private FlowLayoutPanel flpTable;
        private Panel pnBill;
        private Panel panel3;
        private ListView lsvBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Panel panel1;
        private TextBox txbSumPrice;
        private Button btnPrintBill;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button btnCheckOut;
        private Button btnSwithTable;
        private Label label3;
        private Label lbTAble;
        private Label lb1;
        private NumericUpDown nmDisCount;
        private Button btnDeleteTableBill;
        private ComboBox cbClient;
        private Button btnDeleteFood;
        private NumericUpDown nmAddcount;
        private Button btnAddFood;
        private ComboBox cbFood;
        private ComboBox cbCaterogy;
    }
}