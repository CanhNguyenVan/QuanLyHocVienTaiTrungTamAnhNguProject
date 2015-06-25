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
    public partial class frmTraCuuHocVien : Form
    {
        DataTable dsHocVien;
        public frmTraCuuHocVien()
        {
            InitializeComponent();         
            dsHocVien = TraCuuHocVienBLL.SelectMaHocVien();
            ShowALL();
            AuToComplete();           
        }

        public void ShowALL()
        {
            DataTable tracuu = TraCuuHocVienBLL.TraCuuHocVien();
            dataGridView.DataSource = tracuu;
        }

        public void AuToComplete()
        {
            cbMaHocVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMaHocVien.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (DataRow row in dsHocVien.Rows)
            {
                data.Add(row.ItemArray[0].ToString());                
            }
            cbMaHocVien.AutoCompleteCustomSource = data;          
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaHocVien.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mã học viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(!cbMaHocVien.Text.Equals("All"))
                    {
                        DataTable tracuu = TraCuuHocVienBLL.TraCuuHocVienTheoMa(cbMaHocVien.Text);
                        dataGridView.DataSource = tracuu;
                    }
                    else
                    {
                        ShowALL();
                    }
                }
            }
            catch { }          
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void cbMaHocVien_MouseClick(object sender, MouseEventArgs e)
        {
            cbMaHocVien.Items.Clear();           
            foreach (DataRow row in dsHocVien.Rows)
            {
                cbMaHocVien.Items.Add(row.ItemArray[0]);
            }

            cbMaHocVien.Items.Add("All");
        }
    }
}
