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
    public class KhachHangAccess : DatabaseAccess
    {
        public List<string> xemListMathe()
        {
            return DatabaseAccess.xemListMaThe();
        }

        public int demKH()
        {
            return DatabaseAccess.demsoKH();
        }
        public string UpdateKH(KHACHHANG kh)
        {
            string updateKH = DatabaseAccess.UpdatethongtinKH(kh);
            return updateKH;
        }
        public List<KHACHHANG> xemKH()
        {
            List<KHACHHANG> lKH = new List<KHACHHANG>();
            lKH = DatabaseAccess.XemKH();
            return lKH;
        }
        public KHACHHANG xemthongTinKH(string mathe)
        {
            KHACHHANG kh = DatabaseAccess.xemThongTinKH(mathe);

            return kh;
        }
        public bool ThemDuLieu(KHACHHANG kh)
        {
            return themTaiKhoan(kh);
        }
        public bool xoaThongtinKH(string maTHE)
        {
            bool xoathongtin = DatabaseAccess.XoaThongtinKH(maTHE);
            return xoathongtin;
        }
        public List<KHACHHANG> thongkeKH(DateTime d1)
        {
            List<KHACHHANG> lKH = new List<KHACHHANG>();
            lKH = DatabaseAccess.thongkeKhachHang(d1);
            return lKH;
        }
        public List<string> xemmaHLV(string CHUCVU)
        {
            return DatabaseAccess.xemMAHLV(CHUCVU);
        }

        public int ifCustomerExitsInDB(string maThe)
        {
            return DatabaseAccess.ifCustomerExitsInDB(maThe);
        }
    }
}
