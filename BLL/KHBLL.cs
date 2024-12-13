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
    public class KHBLL
    {
        KhachHangAccess khaccs = new KhachHangAccess();
        GoiThanhVienAccess gtaccs = new GoiThanhVienAccess();
        BienlaiBLL bienlaibll = new BienlaiBLL();
        public List<string> xemListMaThe()
        {
            return khaccs.xemListMathe();
        }
        public bool themdulieu(KHACHHANG kh)
        {
            kh.Mathe = MaKHAuto();
            bool checking = khaccs.ThemDuLieu(kh);
            if(checking == true)
            {
                bienlaibll.capnhatBienlai(kh);
                return checking;
            }
            else
            {
                return checking;
            }    
        }
        private string MaKHAuto()
        {
            DateTime now = DateTime.Now;
            int dem = khaccs.demKH() + 1;
            return "KH" + dem.ToString().PadLeft(6, '0') + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Minute.ToString();
        }
        public string checkcapnhatKH(KHACHHANG kh)
        {
            string updatekh = khaccs.UpdateKH(kh);
            return updatekh;
        }
        public string CheckthemKH(KHACHHANG kh)
        {

            if (kh.NgayBatDau.Date == new DateTime(2000, 1, 1))
            {
                return "Nhapnbd";
            }
            else
            {
                if (gtaccs.kiemTraGoiThanhVien(kh.MaGoiThanhVien) == true)
                {
                    return "Sailoai";
                }
                else 
                {
                    bool checking = themdulieu(kh);
                    if (checking == true)
                    {
                        return "success";
                    }
                    else
                    {
                        return "fail";
                    }
                }
            }
        }
        public List<KHACHHANG> xemKH()
        {
            List<KHACHHANG> lkh = new List<KHACHHANG>();
            lkh = khaccs.xemKH();
            return lkh;
        }
        public KHACHHANG xemThongTinKH(string mathe)
        {
            KHACHHANG kh = new KHACHHANG();
            kh = khaccs.xemthongTinKH(mathe);
            return kh;
        }
        public bool xoathongtinKH(string maTHE)
        {
            bool xoathongtin = khaccs.xoaThongtinKH(maTHE);
            return xoathongtin;
        }
        public List<KHACHHANG> thongkeKH(DateTime d1)
        {
            List<KHACHHANG> lkh = new List<KHACHHANG>();
            lkh = khaccs.thongkeKH(d1);
            return lkh;
        }
        public List<string> xemMAHLV(string chucvu)
        {
            return khaccs.xemmaHLV(chucvu);
        }
        public int ifCustomerExitsInDB(string maThe)
        {
            return khaccs.ifCustomerExitsInDB(maThe);
        }
    }
}
