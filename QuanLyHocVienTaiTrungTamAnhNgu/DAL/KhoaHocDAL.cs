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
    public class KhoaHocDAL
    {
        private DataConnecter connect;
        public KhoaHocDAL()
        {
            connect = new DataConnecter();
        }

        public List<KhoaHocDTO> SelectAll()
        {
            List<KhoaHocDTO> list = new List<KhoaHocDTO>();

            DataTable dataTable = new DataTable();
            dataTable = connect.GetData("KhoaHoc_SelectAll");
            int row = dataTable.Rows.Count;

            for (int i = 0; i < row; i++)
            {
                KhoaHocDTO khoaHocDTO = new KhoaHocDTO();
                khoaHocDTO.MaKhoaHoc = dataTable.Rows[i].ItemArray[0].ToString();
                khoaHocDTO.NienHoc = int.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                khoaHocDTO.HocKy = int.Parse(dataTable.Rows[i].ItemArray[2].ToString());

                list.Add(khoaHocDTO);
            }

            return list;
        }

        public void InsertKhoaHoc(KhoaHocDTO khoaHocDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaKhoaHoc";
            names[1] = "@NienHoc";
            names[2] = "@HocKy";

            values[0] = khoaHocDTO.MaKhoaHoc;
            values[1] = khoaHocDTO.NienHoc;
            values[2] = khoaHocDTO.HocKy;

            connect.ExcuteNonQuery("KhoaHoc_Insert", names, values, param);
        }

        public void UpdateKhoaHoc(KhoaHocDTO khoaHocDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaKhoaHoc";
            names[1] = "@NienHoc";
            names[2] = "@HocKy";

            values[0] = khoaHocDTO.MaKhoaHoc;
            values[1] = khoaHocDTO.NienHoc;
            values[2] = khoaHocDTO.HocKy;

            connect.ExcuteNonQuery("KhoaHoc_Update", names, values, param);
        }

        public void DeleteKhoaHoc(KhoaHocDTO khoaHocDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];
            names[0] = "@MaKhoaHoc";
            values[0] = khoaHocDTO.MaKhoaHoc;

            connect.ExcuteNonQuery("KhoaHoc_Delete", names, values, param);
        }
    }
}
