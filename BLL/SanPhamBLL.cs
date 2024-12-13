using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

/*
 ____   ___  _____ _______        ___    ____  _____ 
/ ___| / _ \|  ___|_   _\ \      / / \  |  _ \| ____|
\___ \| | | | |_    | |  \ \ /\ / / _ \ | |_) |  _|  
 ___) | |_| |  _|   | |   \ V  V / ___ \|  _ <| |___ 
|____/ \___/|_|__ __|_|  _ \_/\_/_/   \_\_| \_\_____|
/ ___|| | | / ___|_   _|/ \  |_ _| \ | |             
\___ \| | | \___ \ | | / _ \  | ||  \| |             
 ___) | |_| |___) || |/ ___ \ | || |\  |             
|____/ \___/|____/ |_/_/   \_\___|_| \_|     

DEVELOPED AND MAINTAINED BY SOFTWARE SUSTAIN
*/

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamAccess spaccs = new SanPhamAccess();
        public bool themSP(SanPham sp)
        {
            DateTime now = DateTime.Now;
            sp.MaSP = sp.LoaiSP + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
            return spaccs.themSP(sp);
        }
        public List<SanPham> xemListSP()
        {
            return spaccs.xemListSP();
        }
        public List<SanPham> xemListSPtheoLoai(string loaisp)
        {
            return spaccs.xemListSPtheoLoai(loaisp);
        }
        public string updateSP(SanPham sp)
        {
            return spaccs.updateSP(sp);
        }
        public SanPham xemSP(string masp)
        {
            return spaccs.xemSP(masp);
        }
        public bool XoaThongTinSanPham(string maSanPham)
        {
            return spaccs.XoaThongTinSanPham(maSanPham);
        }

        public int ifProductExitsInDB(string maSanPham)
        {
            return spaccs.ifProductExitsInDB(maSanPham);
        }
    }
}
