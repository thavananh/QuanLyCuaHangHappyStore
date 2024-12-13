using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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

namespace DAL
{
    public class SanPhamAccess:DatabaseAccess
    {
        public List<SanPham> xemListSP()
        {
            return DatabaseAccess.xemListSP();
        }
        public List<SanPham> xemListSPtheoLoai(string loaisp)
        {
            return DatabaseAccess.xemListSPtheoLoai(loaisp);
        }
        public int demSP(string loaisp)
        {
            return DatabaseAccess.demSanPham(loaisp);
        }
        public string updateSP(SanPham sp)
        {
            return DatabaseAccess.UpdatethongtinSanPham(sp);
        }
        public bool themSP(SanPham sp)
        {
            return DatabaseAccess.ThemSanPham(sp);
        }
        public SanPham xemSP(string masp)
        {
            return DatabaseAccess.xemthongtinSP(masp);
        }
        public bool XoaThongTinSanPham(string maSanPham)
        {
            return DatabaseAccess.XoaThongTinSanPham(maSanPham);
        }
        public int ifProductExitsInDB(string maSanPham)
        {
            return DatabaseAccess.ifProductExitsInDB(maSanPham);
        }
    }
}
