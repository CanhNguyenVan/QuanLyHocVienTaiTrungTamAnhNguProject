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

        public void InsertGiaoVien(GiaoVienDTO giaoVienDTO)
        {
            giaoVienDAL.InsertGiaoVien(giaoVienDTO);
        }
        public void UpdateGiaoVien(GiaoVienDTO giaoVienDTO)
        {
            giaoVienDAL.UpdateGiaoVien(giaoVienDTO);
        }

        public void DeleteGiaoVien(GiaoVienDTO giaoVienDTO)
        {
            giaoVienDAL.DeleteGiaoVien(giaoVienDTO);
        }
    }
}
