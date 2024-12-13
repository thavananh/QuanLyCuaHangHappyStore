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
    public class ThietBiAccess:DatabaseAccess
    {   

        public List<THIETBI> xemTB()
        {
            List<THIETBI> lTB = new List<THIETBI>();
            lTB = DatabaseAccess.xemTB();
            return lTB;
        }
        public List<THIETBI> xemTBBT()
        {
            List<THIETBI> lTBBT = new List<THIETBI>();
            lTBBT = DatabaseAccess.xemTBBT();
            return lTBBT;
        }
        public List<THIETBI> xemTBtheoloai(string loaithietbi)
        {
            return DatabaseAccess.xemDanhsachTB(loaithietbi);
        }
        public int demTB(string loaitb)
        {
            return DatabaseAccess.demsoTB(loaitb);
        }
        public THIETBI xemthongTinTB(string maTB)
        {
            THIETBI tb = DatabaseAccess.xemThongTinTB(maTB);

            return tb;
        }


        public bool ThemDuLieuThietBi(THIETBI tb)
        {
            return DatabaseAccess.themThietBi(tb);
        }
        public string UpdateTB(THIETBI tb)
        {
            string updateTB = DatabaseAccess.UpdatethongtinTB(tb);
            return updateTB;
        }
        public bool XoaThongTinThietBi(string maThietBi)
        {
            return DatabaseAccess.XoaThongTinThietBi(maThietBi);
        }
        public int ifEquipmentInDB(string equipmentId)
        {
            return DatabaseAccess.ifEquipmentInDB(equipmentId);
        }
    }
}
