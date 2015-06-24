using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemThiDTO
    {
        private string _maHocVien;

        public string MaHocVien
        {
            get { return _maHocVien; }
            set { _maHocVien = value; }
        }
        private string _maKyThi;

        public string MaKyThi
        {
            get { return _maKyThi; }
            set { _maKyThi = value; }
        }
        private float _diem;

        public float Diem
        {
            get { return _diem; }
            set { _diem = value; }
        }
    }
}
