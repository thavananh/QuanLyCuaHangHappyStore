using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChucNang_QuyenTaiKhoanAceess:DatabaseAccess
    {
        public bool AddChucNang_QuyenTaiKhoan(CHUCNANG_QUYENTAIKHOAN input)
        {
            return DatabaseAccess.AddChucNang_QuyenTaiKhoan(input);
        }
        public List<CHUCNANG_QUYENTAIKHOAN> GetAllChucNang_QuyenTaiKhoan()
        {
            return DatabaseAccess.GetAllChucNang_QuyenTaiKhoan();
        }
        public bool UpdateChucNang_QuyenTaiKhoan(string maChucNang, string newMaQuyenTaiKhoan, string oldMaQuyenTaiKhoan)
        {
            return DatabaseAccess.UpdateChucNang_QuyenTaiKhoan(maChucNang, newMaQuyenTaiKhoan, oldMaQuyenTaiKhoan);
        }
        public bool DeleteChucNang_QuyenTaiKhoan(string maChucNang, string maQuyenTaiKhoan)
        {
            return DatabaseAccess.DeleteChucNang_QuyenTaiKhoan(maChucNang, maQuyenTaiKhoan);
        }
        
    }
}
