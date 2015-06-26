using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmHoSoHocVien : Form
    {
        HoSoHocVienBLL _hoSoHocVienBll = new HoSoHocVienBLL();
        HocVienBLL _hocVienBll = new HocVienBLL();
        LopBLL _lopBll = new LopBLL();

        public frmHoSoHocVien()
        {
            InitializeComponent();
        }

        private void frmHoSoHocVien_Load(object sender, EventArgs e)
        {
            LoadData();

            Binding();
        }

        private void Binding()
        {
            txt_MaHoSo.DataBindings.Clear();
            txt_MaHoSo.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_MaHoSo.DataBindings.Add("Text", dataGridViewHoSoHocVien.DataSource, "MaHoSo");

            txt_MaHocVien.DataBindings.Clear();
            txt_MaHocVien.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_MaHocVien.DataBindings.Add("Text", dataGridViewHoSoHocVien.DataSource, "MaHocVien");

            cbx_MaLop.DataBindings.Clear();
            cbx_MaLop.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            cbx_MaLop.DataBindings.Add("Text", dataGridViewHoSoHocVien.DataSource, "MaLop");
            
            txt_Diem.DataBindings.Clear();
            txt_Diem.DataBindings.DefaultDataSourceUpdateMode =   DataSourceUpdateMode.Never;
            txt_Diem.DataBindings.Add("Text", dataGridViewHoSoHocVien.DataSource, "DiemThi");

            txt_XepLoai.DataBindings.Clear();
            txt_XepLoai.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_XepLoai.DataBindings.Add("Text", dataGridViewHoSoHocVien.DataSource, "XepLoai");
        }

        private void LoadData()
        {
            dataGridViewHoSoHocVien.DataSource = _hoSoHocVienBll.SelectAll();

            cbx_MaLop.DataSource = _lopBll.SelectAll();
            cbx_MaLop.DisplayMember = "MaLop";
            cbx_MaLop.ValueMember = "MaLop";

            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                HoSoHocVienDTO hoSoHocVienDto = new HoSoHocVienDTO();
                hoSoHocVienDto.MaHoSo = txt_MaHoSo.Text;
                hoSoHocVienDto.MaHocVien = txt_MaHocVien.Text;
                hoSoHocVienDto.MaLop = (cbx_MaLop.SelectedItem as LopDTO).MaLop;
                hoSoHocVienDto.DiemThi = float.Parse(txt_Diem.Text);
                hoSoHocVienDto.XepLoai = txt_XepLoai.Text;

                _hoSoHocVienBll.UpdateHoSoHocVien(hoSoHocVienDto);

                MessageBox.Show("Cập nhật thành công!");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
