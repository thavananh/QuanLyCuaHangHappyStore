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
    public class NhanVienBLL
    {
        NhanVienAccess nvaccess = new NhanVienAccess();
        public List<NHANVIEN> xemNhanVien()
        {
            List<NHANVIEN> lnv = new List<NHANVIEN>();
            lnv = nvaccess.xemLeTan();
            return lnv;
        }
        public string checkcapnhat(NHANVIEN nv)
        {
            string updatenv = nvaccess.UpdateNV(nv);
            return updatenv;
        }
        public List<NHANVIEN> xemHuanLuyenVien(string chucVu)
        {
            List<NHANVIEN> lhlv = new List<NHANVIEN>();
            lhlv= nvaccess.xemHuanLuyenVien(chucVu);
            return lhlv;
        }
        public NHANVIEN xemThongTinNV(string manv)
        {
            NHANVIEN nv = new NHANVIEN();
            nv = nvaccess.xemthongTinNV(manv);
            return nv;
        }
        public NHANVIEN xemThongTinHLV(string manv)
        {
            NHANVIEN nv = new NHANVIEN();
            nv = nvaccess.xemthongTinHLV(manv);
            return nv;
        }
        public bool themNV(NHANVIEN nv)
        {
            DateTime now = DateTime.Now;
            nv.maNhanVien = nv.MaLoaiChucVu + now.Year + now.Month.ToString("D2") + now.Day.ToString("D2") + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
            return nvaccess.ThemNV(nv);
        }
        public bool XoaNV(string manv)
        {
            return nvaccess.xoaNV(manv);
        }

        public bool ifEmployeeExistsInDB(string manv)
        {
            return nvaccess.ifEmployeeExistsInDB(manv);
        }
    }
}
