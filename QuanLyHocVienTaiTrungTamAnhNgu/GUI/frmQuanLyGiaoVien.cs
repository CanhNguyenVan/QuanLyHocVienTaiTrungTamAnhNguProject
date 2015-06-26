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
    public partial class frmQuanLyGiaoVien : Form
    {

        private GiaoVienBLL _giaoVienBll = new GiaoVienBLL();

        private BangCapBLL _bangCapBll = new BangCapBLL();

        public frmQuanLyGiaoVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();

            Binding();

            BindingTenBangCap();
        }

        private void BindingTenBangCap()
        {
            txt_TenBangCap.DataBindings.Clear();
            txt_TenBangCap.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_TenBangCap.DataBindings.Add("Text", cbx_MaBangCap.DataSource, "TenBangCap");
        }

        private void LoadData()
        {
            dataGridViewQuanLyGiaoVien.DataSource = _giaoVienBll.SelectAll();

            cbx_MaBangCap.DataSource = _bangCapBll.SelectAll();
            cbx_MaBangCap.DisplayMember = "MaBangCap";
            cbx_MaBangCap.ValueMember = "MaBangCap";
        }

        private void Binding()
        {
            txt_MaGiaoVien.DataBindings.Clear();
            txt_MaGiaoVien.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_MaGiaoVien.DataBindings.Add("Text", dataGridViewQuanLyGiaoVien.DataSource, "MaGiaoVien");

            txt_TenGiaoVien.DataBindings.Clear();
            txt_TenGiaoVien.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_TenGiaoVien.DataBindings.Add("Text", dataGridViewQuanLyGiaoVien.DataSource, "TenGiaoVien");

            cbx_MaBangCap.DataBindings.Clear();
            cbx_MaBangCap.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            cbx_MaBangCap.DataBindings.Add("Text", dataGridViewQuanLyGiaoVien.DataSource, "MaBangCap");


        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVienDTO giaoVienDto = new GiaoVienDTO();
                giaoVienDto.MaGiaoVien = MyTools.Utility.PhatSinhMaGiaoVien();
                giaoVienDto.TenGiaoVien = txt_TenGiaoVien.Text;
                giaoVienDto.MaBangCap = (cbx_MaBangCap.SelectedItem as BangCapDTO).MaBangCap;

                _giaoVienBll.InsertGiaoVien(giaoVienDto);

                MessageBox.Show("Thêm thành công!");

                LoadData();
               
                Binding();
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
                GiaoVienDTO giaoVienDto = new GiaoVienDTO();
                giaoVienDto.MaGiaoVien = txt_MaGiaoVien.Text;
                giaoVienDto.TenGiaoVien = txt_TenGiaoVien.Text;
                giaoVienDto.MaBangCap = (cbx_MaBangCap.SelectedItem as BangCapDTO).MaBangCap;

                _giaoVienBll.UpdateGiaoVien(giaoVienDto);

                MessageBox.Show("Sửa thành công!");

                LoadData();

                Binding();
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
                GiaoVienDTO giaoVienDto = new GiaoVienDTO();
                giaoVienDto.MaGiaoVien = txt_MaGiaoVien.Text;
                giaoVienDto.TenGiaoVien = txt_TenGiaoVien.Text;
                giaoVienDto.MaBangCap = (cbx_MaBangCap.SelectedItem as BangCapDTO).MaBangCap;

                _giaoVienBll.DeleteGiaoVien(giaoVienDto);

                MessageBox.Show("Sửa thành công!");

                LoadData();

                Binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
