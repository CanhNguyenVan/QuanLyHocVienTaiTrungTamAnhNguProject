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
    public class PhanCongDAL
    {
        private DataConnecter connect;
        public PhanCongDAL()
        {
            connect = new DataConnecter();
        }
    }
}
