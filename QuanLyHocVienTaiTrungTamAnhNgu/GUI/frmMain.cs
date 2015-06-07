using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace GUI
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        frmGioiThieu frmGT = new frmGioiThieu();
        frmQuanLyDangKy frmQuanLyDangKy = new frmQuanLyDangKy();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmGT.MdiParent = this;
            frmGT.Show();
        }

        private void ribbonPanel4_Click(object sender, EventArgs e)
        {

        }

        private void btnQLDangKy_Click(object sender, EventArgs e)
        {
            frmQuanLyDangKy.MdiParent = this;
            frmQuanLyDangKy.Show();
        }
       
       
    }
}
