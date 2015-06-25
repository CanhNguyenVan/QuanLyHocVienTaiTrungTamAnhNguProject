using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class TraCuuHocVienDAL
    {
        private DataConnecter connect;

        public TraCuuHocVienDAL()
        {
            connect = new DataConnecter();
        }

        public DataTable SelectMaHocVien()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("HocVien_SelectAll");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public DataTable TraCuuHocVien()
        {
            try
            {
                DataTable dataTable = new DataTable();               
                dataTable = connect.GetData("TraCuuHocVien");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public DataTable TraCuuHocVienTheoMa(string ma)
        {
            try
            {                
                DataTable dataTable = new DataTable();
                int param = 1;
                string[] names = new string[param];
                object[] values = new object[param];

                names[0] = "@MaHocVien";
                values[0] = ma;                
                dataTable = connect.GetData("TraCuuHocVienTheoMa", names, values, param);               
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }
    }
}
