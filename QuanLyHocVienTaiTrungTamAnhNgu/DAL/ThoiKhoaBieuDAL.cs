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
    public class ThoiKhoaBieuDAL
    {
        private DataConnecter connect;

        public ThoiKhoaBieuDAL()
        {
            connect = new DataConnecter();
        }

        public DataTable SelectMaLop()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("Lop_SelectAll");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public DataTable ThoiKhoaBieu()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("TraCuuTKB");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public DataTable TraCuuTKBTheoMa(string ma)
        {
            try
            {                
                DataTable dataTable = new DataTable();
                int param = 1;
                string[] names = new string[param];
                object[] values = new object[param];

                names[0] = "@MaLop";
                values[0] = ma;
                dataTable = connect.GetData("TraCuuTKBTheoMa", names, values, param);               
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
