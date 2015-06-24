using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using System.Data;

namespace DAL
{
    public class DangKyDAL
    {
        DataConnecter connect;
        //constructor
        public DangKyDAL()
        {
            connect = new DataConnecter();
        }

        //hiển thị danh sách biên lai
        public List<DangKyDTO> SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<DangKyDTO> list = new List<DangKyDTO>();

                dataTable = connect.GetData("DangKy_SelectAll");
                int row = dataTable.Rows.Count;

                for(int i = 0; i < row; i++)
                {
                    DangKyDTO dangKyDTO = new DangKyDTO();
                    dangKyDTO.MaDangKy = dataTable.Rows[i].ItemArray[0].ToString();
                    dangKyDTO.MaKhoaHoc = dataTable.Rows[i].ItemArray[1].ToString();
                    dangKyDTO.MaLop = dataTable.Rows[i].ItemArray[2].ToString();
                    dangKyDTO.MaHocVien = dataTable.Rows[i].ItemArray[3].ToString();
                    dangKyDTO.MaBienLai = dataTable.Rows[i].ItemArray[4].ToString();

                    list.Add(dangKyDTO);
                }

                return list;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public void InsertDangKy(DangKyDTO dangKyDTO)
        {
            int param = 5;
            string [] names = new string[param];
            object [] values = new object[param];

            names[0] = "@MaDangKy";
            names[1] = "@MaKhoaHoc";
            names[2] = "@MaLop";
            names[3] = "@MaHocVien";
            names[4] = "@MaBienLai";

            values[0] = dangKyDTO.MaDangKy;
            values[1] = dangKyDTO.MaKhoaHoc;
            values[2] = dangKyDTO.MaLop;
            values[3] = dangKyDTO.MaHocVien;
            values[4] = dangKyDTO.MaBienLai;

            connect.ExcuteNonQuery("DangKy_Insert",names,values,param);
        }

        public void UpdateDangKy(DangKyDTO dangKyDTO)
        {
            int param = 5;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaDangKy";
            names[1] = "@MaKhoaHoc";
            names[2] = "@MaLop";
            names[3] = "@MaHocVien";
            names[4] = "@MaBienLai";

            values[0] = dangKyDTO.MaDangKy;
            values[1] = dangKyDTO.MaKhoaHoc;
            values[2] = dangKyDTO.MaLop;
            values[3] = dangKyDTO.MaHocVien;
            values[4] = dangKyDTO.MaBienLai;

            connect.ExcuteNonQuery("DangKy_Update", names, values, param);
        }

        public void DeleteByMaDangKy(DangKyDTO dangKyDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaDangKy";
            values[0] = dangKyDTO.MaDangKy;

            connect.ExcuteNonQuery("DangKy_Delete", names, values, param);
        }
    }
}
