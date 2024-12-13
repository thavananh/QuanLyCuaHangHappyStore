using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using DTO;

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

namespace DAL
{   
    
    public class TaiKhoanAccesss:DatabaseAccess
    {
        private string ADmail;
        public string Encrypt(string password)
        {
            string cyper = BCrypt.Net.BCrypt.HashPassword(password);
            return cyper;
        }
        public bool Checklogin(TaiKhoan taikhoan)
        {
            if (DatabaseAccess.ifAccountExsitsInDB(taikhoan.MaTaiKhoan))
            {
                bool checking = BCrypt.Net.BCrypt.Verify(taikhoan.MatKhau, DatabaseAccess.getAccountPasswordInDB(taikhoan));
                if (checking == true)
                {
                    return true;
                }
            }
            return false;
        }
       
        public bool addAccount(TaiKhoan taikhoan)
        {
            taikhoan.MatKhau = Encrypt(taikhoan.MatKhau);
            return AddAccountToDB(taikhoan);
        }
       
        public bool UpdatePassword(TaiKhoan taikhoan)
        {
            if(DatabaseAccess.ifAccountExsitsInDB(taikhoan.MaTaiKhoan))
            {
                taikhoan.MatKhau = Encrypt(taikhoan.MatKhau);
                if (DatabaseAccess.updatePasswordToDB(taikhoan))
                {
                    return true;
                }
            }    
            return false;
        }
        public int CheckAccountType(TaiKhoan taikhoan)
        {
            int ltk = DatabaseAccess.CheckAccountTypeInDB(taikhoan);
            return ltk;
        }

        public string LayEmailCaNhan(TaiKhoan taikhoan)
        {
            return DatabaseAccess.LayEmailCaNhan(taikhoan);
        }

        public int checkEmail(string email)
        {
            return DatabaseAccess.checkEmail(email);
        }
        public bool ifAccountExsitsInDB(string maTaiKhoan)
        {
            return DatabaseAccess.ifAccountExsitsInDB(maTaiKhoan);
        }
    }
}
