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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (checkTab("Giơi thiệu") == false)
            {
                TabItem tab = tabControl.CreateTab("Giơi thiệu");
                tab.CloseButtonVisible = false;
                frmGioiThieu frm01 = new frmGioiThieu();
                frm01.Dock = DockStyle.Fill;
                frm01.FormBorderStyle = FormBorderStyle.None;
                frm01.TopLevel = false;
                tab.AttachedControl.Controls.Add(frm01);
                frm01.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
        }

        public void AddTabControl(Form form, string nameTab)
        {
            TabItem tab = tabControl.CreateTab(nameTab);
            form.Dock = DockStyle.Fill;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            tab.AttachedControl.Controls.Add(form);
            form.Show();
            tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;           
        }

        private bool checkTab(string name)
        {
            for (int i = 0; i < tabControl.Tabs.Count; i++)
            {
                if (tabControl.Tabs[i].Text == name)
                {
                    tabControl.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void tabControl_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            tabControl.Tabs.Remove(tabControl.SelectedTab);
        }

        private void ribbonTabItem3_Click(object sender, EventArgs e)
        {

        }

        private void btnQLDangKy_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Đăng Ký") == false)
            {
                frmQuanLyDangKy form = new frmQuanLyDangKy();
                AddTabControl(form, "Quản Lý Đăng Ký");
            }
        }

        private void btnQLHocVien_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Học Viên") == false)
            {
                frmQuanLyHocVien form = new frmQuanLyHocVien();
                AddTabControl(form, "Quản Lý Học Viên");
            }
        }

        private void btnQLLop_Click(object sender, EventArgs e)
        {

        }
    }
}
