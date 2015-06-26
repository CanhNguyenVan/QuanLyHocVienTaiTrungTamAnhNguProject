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
    public class BangCapDAL
    {
        private DataConnecter connect = new DataConnecter();
        //constructor
        public BangCapDAL()
        {
            connect = new DataConnecter();
        }

        public List<BangCapDTO> SelectAll()
        {
            try
            {
                List<BangCapDTO> list = new List<BangCapDTO>();
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("BangCap_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    BangCapDTO bangCapDTO = new BangCapDTO();
                    bangCapDTO.MaBangCap = dataTable.Rows[i].ItemArray[0].ToString();
                    bangCapDTO.TenBangCap = dataTable.Rows[i].ItemArray[1].ToString();

                    list.Add(bangCapDTO);
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
            
        }
    }
}
