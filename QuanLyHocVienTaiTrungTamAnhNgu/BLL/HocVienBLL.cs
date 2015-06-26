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

        public int InsertHocVien(HocVienDTO hocVienDTO)
        {
            return hocVienDAL.InsertHocVien(hocVienDTO);
        }

        public int UpdateHocVien(HocVienDTO hocVienDTO)
        {
            return hocVienDAL.UpdateHocVien(hocVienDTO);
        }

        public int DeleteHocVien(HocVienDTO hocVienDTO)
        {
            return hocVienDAL.DeleteHocVien(hocVienDTO);
        }
    }
}
