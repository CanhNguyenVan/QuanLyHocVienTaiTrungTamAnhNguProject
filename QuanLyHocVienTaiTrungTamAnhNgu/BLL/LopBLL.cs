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

        public void InsertLop(LopDTO lopDTO)
        {
            lopDAL.InsertLop(lopDTO);
        }

        public void UpdateLop(LopDTO lopDTO)
        {
            lopDAL.UpdateLop(lopDTO);
        }
        public void DeleteLop(LopDTO lopDTO)
        {
            lopDAL.DeleteLop(lopDTO);
        }
    }
}
