using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Security.Cryptography;

namespace GUI
{
    public partial class frmPhanQuyen : Form
    {
        
        public frmPhanQuyen()
        {
            InitializeComponent();
            
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (_HienMatKhau.Checked == true)
            {
                textMK1.UseSystemPasswordChar = false;
                textMK2.UseSystemPasswordChar = false;
            }
            else
            {
                textMK1.UseSystemPasswordChar = true;
                textMK2.UseSystemPasswordChar = true;
            }
        }

        #region Mã hóa MD5

        
        private string MaHoaMD5(string str)
        {
            Byte[] dauvao = ASCIIEncoding.Default.GetBytes(str);
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                var daura = md5.ComputeHash(dauvao);
                return BitConverter.ToString(daura).Replace("-", "");
            }
        }
        #endregion

        private void ClearText()
        {
            textTK.Clear();
            textMK1.Clear();
            textMK2.Clear();
        }

        private int IndexPhanQuyen()
        {
            if (radioAmin.Checked == true)
                return 0;
            else if (radioGiaoVu.Checked == true)
                return 1;
            else if (radioGiangVien.Checked == true)
                return 2;
            else return 3;
        }

        private void RadioPhanQuyen(int index)
        {
            if (index == 0)
                radioAmin.Checked = true;
            else if (index == 1)
                radioGiaoVu.Checked = true;
            else if (index == 2)
                radioGiangVien.Checked = true;
            else radioNhanVien.Checked = true;
        }

        //private void Luu()
        //{
        //    try
        //    {
        //        //Delete
        //        foreach (TAIKHOAN newHs in ListTaiKhoanDelete)
        //        {
        //            _TaiKhoan.Xoa(newHs.MATK);
        //        }
        //        //ADD
        //        foreach (TAIKHOAN newHs in ListTaiKhoanInsert)
        //        {
        //            _TaiKhoan.Them(newHs.MATK, newHs.TENTK, newHs.MATKHAU, newHs.LOAITK);
        //        }
        //        //Update
        //        foreach (TAIKHOAN newHs in ListTaiKhoanUpdate)
        //        {
        //            _TaiKhoan.Sua(newHs.MATK, newHs.TENTK, newHs.MATKHAU, newHs.LOAITK);
        //        }
        //        _luu = false;

        //        ListTaiKhoanInsert.Clear();
        //        ListTaiKhoanDelete.Clear();
        //        ListTaiKhoanUpdate.Clear();
        //    }
        //    catch { }
        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
         
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Luu();
        }

        private void dataPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t\tHƯỚNG DẪN\n" +
            "THÊM: Hãy nhập tên mới(không trùng), mật khẩu và mật khẩu xác nhận phải giống nhau\n" +
            "SỬA: Chọn vào 1 tài khoản muốn sửa->Sau đó nhập mật khẩu và xác nhận. Lưu ý nhập tên tài khoản mong muốn, không để mặc định vì tên tài khoản đó" +
            " đã mã hóa và chương trình sẽ tự hiểu là tài khoản mới.\n" +
            "XÓA: Xóa tài khoản mà bạn chọn.\n" +
            "GIÚP ĐỠ: Sẽ hướng dẫn cách sử dụng.\n" +
            "LƯU: sẽ lưu lại thay đổi của bạn lên dữ liệu.\n" +
            "THOÁT: Thoát khỏi chương trình và sẽ hỏi lại bạn có muốn lưu lại trước khi thoát không.\n" +
            "Bên trái là các nút chức năng và các ô tên đăng nhập và tài khoản.\n" +
            "Ở giữa là quyền của loại tài khoản mà bạn chọn.\n" +
            "Bên phải là danh sách và thông tin tài khoản.\n"
            ,
            "Hướng dẫn dùng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
