using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BienLaiBLL
    {
        BienLaiDAL bienLaiDAL = new BienLaiDAL();
        public List<BienLaiDTO> SelectAll()
        {
            return bienLaiDAL.SelectAll();
        }

        public int InsertBienLai(BienLaiDTO bienLaiDTO)
        {
            return bienLaiDAL.InsertBienLai(bienLaiDTO);
        }

        public int UpdateBienLai(BienLaiDTO bienLaiDTO)
        {
            return bienLaiDAL.UpdateBienLai(bienLaiDTO);
        }

        public int DeleteBienLai(BienLaiDTO bienLaiDTO)
        {
            return bienLaiDAL.DeleteByMaBienLai(bienLaiDTO);
        }
    }
}
