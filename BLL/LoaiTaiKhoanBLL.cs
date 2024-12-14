using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoaiTaiKhoanBLL
    {
        LoaiTaiKhoanAccess loaiTaiKhoanAccess = new LoaiTaiKhoanAccess();   
        public bool CreateLoaiTaiKhoan(LOAITAIKHOAN loai)
        {
            return loaiTaiKhoanAccess.CreateLoaiTaiKhoan(loai);
        }
        public List<LOAITAIKHOAN> GetAllLoaiTaiKhoan()
        {
            return loaiTaiKhoanAccess.GetAllLoaiTaiKhoan();
        }
        public LOAITAIKHOAN GetLoaiTaiKhoanById(string maLoaiTaiKhoan)
        {
            return loaiTaiKhoanAccess.GetLoaiTaiKhoanById(maLoaiTaiKhoan);
        }
        public bool UpdateLoaiTaiKhoan(LOAITAIKHOAN loai)
        {
            return loaiTaiKhoanAccess.UpdateLoaiTaiKhoan(loai);   
        }
        public bool DeleteLoaiTaiKhoan(string maLoaiTaiKhoan)
        {
            return loaiTaiKhoanAccess.DeleteLoaiTaiKhoan(maLoaiTaiKhoan);
        }
    }
}
