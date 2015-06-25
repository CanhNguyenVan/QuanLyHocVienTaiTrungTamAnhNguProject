using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TraCuuLopBLL
    {
        private static TraCuuLopDAL tracuu = new TraCuuLopDAL();

        public static DataTable SelectMaLop()
        {
            return tracuu.SelectMaLop();
        }
        public static DataTable TraCuuLop()
        {
            return tracuu.TraCuuLop();
        }
        public static DataTable TraCuuLopTheoMa(string ma)
        {
            return tracuu.TraCuuLopTheoMa(ma);
        }
    }
}
