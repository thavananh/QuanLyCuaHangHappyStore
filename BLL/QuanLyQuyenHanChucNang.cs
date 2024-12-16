using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class QuanLyQuyenHanChucNang
    {
        ChucNangBLL chucNangBLL = new ChucNangBLL();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        LoaiTaiKhoanBLL loaiTaiKhoanBLL = new LoaiTaiKhoanBLL();
        QuyenTaiKhoan_LoaiTaiKhoanBLL quyenTaiKhoan_LoaiTaiKhoanBLL = new QuyenTaiKhoan_LoaiTaiKhoanBLL();
        ChucNang_QuyenTaiKhoanBLL chucNang_QuyenTaiKhoanBLL = new ChucNang_QuyenTaiKhoanBLL();
        public bool KiemTraQuyenTruyCapVaoChucNang(string tenChucNang, string maTaiKhoan, string maLoaiTaiKhoan)
        {
            CHUCNANG chucNang = new CHUCNANG();
            chucNang = chucNangBLL.TimChucNangTheoTen(tenChucNang);
            List<CHUCNANG_QUYENTAIKHOAN> listChucNang_QuyenTaiKhoan = chucNang_QuyenTaiKhoanBLL.GetAllChucNang_QuyenTaiKhoan_ById(chucNang.MaChucNang);
            LOAITAIKHOAN loaiTaiKhoan = new LOAITAIKHOAN();
            loaiTaiKhoan = loaiTaiKhoanBLL.GetLoaiTaiKhoanById(maLoaiTaiKhoan);
            List<QUYENTAIKHOAN_LOAITAIKHOAN> listQuyentaiKhoan_LoaiTaiKhoan = new List<QUYENTAIKHOAN_LOAITAIKHOAN>();
            listQuyentaiKhoan_LoaiTaiKhoan = quyenTaiKhoan_LoaiTaiKhoanBLL.GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(maLoaiTaiKhoan);
            foreach (var item in listChucNang_QuyenTaiKhoan)
            {
                foreach (var item1 in listQuyentaiKhoan_LoaiTaiKhoan)
                {
                    if (item.MaQuyenTaiKhoan == item1.MaQuyenTaiKhoan)
                    {
                        return true;
                    }
                }
            }            
            return false;
        }
    }
}
