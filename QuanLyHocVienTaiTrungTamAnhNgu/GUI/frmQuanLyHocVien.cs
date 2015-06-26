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
    public partial class frmQuanLyHocVien : Form
    {

        private HocVienBLL _hocVienBll = new HocVienBLL();

        private frmHoSoHocVien _hoSoHocVien = null;

        public frmQuanLyHocVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyHocVien_Load(object sender, EventArgs e)
        {
            LoadData();

            Binding();
        }


        private void LoadData()
        {
            dataGridViewQuanLyHocVien.DataSource = _hocVienBll.SelectAll();
        }

        private void Binding()
        {
            txt_MaHocVien.DataBindings.Clear();
            txt_MaHocVien.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_MaHocVien.DataBindings.Add("Text", dataGridViewQuanLyHocVien.DataSource, "MaHocVien");

            txt_TenHocVien.DataBindings.Clear();
            txt_TenHocVien.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_TenHocVien.DataBindings.Add("Text", dataGridViewQuanLyHocVien.DataSource, "TenHocVien");

            dateTimePicker_NgaySinh.DataBindings.Clear();
            dateTimePicker_NgaySinh.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            dateTimePicker_NgaySinh.DataBindings.Add("Value", dataGridViewQuanLyHocVien.DataSource, "NgaySinh");

            cbx_GioiTinh.DataBindings.Clear();
            cbx_GioiTinh.DataBindings.DefaultDataSourceUpdateMode =  DataSourceUpdateMode.Never;
            cbx_GioiTinh.DataBindings.Add("Text", dataGridViewQuanLyHocVien.DataSource, "GioiTinh");

            txt_NgheNghiep.DataBindings.Clear();
            txt_NgheNghiep.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_NgheNghiep.DataBindings.Add("Text", dataGridViewQuanLyHocVien.DataSource, "NgheNghiep");

            txt_SoDienThoai.DataBindings.Clear();
            txt_SoDienThoai.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_SoDienThoai.DataBindings.Add("Text", dataGridViewQuanLyHocVien.DataSource, "SoDienThoai");

            txt_DiaChi.DataBindings.Clear();
            txt_DiaChi.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_DiaChi.DataBindings.Add("Text", dataGridViewQuanLyHocVien.DataSource, "DiaChi");
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                HocVienDTO hocVienDto = new HocVienDTO();
                hocVienDto.MaHocVien = txt_MaHocVien.Text;
                hocVienDto.TenHocVien = txt_TenHocVien.Text;
                hocVienDto.NgaySinh = dateTimePicker_NgaySinh.Value;
                hocVienDto.GioiTinh = cbx_GioiTinh.SelectedText;
                hocVienDto.NgheNghiep = txt_NgheNghiep.Text;
                hocVienDto.SoDienThoai = txt_SoDienThoai.Text;
                hocVienDto.DiaChi = txt_DiaChi.Text;

                if (1 == _hocVienBll.UpdateHocVien(hocVienDto))
                {

                    MessageBox.Show("Chỉnh sửa thành công!");

                    LoadData();

                    Binding();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không được để trống các trường nhập vào", "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                HocVienDTO hocVienDto = new HocVienDTO();
                hocVienDto.MaHocVien = txt_MaHocVien.Text;

                if (_hocVienBll.DeleteHocVien(hocVienDto) == 1)
                {

                    MessageBox.Show("Xóa thành công!");

                    LoadData();

                    Binding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_ChinhSuaHoSo_Click(object sender, EventArgs e)
        {
            if (_hoSoHocVien == null)
            {
                _hoSoHocVien = new frmHoSoHocVien();
                _hoSoHocVien.ShowDialog();
                _hoSoHocVien.FormClosed += _hoSoHocVien_FormClosed;
            }
            else
            {
                _hoSoHocVien.Show();
            }
        }

        void _hoSoHocVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            _hoSoHocVien = null;
        }
    }
}
