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
    public partial class frmQuanLyLoaiLop : Form
    {
        private LoaiLopBLL _loaiLopBll = new LoaiLopBLL();

        public frmQuanLyLoaiLop()
        {
            InitializeComponent();
        }

        private void frmQuanLyLoaiLop_Load(object sender, EventArgs e)
        {
            LoadData();

            Binding();
        }

        private void LoadData()
        {
            dataGridViewQuanLyLoaiLop.DataSource = _loaiLopBll.SelectAll();
        }

        private void Binding()
        {
            txt_MaLoaiLop.DataBindings.Clear();
            txt_MaLoaiLop.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_MaLoaiLop.DataBindings.Add("Text", dataGridViewQuanLyLoaiLop.DataSource, "MaLoaiLop");

            txt_TenLoaiLop.DataBindings.Clear();
            txt_TenLoaiLop.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_TenLoaiLop.DataBindings.Add("Text", dataGridViewQuanLyLoaiLop.DataSource, "TenLoaiLop");

            dTime_NgayHoc.DataBindings.Clear();
            dTime_NgayHoc.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            dTime_NgayHoc.DataBindings.Add("Value", dataGridViewQuanLyLoaiLop.DataSource, "NgayHoc");

            dTime_GioHoc.DataBindings.Clear();
            dTime_GioHoc.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            dTime_GioHoc.DataBindings.Add("EditValue", dataGridViewQuanLyLoaiLop.DataSource, "GioHoc");

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            try
            {

                LoaiLopDTO loaiLopDto = new LoaiLopDTO();
                loaiLopDto.MaLoaiLop = MyTools.Utility.PhatSinhMaLoaiLop();
                loaiLopDto.TenLoaiLop = txt_TenLoaiLop.Text;
                loaiLopDto.NgayHoc = dTime_NgayHoc.Value;
                loaiLopDto.GioHoc = dTime_GioHoc.EditValue.ToString();

                if (1 == _loaiLopBll.InsertLoaiLop(loaiLopDto))
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
            try
            {

                LoaiLopDTO loaiLopDto = new LoaiLopDTO();
                loaiLopDto.MaLoaiLop = txt_MaLoaiLop.Text;
                loaiLopDto.TenLoaiLop = txt_TenLoaiLop.Text;
                loaiLopDto.NgayHoc = dTime_NgayHoc.Value;
                loaiLopDto.GioHoc = dTime_GioHoc.EditValue.ToString();

                if (1 == _loaiLopBll.UpdateLoaiLop(loaiLopDto))
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
            try
            {

                LoaiLopDTO loaiLopDto = new LoaiLopDTO();
                loaiLopDto.MaLoaiLop = txt_MaLoaiLop.Text;
                loaiLopDto.TenLoaiLop = txt_TenLoaiLop.Text;
                loaiLopDto.NgayHoc = dTime_NgayHoc.Value;
                loaiLopDto.GioHoc = dTime_GioHoc.EditValue.ToString();

                if (1 == _loaiLopBll.DeleteLoaiLop(loaiLopDto))
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
