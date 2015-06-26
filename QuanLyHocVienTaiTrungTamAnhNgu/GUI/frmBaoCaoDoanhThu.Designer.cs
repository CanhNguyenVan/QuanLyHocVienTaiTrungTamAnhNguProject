namespace GUI
{
    partial class frmBaoCaoDoanhThu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNienHoc = new System.Windows.Forms.Label();
            this.cbNienHoc = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.BaoCao_DoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyHocVienTrungTamAnhNguDataSet = new GUI.QuanLyHocVienTrungTamAnhNguDataSet();
            this.BaoCao_DoanhThuTableAdapter = new GUI.QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.BaoCao_DoanhThuTableAdapter();
            this.selectAllNienHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectAllNienHocTableAdapter = new GUI.QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.SelectAllNienHocTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_DoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyHocVienTrungTamAnhNguDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllNienHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.BaoCao_DoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report_DoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 334);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 334);
            this.panel1.TabIndex = 1;
            // 
            // lblNienHoc
            // 
            this.lblNienHoc.AutoSize = true;
            this.lblNienHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNienHoc.Location = new System.Drawing.Point(143, 19);
            this.lblNienHoc.Name = "lblNienHoc";
            this.lblNienHoc.Size = new System.Drawing.Size(94, 22);
            this.lblNienHoc.TabIndex = 2;
            this.lblNienHoc.Text = "Niên Học :";
            // 
            // cbNienHoc
            // 
            this.cbNienHoc.DataSource = this.selectAllNienHocBindingSource;
            this.cbNienHoc.DisplayMember = "NienHoc";
            this.cbNienHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNienHoc.FormattingEnabled = true;
            this.cbNienHoc.Location = new System.Drawing.Point(243, 16);
            this.cbNienHoc.Name = "cbNienHoc";
            this.cbNienHoc.Size = new System.Drawing.Size(161, 28);
            this.cbNienHoc.TabIndex = 3;
            this.cbNienHoc.ValueMember = "NienHoc";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(443, 15);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(99, 29);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // BaoCao_DoanhThuBindingSource
            // 
            this.BaoCao_DoanhThuBindingSource.DataMember = "BaoCao_DoanhThu";
            this.BaoCao_DoanhThuBindingSource.DataSource = this.QuanLyHocVienTrungTamAnhNguDataSet;
            // 
            // QuanLyHocVienTrungTamAnhNguDataSet
            // 
            this.QuanLyHocVienTrungTamAnhNguDataSet.DataSetName = "QuanLyHocVienTrungTamAnhNguDataSet";
            this.QuanLyHocVienTrungTamAnhNguDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BaoCao_DoanhThuTableAdapter
            // 
            this.BaoCao_DoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // selectAllNienHocBindingSource
            // 
            this.selectAllNienHocBindingSource.DataMember = "SelectAllNienHoc";
            this.selectAllNienHocBindingSource.DataSource = this.QuanLyHocVienTrungTamAnhNguDataSet;
            // 
            // selectAllNienHocTableAdapter
            // 
            this.selectAllNienHocTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 411);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cbNienHoc);
            this.Controls.Add(this.lblNienHoc);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoDoanhThu";
            this.Text = "Báo Cáo Doanh Thu";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao_DoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyHocVienTrungTamAnhNguDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllNienHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BaoCao_DoanhThuBindingSource;
        private QuanLyHocVienTrungTamAnhNguDataSet QuanLyHocVienTrungTamAnhNguDataSet;
        private QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.BaoCao_DoanhThuTableAdapter BaoCao_DoanhThuTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNienHoc;
        private System.Windows.Forms.ComboBox cbNienHoc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.BindingSource selectAllNienHocBindingSource;
        private QuanLyHocVienTrungTamAnhNguDataSetTableAdapters.SelectAllNienHocTableAdapter selectAllNienHocTableAdapter;
    }
}