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
    public partial class frmBaoCaoHocVien : Form
    {
        public frmBaoCaoHocVien()
        {
            InitializeComponent();
        }

        private void BaoCaoHocVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHocVienTrungTamAnhNguDataSet.BaoCao_HocVien' table. You can move, or remove it, as needed.
            this.baoCao_HocVienTableAdapter.Fill(this.quanLyHocVienTrungTamAnhNguDataSet.BaoCao_HocVien);

            this.reportViewerBaoCaoHocVien.RefreshReport();
        }
    }
}
