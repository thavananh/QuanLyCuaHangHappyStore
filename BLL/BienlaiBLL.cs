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
    public class BienlaiBLL
    {

        BienlaiAccess blaccss = new BienlaiAccess();
        public static string maBL { get; set; }
        public void capnhatBienlai(KHACHHANG khachhang)
        {
            DateTime currentTime = DateTime.Now;
            BIENLAI bl = new BIENLAI();
            bl.MaThe = khachhang.Mathe;
            bl.MaGoiThanhVien = khachhang.MaGoiThanhVien;
            bl.NgayThanhToan = khachhang.NgayBatDau;
            bl.MaBienLai = bl.MaThe + bl.MaGoiThanhVien + currentTime.Year.ToString() + currentTime.Month.ToString() + currentTime.Day.ToString() + currentTime.Hour.ToString() + currentTime.Minute.ToString() + currentTime.Second;
            maBL = bl.MaBienLai;
            blaccss.ThemBienLai(bl);

        }
        public BIENLAI xemBienlai()
        {
            return blaccss.xemBienLai(maBL);
        }
    }
}
