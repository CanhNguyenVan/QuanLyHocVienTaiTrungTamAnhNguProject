using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiLopDTO
    {
        private string _maLoaiLop;

        public string MaLoaiLop
        {
            get { return _maLoaiLop; }
            set { _maLoaiLop = value; }
        }
        private string _tenLoaiLop;

        public string TenLoaiLop
        {
            get { return _tenLoaiLop; }
            set { _tenLoaiLop = value; }
        }
        private DateTime _ngayHoc;

        public DateTime NgayHoc
        {
            get { return _ngayHoc; }
            set { _ngayHoc = value; }
        }
        private string _gioHoc;

        public string GioHoc
        {
            get { return _gioHoc; }
            set { _gioHoc = value; }
        }
    }
}
