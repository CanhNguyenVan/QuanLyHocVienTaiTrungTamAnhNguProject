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
    public class KyThiDAL
    {
        private DataConnecter connect;

        public KyThiDAL()
        {
            connect = new DataConnecter();
        }

        public List<KyThiDTO> SelectAll()
        {
            try
            {
                List<KyThiDTO> list = new List<KyThiDTO>();

                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("KyThi_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    KyThiDTO kyThiDTO = new KyThiDTO();
                    kyThiDTO.MaKyThi = dataTable.Rows[i].ItemArray[0].ToString();
                    kyThiDTO.MaKhoaHoc = dataTable.Rows[i].ItemArray[1].ToString();
                    kyThiDTO.NgayThi = DateTime.Parse(dataTable.Rows[i].ItemArray[2].ToString());
                    kyThiDTO.GioThi = dataTable.Rows[i].ItemArray[3].ToString();

                    list.Add(kyThiDTO);
                }

                return list;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public int InsertKyThi(KyThiDTO kyThiDTO)
        {
            int param = 4;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaKyThi";
            names[1] = "@MaKhoaHoc";
            names[2] = "@NgayThi";
            names[3] = "@GioThi";

            values[0] = kyThiDTO.MaKyThi;
            values[1] = kyThiDTO.MaKhoaHoc;
            values[2] = kyThiDTO.NgayThi;
            values[3] = kyThiDTO.GioThi;

            return connect.ExcuteNonQuery("KyThi_Insert", names, values, param);
        }

        public int UpdateKyThi(KyThiDTO kyThiDTO)
        {
            int param = 4;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaKyThi";
            names[1] = "@MaKhoaHoc";
            names[2] = "@NgayThi";
            names[3] = "@GioThi";

            values[0] = kyThiDTO.MaKyThi;
            values[1] = kyThiDTO.MaKhoaHoc;
            values[2] = kyThiDTO.NgayThi;
            values[3] = kyThiDTO.GioThi;

            return connect.ExcuteNonQuery("KyThi_Update", names, values, param);
        }

        public int DeleteKyThi(KyThiDTO kyThiDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];
            names[0] = "@MaKyThi";
            values[0] = kyThiDTO.MaKyThi;

            return connect.ExcuteNonQuery("KyThi_Delete", names, values, param);
        }
    }
}
