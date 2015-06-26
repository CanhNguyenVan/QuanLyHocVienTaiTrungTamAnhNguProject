using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DTO;

namespace DAL
{
    public class CapLopDAL
    {
        private DataConnecter connect;

        public CapLopDAL()
        {
            connect = new DataConnecter();
        }

        public List<CapLopDTO> SelectAll()
        {
            try
            {
                List<CapLopDTO> list = new List<CapLopDTO>();

                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("CapLop_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    CapLopDTO capLopDTO = new CapLopDTO();
                    capLopDTO.MaCapLop = dataTable.Rows[i].ItemArray[0].ToString();
                    capLopDTO.TenCapLop = dataTable.Rows[i].ItemArray[1].ToString();

                    list.Add(capLopDTO);
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public int InsertCapLop(CapLopDTO capLopDTO)
        {
            int param = 2;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaCapLop";
            names[1] = "@TenCapLop";

            values[0] = capLopDTO.MaCapLop;
            values[1] = capLopDTO.TenCapLop;

            return connect.ExcuteNonQuery("CapLop_Insert", names, values, param);
        }

        public int UpdateCapLop(CapLopDTO capLopDTO)
        {
            int param = 2;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaCapLop";
            names[1] = "@TenCapLop";

            values[0] = capLopDTO.MaCapLop;
            values[1] = capLopDTO.TenCapLop;

            return connect.ExcuteNonQuery("CapLop_Update", names, values, param);
        }

        public int DeleteCapLop(CapLopDTO capLopDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaCapLop";
            values[0] = capLopDTO.MaCapLop;

            return connect.ExcuteNonQuery("CapLop_Delete", names, values, param);
        }
    }
}
