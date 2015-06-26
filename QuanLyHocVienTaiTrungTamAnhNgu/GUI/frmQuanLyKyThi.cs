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
    public partial class frmQuanLyKyThi : Form
    {
        private KyThiBLL _kyThiBll = new KyThiBLL();

        private KhoaHocBLL _khoaHocBll = new KhoaHocBLL();


        public frmQuanLyKyThi()
        {
            InitializeComponent();
        }


        private void frmQuanLyKyThi_Load(object sender, EventArgs e)
        {
            LoadData();

            Binding();

        }

        private void LoadData()
        {
            dataGridViewQuanLyKyThi.DataSource = _kyThiBll.SelectAll();

            cbx_MaKhoaHoc.DataSource = _khoaHocBll.SelectAll();
            cbx_MaKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbx_MaKhoaHoc.ValueMember = "MaKhoaHoc";
        }

        private void Binding()
        {
            txt_MaKyThi.DataBindings.Clear();
            txt_MaKyThi.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_MaKyThi.DataBindings.Add("Text", dataGridViewQuanLyKyThi.DataSource, "MaKyThi");

            cbx_MaKhoaHoc.DataBindings.Clear();
            cbx_MaKhoaHoc.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            cbx_MaKhoaHoc.DataBindings.Add("Text", dataGridViewQuanLyKyThi.DataSource, "MaKhoaHoc");

            dTime_NgayThi.DataBindings.Clear();
            dTime_NgayThi.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            dTime_NgayThi.DataBindings.Add("Value", dataGridViewQuanLyKyThi.DataSource, "NgayThi");

            tEd_GioThi.DataBindings.Clear();
            tEd_GioThi.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            tEd_GioThi.DataBindings.Add("EditValue", dataGridViewQuanLyKyThi.DataSource, "GioThi");


        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                KyThiDTO kyThiDto = new KyThiDTO();

                kyThiDto.MaKyThi = MyTools.Utility.PhatSinhMaKyThi();
                kyThiDto.MaKhoaHoc = (cbx_MaKhoaHoc.SelectedItem as KhoaHocDTO).MaKhoaHoc;
                kyThiDto.NgayThi = dTime_NgayThi.Value;
                kyThiDto.GioThi = tEd_GioThi.EditValue.ToString();

                if (1 == _kyThiBll.InsertKyThi(kyThiDto))
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
                KyThiDTO kyThiDto = new KyThiDTO();

                kyThiDto.MaKyThi = txt_MaKyThi.Text;
                kyThiDto.MaKhoaHoc = (cbx_MaKhoaHoc.SelectedItem as KhoaHocDTO).MaKhoaHoc;
                kyThiDto.NgayThi = dTime_NgayThi.Value;
                kyThiDto.GioThi = tEd_GioThi.EditValue.ToString();

                if (1 == _kyThiBll.UpdateKyThi(kyThiDto))
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
                KyThiDTO kyThiDto = new KyThiDTO();

                kyThiDto.MaKyThi = txt_MaKyThi.Text;
                kyThiDto.MaKhoaHoc = (cbx_MaKhoaHoc.SelectedItem as KhoaHocDTO).MaKhoaHoc;
                kyThiDto.NgayThi = dTime_NgayThi.Value;
                kyThiDto.GioThi = tEd_GioThi.EditValue.ToString();

                if (1 == _kyThiBll.DeleteKyThi(kyThiDto))
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
