using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BangCapBLL
    {
        BangCapDAL bangCapDAL = new BangCapDAL();

        public List<BangCapDTO> SelectAll()
        {
            return bangCapDAL.SelectAll();
        }
    }
}
