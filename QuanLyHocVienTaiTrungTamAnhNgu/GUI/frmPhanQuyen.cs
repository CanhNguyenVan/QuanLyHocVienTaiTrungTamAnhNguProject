using BLL;
using DAL;
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
        private TaiKhoanBLL _TaiKhoan = new TaiKhoanBLL();
        private List<TAIKHOAN> ListTaiKhoan;
        private List<TAIKHOAN> ListTaiKhoanInsert = new List<TAIKHOAN>();
        private List<TAIKHOAN> ListTaiKhoanDelete = new List<TAIKHOAN>(); 
        private List<TAIKHOAN> ListTaiKhoanUpdate = new List<TAIKHOAN>();

        string _tk, _mk;
        int _loai;
        bool _luu = false;
        public frmPhanQuyen()
        {
            InitializeComponent();
            ListTaiKhoan = _TaiKhoan.LayTatCaTaiKhoan();
            dataPhanQuyen.DataSource = ListTaiKhoan; 
            dataPhanQuyen.Columns[2].Visible = false;
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

        private void Luu()
        {
            try
            {
                //Delete
                foreach (TAIKHOAN newHs in ListTaiKhoanDelete)
                {
                    _TaiKhoan.Xoa(newHs.MATK);
                }
                //ADD
                foreach (TAIKHOAN newHs in ListTaiKhoanInsert)
                {
                    _TaiKhoan.Them(newHs.MATK, newHs.TENTK, newHs.MATKHAU, newHs.LOAITK);
                }
                //Update
                foreach (TAIKHOAN newHs in ListTaiKhoanUpdate)
                {
                    _TaiKhoan.Sua(newHs.MATK, newHs.TENTK, newHs.MATKHAU, newHs.LOAITK);
                }
                _luu = false;

                ListTaiKhoanInsert.Clear();
                ListTaiKhoanDelete.Clear();
                ListTaiKhoanUpdate.Clear();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textTK.Text.Trim() == "" || textMK1.Text.Trim() == "" || textMK2.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy dủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textMK1.Text == textMK2.Text)
                    {
                        bool trung = false;

                        
                        foreach (TAIKHOAN newtk in ListTaiKhoan)
                        {
                            if (newtk.TENTK == textTK.Text)
                            {
                                trung = true;
                                break;
                            }
                        }


                        if (!trung)
                        {
                            TAIKHOAN newTK = new TAIKHOAN();
                            List<usp_SelectLastMaTKResult> results = _TaiKhoan.LayMaTKCuoiCung();

                            foreach (usp_SelectLastMaTKResult result in results)
                            {
                                newTK.MATK = result.MATK + 1;
                            }

                            newTK.TENTK = textTK.Text;
                            newTK.MATKHAU = MaHoaMD5(MaHoaMD5(textMK1.Text));
                            newTK.LOAITK = IndexPhanQuyen();

                            //Add List HocSinh Insert To Save DB
                            ListTaiKhoanInsert.Add(newTK);
                            ListTaiKhoan.Add(newTK);
                            dataPhanQuyen.DataSource = ListTaiKhoan.ToArray();
                            MessageBox.Show("Tài khoản bạn tạo thành công!", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _luu = true;
                            ClearText();
                          
                            Luu();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản bạn vừa thêm đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu xác nhận giống và mật khẩu giống nhau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (textTK.Text.Trim() == "" || textMK1.Text.Trim() == "" || textMK2.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy dủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textMK1.Text == textMK2.Text)
                    {
                        bool trung = false;
                        bool ok = false;

                        String id = dataPhanQuyen.CurrentRow.Cells["MATK"].Value.ToString();

                        foreach (TAIKHOAN newTK in ListTaiKhoan)
                        {
                            if (newTK.MATK.ToString() == id)
                            {
                                if (textTK.Text == _tk && textMK1.Text == _mk && IndexPhanQuyen() == _loai)//khong co thay doi
                                {
                                    break;
                                }
                                else
                                {
                                    if (textTK.Text != _tk)
                                    {
                                        foreach (TAIKHOAN newTK1 in ListTaiKhoan)
                                        {
                                            if (newTK1.TENTK == textTK.Text && newTK1.MATK != newTK.MATK)//trung tk
                                            {
                                                trung = true;
                                                break;
                                            }
                                        }

                                        if (!trung)
                                        {
                                            newTK.TENTK = textTK.Text;
                                            ok = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Tài khoản bạn vừa thêm đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    if (textMK1.Text != _mk)//mat khau
                                    {
                                        newTK.MATKHAU = MaHoaMD5(MaHoaMD5(textMK1.Text));
                                        ok = true;
                                    }
                                    if (IndexPhanQuyen() != _loai)//loai
                                    {
                                        newTK.LOAITK = IndexPhanQuyen();
                                        ok = true;
                                    }
                                    if (!trung && ok)
                                    {
                                        ListTaiKhoanUpdate.Add(newTK);
                                        dataPhanQuyen.DataSource = ListTaiKhoan.ToArray();
                                        _luu = true;
                                        ClearText();
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu xác nhận và mật khẩu giống nhau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dataPhanQuyen.CurrentRow.Cells["MATK"].Value.ToString();

                foreach (TAIKHOAN newtk in ListTaiKhoan)
                {
                    if (newtk.MATK.ToString() == id)
                    {
                        ListTaiKhoanDelete.Add(newtk);

                        ListTaiKhoan.Remove(newtk);
                        _luu = true;
                        break;
                    }
                }
                dataPhanQuyen.DataSource = ListTaiKhoan.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (_luu)
            {
                DialogResult di = MessageBox.Show("Bạn có muốn lưu lại dữ liệu lại trước khi thoát?", "ĐÓNG ỨNG DỤNG", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (DialogResult.Yes == di)
                {
                    Luu();
                    DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
                    TAB.Tabs.Remove(TAB.SelectedTab);
                    Close();
                }
                else
                {
                    if (DialogResult.No == di)
                    {
                        DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
                        TAB.Tabs.Remove(TAB.SelectedTab);
                        Close();
                    }
                }
            }
            else
            {
                DialogResult di = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "ĐÓNG ỨNG DỤNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == di)
                {
                    DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
                    TAB.Tabs.Remove(TAB.SelectedTab);
                    Close();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Luu();
        }

        private void dataPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textTK.Text = Convert.ToString(dataPhanQuyen.CurrentRow.Cells["TenTK"].Value.ToString().Trim());
                textMK1.Clear();
                textMK2.Clear();
                RadioPhanQuyen(Convert.ToInt32(Convert.ToString(dataPhanQuyen.CurrentRow.Cells["LoaiTK"].Value.ToString().Trim())));
                _tk = textTK.Text;
                _mk = textMK1.Text;
                _loai = IndexPhanQuyen();
            }
            catch { }
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
