using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DTO;


namespace MyTools
{
    public static class Utility
    {
        private static string _prefixHV = "HV";

        private static string _prefixDK = "DK";

        private static string _prefixBL = "BL";

        private static string _prefixHS = "HS";

        private static string _prefixL = "L";

        private static string _prefixCL = "CL";

        private static string _prefixLL = "LL";

        private static string _prefixKH = "KH";

        private static string _prefixGV = "GV";

        private static string _prefixKT = "KT";

        // Tạo mã học viên với prefix và không trung với dữ liệu đã có
        public static string PhatSinhMaHocVien()
        {
            HocVienBLL hocVienBll = new HocVienBLL();
            List<HocVienDTO> hocVienDtos = hocVienBll.SelectAll();

            if (hocVienDtos.Count() == 0)
            {
                return _prefixHV + 1;
            }

            List<int> maHocVienList = new List<int>();

            foreach (HocVienDTO hocVienDto in hocVienDtos)
            {
                maHocVienList.Add(int.Parse(hocVienDto.MaHocVien.Replace(_prefixHV, "")));
            }
            return _prefixHV + (maHocVienList.Max() + 1).ToString();
        }

        public static string PhatSinhMaDangKy()
        {
            DangKyBLL dangKyBll = new DangKyBLL();

            List<DangKyDTO> dangKyDtos = new List<DangKyDTO>();

            if (dangKyDtos.Count == 0)
            {
                return _prefixDK + 1;
            }

            List<int> maDangKyInts= new List<int>();

            foreach (DangKyDTO dangKyDto in dangKyDtos)
            {
                maDangKyInts.Add(int.Parse(dangKyDto.MaDangKy.Replace(_prefixDK, "")));
            }

            return _prefixDK + maDangKyInts.Max() + 1;
        }


        public static string PhatSinhMaBienLai()
        {
            BienLaiBLL bienLaiBll = new BienLaiBLL();

            List<BienLaiDTO> bienLaiDtos = bienLaiBll.SelectAll();

            if (bienLaiDtos.Count == 0)
            {
                return _prefixBL + 1;
            }

            List<int> maBienLaiInts= new List<int>();

            foreach (BienLaiDTO bienLaiDto in bienLaiDtos)
            {
                maBienLaiInts.Add(int.Parse(bienLaiDto.MaBienLai.Replace(_prefixBL, "")));
            }

            return _prefixBL + (maBienLaiInts.Max() + 1);
        }

        public static string PhatSinhMaHoSo()
        {
            HoSoHocVienBLL hoSoHocVienBll = new HoSoHocVienBLL();

            List<HoSoHocVienDTO> hoSoHocVienDtos = new List<HoSoHocVienDTO>();

            if (hoSoHocVienDtos.Count == 0)
            {
                return _prefixHS + 1;
            }

            List<int> maHoSoInts = new List<int>();

            foreach (HoSoHocVienDTO hoSoHocVienDto in hoSoHocVienDtos)
            {
                maHoSoInts.Add(int.Parse(hoSoHocVienDto.MaHoSo.Replace(_prefixHS, "")));
            }

            return _prefixHS + (maHoSoInts.Max() + 1);
        }

        public static string PhatSinhMaLop()
        {
            LopBLL lopBll = new LopBLL();

            List<LopDTO> lopDtos = lopBll.SelectAll();

            if (lopDtos.Count == 0)
            {
                return _prefixL + 1;
            }

            List<int> maLopInts = new List<int>();

            foreach (LopDTO lopDto in lopDtos)
            {
                maLopInts.Add(int.Parse(lopDto.MaLop.Replace(_prefixL, "")));
            }

            return _prefixL + (maLopInts.Max() + 1);

        }

        public static string PhatSinhMaCapLop()
        {
            CapLopBLL capLopBll = new CapLopBLL();

            List<CapLopDTO> capLopDtos = capLopBll.SelectAll();

            if (capLopDtos.Count == 0)
            {
                return _prefixCL + 1;
            }

            List<int> maCapLopInts = new List<int>();

            foreach (CapLopDTO capLopDto in capLopDtos)
            {
                maCapLopInts.Add(int.Parse(capLopDto.MaCapLop.Replace(_prefixCL, "")));
            }

            return _prefixCL + (maCapLopInts.Max() + 1);
        }

        public static string PhatSinhMaLoaiLop()
        {
            LoaiLopBLL loaiLopBll = new LoaiLopBLL();

            List<LoaiLopDTO> loaiLopDtos = loaiLopBll.SelectAll();

            if (loaiLopDtos.Count == 0)
            {
                return _prefixLL + 1;
            }

            List<int> maLoaiLopInts = new List<int>();

            foreach (LoaiLopDTO LoaiLopDto in loaiLopDtos)
            {
                maLoaiLopInts.Add(int.Parse(LoaiLopDto.MaLoaiLop.Replace(_prefixLL, "")));
            }

            return _prefixLL + (maLoaiLopInts.Max() + 1);
        }


        public static string PhatSinhMaKhoaHoc()
        {
            KhoaHocBLL khoaHocBll = new KhoaHocBLL();

            List<KhoaHocDTO> khoaHocDtos = khoaHocBll.SelectAll();

            if (khoaHocDtos.Count == 0)
            {
                return _prefixKH + 1;
            }

            List<int> maKhoaHocInts = new List<int>();

            foreach (KhoaHocDTO khoaHocDto in khoaHocDtos)
            {
                maKhoaHocInts.Add(int.Parse(khoaHocDto.MaKhoaHoc.Replace(_prefixKH,"")));
            }

            return _prefixKH + (maKhoaHocInts.Max() + 1);
        }

        public static string PhatSinhMaGiaoVien()
        {
            GiaoVienBLL giaoVienBll = new GiaoVienBLL();

            List<GiaoVienDTO> giaoVienDtos = giaoVienBll.SelectAll();

            if (giaoVienDtos.Count == 0)
            {
                return _prefixGV + 1;
            }

            List<int> maGiaoVienInts = new List<int>();

            foreach (GiaoVienDTO giaoVienDto in giaoVienDtos)
            {
                maGiaoVienInts.Add(int.Parse(giaoVienDto.MaGiaoVien.Replace(_prefixGV, "")));
            }

            return _prefixGV + (maGiaoVienInts.Max() + 1);
        }

        public static string PhatSinhMaKyThi()
        {
            KyThiBLL kyThiBll = new KyThiBLL();

            List<KyThiDTO> kyThiDtos = kyThiBll.SelectAll();

            if (kyThiDtos.Count == 0)
            {
                return _prefixKT + 1;
            }

            List<int> maKyThiInts = new List<int>();

            foreach (KyThiDTO kyThiDto in kyThiDtos)
            {
                maKyThiInts.Add(int.Parse(kyThiDto.MaKyThi.Replace(_prefixKT, "")));
            }

            return _prefixKT + (maKyThiInts.Max() + 1);
        }
    }
}
