using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LoaiLopBLL
    {
        LoaiLopDAL loaiLopDAL = new LoaiLopDAL();
        public List<LoaiLopDTO> SelectAll()
        {
            return loaiLopDAL.SelectAll();
        }

        public void InsertLoaiLop(LoaiLopDTO loaiLopDTO)
        {
            loaiLopDAL.InsertLoaiLop(loaiLopDTO);
        }
        public void UpdateLoaiLop(LoaiLopDTO loaiLopDTO)
        {
            loaiLopDAL.UpdateLoaiLop(loaiLopDTO);
        }
        public void DeleteLoaiLop(LoaiLopDTO loaiLopDTO)
        {
            loaiLopDAL.DeleteLoaiLop(loaiLopDTO);
        }
    }
}
