using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVienDTO
    {
        private string _maGiaoVien;

        public string MaGiaoVien
        {
            get { return _maGiaoVien; }
            set { _maGiaoVien = value; }
        }
        private string _tenGiaoVien;

        public string TenGiaoVien
        {
            get { return _tenGiaoVien; }
            set { _tenGiaoVien = value; }
        }
        private string _maBangCap;

        public string MaBangCap
        {
            get { return _maBangCap; }
            set { _maBangCap = value; }
        }
    }
}
