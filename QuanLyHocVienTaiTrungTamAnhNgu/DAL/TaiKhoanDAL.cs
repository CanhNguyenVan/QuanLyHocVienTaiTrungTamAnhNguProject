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
                    taiKhoanDTO.MaTK = int.Parse(dataTable.Rows[i].ItemArray[0].ToString());
                    taiKhoanDTO.TenTK = dataTable.Rows[i].ItemArray[1].ToString();
                    taiKhoanDTO.MatKhau = dataTable.Rows[i].ItemArray[2].ToString();
                    taiKhoanDTO.LoaiTK = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                    list.Add(taiKhoanDTO);
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
                    taiKhoanDTO.MaTK = int.Parse(dataTable.Rows[i].ItemArray[0].ToString());
                    //taiKhoanDTO.TenTK = dataTable.Rows[i].ItemArray[1].ToString();
                    //taiKhoanDTO.MatKhau = dataTable.Rows[i].ItemArray[2].ToString();
                    //taiKhoanDTO.LoaiTK = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                    list.Add(taiKhoanDTO);
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
            int param = 4;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaTK";
            names[1] = "@TenTK";
            names[2] = "@MatKhau";
            names[3] = "@LoaiTK";

            values[0] = taiKhoanDTO.MaTK;
            values[1] = taiKhoanDTO.TenTK;
            values[2] = taiKhoanDTO.MatKhau;
            values[3] = taiKhoanDTO.LoaiTK;

            connect.ExcuteNonQuery("TaiKhoan_Insert", names, values, param);
        }

        public void UpdateTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            int param = 4;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaTK";
            names[1] = "@TenTK";
            names[2] = "@MatKhau";
            names[3] = "@LoaiTK";

            values[0] = taiKhoanDTO.MaTK;
            values[1] = taiKhoanDTO.TenTK;
            values[2] = taiKhoanDTO.MatKhau;
            values[3] = taiKhoanDTO.LoaiTK;

            connect.ExcuteNonQuery("TaiKhoan_Update", names, values, param);
        }

        public void DeleteTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaTK";

            values[0] = taiKhoanDTO.MaTK;

            connect.ExcuteNonQuery("TaiKhoan_Delete", names, values, param);
        }

    }
}
