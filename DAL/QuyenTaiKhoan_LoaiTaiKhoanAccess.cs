using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class QuyenTaiKhoan_LoaiTaiKhoanAccess:DatabaseAccess
    {
        public bool ThemQuyenTaiKhoan_LoaiTaiKhoan(QUYENTAIKHOAN_LOAITAIKHOAN qltk)
        {
            return DatabaseAccess.ThemQuyenTaiKhoan_LoaiTaiKhoan(qltk);
        }
        public List<QUYENTAIKHOAN_LOAITAIKHOAN> GetAllQuyenTaiKhoan_LoaiTaiKhoan()
        {
            return DatabaseAccess.GetAllQuyenTaiKhoan_LoaiTaiKhoan();
        }
        public QUYENTAIKHOAN_LOAITAIKHOAN GetQuyenTaiKhoan_LoaiTaiKhoan(string maQuyenTaiKhoan, string maLoaiTaiKhoan)
        {
            return DatabaseAccess.GetQuyenTaiKhoan_LoaiTaiKhoan(maQuyenTaiKhoan, maLoaiTaiKhoan);
        }
        public bool UpdateQuyenTaiKhoan_LoaiTaiKhoan(string maQuyenTaiKhoan, string oldMaLoaiTaiKhoan, string newMaLoaiTaiKhoan)
        {
            return DatabaseAccess.UpdateQuyenTaiKhoan_LoaiTaiKhoan(maQuyenTaiKhoan, oldMaLoaiTaiKhoan, newMaLoaiTaiKhoan);
        }
        public bool DeleteQuyenTaiKhoan_LoaiTaiKhoan(string maQuyenTaiKhoan, string maLoaiTaiKhoan)
        {
            return DatabaseAccess.DeleteQuyenTaiKhoan_LoaiTaiKhoan(maQuyenTaiKhoan, maLoaiTaiKhoan);
        }
        public List<QUYENTAIKHOAN_LOAITAIKHOAN> GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(string maLoaiTaiKhoan)
        {
            return DatabaseAccess.GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(maLoaiTaiKhoan);
        }
    }
}
