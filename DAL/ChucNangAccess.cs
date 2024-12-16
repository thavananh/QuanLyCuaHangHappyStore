using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChucNangAccess:DatabaseAccess
    {
        public  CHUCNANG TimChucNangTheoTen(string tenChucNang)
        {
            return DatabaseAccess.TimChucNangTheoTen(tenChucNang);
        }

        public CHUCNANG TimChucNangTheoMieuTa(string mieuTa)
        {
            return DatabaseAccess.TimChucNangTheoMieuTa(mieuTa);
        }

        public  List<CHUCNANG> LayTatCaChucNang()
        {
            return DatabaseAccess.LayTatCaChucNang();
        }
    }
}
