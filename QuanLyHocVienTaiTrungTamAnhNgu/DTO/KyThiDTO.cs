using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KyThiDTO
    {
        private string _maKyThi;

        public string MaKyThi
        {
            get { return _maKyThi; }
            set { _maKyThi = value; }
        }
        private string _maKhoaHoc;

        public string MaKhoaHoc
        {
            get { return _maKhoaHoc; }
            set { _maKhoaHoc = value; }
        }
        private DateTime _ngayThi;

        public DateTime NgayThi
        {
            get { return _ngayThi; }
            set { _ngayThi = value; }
        }
        private string _gioThi;

        public string GioThi
        {
            get { return _gioThi; }
            set { _gioThi = value; }
        }
        
    }
}
