using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

namespace DTO
{
    public class GOITHANHVIEN
    {
        private string maGoiThanhVien;
        public string MaGoiThanhVien
        {
            get => maGoiThanhVien;
            set => maGoiThanhVien = value;
        }
        private string tenGoiThanhVien;
        public string TenGoiThanhVien
        {
            get => tenGoiThanhVien;
            set => tenGoiThanhVien = value;
        }
        private int thang;
        public int Thang
        {
            get => thang;
            set => thang = value;
        }
        private double chiphi;
        public double ChiPhi
        {
            get => chiphi;
            set => chiphi = value;
        }
        public GOITHANHVIEN()
        {

        }
        ~GOITHANHVIEN() { }
    }
}
