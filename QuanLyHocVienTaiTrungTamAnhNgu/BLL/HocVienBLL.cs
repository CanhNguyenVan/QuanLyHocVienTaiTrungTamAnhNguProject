using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HocVienBLL
    {
        HocVienDAL hocVienDAL = new HocVienDAL();
        public List<HocVienDTO> SelectAll()
        {
            return hocVienDAL.SelectAll();
        }

        public void InsertHocVien(HocVienDTO hocVienDTO)
        {
            hocVienDAL.InsertHocVien(hocVienDTO);
        }

        public void UpdateHocVien(HocVienDTO hocVienDTO)
        {
            hocVienDAL.UpdateHocVien(hocVienDTO);
        }

        public void DeleteHocVien(HocVienDTO hocVienDTO)
        {
            hocVienDAL.DeleteHocVien(hocVienDTO);
        }
    }
}
