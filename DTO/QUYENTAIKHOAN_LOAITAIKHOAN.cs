using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QUYENTAIKHOAN_LOAITAIKHOAN
    {
        private string maQuyenTaiKhoan;
        public string MaQuyenTaiKhoan
        {
            get => maQuyenTaiKhoan;
            set => maQuyenTaiKhoan = value;
        }
        private string maLoaiTaiKhoan;
        public string MaLoaiTaiKhoan
        {
            get => maLoaiTaiKhoan;
            set => maLoaiTaiKhoan = value;
        }
    }
}
