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
    public class TraCuuLopDAL
    {
        private DataConnecter connect;

        public TraCuuLopDAL()
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

        public DataTable TraCuuLop()
        {
            try
            {
                DataTable dataTable = new DataTable();               
                dataTable = connect.GetData("TraCuuLop");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public DataTable TraCuuLopTheoMa(string ma)
        {
            try
            {                
                DataTable dataTable = new DataTable();
                int param = 1;
                string[] names = new string[param];
                object[] values = new object[param];

                names[0] = "@MaLop";
                values[0] = ma;                
                dataTable = connect.GetData("TraCuuLopTheoMa", names, values, param);               
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
