using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChucNangBLL
    {
        ChucNangAccess chucNangAccess = new ChucNangAccess();
        public CHUCNANG TimChucNangTheoTen(string tenChucNang)
        {
            return chucNangAccess.TimChucNangTheoTen(tenChucNang);
        }
        public List<CHUCNANG> LayTatCaChucNang()
        {
            return chucNangAccess.LayTatCaChucNang();
        }
    }
}
