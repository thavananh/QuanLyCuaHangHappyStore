using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHUCNANG_QUYENTAIKHOAN
    {
        private string maChucNang;
        public string MaChucNang
        {
            get => maChucNang;
            set => maChucNang = value;
        }
        private string maQuyenTaiKhoan;
        public string MaQuyenTaiKhoan
        {
            get => maQuyenTaiKhoan;
            set => maQuyenTaiKhoan = value;
        }
    }
}
