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
    public partial class frmQuanLyLop : Form
    {
        private LopBLL _lopBll = new LopBLL();

        private CapLopBLL _capLopBll = new CapLopBLL();

        private LoaiLopBLL _loaiLopBll  = new LoaiLopBLL();

        private KhoaHocBLL _khoaHocBll = new KhoaHocBLL();

        private frmQuanLyCapLop _frmCapLop = null;

        private frmQuanLyLoaiLop _frmLoaiLop = null;

        public frmQuanLyLop()
        {
            InitializeComponent();
        }

        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadData();

            Binding();
        }

        private void Binding()
        {
            txt_MaLop.DataBindings.Clear();
            txt_MaLop.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_MaLop.DataBindings.Add("Text", dataGridViewQuanLyLop.DataSource, "MaLop");

            cbx_MaCapLop.DataBindings.Clear();
            cbx_MaCapLop.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            cbx_MaCapLop.DataBindings.Add("Text", dataGridViewQuanLyLop.DataSource, "MaCapLop");

            cbx_MaKhoaHoc.DataBindings.Clear();
            cbx_MaKhoaHoc.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            cbx_MaKhoaHoc.DataBindings.Add("Text", dataGridViewQuanLyLop.DataSource, "MaKhoaHoc");

            cbx_MaLoaiLop.DataBindings.Clear();
            cbx_MaLoaiLop.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            cbx_MaLoaiLop.DataBindings.Add("Text", dataGridViewQuanLyLop.DataSource, "MaLoaiLop");

            txt_TenLop.DataBindings.Clear();
            txt_TenLop.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_TenLop.DataBindings.Add("Text", dataGridViewQuanLyLop.DataSource, "TenLop");

            txt_SiSo.DataBindings.Clear();
            txt_SiSo.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_SiSo.DataBindings.Add("Text", dataGridViewQuanLyLop.DataSource, "SiSo");
        }

        private void LoadData()
        {
            dataGridViewQuanLyLop.DataSource = _lopBll.SelectAll();

            cbx_MaCapLop.DataSource = _capLopBll.SelectAll();
            cbx_MaCapLop.DisplayMember = "MaCapLop";
            cbx_MaCapLop.ValueMember = "MaCapLop";

            cbx_MaLoaiLop.DataSource = _loaiLopBll.SelectAll();
            cbx_MaLoaiLop.DisplayMember = "MaLoaiLop";
            cbx_MaLoaiLop.ValueMember = "MaLoaiLop";

            cbx_MaKhoaHoc.DataSource = _khoaHocBll.SelectAll();
            cbx_MaKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbx_MaKhoaHoc.ValueMember = "MaKhoaHoc";
        }

        private void txt_SiSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                LopDTO lopDto = new LopDTO();
                lopDto.MaLop = MyTools.Utility.PhatSinhMaLop();
                lopDto.MaCapLop = (cbx_MaCapLop.SelectedItem as CapLopDTO).MaCapLop;
                lopDto.MaLoaiLop = (cbx_MaLoaiLop.SelectedItem as LoaiLopDTO).MaLoaiLop;
                lopDto.MaKhoaHoc = (cbx_MaKhoaHoc.SelectedItem as KhoaHocDTO).MaKhoaHoc;
                lopDto.TenLop = txt_TenLop.Text;
                lopDto.SiSo = int.Parse(txt_SiSo.Text);

                _lopBll.InsertLop(lopDto);

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
                LopDTO lopDto = new LopDTO();
                lopDto.MaLop = txt_MaLop.Text;
                lopDto.MaCapLop = (cbx_MaCapLop.SelectedItem as CapLopDTO).MaCapLop;
                lopDto.MaLoaiLop = (cbx_MaLoaiLop.SelectedItem as LoaiLopDTO).MaLoaiLop;
                lopDto.MaKhoaHoc = (cbx_MaKhoaHoc.SelectedItem as KhoaHocDTO).MaKhoaHoc;
                lopDto.TenLop = txt_TenLop.Text;
                lopDto.SiSo = int.Parse(txt_SiSo.Text);

                _lopBll.UpdateLop(lopDto);

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
                LopDTO lopDto = new LopDTO();
                lopDto.MaLop = txt_MaLop.Text;
                lopDto.MaCapLop = (cbx_MaCapLop.SelectedItem as CapLopDTO).MaCapLop;
                lopDto.MaLoaiLop = (cbx_MaLoaiLop.SelectedItem as LoaiLopDTO).MaLoaiLop;
                lopDto.MaKhoaHoc = (cbx_MaKhoaHoc.SelectedItem as KhoaHocDTO).MaKhoaHoc;
                lopDto.TenLop = txt_TenLop.Text;
                lopDto.SiSo = int.Parse(txt_SiSo.Text);

                _lopBll.DeleteLop(lopDto);

                MessageBox.Show("Xóa thành công!");

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
