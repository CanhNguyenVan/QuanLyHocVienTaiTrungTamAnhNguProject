using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyHocVienTrungTamAnhNguDataSet.SelectAllNienHoc' table. You can move, or remove it, as needed.
            this.selectAllNienHocTableAdapter.Fill(this.QuanLyHocVienTrungTamAnhNguDataSet.SelectAllNienHoc);
            // TODO: This line of code loads data into the 'QuanLyHocVienTrungTamAnhNguDataSet.BaoCao_DoanhThu' table. You can move, or remove it, as needed.
            this.BaoCao_DoanhThuTableAdapter.Fill(this.QuanLyHocVienTrungTamAnhNguDataSet.BaoCao_DoanhThu);

            this.reportViewer1.RefreshReport();

            SetParameters(cbNienHoc.Text);
            reportViewer1.RefreshReport();
        }
        private void SetParameters(string nienHoc)
        {
            ReportParameter rp = new ReportParameter("NienHoc");
            rp.Values.Add(nienHoc);
            reportViewer1.LocalReport.SetParameters(rp);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetParameters(cbNienHoc.Text);
            reportViewer1.RefreshReport();
        }

        
    }
}
