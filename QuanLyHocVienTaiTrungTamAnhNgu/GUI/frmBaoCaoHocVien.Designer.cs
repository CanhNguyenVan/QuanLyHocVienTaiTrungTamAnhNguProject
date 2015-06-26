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
            this.baoCaoHocVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyHocVienTrungTamAnhNguDataSet = new GUI.QuanLyHocVienTrungTamAnhNguDataSet();
            this.reportViewerBaoCaoHocVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.baoCao_HocVienTableAdapter = new GUI.QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.BaoCao_HocVienTableAdapter();
            this.baoCaoHocVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoHocVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocVienTrungTamAnhNguDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoHocVienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // baoCaoHocVienBindingSource
            // 
            this.baoCaoHocVienBindingSource.DataMember = "BaoCao_HocVien";
            this.baoCaoHocVienBindingSource.DataSource = this.quanLyHocVienTrungTamAnhNguDataSet;
            // 
            // quanLyHocVienTrungTamAnhNguDataSet
            // 
            this.quanLyHocVienTrungTamAnhNguDataSet.DataSetName = "QuanLyHocVienTrungTamAnhNguDataSet";
            this.quanLyHocVienTrungTamAnhNguDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerBaoCaoHocVien
            // 
            this.reportViewerBaoCaoHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.baoCaoHocVienBindingSource1;
            this.reportViewerBaoCaoHocVien.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBaoCaoHocVien.LocalReport.ReportEmbeddedResource = "GUI.Report_HocVien.rdlc";
            this.reportViewerBaoCaoHocVien.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBaoCaoHocVien.Name = "reportViewerBaoCaoHocVien";
            this.reportViewerBaoCaoHocVien.Size = new System.Drawing.Size(720, 340);
            this.reportViewerBaoCaoHocVien.TabIndex = 0;
            // 
            // baoCao_HocVienTableAdapter
            // 
            this.baoCao_HocVienTableAdapter.ClearBeforeFill = true;
            // 
            // baoCaoHocVienBindingSource1
            // 
            this.baoCaoHocVienBindingSource1.DataMember = "BaoCao_HocVien";
            this.baoCaoHocVienBindingSource1.DataSource = this.quanLyHocVienTrungTamAnhNguDataSet;
            // 
            // frmBaoCaoHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 340);
            this.Controls.Add(this.reportViewerBaoCaoHocVien);
            this.Name = "frmBaoCaoHocVien";
            this.Text = "Báo Cáo Danh Sách Học Viên";
            this.Load += new System.EventHandler(this.BaoCaoHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoHocVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocVienTrungTamAnhNguDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoHocVienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBaoCaoHocVien;
        private QuanLyHocVienTrungTamAnhNguDataSet quanLyHocVienTrungTamAnhNguDataSet;
        private System.Windows.Forms.BindingSource baoCaoHocVienBindingSource;
        private QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.BaoCao_HocVienTableAdapter baoCao_HocVienTableAdapter;
        private System.Windows.Forms.BindingSource baoCaoHocVienBindingSource1;
    }
}