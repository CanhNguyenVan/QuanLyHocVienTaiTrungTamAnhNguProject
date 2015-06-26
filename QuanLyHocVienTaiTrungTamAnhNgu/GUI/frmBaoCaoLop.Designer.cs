namespace GUI
{
    partial class frmBaoCaoLop
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
            this.reportViewerBaoCaoLop = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaoCao_LopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyHocVienTrungTamAnhNguDataSet = new GUI.QuanLyHocVienTrungTamAnhNguDataSet();
            this.BaoCao_LopTableAdapter = new GUI.QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.BaoCao_LopTableAdapter();
            this.BaoCao_HocVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCao_HocVienTableAdapter = new GUI.QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.BaoCao_HocVienTableAdapter();
            this.baoCaoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_LopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyHocVienTrungTamAnhNguDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_HocVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBaoCaoLop
            // 
            this.reportViewerBaoCaoLop.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.baoCaoLopBindingSource;
            this.reportViewerBaoCaoLop.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBaoCaoLop.LocalReport.ReportEmbeddedResource = "GUI.Report_Lop.rdlc";
            this.reportViewerBaoCaoLop.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBaoCaoLop.Name = "reportViewerBaoCaoLop";
            this.reportViewerBaoCaoLop.Size = new System.Drawing.Size(724, 372);
            this.reportViewerBaoCaoLop.TabIndex = 0;
            // 
            // BaoCao_LopBindingSource
            // 
            this.BaoCao_LopBindingSource.DataMember = "BaoCao_Lop";
            this.BaoCao_LopBindingSource.DataSource = this.QuanLyHocVienTrungTamAnhNguDataSet;
            // 
            // QuanLyHocVienTrungTamAnhNguDataSet
            // 
            this.QuanLyHocVienTrungTamAnhNguDataSet.DataSetName = "QuanLyHocVienTrungTamAnhNguDataSet";
            this.QuanLyHocVienTrungTamAnhNguDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BaoCao_LopTableAdapter
            // 
            this.BaoCao_LopTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCao_HocVienBindingSource
            // 
            this.BaoCao_HocVienBindingSource.DataMember = "BaoCao_HocVien";
            this.BaoCao_HocVienBindingSource.DataSource = this.QuanLyHocVienTrungTamAnhNguDataSet;
            // 
            // BaoCao_HocVienTableAdapter
            // 
            this.BaoCao_HocVienTableAdapter.ClearBeforeFill = true;
            // 
            // baoCaoLopBindingSource
            // 
            this.baoCaoLopBindingSource.DataMember = "BaoCao_Lop";
            this.baoCaoLopBindingSource.DataSource = this.QuanLyHocVienTrungTamAnhNguDataSet;
            // 
            // frmBaoCaoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 372);
            this.Controls.Add(this.reportViewerBaoCaoLop);
            this.Name = "frmBaoCaoLop";
            this.Text = "BaoCaoLop";
            this.Load += new System.EventHandler(this.frmBaoCaoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_LopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyHocVienTrungTamAnhNguDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_HocVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoLopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBaoCaoLop;
        private System.Windows.Forms.BindingSource BaoCao_LopBindingSource;
        private QuanLyHocVienTrungTamAnhNguDataSet QuanLyHocVienTrungTamAnhNguDataSet;
        private QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.BaoCao_LopTableAdapter BaoCao_LopTableAdapter;
        private System.Windows.Forms.BindingSource BaoCao_HocVienBindingSource;
        private QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.BaoCao_HocVienTableAdapter BaoCao_HocVienTableAdapter;
        private System.Windows.Forms.BindingSource baoCaoLopBindingSource;
    }
}