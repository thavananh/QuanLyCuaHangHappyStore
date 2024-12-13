using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QUYENTAIKHOAN
    {
        private string maQuyenTaiKhoan;
        public string MaQuyenTaiKhoan
        {
            get => maQuyenTaiKhoan;
            set => maQuyenTaiKhoan = value;
        }
        private string tenQuyenTaiKhoan;
        public string TenQuyenTaiKhoan
        {
            get => tenQuyenTaiKhoan;
            set => tenQuyenTaiKhoan = value;
        }
        private string mieuTa;
        public string MieuTa
        {
            get => mieuTa;
            set => mieuTa = value;
        }
    }
}
