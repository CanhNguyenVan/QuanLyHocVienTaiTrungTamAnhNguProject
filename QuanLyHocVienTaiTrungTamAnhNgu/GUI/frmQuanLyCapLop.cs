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
    public partial class frmQuanLyCapLop : Form
    {

        CapLopBLL _capLopBll = new CapLopBLL();

        public frmQuanLyCapLop()
        {
            InitializeComponent();
        }

        private void frmQuanLyCapLop_Load(object sender, EventArgs e)
        {
            LoadData();

            Binding();
        }

        private void LoadData()
        {
            dataGridViewQuanLyCapLop.DataSource = _capLopBll.SelectAll();
        }

        private void Binding()
        {
            txt_MaCapLop.DataBindings.Clear();
            txt_MaCapLop.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_MaCapLop.DataBindings.Add("Text", dataGridViewQuanLyCapLop.DataSource, "MaCapLop");

            txt_TenLop.DataBindings.Clear();
            txt_TenLop.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txt_TenLop.DataBindings.Add("Text", dataGridViewQuanLyCapLop.DataSource, "TenCapLop");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                CapLopDTO capLopDto = new CapLopDTO();
                capLopDto.MaCapLop = MyTools.Utility.PhatSinhMaCapLop();
                capLopDto.TenCapLop = txt_TenLop.Text;

                if (1 == _capLopBll.InsertCapLop(capLopDto))
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
                CapLopDTO capLopDto = new CapLopDTO();
                capLopDto.MaCapLop = txt_MaCapLop.Text;
                capLopDto.TenCapLop = txt_TenLop.Text;

                if (1 == _capLopBll.UpdateCapLop(capLopDto))
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
                CapLopDTO capLopDto = new CapLopDTO();
                capLopDto.MaCapLop = txt_MaCapLop.Text;
                capLopDto.TenCapLop = txt_TenLop.Text;

                if (1 ==_capLopBll.DeleteCapLop(capLopDto))
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
