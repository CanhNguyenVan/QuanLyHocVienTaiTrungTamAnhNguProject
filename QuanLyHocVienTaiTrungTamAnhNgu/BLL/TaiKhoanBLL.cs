using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public List<TaiKhoanDTO> SelectAll()
        {
            return taiKhoanDAL.SelectAll();
        }

        public List<TaiKhoanDTO> SelectLastMaTK()
        {
            return taiKhoanDAL.SelectLastMaTK();
        }

        public void InsertTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            taiKhoanDAL.InsertTaiKhoan(taiKhoanDTO);
        }

        public void UpdateTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            taiKhoanDAL.UpdateTaiKhoan(taiKhoanDTO);
        }

        public void DeleteTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            taiKhoanDAL.DeleteTaiKhoan(taiKhoanDTO);
        }
    }
}
