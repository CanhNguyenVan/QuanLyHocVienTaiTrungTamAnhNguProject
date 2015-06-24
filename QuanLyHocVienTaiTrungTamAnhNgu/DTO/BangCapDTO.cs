using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangCapDTO
    {
        private string _maBangCap;

        public string MaBangCap
        {
            get { return _maBangCap; }
            set { _maBangCap = value; }
        }
        private string _tenBangCap;

        public string TenBangCap
        {
            get { return _tenBangCap; }
            set { _tenBangCap = value; }
        }
    }
}
