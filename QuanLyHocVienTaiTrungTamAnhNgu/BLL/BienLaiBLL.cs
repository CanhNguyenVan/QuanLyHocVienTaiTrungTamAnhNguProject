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

        public void InsertBienLai(BienLaiDTO bienLaiDTO)
        {
            bienLaiDAL.InsertBienLai(bienLaiDTO);
        }

        public void UpdateBienLai(BienLaiDTO bienLaiDTO)
        {
            bienLaiDAL.UpdateBienLai(bienLaiDTO);
        }

        public void DeleteBienLai(BienLaiDTO bienLaiDTO)
        {
            bienLaiDAL.DeleteByMaBienLai(bienLaiDTO);
        }
    }
}
