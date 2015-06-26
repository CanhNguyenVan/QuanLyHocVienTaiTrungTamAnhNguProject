using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class GiaoVienBLL
    {
        private GiaoVienDAL giaoVienDAL = new GiaoVienDAL();
        public List<GiaoVienDTO> SelectAll()
        {
            return giaoVienDAL.SelectAll();
        }

        public int  InsertGiaoVien(GiaoVienDTO giaoVienDTO)
        {
            return giaoVienDAL.InsertGiaoVien(giaoVienDTO);
        }
        public int UpdateGiaoVien(GiaoVienDTO giaoVienDTO)
        {
            return giaoVienDAL.UpdateGiaoVien(giaoVienDTO);
        }

        public int DeleteGiaoVien(GiaoVienDTO giaoVienDTO)
        {
            return giaoVienDAL.DeleteGiaoVien(giaoVienDTO);
        }
    }
}
