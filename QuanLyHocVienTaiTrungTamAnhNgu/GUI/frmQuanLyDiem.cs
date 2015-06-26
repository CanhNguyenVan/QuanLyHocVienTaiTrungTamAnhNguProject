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
    public partial class frmQuanLyDiem : Form
    {
        DiemThiBLL _diemThiBll = new DiemThiBLL();

        HocVienBLL _hocVienBll = new HocVienBLL();

        KyThiBLL _kyThiBll = new KyThiBLL();


        public frmQuanLyDiem()
        {
            InitializeComponent();
        }

        private void frmQuanLyDiem_Load(object sender, EventArgs e)
        {
            LoadData();

            Binding();
        }

        private void LoadData()
        {
            dataGridViewQuanLyDiem.DataSource = _diemThiBll.SelectAll();

            cbx_MaHocVien.DataSource = _hocVienBll.SelectAll();
            cbx_MaHocVien.DisplayMember = "MaHocVien";
            cbx_MaHocVien.ValueMember = "MaHocVien";

            cbx_MaKyThi.DataSource = _kyThiBll.SelectAll();
            cbx_MaKyThi.DisplayMember = "MaKyThi";
            cbx_MaKyThi.ValueMember = "MaKyThi";

        }

        private void Binding()
        {
            cbx_MaHocVien.DataBindings.Clear();
            cbx_MaHocVien.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            cbx_MaHocVien.DataBindings.Add("Text", dataGridViewQuanLyDiem.DataSource, "MaHocVien");

            cbx_MaKyThi.DataBindings.Clear();
            cbx_MaKyThi.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            cbx_MaKyThi.DataBindings.Add("Text", dataGridViewQuanLyDiem.DataSource, "MaKyThi");

            txt_Diem.DataBindings.Clear();
            txt_Diem.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_Diem.DataBindings.Add("Text", dataGridViewQuanLyDiem.DataSource, "Diem");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            try
            {
                DiemThiDTO diemThiDto = new DiemThiDTO();
                diemThiDto.MaHocVien = (cbx_MaHocVien.SelectedItem as HocVienDTO).MaHocVien;
                diemThiDto.MaKyThi = (cbx_MaKyThi.SelectedItem as KyThiDTO).MaKyThi;
                diemThiDto.Diem = int.Parse(txt_Diem.Text);

                _diemThiBll.InsertDiemThi(diemThiDto);

                LoadData();

                Binding();

                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                DiemThiDTO diemThiDto = new DiemThiDTO();
                diemThiDto.MaHocVien = (cbx_MaHocVien.SelectedItem as HocVienDTO).MaHocVien;
                diemThiDto.MaKyThi = (cbx_MaKyThi.SelectedItem as KyThiDTO).MaKyThi;
                diemThiDto.Diem = int.Parse(txt_Diem.Text);

                _diemThiBll.UpdateDiemThi(diemThiDto);

                LoadData();

                Binding();

                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            try
            {
                DiemThiDTO diemThiDto = new DiemThiDTO();
                diemThiDto.MaHocVien = (cbx_MaHocVien.SelectedItem as HocVienDTO).MaHocVien;
                diemThiDto.MaKyThi = (cbx_MaKyThi.SelectedItem as KyThiDTO).MaKyThi;
                diemThiDto.Diem = int.Parse(txt_Diem.Text);

                _diemThiBll.DeleteDiemThi(diemThiDto);

                LoadData();

                Binding();

                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
