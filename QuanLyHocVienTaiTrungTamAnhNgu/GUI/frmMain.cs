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
        public static DevComponents.DotNetBar.TabControl m_Tab;
        public int Quyen = -1; // khởi tạo phân quyền chức năng cho tài khoảng
        static public string TenDangNhap;

        public frmMain()
        {
            InitializeComponent();
        }

        public void laydulieu()
        {
            lbTenDangNhap.Text = TenDangNhap;
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

            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.ShowDialog();
            Quyen = dangNhap._quyen;
            KhoiTaoChucNang();
            laydulieu();

            lbthoigian.Text = Convert.ToDateTime(DateTime.Today).ToString("dd/MM/yyyy");
        }

        private void BatTat(Boolean temp)
        {
            btnDangNhap.Enabled = temp;
            btnDangXuat.Enabled = temp;
            btnPhanQuyen.Enabled = temp;
        }

        private void KhoiTaoChucNang()
        {
            try
            {
                switch (Quyen)
                {
                    case -1:
                        BatTat(false);
                        btnDangNhap.Enabled = true;
                        break;
                    case 0:// Quan tri vien
                        BatTat(false);
                        btnDangXuat.Enabled = true;
                        btnPhanQuyen.Enabled = true;

                        break;
                    case 1://Giao vu
                        BatTat(false);

                        break;
                    case 2://Giang vien
                        BatTat(false);

                        break;
                    case 3://Nhan vien
                        BatTat(false);

                        break;
                }
            }
            catch { }
        }

        public void DangNhap()
        {
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.ShowDialog();
            Quyen = dangNhap._quyen;
            laydulieu();
            KhoiTaoChucNang();
        }

        public void DangXuat()
        {
            if (lbTenDangNhap.Text.Equals("Chưa đăng nhập"))
            {
                btnDangXuat.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất không", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    BatTat(false);
                    lbTenDangNhap.Text = "Chưa đăng nhập";
                    //for (int i = 0; i < TabCtrl_main.Tabs.Count-1; i++)
                    //{
                    // TabCtrl_main.Tabs.Remove(TabCtrl_main.SelectedTab);
                    tabControl.Tabs.Clear();
                    //}

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
                        btnDangXuat.Enabled = false;
                    }
                    btnDangNhap.Enabled = true;
                    DangNhap();
                }
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            if (checkTab("Phân Quyền") == false)
            {
                frmPhanQuyen form = new frmPhanQuyen();
                AddTabControl(form, "Phân Quyền");
            }
        }
    }
}
