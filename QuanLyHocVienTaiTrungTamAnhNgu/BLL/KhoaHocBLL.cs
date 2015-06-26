using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class KhoaHocBLL
    {
        KhoaHocDAL khoaHocDAL = new KhoaHocDAL();
        public List<KhoaHocDTO> SelectAll()
        {
            return khoaHocDAL.SelectAll();
        }

        public int InsertKhoaHoc(KhoaHocDTO khoaHocDTO)
        {
            return khoaHocDAL.InsertKhoaHoc(khoaHocDTO);
        }
        public int UpdateKhoaHoc(KhoaHocDTO khoaHocDTO)
        {
            return khoaHocDAL.UpdateKhoaHoc(khoaHocDTO);
        }

        public int DeleteKhoaHoc(KhoaHocDTO khoaHocDTO)
        {
            return khoaHocDAL.DeleteKhoaHoc(khoaHocDTO);
        }
    }
}
