using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoaiTaiKhoanAccess:DatabaseAccess
    {
        public bool CreateLoaiTaiKhoan(LOAITAIKHOAN loai)
        {
            return DatabaseAccess.CreateLoaiTaiKhoan(loai);
        }
        public List<LOAITAIKHOAN> GetAllLoaiTaiKhoan()
        {
            return DatabaseAccess.GetAllLoaiTaiKhoan();
        }
        public LOAITAIKHOAN GetLoaiTaiKhoanById(string maLoaiTaiKhoan)
        {
            return DatabaseAccess.GetLoaiTaiKhoanById(maLoaiTaiKhoan);
        }
        public bool UpdateLoaiTaiKhoan(LOAITAIKHOAN loai)
        {
            return DatabaseAccess.UpdateLoaiTaiKhoan(loai);
        }
        public bool DeleteLoaiTaiKhoan(string maLoaiTaiKhoan)
        {
            return DatabaseAccess.DeleteLoaiTaiKhoan(maLoaiTaiKhoan);
        }
    }
}
