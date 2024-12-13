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
    public class BIENLAI
    {
        private string mabienlai;
        public string MaBienLai
        {
            get => mabienlai;
            set => mabienlai = value;
        }
        private string mathe;
        public string MaThe
        {
            get => mathe;
            set => mathe = value;
        }
        private string maGoiThanhVien;
        public string MaGoiThanhVien
        {
            get => maGoiThanhVien;
            set => maGoiThanhVien = value;
            
        }
        private int tongtien;
        public int TongTien
        {
            get => tongtien;
            set => tongtien = value;
        }
        private DateTime ngaythanhtoan;
        public DateTime NgayThanhToan
        {
            get => ngaythanhtoan;
            set => ngaythanhtoan = value;

        }
        public BIENLAI()
        {
            
        }
        ~BIENLAI() { }


    }
}
