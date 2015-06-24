using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVienDTO
    {
        private string _maHocVien;

        public string MaHocVien
        {
            get { return _maHocVien; }
            set { _maHocVien = value; }
        }
        private string _tenHocVien;

        public string TenHocVien
        {
            get { return _tenHocVien; }
            set { _tenHocVien = value; }
        }
        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        private string _gioiTinh;

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        private string _ngheNghiep;

        public string NgheNghiep
        {
            get { return _ngheNghiep; }
            set { _ngheNghiep = value; }
        }
        private string _soDienThoai;

        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
    }
}
