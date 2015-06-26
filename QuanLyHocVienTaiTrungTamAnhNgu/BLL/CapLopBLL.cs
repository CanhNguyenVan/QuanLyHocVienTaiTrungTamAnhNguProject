using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CapLopBLL
    {
        CapLopDAL capLopDAL = new CapLopDAL();
        public List<CapLopDTO> SelectAll()
        {
            return capLopDAL.SelectAll();
        }

        public int InsertCapLop(CapLopDTO capLopDTO)
        {
            return capLopDAL.InsertCapLop(capLopDTO);
        }

        public int UpdateCapLop(CapLopDTO capLopDTO)
        {
            return capLopDAL.UpdateCapLop(capLopDTO);
        }

        public int DeleteCapLop(CapLopDTO capLopDTO)
        {
            return capLopDAL.DeleteCapLop(capLopDTO);
        }
    }
}
