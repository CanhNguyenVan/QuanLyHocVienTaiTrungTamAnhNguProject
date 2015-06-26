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
    public partial class frmQuanLyKhoaHoc : Form
    {
        private KhoaHocBLL _khoaHocBll = new KhoaHocBLL();

        public frmQuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadData();

            Binding();
        }

        private void LoadData()
        {
            dataGridViewQuanLyKhoaHoc.DataSource = _khoaHocBll.SelectAll();
        }

        private void Binding()
        {
            txt_MaKhoaHoc.DataBindings.Clear();
            txt_MaKhoaHoc.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_MaKhoaHoc.DataBindings.Add("Text", dataGridViewQuanLyKhoaHoc.DataSource, "MaKhoaHoc");

            txt_NienHoc.DataBindings.Clear();
            txt_NienHoc.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_NienHoc.DataBindings.Add("Text", dataGridViewQuanLyKhoaHoc.DataSource, "NienHoc");

            txt_HocKy.DataBindings.Clear();
            txt_HocKy.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_HocKy.DataBindings.Add("Text", dataGridViewQuanLyKhoaHoc.DataSource, "HocKy");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            KhoaHocDTO khoaHOcDto = new KhoaHocDTO();

            try
            {

                khoaHOcDto.MaKhoaHoc = MyTools.Utility.PhatSinhMaKhoaHoc();
                khoaHOcDto.HocKy = int.Parse(txt_HocKy.Text);
                khoaHOcDto.NienHoc = int.Parse(txt_NienHoc.Text);

                if (1 == _khoaHocBll.InsertKhoaHoc(khoaHOcDto))
                {

                    MessageBox.Show("Thêm thành công!");

                    LoadData();

                    Binding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            KhoaHocDTO khoaHOcDto = new KhoaHocDTO();

            try
            {

                khoaHOcDto.MaKhoaHoc = txt_MaKhoaHoc.Text;
                khoaHOcDto.HocKy = int.Parse(txt_HocKy.Text);
                khoaHOcDto.NienHoc = int.Parse(txt_NienHoc.Text);

                if (1 == _khoaHocBll.UpdateKhoaHoc(khoaHOcDto))
                {

                    MessageBox.Show("Sửa thành công!");

                    LoadData();

                    Binding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            KhoaHocDTO khoaHOcDto = new KhoaHocDTO();

            try
            {

                khoaHOcDto.MaKhoaHoc = txt_MaKhoaHoc.Text;
                khoaHOcDto.HocKy = int.Parse(txt_HocKy.Text);
                khoaHOcDto.NienHoc = int.Parse(txt_NienHoc.Text);

                if (1 == _khoaHocBll.DeleteKhoaHoc(khoaHOcDto))
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
    }
}
