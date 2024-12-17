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
    public class ThietBiBLL
    {
        ThietBiAccess tbaccess = new ThietBiAccess();
        public bool themdulieu(THIETBI tb)
        {
            tb.Mathietbi = Guid.NewGuid().ToString();   
            return tbaccess.ThemDuLieuThietBi(tb);

        }
        public List<THIETBI> xemTB()
        {
            List<THIETBI> lTB = new List<THIETBI>();
            lTB = tbaccess.xemTB();
            return lTB;
        }
        public List<THIETBI> xemTBBT()
        {
            List<THIETBI> lTBBT = new List<THIETBI>();
            lTBBT = tbaccess.xemTBBT();
            return lTBBT;
        }
        //public List<THIETBI> xemThietBiTheoLoaiThietBi()
        //{
        //    List<THIETBI> listThietBi = new List<THIETBI>();

        //}
        public THIETBI xemThongTinTB(string maTB)
        {
            THIETBI tb = new THIETBI();
            tb = tbaccess.xemthongTinTB(maTB);
            
            return tb;
        }
        public string checkcapnhat(THIETBI tb)
        {

            string updateTB = tbaccess.UpdateTB(tb);
            return updateTB;
        }
        public List<THIETBI> xemDSTBtheoloai(string loaitb)
        {
            return tbaccess.xemTBtheoloai(loaitb);
        }
        public string chuyendoiloaitheitbi(string loaitb)
        {
            if (loaitb  == "MAYCARDIO")
            {   
                return "MÁY CARDIO";
            }
            else if (loaitb  == "MAYTAPNGUC")
            {

                return "MÁY TẬP NGỰC";
            }
            else if (loaitb  == "MAYTAPVAI")
            {
                return "MÁY TẬP VAI";
            }
            else if (loaitb == "MAYTAPTAY")
            {
                
                return "MÁY TẬP TAY";
            }
            else if (loaitb == "MAYTAPBUNG")
            {
               
                return "MÁY TẬP BỤNG";
            }
            else if (loaitb  == "MAYTAPCHAN")
            {
                
                return "MÁY TẬP CHÂN";
            }
            else if (loaitb == "MAYTAPLUNG")
            {
                
                return "MÁY TẬP LƯNG";
            }
            else if (loaitb == "MAYTAPXO")
            {
                
                return "MÁY TẬP XÔ";
            }
            else if (loaitb == "MAYTAPTONGHOP")
            {
                return "MÁY TẬP TỔNG HỢP";
            }
            else if (loaitb == "DANRACK")
            {
                
                return "DÀN RACK";
            }
            else if (loaitb == "TADON")
            {
                
                return "TẠ ĐƠN";
            }
            else 
            {
                return "TẠ ĐÒN";
            }
        }
        public bool XoaThongTinThietBi(string maThietBi)
        {
            return tbaccess.XoaThongTinThietBi(maThietBi);
        }

        public int ifEquipmentInDB(string equipmentId)
        {
            return tbaccess.ifEquipmentInDB(equipmentId);
        }
    }
}
