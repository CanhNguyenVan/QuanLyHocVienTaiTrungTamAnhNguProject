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
    public class HoSoHocVienDAL
    {
        private DataConnecter connect;

        public HoSoHocVienDAL()
        {
            connect = new DataConnecter();
        }

        public List<HoSoHocVienDTO> SelectAll()
        {
            List<HoSoHocVienDTO> list = new List<HoSoHocVienDTO>();

            DataTable dataTable = new DataTable();
            dataTable = connect.GetData("HoSoHocVien_SelectAll");
            int row = dataTable.Rows.Count;

            for (int i = 0; i < row; i++)
            {
                HoSoHocVienDTO hoSoHocVienDTO = new HoSoHocVienDTO();
                hoSoHocVienDTO.MaHoSo = dataTable.Rows[i].ItemArray[0].ToString();
                hoSoHocVienDTO.MaHocVien = dataTable.Rows[i].ItemArray[1].ToString();
                hoSoHocVienDTO.MaLop = dataTable.Rows[i].ItemArray[2].ToString();
                hoSoHocVienDTO.DiemThi = float.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                hoSoHocVienDTO.XepLoai = dataTable.Rows[i].ItemArray[4].ToString();

                list.Add(hoSoHocVienDTO);
            }

            return list;
        }

        public void InsertHoSoHocVien(HoSoHocVienDTO hoSoHocVienDTO)
        {
            int param = 5;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaHoSo";
            names[1] = "@MaHocVien";
            names[2] = "@MaLop";
            names[3] = "@DiemThi";
            names[4] = "@XepLoai";

            values[0] = hoSoHocVienDTO.MaHoSo;
            values[1] = hoSoHocVienDTO.MaHocVien;
            values[2] = hoSoHocVienDTO.MaLop;
            values[3] = hoSoHocVienDTO.DiemThi;
            values[4] = hoSoHocVienDTO.XepLoai;

            connect.ExcuteNonQuery("HoSoHocVien_Insert", names, values, param);
        }

        public void UpdateHoSoHocVien(HoSoHocVienDTO hoSoHocVienDTO)
        {
            int param = 5;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaHoSo";
            names[1] = "@MaHocVien";
            names[2] = "@MaLop";
            names[3] = "@DiemThi";
            names[4] = "@XepLoai";

            values[0] = hoSoHocVienDTO.MaHoSo;
            values[1] = hoSoHocVienDTO.MaHocVien;
            values[2] = hoSoHocVienDTO.MaLop;
            values[3] = hoSoHocVienDTO.DiemThi;
            values[4] = hoSoHocVienDTO.XepLoai;

            connect.ExcuteNonQuery("HoSoHocVien_Update", names, values, param);
        }

        public void DeleteHoSoHocVien(HoSoHocVienDTO hoSoHocVienDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaHoSo";
            values[0] = hoSoHocVienDTO.MaHoSo;

            connect.ExcuteNonQuery("HoSoHocVien_Delete", names, values, param);
        }
    }
}
