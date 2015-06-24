using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CapLopDTO
    {
        private string _maCapLop;

        public string MaCapLop
        {
            get { return _maCapLop; }
            set { _maCapLop = value; }
        }
        private string _tenCapLop;

        public string TenCapLop
        {
            get { return _tenCapLop; }
            set { _tenCapLop = value; }
        }
    }
}
