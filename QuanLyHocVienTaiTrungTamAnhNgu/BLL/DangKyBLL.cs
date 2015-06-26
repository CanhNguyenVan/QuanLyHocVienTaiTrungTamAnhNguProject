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

        public int InsertDangKy(DangKyDTO dangKyDTO)
        {
            return dangKyDAL.InsertDangKy(dangKyDTO);
        }

        public int UpdateDangKy(DangKyDTO dangKyDTO)
        {
            return dangKyDAL.UpdateDangKy(dangKyDTO);
        }

        public int DeleteDangKy(DangKyDTO dangKyDTO)
        {
            return dangKyDAL.DeleteByMaDangKy(dangKyDTO);
        }
    }
}
