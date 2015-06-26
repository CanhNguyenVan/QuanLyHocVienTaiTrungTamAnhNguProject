using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LopBLL
    {
        LopDAL lopDAL = new LopDAL();
        public List<LopDTO> SelectAll()
        {
            return lopDAL.SelectAll();
        }

        public int InsertLop(LopDTO lopDTO)
        {
            return lopDAL.InsertLop(lopDTO);
        }

        public int UpdateLop(LopDTO lopDTO)
        {
            return lopDAL.UpdateLop(lopDTO);
        }
        public int DeleteLop(LopDTO lopDTO)
        {
            return lopDAL.DeleteLop(lopDTO);
        }
    }
}
