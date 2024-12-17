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
    public class TaiKhoan
    {
        private string maTK;
        private string matkhau;
        private string loaiTK;
        private string email;
        public string MaTaiKhoan
        {
            get => maTK;
            set => maTK = value;
        }
        
        public string MatKhau
        {
            get => matkhau;
            set => matkhau = value;
        }
        
        public string LoaiTK
        {
            get => loaiTK;
            set => loaiTK = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        private string maTaiKhoanNhanVien;
        public string MaTaiKhoanNhanVien
        {
            get => maTaiKhoanNhanVien;
            set => maTaiKhoanNhanVien = value;
        }
        public TaiKhoan()
        {
            
        }
        ~TaiKhoan() { }
    }
}
