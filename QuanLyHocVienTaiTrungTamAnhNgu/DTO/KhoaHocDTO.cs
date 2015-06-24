using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaHocDTO
    {
        private string _maKhoaHoc;

        public string MaKhoaHoc
        {
            get { return _maKhoaHoc; }
            set { _maKhoaHoc = value; }
        }
        private int _nienHoc;

        public int NienHoc
        {
            get { return _nienHoc; }
            set { _nienHoc = value; }
        }
        private int _hocKy;

        public int HocKy
        {
            get { return _hocKy; }
            set { _hocKy = value; }
        }
    }
}
