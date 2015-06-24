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

        public void InsertDiemThi(DiemThiDTO diemThiDTO)
        {
            diemThiDAL.InsertDiemThi(diemThiDTO);
        }

        public void UpdateDiemThi(DiemThiDTO diemThiDTO)
        {
            diemThiDAL.UpdateDiemThi(diemThiDTO);
        }
        public void DeleteDiemThi(DiemThiDTO diemThiDTO)
        {
            diemThiDAL.DeleteDiemThi(diemThiDTO);
        }
    }
}
