using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HoSoHocVienBLL
    {
        HoSoHocVienDAL hoSoHocVienDAL = new HoSoHocVienDAL();

        public List<HoSoHocVienDTO> SelectAll()
        {
            return hoSoHocVienDAL.SelectAll();
        }

        public int InsertHoSoHocVien(HoSoHocVienDTO hoSoHocVienDTO)
        {
            return hoSoHocVienDAL.InsertHoSoHocVien(hoSoHocVienDTO);
        }

        public int UpdateHoSoHocVien(HoSoHocVienDTO hoSoHocVienDTO)
        {
            return hoSoHocVienDAL.UpdateHoSoHocVien(hoSoHocVienDTO);
        }

        public int DeleteHoSoHocVien(HoSoHocVienDTO hoSoHocVienDTO)
        {
            return hoSoHocVienDAL.DeleteHoSoHocVien(hoSoHocVienDTO);
        }
    }
}
