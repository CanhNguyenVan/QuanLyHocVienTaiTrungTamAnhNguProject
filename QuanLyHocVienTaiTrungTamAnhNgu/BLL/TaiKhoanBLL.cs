using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace BLL
{
    public class TaiKhoanBLL
    {
        // truy xuat du lieu APPDATA
        TaiKhoanDataContext HS = new TaiKhoanDataContext();

        // Tra ve danh sach tu bang TAIKHOAN
        public List<TAIKHOAN> LayTatCaTaiKhoan()
        {
            return HS.TAIKHOANs.ToList();
        }
           
        public List<usp_SelectLastMaTKResult> LayMaTKCuoiCung()
        {
            return HS.usp_SelectLastMaTK().ToList();
        }

        public void Them(int imatk, String itentk, String imatKhau, int iloai)
        {
            HS.usp_InsertTaiKhoan(imatk, itentk, imatKhau, iloai);
            HS.SubmitChanges();
        }
        public void Sua(int imatk, String itentk, String imatKhau, int iloai)
        {
            HS.usp_UpdateTaiKhoan(imatk, itentk, imatKhau, iloai);
            HS.SubmitChanges();
        }

 
        public void Xoa(int _MSSV)
        {
            HS.usp_DeleteTaiKhoan(_MSSV);
            HS.SubmitChanges();
        }


   
        public List<usp_SelectTaikhoanResult> TruyVanTaiKhoanTheoMaTK(int _MATK)
        {
            return HS.usp_SelectTaikhoan(_MATK).ToList();
        }        
    }
}
