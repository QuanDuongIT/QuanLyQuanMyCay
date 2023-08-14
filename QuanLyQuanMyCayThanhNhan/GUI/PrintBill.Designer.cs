namespace QuanLyQuanMyCayThanhNhan.GUI
{
    partial class PrintBill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uSPReportBillBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanMyCayThanhNhanDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanMyCayThanhNhanDataSet4 = new QuanLyQuanMyCayThanhNhan.QuanLyQuanMyCayThanhNhanDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSPReportBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_ReportBillTableAdapter = new QuanLyQuanMyCayThanhNhan.QuanLyQuanMyCayThanhNhanDataSet4TableAdapters.USP_ReportBillTableAdapter();
            this.uSPReportBillBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyQuanMyCayThanhNhanDataSet = new QuanLyQuanMyCayThanhNhan.QuanLyQuanMyCayThanhNhanDataSet();
            this.quanLyQuanMyCayThanhNhanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_ReportBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReportBillBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReportBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReportBillBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPReportBillBindingSource2
            // 
            this.uSPReportBillBindingSource2.DataMember = "USP_ReportBill";
            this.uSPReportBillBindingSource2.DataSource = this.quanLyQuanMyCayThanhNhanDataSet4BindingSource;
            // 
            // quanLyQuanMyCayThanhNhanDataSet4BindingSource
            // 
            this.quanLyQuanMyCayThanhNhanDataSet4BindingSource.DataSource = this.quanLyQuanMyCayThanhNhanDataSet4;
            this.quanLyQuanMyCayThanhNhanDataSet4BindingSource.Position = 0;
            // 
            // quanLyQuanMyCayThanhNhanDataSet4
            // 
            this.quanLyQuanMyCayThanhNhanDataSet4.DataSetName = "QuanLyQuanMyCayThanhNhanDataSet4";
            this.quanLyQuanMyCayThanhNhanDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReportBill";
            reportDataSource1.Value = this.uSPReportBillBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanMyCayThanhNhan.ReportDataSources.InHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1177, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSPReportBillBindingSource
            // 
            this.uSPReportBillBindingSource.DataMember = "USP_ReportBill";
            this.uSPReportBillBindingSource.DataSource = this.quanLyQuanMyCayThanhNhanDataSet4;
            // 
            // uSP_ReportBillTableAdapter
            // 
            this.uSP_ReportBillTableAdapter.ClearBeforeFill = true;
            // 
            // uSPReportBillBindingSource1
            // 
            this.uSPReportBillBindingSource1.DataMember = "USP_ReportBill";
            this.uSPReportBillBindingSource1.DataSource = this.quanLyQuanMyCayThanhNhanDataSet4;
            // 
            // quanLyQuanMyCayThanhNhanDataSet
            // 
            this.quanLyQuanMyCayThanhNhanDataSet.DataSetName = "QuanLyQuanMyCayThanhNhanDataSet";
            this.quanLyQuanMyCayThanhNhanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyQuanMyCayThanhNhanDataSetBindingSource
            // 
            this.quanLyQuanMyCayThanhNhanDataSetBindingSource.DataSource = this.quanLyQuanMyCayThanhNhanDataSet;
            this.quanLyQuanMyCayThanhNhanDataSetBindingSource.Position = 0;
            // 
            // USP_ReportBillBindingSource
            // 
            this.USP_ReportBillBindingSource.DataMember = "USP_ReportBill";
            this.USP_ReportBillBindingSource.DataSource = this.quanLyQuanMyCayThanhNhanDataSet4;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(908, 430);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(64, 37);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // PrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 722);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.PrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPReportBillBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReportBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReportBillBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanMyCayThanhNhanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportBillBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPReportBillBindingSource;
        private QuanLyQuanMyCayThanhNhanDataSet4 quanLyQuanMyCayThanhNhanDataSet4;
        private QuanLyQuanMyCayThanhNhanDataSet4TableAdapters.USP_ReportBillTableAdapter uSP_ReportBillTableAdapter;
        private System.Windows.Forms.BindingSource uSPReportBillBindingSource1;
        private System.Windows.Forms.BindingSource quanLyQuanMyCayThanhNhanDataSet4BindingSource;
        private System.Windows.Forms.BindingSource quanLyQuanMyCayThanhNhanDataSetBindingSource;
        private QuanLyQuanMyCayThanhNhanDataSet quanLyQuanMyCayThanhNhanDataSet;
        private System.Windows.Forms.BindingSource USP_ReportBillBindingSource;
        private System.Windows.Forms.BindingSource uSPReportBillBindingSource2;
        private System.Windows.Forms.Button btnCheckOut;
    }
}