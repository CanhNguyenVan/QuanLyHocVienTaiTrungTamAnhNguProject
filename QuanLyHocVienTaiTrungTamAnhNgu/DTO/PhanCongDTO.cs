using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanCongDTO
    {
        private string _maGiaoVien;

        public string MaGiaoVien
        {
            get { return _maGiaoVien; }
            set { _maGiaoVien = value; }
        }
        private string _maLop;

        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }
    }
}
