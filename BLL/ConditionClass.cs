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

namespace BLL
{
    public static class ConditionClass
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            // Kiểm tra xem có đúng một dấu '@'
            int atPos = email.IndexOf('@');
            if (atPos <= 0 || atPos != email.LastIndexOf('@'))
            {
                return false;
            }

            // Tách phần local và domain
            string localPart = email.Substring(0, atPos);
            string domainPart = email.Substring(atPos + 1);

            // Kiểm tra phần local và domain không trống
            if (string.IsNullOrEmpty(localPart) || string.IsNullOrEmpty(domainPart))
            {
                return false;
            }

            // Kiểm tra phần domain có chứa ít nhất một dấu '.'
            int dotPos = domainPart.LastIndexOf('.');
            if (dotPos <= 0 || dotPos == domainPart.Length - 1)
            {
                return false;
            }

            return true;
        }
    }
}
