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
    public class DOANHTHU
    {
        public DOANHTHU() {
            MaDoanhThu = "null";
        }
        private string maDoanhThu;
        public string MaDoanhThu
        {
            get => maDoanhThu;
            set => maDoanhThu = value;
        }
        private double tienThu;
        public double TienThu
        {
            get => tienThu;
            set => tienThu = value;
        }

        private DateTime ngayTongKetDoanhThu;
        public DateTime NgayTongKetDoanhThu
        {
            get => ngayTongKetDoanhThu;
            set => ngayTongKetDoanhThu = value;
        }

    }
}
