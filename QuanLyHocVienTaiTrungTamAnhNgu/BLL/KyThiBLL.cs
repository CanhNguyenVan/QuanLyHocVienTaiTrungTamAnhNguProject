using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KyThiBLL
    {
        KyThiDAL kyThiDAL = new KyThiDAL();
        public List<KyThiDTO> SelectAll()
        {
            return kyThiDAL.SelectAll();
        }

        public void InsertKyThi(KyThiDTO kyThiDTO)
        {
            kyThiDAL.InsertKyThi(kyThiDTO);
        }
        public void UpdateKyThi(KyThiDTO kyThiDTO)
        {
            kyThiDAL.UpdateKyThi(kyThiDTO);
        }

        public void DeleteKyThi(KyThiDTO kyThiDTO)
        {
            kyThiDAL.DeleteKyThi(kyThiDTO);
        }
    }
}
