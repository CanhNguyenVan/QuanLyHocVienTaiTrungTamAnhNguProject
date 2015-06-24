using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopDTO
    {
        private string _maLop;

        public string MaLop
        {
            get { return _maLop; }
            set { _maLop = value; }
        }
        private string _maCapLop;

        public string MaCapLop
        {
            get { return _maCapLop; }
            set { _maCapLop = value; }
        }
        private string _maLoaiLop;

        public string MaLoaiLop
        {
            get { return _maLoaiLop; }
            set { _maLoaiLop = value; }
        }
        private string _maKhoaHoc;

        public string MaKhoaHoc
        {
            get { return _maKhoaHoc; }
            set { _maKhoaHoc = value; }
        }
        private string _tenLop;

        public string TenLop
        {
            get { return _tenLop; }
            set { _tenLop = value; }
        }
        private int _siSo;

        public int SiSo
        {
            get { return _siSo; }
            set { _siSo = value; }
        }
    }
}
