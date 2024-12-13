using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
    public class EmailOTPBLL
    {
        public string sendOTP(string toMail)
        {
            Random rand = new Random();
            MailMessage mail = new MailMessage();
            string fromMail = "longly777666@gmail.com";
            string randomCode = (rand.Next(999999)).ToString();
            string apiPass = "tcpfibzyyqevbvco";
            string messageBody = "Your otp: " + randomCode;
            mail.To.Add(toMail);
            mail.From = new MailAddress(fromMail);
            mail.Body = messageBody;
            mail.Subject = "Your OTP code here !!!";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromMail, apiPass);
            try
            {
                smtp.Send(mail);
                return randomCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
