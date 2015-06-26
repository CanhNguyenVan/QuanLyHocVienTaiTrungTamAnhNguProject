using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBaoCaoLop : Form
    {
        public frmBaoCaoLop()
        {
            InitializeComponent();
        }

        private void frmBaoCaoLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyHocVienTrungTamAnhNguDataSet.BaoCao_HocVien' table. You can move, or remove it, as needed.
            this.BaoCao_HocVienTableAdapter.Fill(this.QuanLyHocVienTrungTamAnhNguDataSet.BaoCao_HocVien);
            // TODO: This line of code loads data into the 'QuanLyHocVienTrungTamAnhNguDataSet.BaoCao_Lop' table. You can move, or remove it, as needed.
            this.BaoCao_LopTableAdapter.Fill(this.QuanLyHocVienTrungTamAnhNguDataSet.BaoCao_Lop);

            this.reportViewerBaoCaoLop.RefreshReport();
        }
    }
}
