using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class QuyenTaiKhoan_LoaiTaiKhoanBLL
    {
        private QuyenTaiKhoan_LoaiTaiKhoanAccess quyenTaiKhoan_LoaiTaiKhoanAccess = new QuyenTaiKhoan_LoaiTaiKhoanAccess();
        public bool ThemQuyenTaiKhoan_LoaiTaiKhoan(QUYENTAIKHOAN_LOAITAIKHOAN qltk)
        {
            return quyenTaiKhoan_LoaiTaiKhoanAccess.ThemQuyenTaiKhoan_LoaiTaiKhoan(qltk);
        }
        public List<QUYENTAIKHOAN_LOAITAIKHOAN> GetAllQuyenTaiKhoan_LoaiTaiKhoan()
        {
            return quyenTaiKhoan_LoaiTaiKhoanAccess.GetAllQuyenTaiKhoan_LoaiTaiKhoan();
        }
        public QUYENTAIKHOAN_LOAITAIKHOAN GetQuyenTaiKhoan_LoaiTaiKhoan(string maQuyenTaiKhoan, string maLoaiTaiKhoan)
        {
            return quyenTaiKhoan_LoaiTaiKhoanAccess.GetQuyenTaiKhoan_LoaiTaiKhoan(maQuyenTaiKhoan, maLoaiTaiKhoan);
        }
        public bool UpdateQuyenTaiKhoan_LoaiTaiKhoan(string maQuyenTaiKhoan, string oldMaLoaiTaiKhoan, string newMaLoaiTaiKhoan)
        {
            return quyenTaiKhoan_LoaiTaiKhoanAccess.UpdateQuyenTaiKhoan_LoaiTaiKhoan(maQuyenTaiKhoan, oldMaLoaiTaiKhoan, newMaLoaiTaiKhoan);
        }
        public bool DeleteQuyenTaiKhoan_LoaiTaiKhoan(string maQuyenTaiKhoan, string maLoaiTaiKhoan)
        {
            return quyenTaiKhoan_LoaiTaiKhoanAccess.DeleteQuyenTaiKhoan_LoaiTaiKhoan(maQuyenTaiKhoan, maLoaiTaiKhoan);
        }
        public List<QUYENTAIKHOAN_LOAITAIKHOAN> GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(string maLoaiTaiKhoan)
        {
            return quyenTaiKhoan_LoaiTaiKhoanAccess.GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(maLoaiTaiKhoan);
        }
    }
}
