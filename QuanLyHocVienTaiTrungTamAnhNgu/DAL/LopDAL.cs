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
    public class LopDAL
    {
        private DataConnecter connect;
        public LopDAL()
        {
            connect = new DataConnecter();
        }

        public List<LopDTO> SelectAll()
        {
            List<LopDTO> list = new List<LopDTO>();

            DataTable dataTable = new DataTable();
            dataTable = connect.GetData("Lop_SelectAll");
            int row = dataTable.Rows.Count;

            for (int i = 0; i < row; i++)
            {
                LopDTO lopDTO = new LopDTO();
                lopDTO.MaLop = dataTable.Rows[i].ItemArray[0].ToString();
                lopDTO.MaCapLop = dataTable.Rows[i].ItemArray[1].ToString();
                lopDTO.MaLoaiLop = dataTable.Rows[i].ItemArray[2].ToString();
                lopDTO.MaKhoaHoc = dataTable.Rows[i].ItemArray[3].ToString();
                lopDTO.TenLop = dataTable.Rows[i].ItemArray[4].ToString();
                lopDTO.SiSo = int.Parse(dataTable.Rows[i].ItemArray[5].ToString());

                list.Add(lopDTO);
            }

            return list;
        }

        public void InsertLop(LopDTO lopDTO)
        {
            int param = 6;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaLop";
            names[1] = "@MaCapLop";
            names[2] = "@MaLoaiLop";
            names[3] = "@MaKhoaHoc";
            names[4] = "@TenLop";
            names[5] = "@SiSo";

            values[0] = lopDTO.MaLop;
            values[1] = lopDTO.MaCapLop;
            values[2] = lopDTO.MaLoaiLop;
            values[3] = lopDTO.MaKhoaHoc;
            values[4] = lopDTO.TenLop;
            values[5] = lopDTO.SiSo;

            connect.ExcuteNonQuery("Lop_Insert", names, values, param);
        }

        public void UpdateLop(LopDTO lopDTO)
        {
            int param = 6;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaLop";
            names[1] = "@MaCapLop";
            names[2] = "@MaLoaiLop";
            names[3] = "@MaKhoaHoc";
            names[4] = "@TenLop";
            names[5] = "@SiSo";

            values[0] = lopDTO.MaLop;
            values[1] = lopDTO.MaCapLop;
            values[2] = lopDTO.MaLoaiLop;
            values[3] = lopDTO.MaKhoaHoc;
            values[4] = lopDTO.TenLop;
            values[5] = lopDTO.SiSo;

            connect.ExcuteNonQuery("Lop_Update", names, values, param);
        }

        public void DeleteLop(LopDTO lopDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaLop";
            values[0] = lopDTO.MaLop;

            connect.ExcuteNonQuery("Lop_Delete", names, values, param);
        }
    }
}
