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

        public void InsertCapLop(CapLopDTO capLopDTO)
        {
            capLopDAL.InsertCapLop(capLopDTO);
        }

        public void UpdateCapLop(CapLopDTO capLopDTO)
        {
            capLopDAL.UpdateCapLop(capLopDTO);
        }

        public void DeleteCapLop(CapLopDTO capLopDTO)
        {
            capLopDAL.DeleteCapLop(capLopDTO);
        }
    }
}
