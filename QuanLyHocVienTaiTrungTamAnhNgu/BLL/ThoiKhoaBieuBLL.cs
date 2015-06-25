using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThoiKhoaBieuBLL
    {
        private static ThoiKhoaBieuDAL tracuu = new ThoiKhoaBieuDAL();

        public static DataTable SelectMaLop()
        {
            return tracuu.SelectMaLop();
        }
        public static DataTable ThoiKhoaBieu()
        {
            return tracuu.ThoiKhoaBieu();
        }
        public static DataTable TraCuuTKBTheoMa(string ma)
        {
            return tracuu.TraCuuTKBTheoMa(ma);
        }
    }
}
