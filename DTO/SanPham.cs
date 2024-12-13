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
    public class SanPham
    {
        private string masp;
        public string MaSP
        {
            get => masp;
            set => masp = value;
        }
        private string loaisp;
        public string LoaiSP
        {
            get => loaisp;
            set => loaisp = value;
        }
        private string tensp;
        public string TenSP
        {
            get => tensp;
            set => tensp = value;
        }

        private double giaNhap;
        public double GiaNhap
        {
            get => giaNhap;
            set => giaNhap = value;
        }

        private double giathanh;
        public double GiaThanh
        {
            get => giathanh;
            set => giathanh = value;
        }
        private int sl;
        public  int SL
        {
            get => sl;
            set => sl = value;
        }
        private Byte[] anh;
        public Byte[] Anh
        {
            get => anh;
            set => anh = value;
        }
        public  SanPham()
        { }
        ~SanPham() { }
    }
}
