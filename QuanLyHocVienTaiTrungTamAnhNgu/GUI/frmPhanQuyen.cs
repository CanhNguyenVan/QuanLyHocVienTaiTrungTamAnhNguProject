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
using DTO;

namespace GUI
{
    public partial class frmPhanQuyen : Form
    {
        private TaiKhoanBLL _TaiKhoan = new TaiKhoanBLL();
        private List<TaiKhoanDTO> ListTaiKhoan;// chứa danh sách tài khoản ban đầu lấy từ database
        private List<TaiKhoanDTO> ListTaiKhoanInsert = new List<TaiKhoanDTO>(); // chứa danh sách tài khoản sẽ được thêm vào
        private List<TaiKhoanDTO> ListTaiKhoanDelete = new List<TaiKhoanDTO>(); // chứa danh sách tài khoản sẽ được xóa
        private List<TaiKhoanDTO> ListTaiKhoanUpdate = new List<TaiKhoanDTO>();// chứa danh sách tài khoản sẽ được cập nhật

        string _tk, _mk;
        int _loai;
        bool _luu = false;
        public frmPhanQuyen()
        {
            InitializeComponent();
            ListTaiKhoan = _TaiKhoan.SelectAll();// lấy tất cả tài khoản có trong cơ sở dữ liệu
            dataPhanQuyen.DataSource = ListTaiKhoan; // thiết lập dữ liệu hiển thị lên datagridview
            //dataPhanQuyen.Columns[2].Visible = false;
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
                return 1;
            else if (radioNhanVien.Checked == true)
                return 2;            
            else return 3;
        }

        private void RadioPhanQuyen(int index)
        {
            if (index == 1)
                radioAmin.Checked = true;
            else if (index == 2)
                radioNhanVien.Checked = true;            
            else radioGiaoVien.Checked = true;
        }

        private void Luu()
        {
            try
            {
                //Delete
                foreach (TaiKhoanDTO newHs in ListTaiKhoanDelete)
                {
                    _TaiKhoan.DeleteTaiKhoan(newHs);
                }
                //ADD
                foreach (TaiKhoanDTO newHs in ListTaiKhoanInsert)
                {                    
                   _TaiKhoan.InsertTaiKhoan(newHs);
                }
                //Update
                foreach (TaiKhoanDTO newHs in ListTaiKhoanUpdate)
                {                  
                    _TaiKhoan.UpdateTaiKhoan(newHs);
                }
                _luu = false;

                ListTaiKhoanInsert.Clear();
                ListTaiKhoanDelete.Clear();
                ListTaiKhoanUpdate.Clear();
                MessageBox.Show("Lưu thành công!", "Lưu tất cả xuống CSDL", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (textMK1.Text == textMK2.Text)// nếu mật khẩu nhập 2 lần như nhau
                    {
                        bool trung = false;

                        // Kiểm tra tài khoản mới nhập đã tồn tại chưa
                        foreach (TaiKhoanDTO newtk in ListTaiKhoan)
                        {
                            if (newtk.TenTK == textTK.Text)
                            {
                                trung = true;
                                break;
                            }
                        }


                        if (!trung)// nếu chưa tồn tại thì thêm vào
                        {
                            TaiKhoanDTO newTK = new TaiKhoanDTO();
                            List<TaiKhoanDTO> results = _TaiKhoan.SelectLastMaTK();// lấy mã tài khoản cuối cùng

                            foreach (TaiKhoanDTO result in results)
                            {
                                newTK.MaTK = result.MaTK + 1;
                            }

                            newTK.TenTK = textTK.Text;
                            newTK.MatKhau = textMK1.Text;
                            newTK.LoaiTK = IndexPhanQuyen();

                            //Add List HocSinh Insert To Save DB
                            ListTaiKhoanInsert.Add(newTK);
                            ListTaiKhoan.Add(newTK);
                            dataPhanQuyen.DataSource = ListTaiKhoan.ToArray();
                            MessageBox.Show("Tài khoản bạn tạo thành công!", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _luu = true;
                            ClearText();
                                                        
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
                    if (textMK1.Text == textMK2.Text)//2 mật khẩu giống nhau
                    {
                        bool trung = false;
                        bool ok = false;

                        String id = dataPhanQuyen.CurrentRow.Cells["MaTK"].Value.ToString();

                        foreach (TaiKhoanDTO newTK in ListTaiKhoan)
                        {
                            if (newTK.MaTK.ToString() == id)
                            {
                                if (textTK.Text == _tk && textMK1.Text == _mk && IndexPhanQuyen() == _loai)//không có thay đổi
                                {
                                    break;
                                }
                                else
                                {
                                    if (textTK.Text != _tk)//tên tk thay đổi
                                    {
                                        foreach (TaiKhoanDTO newTK1 in ListTaiKhoan)
                                        {
                                            if (newTK1.TenTK == textTK.Text && newTK1.MaTK != newTK.MaTK)//trùng tk
                                            {
                                                trung = true;
                                                break;
                                            }
                                        }

                                        if (!trung)//khác trùng thì đổi
                                        {
                                            newTK.TenTK = textTK.Text;
                                            ok = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Tài khoản bạn vừa thêm đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    if (textMK1.Text != _mk)//mat khẩu
                                    {
                                        newTK.MatKhau = textMK1.Text;
                                        ok = true;
                                    }
                                    if (IndexPhanQuyen() != _loai)//loại
                                    {
                                        newTK.LoaiTK = IndexPhanQuyen();
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
                String id = dataPhanQuyen.CurrentRow.Cells["MaTK"].Value.ToString();

                foreach (TaiKhoanDTO newtk in ListTaiKhoan)
                {
                    if (newtk.MaTK.ToString() == id)
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
                    this.Close();
                }
                else
                {
                    if (DialogResult.No == di)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                DialogResult di = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "ĐÓNG ỨNG DỤNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == di)
                {
                    this.Close();
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
            "THÊM: Hãy nhập tên mới(không trùng), mật khẩu và mật khẩu xác nhận phải giống nhau\n\n" +
            "SỬA: Chọn vào 1 tài khoản muốn sửa->Sau đó nhập mật khẩu và xác nhận.\n\n" +
            "XÓA: Xóa tài khoản mà bạn chọn.\n\n" +         
            "LƯU: sẽ lưu lại thay đổi của bạn lên dữ liệu."            
            ,
            "Hướng dẫn dùng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
