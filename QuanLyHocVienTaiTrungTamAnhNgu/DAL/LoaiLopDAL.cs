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
    public class LoaiLopDAL
    {
        private DataConnecter connect;

        public LoaiLopDAL()
        {
            connect = new DataConnecter();
        }

        public List<LoaiLopDTO> SelectAll()
        {
            try
            {
                List<LoaiLopDTO> list = new List<LoaiLopDTO>();

                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("LoaiLop_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    LoaiLopDTO loaiLopDTO = new LoaiLopDTO();
                    loaiLopDTO.MaLoaiLop = dataTable.Rows[i].ItemArray[0].ToString();
                    loaiLopDTO.TenLoaiLop = dataTable.Rows[i].ItemArray[1].ToString();
                    loaiLopDTO.NgayHoc = DateTime.Parse(dataTable.Rows[i].ItemArray[2].ToString());
                    loaiLopDTO.GioHoc = dataTable.Rows[i].ItemArray[3].ToString();

                    list.Add(loaiLopDTO);
                }

                return list;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public int InsertLoaiLop(LoaiLopDTO loaiLopDTO)
        {
            int param = 4;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaLoaiLop";
            names[1] = "@TenLoaiLop";
            names[2] = "@NgayHoc";
            names[3] = "@GioHoc";

            values[0] = loaiLopDTO.MaLoaiLop;
            values[1] = loaiLopDTO.TenLoaiLop;
            values[2] = loaiLopDTO.NgayHoc;
            values[3] = loaiLopDTO.GioHoc;

            return connect.ExcuteNonQuery("LoaiLop_Insert", names, values, param);
        }

        public int UpdateLoaiLop(LoaiLopDTO loaiLopDTO)
        {
            int param = 4;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaLoaiLop";
            names[1] = "@TenLoaiLop";
            names[2] = "@NgayHoc";
            names[3] = "@GioHoc";

            values[0] = loaiLopDTO.MaLoaiLop;
            values[1] = loaiLopDTO.TenLoaiLop;
            values[2] = loaiLopDTO.NgayHoc;
            values[3] = loaiLopDTO.GioHoc;

            return connect.ExcuteNonQuery("LoaiLop_Update", names, values, param);
        }

        public int DeleteLoaiLop(LoaiLopDTO loaiLopDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];
            names[0] = "@MaLoaiLop";
            values[0] = loaiLopDTO.MaLoaiLop;

            return connect.ExcuteNonQuery("LoaiLop_Delete", names, values, param);
        }
    }
}
