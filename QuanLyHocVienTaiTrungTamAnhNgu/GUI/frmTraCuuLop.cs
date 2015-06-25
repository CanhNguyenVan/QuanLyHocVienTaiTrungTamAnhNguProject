using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTraCuuLop : Form
    {
        DataTable dsLop;
        public frmTraCuuLop()
        {
            InitializeComponent();
            dsLop = TraCuuLopBLL.SelectMaLop();
            ShowALL();
            AuToComplete();       
        }

        public void ShowALL()
        {
            DataTable tracuu = TraCuuLopBLL.TraCuuLop();
            dataGridView.DataSource = tracuu;
        }

        public void AuToComplete()
        {
            cbMaLop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMaLop.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (DataRow row in dsLop.Rows)
            {
                data.Add(row.ItemArray[0].ToString());
            }
            cbMaLop.AutoCompleteCustomSource = data;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaLop.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mã lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!cbMaLop.Text.Equals("All"))
                    {
                        DataTable tracuu = TraCuuLopBLL.TraCuuLopTheoMa(cbMaLop.Text);
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

        private void cbMaLop_MouseClick(object sender, MouseEventArgs e)
        {
            cbMaLop.Items.Clear();
            foreach (DataRow row in dsLop.Rows)
            {
                cbMaLop.Items.Add(row.ItemArray[0]);
            }

            cbMaLop.Items.Add("All");
        }
    }
}
