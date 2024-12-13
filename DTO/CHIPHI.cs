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
    public class CHIPHI
    {
        public CHIPHI()
        {
            MaChiPhi = "null";
        }
        private string maChiPhi;
        public string MaChiPhi
        {
            get => maChiPhi;
            set => maChiPhi = value;
        }
        private double tongChiPhi;
        public double TongChiPhi
        {
            get => tongChiPhi;
            set => tongChiPhi = value;
        }

        private DateTime ngayPhatSinh;
        public DateTime NgayPhatSinh
        {
            get => ngayPhatSinh;
            set => ngayPhatSinh = value;
        }

    }
}
