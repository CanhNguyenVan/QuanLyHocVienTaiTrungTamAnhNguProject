using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmQuanLyDangKy : Form
    {
        HocVienBLL _hocVienBll = new HocVienBLL();
        DangKyBLL _dangKyBll = new DangKyBLL();
        BienLaiBLL _bienLaiBll = new BienLaiBLL();
        KhoaHocBLL _khoaHocBll = new KhoaHocBLL();
        LopBLL _lopHocBll = new LopBLL();
        HoSoHocVienBLL _hoSoHocVienBll = new HoSoHocVienBLL();

        public frmQuanLyDangKy()
        {
            InitializeComponent();
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmQuanLyDangKy_Load(object sender, EventArgs e)
        {
            txt_MaHocVien.Text = MyTools.Utility.PhatSinhMaHocVien();

            cbx_KhoaHoc.DataSource = _khoaHocBll.SelectAll();
            cbx_KhoaHoc.DisplayMember = "NienHoc";
            cbx_KhoaHoc.ValueMember = "NienHoc";

            cbx_Lop.DataSource = _lopHocBll.SelectAll();
            cbx_Lop.DisplayMember = "TenLop";
            cbx_Lop.ValueMember = "TenLop";

        }

        private void btn_ChapNhan_Click(object sender, EventArgs e)
        {
            try
            {
                // Thông tin học viên
                HocVienDTO hocVienDto = new HocVienDTO();
                hocVienDto.MaHocVien = txt_MaHocVien.Text;
                hocVienDto.TenHocVien = txt_TenHocVien.Text;
                hocVienDto.NgaySinh = dateTimePicker_NgaySinh.Value;
                hocVienDto.GioiTinh = (cbx_GioiTinh.SelectedText);
                hocVienDto.NgheNghiep = txt_NgheNghiep.Text;
                hocVienDto.SoDienThoai = txt_SoDienThoai.Text;
                hocVienDto.DiaChi = txt_DiaChi.Text;

                // Thông tin đăng ký
                DangKyDTO dangKyDto = new DangKyDTO();
                dangKyDto.MaDangKy = MyTools.Utility.PhatSinhMaDangKy();
                dangKyDto.MaHocVien = hocVienDto.MaHocVien;
                dangKyDto.MaKhoaHoc = (cbx_KhoaHoc.SelectedItem as KhoaHocDTO).MaKhoaHoc;
                dangKyDto.MaLop = (cbx_Lop.SelectedItem as LopDTO).MaLop;

                // Thông tin biên lai
                BienLaiDTO bienLaiDto = new BienLaiDTO();
                bienLaiDto.MaBienLai = MyTools.Utility.PhatSinhMaBienLai();
                bienLaiDto.HocPhi = decimal.Parse(txt_HocPhi.Text.ToString());
                bienLaiDto.MienGiam = decimal.Parse(txt_MienGiam.Text.ToString());

                // Hồ sơ học viên
                HoSoHocVienDTO hoSoHocVienDto = new HoSoHocVienDTO();
                hoSoHocVienDto.MaHoSo = MyTools.Utility.PhatSinhMaHoSo();
                hoSoHocVienDto.MaHocVien = hocVienDto.MaHocVien;
                hoSoHocVienDto.MaLop = dangKyDto.MaLop;
                hoSoHocVienDto.DiemThi = 0;
                hoSoHocVienDto.XepLoai = "Chưa xếp loại";

                // Insert vào cơ sở dữ liệu
                if (1 == _hocVienBll.InsertHocVien(hocVienDto) &&
                    1 == _dangKyBll.InsertDangKy(dangKyDto)
                    )
                {
                    _bienLaiBll.InsertBienLai(bienLaiDto);
                    _hoSoHocVienBll.InsertHoSoHocVien(hoSoHocVienDto);

                    MessageBox.Show("Đăng ký thành công!");
                }

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Không được để trống các trường nhập vào", "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dauPhayDongTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbx_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var s = ((sender as ComboBox).SelectedItem as LopDTO).MaLoaiLop.Trim();
                if (s == LoaiLops.LL1.ToString())
                {
                    txt_HocPhi.Text = "3000000";
                }
                else if (s == LoaiLops.LL2.ToString())
                {
                    txt_HocPhi.Text = "4000000";
                }
                else if (s == LoaiLops.LL3.ToString())
                {
                    txt_HocPhi.Text = "5000000";
                }

            }
            catch (Exception)
            {

            }
        }

        private void cbx_Lop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var s = ((sender as ComboBox).SelectedItem as LopDTO).MaLoaiLop.Trim();
                if (s == LoaiLops.LL1.ToString())
                {
                    txt_HocPhi.Text = "3000000";
                }
                else if (s == LoaiLops.LL2.ToString())
                {
                    txt_HocPhi.Text = "4000000";
                }
                else if (s == LoaiLops.LL3.ToString())
                {
                    txt_HocPhi.Text = "5000000";
                }

            }
            catch (Exception)
            {

            }
        }

    }
}
