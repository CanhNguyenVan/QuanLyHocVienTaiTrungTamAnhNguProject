using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Data;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private DataConnecter connect;
        public TaiKhoanDAL()
        {
            connect = new DataConnecter();
        }

        public List<TaiKhoanDTO> SelectAll()
        {
            try
            {
                List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();

                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("TaiKhoan_SelectAll");

                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                    taiKhoanDTO.TenTK = dataTable.Rows[i].ItemArray[1].ToString();
                    taiKhoanDTO.MatKhau = dataTable.Rows[i].ItemArray[2].ToString();
                    taiKhoanDTO.LoaiTK = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                }

                    return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public List<TaiKhoanDTO> SelectLastMaTK()
        {
            try
            {
                List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();

                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("TaiKhoan_SelectLastMaTK");

                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                    taiKhoanDTO.TenTK = dataTable.Rows[i].ItemArray[1].ToString();
                    taiKhoanDTO.MatKhau = dataTable.Rows[i].ItemArray[2].ToString();
                    taiKhoanDTO.LoaiTK = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public void InsertTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@TenTK";
            names[1] = "@MatKhau";
            names[2] = "@LoaiTK";

            values[0] = taiKhoanDTO.TenTK;
            values[1] = taiKhoanDTO.MatKhau;
            values[2] = taiKhoanDTO.LoaiTK;

            connect.ExcuteNonQuery("TaiKhoan_Insert", names, values, param);
        }

        public void UpdateTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@TenTK";
            names[1] = "@MatKhau";
            names[2] = "@LoaiTK";

            values[0] = taiKhoanDTO.TenTK;
            values[1] = taiKhoanDTO.MatKhau;
            values[2] = taiKhoanDTO.LoaiTK;

            connect.ExcuteNonQuery("TaiKhoan_Update", names, values, param);
        }

        public void DeleteTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@TenTK";

            values[0] = taiKhoanDTO.TenTK;

            connect.ExcuteNonQuery("TaiKhoan_Delete", names, values, param);
        }

    }
}
