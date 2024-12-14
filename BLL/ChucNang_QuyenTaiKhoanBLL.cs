using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChucNang_QuyenTaiKhoanBLL
    {
        ChucNang_QuyenTaiKhoanAceess chucNang_QuyenTaiKhoanAceess = new ChucNang_QuyenTaiKhoanAceess();
        public bool AddChucNang_QuyenTaiKhoan(CHUCNANG_QUYENTAIKHOAN input)
        {
           return chucNang_QuyenTaiKhoanAceess.AddChucNang_QuyenTaiKhoan(input);
        }
        public List<CHUCNANG_QUYENTAIKHOAN> GetAllChucNang_QuyenTaiKhoan()
        {
            return chucNang_QuyenTaiKhoanAceess.GetAllChucNang_QuyenTaiKhoan();
        }
        public bool UpdateChucNang_QuyenTaiKhoan(string maChucNang, string newMaQuyenTaiKhoan, string oldMaQuyenTaiKhoan)
        {
            return chucNang_QuyenTaiKhoanAceess.UpdateChucNang_QuyenTaiKhoan(maChucNang, newMaQuyenTaiKhoan, oldMaQuyenTaiKhoan);
        }
        public bool DeleteChucNang_QuyenTaiKhoan(string maChucNang, string maQuyenTaiKhoan)
        {
            return chucNang_QuyenTaiKhoanAceess.DeleteChucNang_QuyenTaiKhoan(maChucNang, maQuyenTaiKhoan);
        }
    }
}
