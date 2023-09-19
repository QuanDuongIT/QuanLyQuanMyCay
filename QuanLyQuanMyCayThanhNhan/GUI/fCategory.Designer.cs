using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanMyCayThanhNhan
{
    partial class fCategory
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpFood = new System.Windows.Forms.TabPage();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSeachFood = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.tbpClient = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txbClientID = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txbClientPhone = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txbClientAddress = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dtgvClient = new System.Windows.Forms.DataGridView();
            this.tbpFoodCategory = new System.Windows.Forms.TabPage();
            this.dtgvFoodCategory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIDFoodCategory = new System.Windows.Forms.TextBox();
            this.panel32 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txbFoodCategoryName = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnEditFoodCategory = new System.Windows.Forms.Button();
            this.btnDeleteFoodCategory = new System.Windows.Forms.Button();
            this.btnAddFoodCategory = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tbpClient.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClient)).BeginInit();
            this.tbpFoodCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodCategory)).BeginInit();
            this.panel29.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpFood);
            this.tabControl1.Controls.Add(this.tbpClient);
            this.tabControl1.Controls.Add(this.tbpFoodCategory);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 642);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpFood
            // 
            this.tbpFood.BackColor = System.Drawing.Color.White;
            this.tbpFood.Controls.Add(this.dtgvFood);
            this.tbpFood.Controls.Add(this.panel2);
            this.tbpFood.Location = new System.Drawing.Point(4, 25);
            this.tbpFood.Name = "tbpFood";
            this.tbpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFood.Size = new System.Drawing.Size(1115, 613);
            this.tbpFood.TabIndex = 0;
            this.tbpFood.Text = "Danh sách thức ăn";
            // 
            // dtgvFood
            // 
            this.dtgvFood.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column7,
            this.Column14});
            this.dtgvFood.Location = new System.Drawing.Point(9, 5);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.ReadOnly = true;
            this.dtgvFood.RowTemplate.Height = 25;
            this.dtgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFood.Size = new System.Drawing.Size(601, 584);
            this.dtgvFood.TabIndex = 1;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Name";
            this.Column6.HeaderText = "Tên thức ăn";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 380;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID";
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "CategoryID";
            this.Column9.HeaderText = "CategoryID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Price";
            this.Column7.HeaderText = "Giá";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Quantity1";
            this.Column14.HeaderText = "Số lượng";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.txbSearchFoodName);
            this.panel2.Controls.Add(this.btnSeachFood);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(625, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 571);
            this.panel2.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.nmQuantity);
            this.panel13.Controls.Add(this.label11);
            this.panel13.Location = new System.Drawing.Point(36, 348);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(384, 35);
            this.panel13.TabIndex = 10;
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(93, 9);
            this.nmQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(277, 22);
            this.nmQuantity.TabIndex = 3;
            this.nmQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Số lượng :";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.nmFoodPrice);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Location = new System.Drawing.Point(36, 293);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(384, 35);
            this.panel12.TabIndex = 9;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(93, 9);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(277, 22);
            this.nmFoodPrice.TabIndex = 3;
            this.nmFoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá :";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.cbCategory);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Location = new System.Drawing.Point(36, 239);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(384, 35);
            this.panel11.TabIndex = 8;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(91, 8);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(279, 24);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbCategory_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh mục :";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.txbFoodName);
            this.panel10.Location = new System.Drawing.Point(36, 189);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(384, 35);
            this.panel10.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món :";
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(91, 8);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(279, 22);
            this.txbFoodName.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.txbFoodID);
            this.panel9.Location = new System.Drawing.Point(36, 127);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(384, 35);
            this.panel9.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID :";
            // 
            // txbFoodID
            // 
            this.txbFoodID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbFoodID.Location = new System.Drawing.Point(91, 8);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(279, 22);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Location = new System.Drawing.Point(36, 16);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(230, 22);
            this.txbSearchFoodName.TabIndex = 4;
            // 
            // btnSeachFood
            // 
            this.btnSeachFood.Location = new System.Drawing.Point(288, 7);
            this.btnSeachFood.Name = "btnSeachFood";
            this.btnSeachFood.Size = new System.Drawing.Size(118, 36);
            this.btnSeachFood.TabIndex = 3;
            this.btnSeachFood.Text = "Tìm kiếm";
            this.btnSeachFood.UseVisualStyleBackColor = true;
            this.btnSeachFood.Click += new System.EventHandler(this.btnSeachFood_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnEditFood);
            this.panel7.Controls.Add(this.btnDeleteFood);
            this.panel7.Controls.Add(this.btnAddFood);
            this.panel7.Location = new System.Drawing.Point(36, 49);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(384, 63);
            this.panel7.TabIndex = 2;
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(162, 7);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(68, 52);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(302, 7);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(68, 52);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(20, 7);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(68, 52);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // tbpClient
            // 
            this.tbpClient.Controls.Add(this.panel8);
            this.tbpClient.Controls.Add(this.panel6);
            this.tbpClient.Controls.Add(this.panel5);
            this.tbpClient.Controls.Add(this.panel4);
            this.tbpClient.Controls.Add(this.panel3);
            this.tbpClient.Controls.Add(this.btnEditClient);
            this.tbpClient.Controls.Add(this.btnDeleteClient);
            this.tbpClient.Controls.Add(this.btnAddClient);
            this.tbpClient.Controls.Add(this.dtgvClient);
            this.tbpClient.Location = new System.Drawing.Point(4, 25);
            this.tbpClient.Name = "tbpClient";
            this.tbpClient.Padding = new System.Windows.Forms.Padding(3);
            this.tbpClient.Size = new System.Drawing.Size(1115, 613);
            this.tbpClient.TabIndex = 1;
            this.tbpClient.Text = "Danh sách khách hàng";
            this.tbpClient.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.cbGender);
            this.panel8.Location = new System.Drawing.Point(636, 376);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(466, 35);
            this.panel8.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Giới tính :";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(125, 6);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(329, 24);
            this.cbGender.TabIndex = 6;
            this.cbGender.Click += new System.EventHandler(this.cbGender_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.txbClientID);
            this.panel6.Location = new System.Drawing.Point(636, 129);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(466, 35);
            this.panel6.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "ID :";
            // 
            // txbClientID
            // 
            this.txbClientID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbClientID.Location = new System.Drawing.Point(125, 8);
            this.txbClientID.Name = "txbClientID";
            this.txbClientID.ReadOnly = true;
            this.txbClientID.Size = new System.Drawing.Size(329, 22);
            this.txbClientID.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txbClientPhone);
            this.panel5.Location = new System.Drawing.Point(636, 303);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 35);
            this.panel5.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số điện thoại :";
            // 
            // txbClientPhone
            // 
            this.txbClientPhone.Location = new System.Drawing.Point(125, 5);
            this.txbClientPhone.Name = "txbClientPhone";
            this.txbClientPhone.Size = new System.Drawing.Size(329, 22);
            this.txbClientPhone.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txbClientAddress);
            this.panel4.Location = new System.Drawing.Point(636, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 57);
            this.panel4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa chỉ :";
            // 
            // txbClientAddress
            // 
            this.txbClientAddress.Location = new System.Drawing.Point(125, 8);
            this.txbClientAddress.Name = "txbClientAddress";
            this.txbClientAddress.Size = new System.Drawing.Size(329, 22);
            this.txbClientAddress.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txbClientName);
            this.panel3.Location = new System.Drawing.Point(636, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 35);
            this.panel3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên khách hàng :";
            // 
            // txbClientName
            // 
            this.txbClientName.Location = new System.Drawing.Point(125, 8);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.Size = new System.Drawing.Size(329, 22);
            this.txbClientName.TabIndex = 1;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(829, 48);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(68, 52);
            this.btnEditClient.TabIndex = 3;
            this.btnEditClient.Text = "Sửa";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(997, 48);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(68, 52);
            this.btnDeleteClient.TabIndex = 2;
            this.btnDeleteClient.Text = "Xóa";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(642, 48);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(68, 52);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Thêm";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dtgvClient
            // 
            this.dtgvClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column13,
            this.Column4,
            this.Column5,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dtgvClient.Location = new System.Drawing.Point(15, 0);
            this.dtgvClient.Name = "dtgvClient";
            this.dtgvClient.ReadOnly = true;
            this.dtgvClient.RowTemplate.Height = 25;
            this.dtgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvClient.Size = new System.Drawing.Size(601, 584);
            this.dtgvClient.TabIndex = 0;
            // 
            // tbpFoodCategory
            // 
            this.tbpFoodCategory.Controls.Add(this.dtgvFoodCategory);
            this.tbpFoodCategory.Controls.Add(this.panel29);
            this.tbpFoodCategory.Controls.Add(this.panel22);
            this.tbpFoodCategory.Location = new System.Drawing.Point(4, 25);
            this.tbpFoodCategory.Name = "tbpFoodCategory";
            this.tbpFoodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFoodCategory.Size = new System.Drawing.Size(1115, 613);
            this.tbpFoodCategory.TabIndex = 2;
            this.tbpFoodCategory.Text = "Danh sách loại món ăn";
            this.tbpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // dtgvFoodCategory
            // 
            this.dtgvFoodCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvFoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFoodCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgvFoodCategory.Location = new System.Drawing.Point(16, 16);
            this.dtgvFoodCategory.Name = "dtgvFoodCategory";
            this.dtgvFoodCategory.ReadOnly = true;
            this.dtgvFoodCategory.RowTemplate.Height = 25;
            this.dtgvFoodCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFoodCategory.Size = new System.Drawing.Size(601, 584);
            this.dtgvFoodCategory.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 237;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Tên loại món ăn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 330;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.panel1);
            this.panel29.Controls.Add(this.panel32);
            this.panel29.Location = new System.Drawing.Point(638, 83);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(456, 517);
            this.panel29.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbIDFoodCategory);
            this.panel1.Location = new System.Drawing.Point(19, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 35);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID :";
            // 
            // txbIDFoodCategory
            // 
            this.txbIDFoodCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbIDFoodCategory.Location = new System.Drawing.Point(146, 8);
            this.txbIDFoodCategory.Name = "txbIDFoodCategory";
            this.txbIDFoodCategory.ReadOnly = true;
            this.txbIDFoodCategory.Size = new System.Drawing.Size(282, 22);
            this.txbIDFoodCategory.TabIndex = 1;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.label14);
            this.panel32.Controls.Add(this.txbFoodCategoryName);
            this.panel32.Location = new System.Drawing.Point(19, 81);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(431, 35);
            this.panel32.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(18, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tên loại món ăn :";
            // 
            // txbFoodCategoryName
            // 
            this.txbFoodCategoryName.Location = new System.Drawing.Point(146, 5);
            this.txbFoodCategoryName.Name = "txbFoodCategoryName";
            this.txbFoodCategoryName.Size = new System.Drawing.Size(282, 22);
            this.txbFoodCategoryName.TabIndex = 1;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.btnEditFoodCategory);
            this.panel22.Controls.Add(this.btnDeleteFoodCategory);
            this.panel22.Controls.Add(this.btnAddFoodCategory);
            this.panel22.Location = new System.Drawing.Point(638, 16);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(456, 62);
            this.panel22.TabIndex = 9;
            // 
            // btnEditFoodCategory
            // 
            this.btnEditFoodCategory.Location = new System.Drawing.Point(362, 7);
            this.btnEditFoodCategory.Name = "btnEditFoodCategory";
            this.btnEditFoodCategory.Size = new System.Drawing.Size(68, 52);
            this.btnEditFoodCategory.TabIndex = 2;
            this.btnEditFoodCategory.Text = "Sửa";
            this.btnEditFoodCategory.UseVisualStyleBackColor = true;
            this.btnEditFoodCategory.Click += new System.EventHandler(this.btnEditFoodCategory_Click);
            // 
            // btnDeleteFoodCategory
            // 
            this.btnDeleteFoodCategory.Location = new System.Drawing.Point(203, 7);
            this.btnDeleteFoodCategory.Name = "btnDeleteFoodCategory";
            this.btnDeleteFoodCategory.Size = new System.Drawing.Size(68, 52);
            this.btnDeleteFoodCategory.TabIndex = 1;
            this.btnDeleteFoodCategory.Text = "Xóa";
            this.btnDeleteFoodCategory.UseVisualStyleBackColor = true;
            this.btnDeleteFoodCategory.Click += new System.EventHandler(this.btnDeleteFoodCategory_Click);
            // 
            // btnAddFoodCategory
            // 
            this.btnAddFoodCategory.Location = new System.Drawing.Point(3, 7);
            this.btnAddFoodCategory.Name = "btnAddFoodCategory";
            this.btnAddFoodCategory.Size = new System.Drawing.Size(68, 52);
            this.btnAddFoodCategory.TabIndex = 0;
            this.btnAddFoodCategory.Text = "Thêm";
            this.btnAddFoodCategory.UseVisualStyleBackColor = true;
            this.btnAddFoodCategory.Click += new System.EventHandler(this.btnAddFoodCategory_Click);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Password";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 5;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Role";
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 5;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "UserName";
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 5;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DisplayName";
            this.Column5.HeaderText = "Tên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Address";
            this.Column10.HeaderText = "Địa chỉ";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 210;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "phone";
            this.Column11.HeaderText = "SDT";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Gender";
            this.Column12.HeaderText = "Giới tính";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // fCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 722);
            this.Controls.Add(this.tabControl1);
            this.Name = "fCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục";
            this.tabControl1.ResumeLayout(false);
            this.tbpFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tbpClient.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClient)).EndInit();
            this.tbpFoodCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodCategory)).EndInit();
            this.panel29.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpFood;
        private TabPage tbpClient;
        private TabPage tbpFoodCategory;
        private Panel panel22;
        private Button btnEditFoodCategory;
        private Button btnDeleteFoodCategory;
        private Button btnAddFoodCategory;
        private DataGridView dtgvFoodCategory;
        private Panel panel29;
        private Panel panel32;
        private Label label14;
        private TextBox txbFoodCategoryName;
        private Panel panel1;
        private Label label1;
        private TextBox txbIDFoodCategory;
        private DataGridView dtgvFood;
        private Panel panel2;
        private Panel panel12;
        private NumericUpDown nmFoodPrice;
        private Label label5;
        private Panel panel11;
        private ComboBox cbCategory;
        private Label label2;
        private Panel panel10;
        private Label label3;
        private TextBox txbFoodName;
        private Panel panel9;
        private Label label4;
        private TextBox txbFoodID;
        private TextBox txbSearchFoodName;
        private Button btnSeachFood;
        private Panel panel7;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private DataGridView dtgvClient;
        private Panel panel5;
        private Label label8;
        private TextBox txbClientPhone;
        private Panel panel4;
        private Label label7;
        private TextBox txbClientAddress;
        private Panel panel3;
        private Label label6;
        private TextBox txbClientName;
        private Button btnEditClient;
        private Button btnDeleteClient;
        private Button btnAddClient;
        private Panel panel6;
        private Label label9;
        private TextBox txbClientID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel8;
        private Label label10;
        private ComboBox cbGender;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column14;
        private Panel panel13;
        private NumericUpDown nmQuantity;
        private Label label11;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}