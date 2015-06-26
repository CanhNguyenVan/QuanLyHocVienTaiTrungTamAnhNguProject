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
    public class BienLaiDAL
    {
        DataConnecter connect;
        //constructor
        public BienLaiDAL()
        {
            connect = new DataConnecter();
        }

        //hiển thị danh sách biên lai
        public List<BienLaiDTO> SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<BienLaiDTO> list = new List<BienLaiDTO>();

                dataTable = connect.GetData("BienLai_SelectAll");
                int row = dataTable.Rows.Count;

                for(int i = 0; i < row; i++)
                {
                    BienLaiDTO bienLaiDTO = new BienLaiDTO();
                    bienLaiDTO.MaBienLai = dataTable.Rows[i].ItemArray[0].ToString();
                    bienLaiDTO.HocPhi = decimal.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                    bienLaiDTO.MienGiam = decimal.Parse(dataTable.Rows[i].ItemArray[2].ToString());

                    list.Add(bienLaiDTO);
                }

                return list;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public int InsertBienLai(BienLaiDTO bienLaiDTO)
        {
            int param = 3;
            string [] names = new string[param];
            object [] values = new object[param];

            names[0] = "@MaBienLai";
            names[1] = "@HocPhi";
            names[2] = "@MienGiam";

            values[0] = bienLaiDTO.MaBienLai;
            values[1] = bienLaiDTO.HocPhi;
            values[2] = bienLaiDTO.MienGiam;

            return connect.ExcuteNonQuery("BienLai_Insert",names,values,param);
        }

        public int UpdateBienLai(BienLaiDTO bienLaiDTO)
        {
            int param = 3;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaBienLai";
            names[1] = "@HocPhi";
            names[2] = "@MienGiam";

            values[0] = bienLaiDTO.MaBienLai;
            values[1] = bienLaiDTO.HocPhi;
            values[2] = bienLaiDTO.MienGiam;

            return connect.ExcuteNonQuery("BienLai_Update", names, values, param);
        }

        public int DeleteByMaBienLai(BienLaiDTO bienLaiDTO)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaBienLai";
            values[0] = bienLaiDTO.MaBienLai;

            return connect.ExcuteNonQuery("BienLai_Delete", names, values, param);
        }
    }
}
