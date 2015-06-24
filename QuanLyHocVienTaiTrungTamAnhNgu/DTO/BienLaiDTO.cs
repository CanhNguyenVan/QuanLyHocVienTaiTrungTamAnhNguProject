using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BienLaiDTO
    {
        private string _maBienLai;

        public string MaBienLai
        {
            get { return _maBienLai; }
            set { _maBienLai = value; }
        }
        private decimal _hocPhi;

        public decimal HocPhi
        {
            get { return _hocPhi; }
            set { _hocPhi = value; }
        }
        private decimal _mienGiam;

        public decimal MienGiam
        {
            get { return _mienGiam; }
            set { _mienGiam = value; }
        }
    }
}
