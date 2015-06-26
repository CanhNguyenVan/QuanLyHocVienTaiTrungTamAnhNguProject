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
    public class GiaoVienDAL
    {
        private DataConnecter connect;
        public GiaoVienDAL()
        {
            connect = new DataConnecter();
        }

        public List<GiaoVienDTO> SelectAll()
        {
            List<GiaoVienDTO> list = new List<GiaoVienDTO>();

            DataTable dataTable = new DataTable();
            dataTable = connect.GetData("GiaoVien_SelectAll");
            int row = dataTable.Rows.Count;

            for (int i = 0; i < row; i++)
            {
                GiaoVienDTO giaoVienDTO = new GiaoVienDTO();
                giaoVienDTO.MaGiaoVien = dataTable.Rows[i].ItemArray[0].ToString();
                giaoVienDTO.TenGiaoVien = dataTable.Rows[i].ItemArray[1].ToString();
                giaoVienDTO.MaBangCap = dataTable.Rows[i].ItemArray[2].ToString();

                list.Add(giaoVienDTO);
            }

            return list;
        }

        public int InsertGiaoVien(GiaoVienDTO giaoVienDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaGiaoVien";
            names[1] = "@TenGiaoVien";
            names[2] = "@MaBangCap";

            values[0] = giaoVienDTO.MaGiaoVien;
            values[1] = giaoVienDTO.TenGiaoVien;
            values[2] = giaoVienDTO.MaBangCap;

            return connect.ExcuteNonQuery("GiaoVien_Insert", names, values, param);
        }

        public int UpdateGiaoVien(GiaoVienDTO giaoVienDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaGiaoVien";
            names[1] = "@TenGiaoVien";
            names[2] = "@MaBangCap";

            values[0] = giaoVienDTO.MaGiaoVien;
            values[1] = giaoVienDTO.TenGiaoVien;
            values[2] = giaoVienDTO.MaBangCap;

            return connect.ExcuteNonQuery("GiaoVien_Update", names, values, param);
        }

        public int DeleteGiaoVien(GiaoVienDTO giaoVienDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaGiaoVien";
            values[0] = giaoVienDTO.MaGiaoVien;

            return connect.ExcuteNonQuery("GiaoVien_Delete", names, values, param);
        }
    }
}
