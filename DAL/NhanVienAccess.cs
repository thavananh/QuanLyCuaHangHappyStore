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
    public class NhanVienAccess:DatabaseAccess
    {
        public string UpdateNV(NHANVIEN nv)
        {
            string updateNV = DatabaseAccess.UpdatethongtinNV(nv);
            return updateNV;
        }
        public int demsoNV(string chucvu)
        {
            return DatabaseAccess.demsoNV(chucvu);
        }
        public List<NHANVIEN> xemLeTan()
        {
            List<NHANVIEN> lnv = new List<NHANVIEN>();
            lnv = DatabaseAccess.xemNhanVien();
            return lnv;
        }
        public List<NHANVIEN> xemNhanVienTheoLoaiChucVu(string maChucVu)
        {
            List<NHANVIEN> lhlv = new List<NHANVIEN>();
            lhlv = DatabaseAccess.xemNhanVienTheoLoaiChucVu(maChucVu);
            return lhlv;
        }
        public NHANVIEN xemthongTinNV(string manv)
        {
            NHANVIEN nv = DatabaseAccess.xemThongTinNV(manv);

            return nv;
        }
        public NHANVIEN xemthongTinHLV(string manv)
        {
            NHANVIEN hlv = DatabaseAccess.xemThongTinNV(manv);

            return hlv;
        }
        public bool ThemNV(NHANVIEN nv)
        {
            return DatabaseAccess.themNhanVien(nv);
        }
        public bool xoaNV(string manv)
        {
            return DatabaseAccess.XoaThongtinNV(manv);
        }
        public int ifEmployeeExistsInDB(string manv)
        {
            return DatabaseAccess.ifEmployeeExistsInDB(manv);
        }
    }
}
