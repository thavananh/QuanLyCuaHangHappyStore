using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class QuyenTaiKhoanBLL
    {
        QuyenTaiKhoanAccess quyenTaiKhoanAccess = new QuyenTaiKhoanAccess();
        public bool CreateQuyenTaiKhoan(QUYENTAIKHOAN quyen)
        {
            return quyenTaiKhoanAccess.CreateQuyenTaiKhoan(quyen);
        }
        public List<QUYENTAIKHOAN> GetAllQuyenTaiKhoan()
        {
            return quyenTaiKhoanAccess.GetAllQuyenTaiKhoan();
        }
        public QUYENTAIKHOAN GetQuyenTaiKhoanById(string maQuyenTaiKhoan)
        {
            return quyenTaiKhoanAccess.GetQuyenTaiKhoanById(maQuyenTaiKhoan);
        }
        public bool UpdateQuyenTaiKhoan(QUYENTAIKHOAN quyen)
        {
            return quyenTaiKhoanAccess.UpdateQuyenTaiKhoan(quyen);
        }

        public bool DeleteQuyenTaiKhoan(string maQuyenTaiKhoan)
        {
            return quyenTaiKhoanAccess.DeleteQuyenTaiKhoan(maQuyenTaiKhoan);
        }
    }
}
