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
    public class TaiKhoanBLL
    {   
     
        TaiKhoanAccesss tkaccess = new TaiKhoanAccesss();
        
        public bool Checklogin(TaiKhoan taikhoan)
        {
            if(taikhoan.MaTaiKhoan.Length != 0 && taikhoan.MatKhau.Length != 0)
            {
                return tkaccess.Checklogin(taikhoan) == true;
            }
            return false;
        }
        public bool UpdatePassword(TaiKhoan taikhoan)
        {
            if (taikhoan.MaTaiKhoan.Length != 0 && taikhoan.MatKhau.Length != 0)
            {
                return tkaccess.UpdatePassword(taikhoan);
            }
            return false;
        }

        public bool AddAccount(TaiKhoan taikhoan)
        {
            if (taikhoan.MaTaiKhoan.Length != 0 && taikhoan.MatKhau.Length != 0)
            {
                return tkaccess.addAccount(taikhoan);
            }
            return false;
        }

        public string LayEmailCaNhan(TaiKhoan taikhoan)
        {
            return tkaccess.LayEmailCaNhan(taikhoan);
        }

        public int CheckAccountType(TaiKhoan taikhoan)
        {
            int ltk = tkaccess.CheckAccountType(taikhoan);
            return ltk;
        }

        public int checkEmail(string email)
        {
            return tkaccess.checkEmail(email);
        }

        public bool ifAccountExsitsInDB(string maTaiKhoan)
        {
            return tkaccess.ifAccountExsitsInDB(maTaiKhoan);
        }
        
        public bool checkSpecialPassword(string specialPass)
        {
            return BCrypt.Net.BCrypt.Verify(specialPass, FirstRunChecker.GetSpecialPassword());
        }
        
        public TaiKhoan layTaiKhoanTheoMa(string maTaiKhoan)
        {
            return tkaccess.LayTaiKhoanTheoMa(maTaiKhoan);
        }
    }
}
