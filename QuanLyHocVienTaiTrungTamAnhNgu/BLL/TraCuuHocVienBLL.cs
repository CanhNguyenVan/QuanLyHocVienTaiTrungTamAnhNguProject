using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TraCuuHocVienBLL
    {
        private static TraCuuHocVienDAL tracuu = new TraCuuHocVienDAL();

        public static DataTable SelectMaHocVien()
        {
            return tracuu.SelectMaHocVien();
        }
        public static DataTable TraCuuHocVien()
        {
            return tracuu.TraCuuHocVien();
        }
        public static DataTable TraCuuHocVienTheoMa(string ma)
        {
            return tracuu.TraCuuHocVienTheoMa(ma);
        }
    }
}
