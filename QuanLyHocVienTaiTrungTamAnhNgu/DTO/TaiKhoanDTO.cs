using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private int _maTK;

        public int MaTK
        {
            get { return _maTK; }
            set { _maTK = value; }
        }
        private string _tenTK;

        public string TenTK
        {
            get { return _tenTK; }
            set { _tenTK = value; }
        }
        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        private int _loaiTK;

        public int LoaiTK
        {
            get { return _loaiTK; }
            set { _loaiTK = value; }
        }
    }
}
