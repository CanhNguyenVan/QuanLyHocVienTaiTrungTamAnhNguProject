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
            this.QuanLyHocVienTrungTamAnhNgu_DataSet = new GUI.QuanLyHocVienTrungTamAnhNgu_DataSet();
            this.BaoCao_LopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCao_LopTableAdapter = new GUI.QuanLyHocVienTrungTamAnhNgu_DataSetTableAdapters.BaoCao_LopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyHocVienTrungTamAnhNgu_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_LopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBaoCaoLop
            // 
            this.reportViewerBaoCaoLop.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_BaoCaoLop";
            reportDataSource1.Value = this.BaoCao_LopBindingSource;
            this.reportViewerBaoCaoLop.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBaoCaoLop.LocalReport.ReportEmbeddedResource = "GUI.BaoCaoLop.rdlc";
            this.reportViewerBaoCaoLop.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBaoCaoLop.Name = "reportViewerBaoCaoLop";
            this.reportViewerBaoCaoLop.Size = new System.Drawing.Size(724, 366);
            this.reportViewerBaoCaoLop.TabIndex = 0;
            // 
            // QuanLyHocVienTrungTamAnhNgu_DataSet
            // 
            this.QuanLyHocVienTrungTamAnhNgu_DataSet.DataSetName = "QuanLyHocVienTrungTamAnhNgu_DataSet";
            this.QuanLyHocVienTrungTamAnhNgu_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BaoCao_LopBindingSource
            // 
            this.BaoCao_LopBindingSource.DataMember = "BaoCao_Lop";
            this.BaoCao_LopBindingSource.DataSource = this.QuanLyHocVienTrungTamAnhNgu_DataSet;
            // 
            // BaoCao_LopTableAdapter
            // 
            this.BaoCao_LopTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 366);
            this.Controls.Add(this.reportViewerBaoCaoLop);
            this.Name = "frmBaoCaoLop";
            this.Text = "Báo Cáo Lớp";
            this.Load += new System.EventHandler(this.frmBaoCaoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyHocVienTrungTamAnhNgu_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_LopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBaoCaoLop;
        private System.Windows.Forms.BindingSource BaoCao_LopBindingSource;
        private QuanLyHocVienTrungTamAnhNgu_DataSet QuanLyHocVienTrungTamAnhNgu_DataSet;
        private QuanLyHocVienTrungTamAnhNgu_DataSetTableAdapters.BaoCao_LopTableAdapter BaoCao_LopTableAdapter;

    }
}