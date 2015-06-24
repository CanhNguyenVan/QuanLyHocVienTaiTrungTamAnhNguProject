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

        public void InsertKhoaHoc(KhoaHocDTO khoaHocDTO)
        {
            khoaHocDAL.InsertKhoaHoc(khoaHocDTO);
        }
        public void UpdateKhoaHoc(KhoaHocDTO khoaHocDTO)
        {
            khoaHocDAL.UpdateKhoaHoc(khoaHocDTO);
        }

        public void DeleteKhoaHoc(KhoaHocDTO khoaHocDTO)
        {
            khoaHocDAL.DeleteKhoaHoc(khoaHocDTO);
        }
    }
}
