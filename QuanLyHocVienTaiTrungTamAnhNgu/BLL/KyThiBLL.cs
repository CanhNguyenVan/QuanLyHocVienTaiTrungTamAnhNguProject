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

        public int InsertKyThi(KyThiDTO kyThiDTO)
        {
            return kyThiDAL.InsertKyThi(kyThiDTO);
        }
        public int UpdateKyThi(KyThiDTO kyThiDTO)
        {
            return kyThiDAL.UpdateKyThi(kyThiDTO);
        }

        public int DeleteKyThi(KyThiDTO kyThiDTO)
        {
            return kyThiDAL.DeleteKyThi(kyThiDTO);
        }
    }
}
