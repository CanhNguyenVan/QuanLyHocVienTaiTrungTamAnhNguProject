namespace GUI
{
    partial class frmBaoCaoHocVien
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
            this.BaoCao_HocVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyHocVienTrungTamAnhNgu_DataSet = new GUI.QuanLyHocVienTrungTamAnhNgu_DataSet();
            this.reportViewerBaoCaoHocVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaoCao_HocVienTableAdapter = new GUI.QuanLyHocVienTrungTamAnhNgu_DataSetTableAdapters.BaoCao_HocVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_HocVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyHocVienTrungTamAnhNgu_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BaoCao_HocVienBindingSource
            // 
            this.BaoCao_HocVienBindingSource.DataMember = "BaoCao_HocVien";
            this.BaoCao_HocVienBindingSource.DataSource = this.QuanLyHocVienTrungTamAnhNgu_DataSet;
            // 
            // QuanLyHocVienTrungTamAnhNgu_DataSet
            // 
            this.QuanLyHocVienTrungTamAnhNgu_DataSet.DataSetName = "QuanLyHocVienTrungTamAnhNgu_DataSet";
            this.QuanLyHocVienTrungTamAnhNgu_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerBaoCaoHocVien
            // 
            this.reportViewerBaoCaoHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_BaoCaoHocVien";
            reportDataSource1.Value = this.BaoCao_HocVienBindingSource;
            this.reportViewerBaoCaoHocVien.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBaoCaoHocVien.LocalReport.ReportEmbeddedResource = "GUI.BaoCaoHocVien.rdlc";
            this.reportViewerBaoCaoHocVien.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBaoCaoHocVien.Name = "reportViewerBaoCaoHocVien";
            this.reportViewerBaoCaoHocVien.Size = new System.Drawing.Size(729, 323);
            this.reportViewerBaoCaoHocVien.TabIndex = 0;
            // 
            // BaoCao_HocVienTableAdapter
            // 
            this.BaoCao_HocVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 323);
            this.Controls.Add(this.reportViewerBaoCaoHocVien);
            this.Name = "frmBaoCaoHocVien";
            this.Text = "Báo Cáo Học Viên";
            this.Load += new System.EventHandler(this.frmBaoCaoHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_HocVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyHocVienTrungTamAnhNgu_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBaoCaoHocVien;
        private System.Windows.Forms.BindingSource BaoCao_HocVienBindingSource;
        private QuanLyHocVienTrungTamAnhNgu_DataSet QuanLyHocVienTrungTamAnhNgu_DataSet;
        private QuanLyHocVienTrungTamAnhNgu_DataSetTableAdapters.BaoCao_HocVienTableAdapter BaoCao_HocVienTableAdapter;

    }
}