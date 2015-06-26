using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DiemThiBLL
    {
        DiemThiDAL diemThiDAL = new DiemThiDAL();
        public List<DiemThiDTO> SelectAll()
        {
            return diemThiDAL.SelectAll();
        }

        public int InsertDiemThi(DiemThiDTO diemThiDTO)
        {
            return  diemThiDAL.InsertDiemThi(diemThiDTO);
        }

        public int UpdateDiemThi(DiemThiDTO diemThiDTO)
        {
            return diemThiDAL.UpdateDiemThi(diemThiDTO);
        }
        public int DeleteDiemThi(DiemThiDTO diemThiDTO)
        {
            return diemThiDAL.DeleteDiemThi(diemThiDTO);
        }
    }
}
