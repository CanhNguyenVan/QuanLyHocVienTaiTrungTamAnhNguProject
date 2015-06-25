using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        private TaiKhoanBLL _taikhoan = new TaiKhoanBLL();
        private List<TaiKhoanDTO> ListTK = new List<TaiKhoanDTO>();
        public int _quyen;

        public frmDangNhap()
        {
            InitializeComponent();
            ListTK = _taikhoan.SelectAll();
            frmMain.TenDangNhap = "Chưa đăng nhập";
        }

        private string MaHoaMD5(string str)
        {
            Byte[] dauvao = ASCIIEncoding.Default.GetBytes(str);
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                var daura = md5.ComputeHash(dauvao);
                return BitConverter.ToString(daura).Replace("-", "");
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (textTen.Text.Trim() != "" && textMatKhau.Text.Trim() != "")
                {
                    foreach (TaiKhoanDTO newtk in ListTK)
                    {
                        if (newtk.TenTK.Equals(textTen.Text) && newtk.MatKhau.Equals(textMatKhau.Text))
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _quyen = newtk.LoaiTK;
                            frmMain.TenDangNhap = textTen.Text;
                            this.Close();
                            return;
                        }
                    }
                }
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _quyen = -1;
            }
            catch { }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn có muốn thoát!", "THOÁT ỨNG DỤNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                _quyen = -1;
                this.Close();
            }
        }

        #region Trả về giá trị quyền
        public int Quyen()
        {
            return _quyen;
        }
        #endregion

        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMK.Checked == true)
            {
                textMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                textMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //dang nhap
                if (e.KeyChar == 13)
                {
                    btnDangNhap_Click(sender, e);
                }
                //thoat
                if (e.KeyChar == 27)
                {
                    buttonX1_Click(sender, e);
                }
            }
            catch { }
        }
    }
}
