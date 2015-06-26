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
    public class HocVienDAL
    {
        private DataConnecter connect;

        public HocVienDAL()
        {
            connect = new DataConnecter();
        }

        public List<HocVienDTO> SelectAll()
        {
            try
            {
                List<HocVienDTO> list = new List<HocVienDTO>();

                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("HocVien_SelectAll");
                int row = dataTable.Rows.Count;           

                for (int i = 0; i < row; i++)
                {
                    HocVienDTO hocVienDTO = new HocVienDTO();
                    hocVienDTO.MaHocVien = dataTable.Rows[i].ItemArray[0].ToString();
                    hocVienDTO.TenHocVien = dataTable.Rows[i].ItemArray[1].ToString();
                    hocVienDTO.NgaySinh = DateTime.Parse(dataTable.Rows[2].ItemArray[2].ToString());
                    hocVienDTO.GioiTinh = dataTable.Rows[i].ItemArray[3].ToString().Trim();
                    hocVienDTO.NgheNghiep = dataTable.Rows[i].ItemArray[4].ToString();
                    hocVienDTO.SoDienThoai = dataTable.Rows[i].ItemArray[5].ToString();
                    hocVienDTO.DiaChi = dataTable.Rows[i].ItemArray[6].ToString();

                    list.Add(hocVienDTO);
                }

                return list;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public int InsertHocVien(HocVienDTO hocVienDTO)
        {
            int param = 7;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaHocVien";
            names[1] = "@TenHocVien";
            names[2] = "@NgaySinh";
            names[3] = "@GioiTinh";
            names[4] = "@NgheNghiep";
            names[5] = "@SoDienThoai";
            names[6] = "@DiaChi";

            values[0] = hocVienDTO.MaHocVien;
            values[1] = hocVienDTO.TenHocVien;
            values[2] = hocVienDTO.NgaySinh;
            values[3] = hocVienDTO.GioiTinh;
            values[4] = hocVienDTO.NgheNghiep;
            values[5] = hocVienDTO.SoDienThoai;
            values[6] = hocVienDTO.DiaChi;

            return connect.ExcuteNonQuery("HocVien_Insert", names, values, param);
        }

        public int UpdateHocVien(HocVienDTO hocVienDTO)
        {
            int param = 7;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaHocVien";
            names[1] = "@TenHocVien";
            names[2] = "@NgaySinh";
            names[3] = "@GioiTinh";
            names[4] = "@NgheNghiep";
            names[5] = "@SoDienThoai";
            names[6] = "@DiaChi";

            values[0] = hocVienDTO.MaHocVien;
            values[1] = hocVienDTO.TenHocVien;
            values[2] = hocVienDTO.NgaySinh;
            values[3] = hocVienDTO.GioiTinh;
            values[4] = hocVienDTO.NgheNghiep;
            values[5] = hocVienDTO.SoDienThoai;
            values[6] = hocVienDTO.DiaChi;

            return connect.ExcuteNonQuery("HocVien_Update", names, values, param);
        }

        public int DeleteHocVien(HocVienDTO hocVienDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaHocVien";
            values[0] = hocVienDTO.MaHocVien;

            return connect.ExcuteNonQuery("HocVien_Delete", names, values, param);
        }
    }
}
