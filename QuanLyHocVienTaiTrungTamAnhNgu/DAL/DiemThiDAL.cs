using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DiemThiDAL
    {
        private DataConnecter connect;

        //constructor
        public DiemThiDAL()
        {
            connect = new DataConnecter();
        }

        public List<DiemThiDTO> SelectAll()
        {
            try
            {
                List<DiemThiDTO> list = new List<DiemThiDTO>();

                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("DiemThi_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    DiemThiDTO diemThiDTO = new DiemThiDTO();
                    diemThiDTO.MaHocVien = dataTable.Rows[i].ItemArray[0].ToString();
                    diemThiDTO.MaKyThi = dataTable.Rows[i].ItemArray[1].ToString();
                    diemThiDTO.Diem = float.Parse(dataTable.Rows[i].ItemArray[2].ToString());

                    list.Add(diemThiDTO);
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public int InsertDiemThi(DiemThiDTO diemThiDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaHocVien";
            names[1] = "@MaKyThi";
            names[2] = "@DiemThi";

            values[0] = diemThiDTO.MaHocVien;
            values[1] = diemThiDTO.MaKyThi;
            values[2] = diemThiDTO.Diem;

            return connect.ExcuteNonQuery("DiemThi_Insert", names, values, param);
        }

        public int UpdateDiemThi(DiemThiDTO diemThiDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaHocVien";
            names[1] = "@MaKyThi";
            names[2] = "@DiemThi";

            values[0] = diemThiDTO.MaHocVien;
            values[1] = diemThiDTO.MaKyThi;
            values[2] = diemThiDTO.Diem;

            return connect.ExcuteNonQuery("DiemThi_Update", names, values, param);
        }

        public int DeleteDiemThi(DiemThiDTO diemThiDTO)
        {
            int param = 2;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaHocVien";
            names[1] = "@MaKyThi";

            values[0] = diemThiDTO.MaHocVien;
            values[1] = diemThiDTO.MaKyThi;

            return connect.ExcuteNonQuery("DiemThi_Delete", names, values, param);
        }
    }
}
