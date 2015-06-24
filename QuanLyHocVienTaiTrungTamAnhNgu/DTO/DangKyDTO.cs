using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKyDTO
    {
        private string _maDangKy;

        public string MaDangKy
        {
            get { return _maDangKy; }
            set { _maDangKy = value; }
        }
        private string _maKhoaHoc;

        public string MaKhoaHoc
        {
            get { return _maKhoaHoc; }
            set { _maKhoaHoc = value; }
        }
        private string _maLop;

        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }
        private string _maHocVien;

        public string MaHocVien
        {
            get { return _maHocVien; }
            set { _maHocVien = value; }
        }
        private string _maBienLai;

        public string MaBienLai
        {
            get { return _maBienLai; }
            set { _maBienLai = value; }
        }
    }
}
