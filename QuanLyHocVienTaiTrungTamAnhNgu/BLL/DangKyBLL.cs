using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DangKyBLL
    {
        DangKyDAL dangKyDAL = new DangKyDAL();
        public List<DangKyDTO> SelectAll()
        {
            return dangKyDAL.SelectAll();
        }

        public void InsertDangKy(DangKyDTO dangKyDTO)
        {
            dangKyDAL.InsertDangKy(dangKyDTO);
        }

        public void UpdateDangKy(DangKyDTO dangKyDTO)
        {
            dangKyDAL.UpdateDangKy(dangKyDTO);
        }

        public void DeleteDangKy(DangKyDTO dangKyDTO)
        {
            dangKyDAL.DeleteByMaDangKy(dangKyDTO);
        }
    }
}
