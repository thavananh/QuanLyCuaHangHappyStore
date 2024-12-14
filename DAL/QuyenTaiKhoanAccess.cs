using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class QuyenTaiKhoanAccess:DatabaseAccess
    {
        public bool CreateQuyenTaiKhoan(QUYENTAIKHOAN quyen)
        {
            return DatabaseAccess.CreateQuyenTaiKhoan(quyen);
        }
        public List<QUYENTAIKHOAN> GetAllQuyenTaiKhoan()
        {
            return DatabaseAccess.GetAllQuyenTaiKhoan();
        }
        public QUYENTAIKHOAN GetQuyenTaiKhoanById(string maQuyenTaiKhoan)
        {
            return DatabaseAccess.GetQuyenTaiKhoanById(maQuyenTaiKhoan);
        }
        public bool UpdateQuyenTaiKhoan(QUYENTAIKHOAN quyen)
        {
            return DatabaseAccess.UpdateQuyenTaiKhoan(quyen);
        }

        public bool DeleteQuyenTaiKhoan(string maQuyenTaiKhoan)
        {
            return DatabaseAccess.DeleteQuyenTaiKhoan(maQuyenTaiKhoan);
        }
    }
}
