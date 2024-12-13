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
    public class GoiTapBLL
    {
        GoiThanhVienAccess gtaccs = new GoiThanhVienAccess();

        public List<string> xemGoiThanhVien()
        {
            return gtaccs.xemGoiThanhVien();
        }
        public int layThangGoiThanhVien(string magoitap)
        {
            return gtaccs.ThangGoiTap(magoitap);
        }
        public bool themGoiThanhVien(GOITHANHVIEN goitap)
        {
            int dem = gtaccs.demGoiThanhVien() + 1;
            if (dem < 10)
            {
                goitap.MaGoiThanhVien = goitap.MaGoiThanhVien + "00" + dem.ToString();
            }
            else if (dem >= 10 && dem < 100)
            {
                goitap.MaGoiThanhVien = goitap.MaGoiThanhVien + "0" + dem.ToString();
            }
            else
            {
                goitap.MaGoiThanhVien = goitap.MaGoiThanhVien + dem.ToString();
            }
            return gtaccs.themGoiThanhVien(goitap);
        }
        public int demGoiThanhVien()
        {
            return gtaccs.demGoiThanhVien();
        }
       
    }
}

