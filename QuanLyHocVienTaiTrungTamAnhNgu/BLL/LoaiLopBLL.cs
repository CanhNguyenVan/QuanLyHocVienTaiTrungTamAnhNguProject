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

        public int InsertLoaiLop(LoaiLopDTO loaiLopDTO)
        {
            return loaiLopDAL.InsertLoaiLop(loaiLopDTO);
        }
        public int UpdateLoaiLop(LoaiLopDTO loaiLopDTO)
        {
            return loaiLopDAL.UpdateLoaiLop(loaiLopDTO);
        }
        public int DeleteLoaiLop(LoaiLopDTO loaiLopDTO)
        {
            return loaiLopDAL.DeleteLoaiLop(loaiLopDTO);
        }
    }
}
