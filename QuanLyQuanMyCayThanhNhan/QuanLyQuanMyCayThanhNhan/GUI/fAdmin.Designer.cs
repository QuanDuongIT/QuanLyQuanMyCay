using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanMyCayThanhNhan
{
    partial class fAdmin
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uSPGetListBillByDateBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanMyCayThanhNhanDataSet1 = new QuanLyQuanMyCayThanhNhan.QuanLyQuanMyCayThanhNhanDataSet1();
            this.uSPGetListBillByDateBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tbpAccount = new System.Windows.Forms.TabPage();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.btnResetPassWord = new System.Windows.Forms.Button();
            this.panel30 = new System.Windows.Forms.Panel();
            this.nmudAccount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txbDisPlayName = new System.Windows.Forms.TextBox();
            this.panel32 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpStatistical = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.txbPageBill = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevioursBillPage = new System.Windows.Forms.Button();
            this.btnLastBillPage = new System.Windows.Forms.Button();
            this.btnFirstBillPage = new System.Windows.Forms.Button();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpReport = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSPGetListBillByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GetListBillByDateTableAdapter = new QuanLyQuanMyCayThanhNhan.QuanLyQuanMyCayThanhNhanDataSet1TableAdapters.USP_GetListBillByDateTableAdapter();
            this.uSPGetListBillByDateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSPGetListBillByDateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uSPGetListBillByDateBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanMyCayThanhNhanDataSet = new QuanLyQuanMyCayThanhNhan.QuanLyQuanMyCayThanhNhanDataSet();
            this.uSPGetTableListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GetTableListTableAdapter = new QuanLyQuanMyCayThanhNhan.QuanLyQuanMyCayThanhNhanDataSetTableAdapters.USP_GetTableListTableAdapter();
            this.USP_GetListBillByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource4)).BeginInit();
            this.tbpAccount.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudAccount)).BeginInit();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tbpStatistical.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetTableListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPGetListBillByDateBindingSource5
            // 
            this.uSPGetListBillByDateBindingSource5.DataMember = "USP_GetListBillByDate";
            this.uSPGetListBillByDateBindingSource5.DataSource = this.quanLyQuanMyCayThanhNhanDataSet1;
            // 
            // quanLyQuanMyCayThanhNhanDataSet1
            // 
            this.quanLyQuanMyCayThanhNhanDataSet1.DataSetName = "QuanLyQuanMyCayThanhNhanDataSet1";
            this.quanLyQuanMyCayThanhNhanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPGetListBillByDateBindingSource4
            // 
            this.uSPGetListBillByDateBindingSource4.DataMember = "USP_GetListBillByDate";
            this.uSPGetListBillByDateBindingSource4.DataSource = this.quanLyQuanMyCayThanhNhanDataSet1;
            // 
            // tbpAccount
            // 
            this.tbpAccount.Controls.Add(this.panel22);
            this.tbpAccount.Controls.Add(this.panel29);
            this.tbpAccount.Controls.Add(this.dtgvAccount);
            this.tbpAccount.Location = new System.Drawing.Point(4, 25);
            this.tbpAccount.Name = "tbpAccount";
            this.tbpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAccount.Size = new System.Drawing.Size(1139, 671);
            this.tbpAccount.TabIndex = 2;
            this.tbpAccount.Text = "Thông tin tài khoản";
            this.tbpAccount.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.btnEditAccount);
            this.panel22.Controls.Add(this.btnDeleteAccount);
            this.panel22.Controls.Add(this.btnAddAccount);
            this.panel22.Location = new System.Drawing.Point(660, 24);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(457, 83);
            this.panel22.TabIndex = 8;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(355, 9);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(68, 52);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(195, 9);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(68, 52);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(3, 7);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(68, 52);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.btnResetPassWord);
            this.panel29.Controls.Add(this.panel30);
            this.panel29.Controls.Add(this.panel31);
            this.panel29.Controls.Add(this.panel32);
            this.panel29.Location = new System.Drawing.Point(660, 150);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(457, 458);
            this.panel29.TabIndex = 7;
            // 
            // btnResetPassWord
            // 
            this.btnResetPassWord.Location = new System.Drawing.Point(255, 296);
            this.btnResetPassWord.Name = "btnResetPassWord";
            this.btnResetPassWord.Size = new System.Drawing.Size(159, 36);
            this.btnResetPassWord.TabIndex = 6;
            this.btnResetPassWord.Text = "Khôi phục lại mật khẩu";
            this.btnResetPassWord.UseVisualStyleBackColor = true;
            this.btnResetPassWord.Click += new System.EventHandler(this.btnResetPassWord_Click);
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.nmudAccount);
            this.panel30.Controls.Add(this.label12);
            this.panel30.Location = new System.Drawing.Point(0, 123);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(439, 50);
            this.panel30.TabIndex = 5;
            // 
            // nmudAccount
            // 
            this.nmudAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nmudAccount.Location = new System.Drawing.Point(327, 10);
            this.nmudAccount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudAccount.Name = "nmudAccount";
            this.nmudAccount.ReadOnly = true;
            this.nmudAccount.Size = new System.Drawing.Size(49, 29);
            this.nmudAccount.TabIndex = 3;
            this.nmudAccount.Tag = "";
            this.nmudAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmudAccount.ThousandsSeparator = true;
            this.nmudAccount.ValueChanged += new System.EventHandler(this.nmudAccount_ValueChanged);
            this.nmudAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nmudAccount_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(3, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Loại tài khoản :            ";
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.label13);
            this.panel31.Controls.Add(this.txbDisPlayName);
            this.panel31.Location = new System.Drawing.Point(3, 72);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(439, 35);
            this.panel31.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(3, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tên hiển thị :";
            // 
            // txbDisPlayName
            // 
            this.txbDisPlayName.Location = new System.Drawing.Point(91, 8);
            this.txbDisPlayName.Name = "txbDisPlayName";
            this.txbDisPlayName.Size = new System.Drawing.Size(329, 22);
            this.txbDisPlayName.TabIndex = 1;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.label14);
            this.panel32.Controls.Add(this.txbUserName);
            this.panel32.Location = new System.Drawing.Point(3, 13);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(439, 35);
            this.panel32.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tên tài khoản :";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(91, 8);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(329, 22);
            this.txbUserName.TabIndex = 1;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.DisplayName,
            this.Type});
            this.dtgvAccount.Location = new System.Drawing.Point(5, 24);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowTemplate.Height = 25;
            this.dtgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccount.Size = new System.Drawing.Size(601, 584);
            this.dtgvAccount.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên tài khoản";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 240;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Tên hiển thị";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            this.DisplayName.Width = 240;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.FillWeight = 50F;
            this.Type.HeaderText = "Loại tài khoản";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // tbpStatistical
            // 
            this.tbpStatistical.Controls.Add(this.panel1);
            this.tbpStatistical.Location = new System.Drawing.Point(4, 25);
            this.tbpStatistical.Name = "tbpStatistical";
            this.tbpStatistical.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStatistical.Size = new System.Drawing.Size(1139, 671);
            this.tbpStatistical.TabIndex = 1;
            this.tbpStatistical.Text = "Thống kê";
            this.tbpStatistical.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpkToDate);
            this.panel1.Controls.Add(this.txbPageBill);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevioursBillPage);
            this.panel1.Controls.Add(this.btnLastBillPage);
            this.panel1.Controls.Add(this.btnFirstBillPage);
            this.panel1.Controls.Add(this.btnViewBill);
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 663);
            this.panel1.TabIndex = 2;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(739, 11);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(172, 22);
            this.dtpkToDate.TabIndex = 1;
            // 
            // txbPageBill
            // 
            this.txbPageBill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbPageBill.Location = new System.Drawing.Point(412, 43);
            this.txbPageBill.Name = "txbPageBill";
            this.txbPageBill.ReadOnly = true;
            this.txbPageBill.Size = new System.Drawing.Size(86, 22);
            this.txbPageBill.TabIndex = 7;
            this.txbPageBill.Text = "1";
            this.txbPageBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPageBill.TextChanged += new System.EventHandler(this.txbPageBill_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(755, 43);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 27);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevioursBillPage
            // 
            this.btnPrevioursBillPage.Location = new System.Drawing.Point(136, 42);
            this.btnPrevioursBillPage.Name = "btnPrevioursBillPage";
            this.btnPrevioursBillPage.Size = new System.Drawing.Size(64, 28);
            this.btnPrevioursBillPage.TabIndex = 5;
            this.btnPrevioursBillPage.Text = "Previours";
            this.btnPrevioursBillPage.UseVisualStyleBackColor = true;
            this.btnPrevioursBillPage.Click += new System.EventHandler(this.btnPrevioursBillPage_Click);
            // 
            // btnLastBillPage
            // 
            this.btnLastBillPage.Location = new System.Drawing.Point(847, 42);
            this.btnLastBillPage.Name = "btnLastBillPage";
            this.btnLastBillPage.Size = new System.Drawing.Size(64, 28);
            this.btnLastBillPage.TabIndex = 4;
            this.btnLastBillPage.Text = "Last";
            this.btnLastBillPage.UseVisualStyleBackColor = true;
            this.btnLastBillPage.Click += new System.EventHandler(this.btnLastBillPage_Click);
            // 
            // btnFirstBillPage
            // 
            this.btnFirstBillPage.Location = new System.Drawing.Point(24, 42);
            this.btnFirstBillPage.Name = "btnFirstBillPage";
            this.btnFirstBillPage.Size = new System.Drawing.Size(64, 28);
            this.btnFirstBillPage.TabIndex = 3;
            this.btnFirstBillPage.Text = "First";
            this.btnFirstBillPage.UseVisualStyleBackColor = true;
            this.btnFirstBillPage.Click += new System.EventHandler(this.btnFirstBillPage_Click);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(994, 83);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(74, 64);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thông kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtgvBill
            // 
            this.dtgvBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2});
            this.dtgvBill.Location = new System.Drawing.Point(3, 76);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowTemplate.Height = 25;
            this.dtgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBill.Size = new System.Drawing.Size(908, 584);
            this.dtgvBill.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "Tên bàn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateCheckIn";
            this.Column3.HeaderText = "Ngày Tạo Hóa Đơn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateCheckOut";
            this.Column4.HeaderText = "Ngày Thanh Toán";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "discount";
            this.Column5.HeaderText = "Giảm giá(%)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sumprice";
            this.Column2.HeaderText = "Tổng Tiền Hóa Đơn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpkFromDate);
            this.panel3.Location = new System.Drawing.Point(6, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 25);
            this.panel3.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(3, 3);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(172, 22);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpStatistical);
            this.tabControl1.Controls.Add(this.tbpAccount);
            this.tabControl1.Controls.Add(this.tpReport);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 700);
            this.tabControl1.TabIndex = 0;
            // 
            // tpReport
            // 
            this.tpReport.Controls.Add(this.reportViewer1);
            this.tpReport.Location = new System.Drawing.Point(4, 25);
            this.tpReport.Name = "tpReport";
            this.tpReport.Padding = new System.Windows.Forms.Padding(3);
            this.tpReport.Size = new System.Drawing.Size(1139, 671);
            this.tpReport.TabIndex = 3;
            this.tpReport.Text = "Báo cáo";
            this.tpReport.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource13.Name = "ThongKe";
            reportDataSource13.Value = this.uSPGetListBillByDateBindingSource5;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanMyCayThanhNhan.ReportDataSources.DataReportThongKe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1133, 665);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSPGetListBillByDateBindingSource
            // 
            this.uSPGetListBillByDateBindingSource.DataMember = "USP_GetListBillByDate";
            this.uSPGetListBillByDateBindingSource.DataSource = this.quanLyQuanMyCayThanhNhanDataSet1;
            // 
            // uSP_GetListBillByDateTableAdapter
            // 
            this.uSP_GetListBillByDateTableAdapter.ClearBeforeFill = true;
            // 
            // uSPGetListBillByDateBindingSource1
            // 
            this.uSPGetListBillByDateBindingSource1.DataMember = "USP_GetListBillByDate";
            this.uSPGetListBillByDateBindingSource1.DataSource = this.quanLyQuanMyCayThanhNhanDataSet1;
            // 
            // uSPGetListBillByDateBindingSource2
            // 
            this.uSPGetListBillByDateBindingSource2.DataMember = "USP_GetListBillByDate";
            this.uSPGetListBillByDateBindingSource2.DataSource = this.quanLyQuanMyCayThanhNhanDataSet1;
            // 
            // uSPGetListBillByDateBindingSource3
            // 
            this.uSPGetListBillByDateBindingSource3.DataMember = "USP_GetListBillByDate";
            this.uSPGetListBillByDateBindingSource3.DataSource = this.quanLyQuanMyCayThanhNhanDataSet1;
            // 
            // quanLyQuanMyCayThanhNhanDataSet
            // 
            this.quanLyQuanMyCayThanhNhanDataSet.DataSetName = "QuanLyQuanMyCayThanhNhanDataSet";
            this.quanLyQuanMyCayThanhNhanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPGetTableListBindingSource
            // 
            this.uSPGetTableListBindingSource.DataMember = "USP_GetTableList";
            this.uSPGetTableListBindingSource.DataSource = this.quanLyQuanMyCayThanhNhanDataSet;
            // 
            // uSP_GetTableListTableAdapter
            // 
            this.uSP_GetTableListTableAdapter.ClearBeforeFill = true;
            // 
            // USP_GetListBillByDateBindingSource
            // 
            this.USP_GetListBillByDateBindingSource.DataMember = "USP_GetListBillByDate";
            this.USP_GetListBillByDateBindingSource.DataSource = this.quanLyQuanMyCayThanhNhanDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(929, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng Doanh thu:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 722);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.fAdmin_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource4)).EndInit();
            this.tbpAccount.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudAccount)).EndInit();
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tbpStatistical.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetTableListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tbpAccount;
        private TabPage tbpStatistical;
        private TabControl tabControl1;
        private Panel panel22;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private Panel panel29;
        private Button btnResetPassWord;
        private Panel panel30;
        private Label label12;
        private Panel panel31;
        private Label label13;
        private TextBox txbDisPlayName;
        private Panel panel32;
        private Label label14;
        private TextBox txbUserName;
        private DataGridView dtgvAccount;
        private NumericUpDown nmudAccount;
        private Panel panel1;
        private Button btnViewBill;
        private DataGridView dtgvBill;
        private Panel panel3;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Button btnLastBillPage;
        private Button btnFirstBillPage;
        private TextBox txbPageBill;
        private Button btnNext;
        private Button btnPrevioursBillPage;
        private TabPage tpReport;
        private BindingSource uSPGetListBillByDateBindingSource1;
        private QuanLyQuanMyCayThanhNhanDataSet1 quanLyQuanMyCayThanhNhanDataSet1;
        private BindingSource uSPGetListBillByDateBindingSource;
        private QuanLyQuanMyCayThanhNhanDataSet1TableAdapters.USP_GetListBillByDateTableAdapter uSP_GetListBillByDateTableAdapter;
        private BindingSource uSPGetListBillByDateBindingSource2;
        private BindingSource uSPGetListBillByDateBindingSource3;
        private QuanLyQuanMyCayThanhNhanDataSet quanLyQuanMyCayThanhNhanDataSet;
        private BindingSource uSPGetTableListBindingSource;
        private QuanLyQuanMyCayThanhNhanDataSetTableAdapters.USP_GetTableListTableAdapter uSP_GetTableListTableAdapter;
        private BindingSource uSPGetListBillByDateBindingSource4;
        private BindingSource USP_GetListBillByDateBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BindingSource uSPGetListBillByDateBindingSource5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn DisplayName;
        private DataGridViewTextBoxColumn Type;
        private Label label1;
    }
}