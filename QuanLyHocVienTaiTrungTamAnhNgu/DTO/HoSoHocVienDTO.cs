using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoSoHocVienDTO
    {
        private string _maHoSo;

        public string MaHoSo
        {
            get { return _maHoSo; }
            set { _maHoSo = value; }
        }
        private string _maHocVien;

        public string MaHocVien
        {
            get { return _maHocVien; }
            set { _maHocVien = value; }
        }
        private string _maLop;

        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }
        private float _diemThi;

        public float DiemThi
        {
            get { return _diemThi; }
            set { _diemThi = value; }
        }
        private string _xepLoai;

        public string XepLoai
        {
            get { return _xepLoai; }
            set { _xepLoai = value; }
        }
    }
}
