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
    public class GoiThanhVienAccess:DatabaseAccess
    {

        public int ThangGoiTap(string magoitap)
        {
            return DatabaseAccess.layThangGoiThanhVien(magoitap);
        }
        public bool kiemTraGoiThanhVien(string magoitap)
        {
            return DatabaseAccess.kiemTraGoiThanhVien(magoitap);
        }
        public int tongtienBienLai(string mabl)
        {
            return tongtienBienLai(mabl);
        }
        public bool themGoiThanhVien(GOITHANHVIEN goitap)
        {

            return DatabaseAccess.themGoiThanhVien(goitap);
        }
        public int demGoiThanhVien()
        {
            return DatabaseAccess.demGoiThanhVien();
        }
        public List<string> xemGoiThanhVien()
        {
            return DatabaseAccess.xemGoiThanhVien();
        }
    }
}
