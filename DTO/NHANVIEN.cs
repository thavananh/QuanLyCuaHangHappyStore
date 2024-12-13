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
    public class NHANVIEN
    {
        private string maNV;
        public string maNhanVien
        {
            get => maNV;
            set => maNV = value;
        }
        private string hoten;
        public string Hoten
        {
            get => hoten;
            set => hoten = value;
        }
        private DateTime ngaysinh;
        public DateTime Ngaysinh
        {
            get => ngaysinh;
            set => ngaysinh = value;
        }
        private string gioitinh;
        public string Gioitinh
        {
            get => gioitinh;
            set => gioitinh = value;
        }
        private string diachi;
        public string diaChi
        {
            get => diachi;
            set => diachi = value;
        }
        private string sdt;
        public string SDT
        {
            get => sdt;
            set => sdt = value;
        }
        private string email;
        public string Email
        {
            get => email;
            set => email = value;
        }
        private string cmnd;
        public string CMND
        {
            get => cmnd;
            set => cmnd = value;
        }
        private string ghichu;
        public string GhiChu
        {
            get => ghichu;
            set => ghichu = value;
        }
        private string chucvu;
        public string Chucvu
        {
            
            get => chucvu;
            set => chucvu = value;
        }
        private Byte[] anh;
        public Byte[] Anh
        {
            get => anh;
            set => anh = value;
        }
        public NHANVIEN()
        {   

        }
        ~NHANVIEN() { }
    }
}
