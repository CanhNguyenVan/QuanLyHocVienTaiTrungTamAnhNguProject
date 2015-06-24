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

        public void InsertHoSoHocVien(HoSoHocVienDTO hoSoHocVienDTO)
        {
            hoSoHocVienDAL.InsertHoSoHocVien(hoSoHocVienDTO);
        }

        public void UpdateHoSoHocVien(HoSoHocVienDTO hoSoHocVienDTO)
        {
            hoSoHocVienDAL.UpdateHoSoHocVien(hoSoHocVienDTO);
        }

        public void DeleteHoSoHocVien(HoSoHocVienDTO hoSoHocVienDTO)
        {
            hoSoHocVienDAL.DeleteHoSoHocVien(hoSoHocVienDTO);
        }
    }
}
