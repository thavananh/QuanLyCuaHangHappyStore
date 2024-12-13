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
    public class HOADON
    {
        private string hoadon;
        public string MaHoaDon
        {
            get => hoadon;
            set => hoadon = value;
        }
        private string masp;
        public string MaSP
        {
            get => masp;
            set => masp = value;
        }
        private double tongtien;
        public double TongTien
        {
            get => tongtien;
            set => tongtien = value;
        }
        private DateTime ngaythanhtoan;
        public DateTime NgayThanhToan
        {
            get =>  ngaythanhtoan;
            set => ngaythanhtoan = value;
        }
        private string mathe;
        public string MaThe
        {
            get => mathe;
            set => mathe = value;
        }
        public HOADON()
        {
            ngaythanhtoan = DateTime.Today;
            tongtien = 0;
        }
        ~HOADON() { }


    }
}
