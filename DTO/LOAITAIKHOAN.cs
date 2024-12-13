using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LOAITAIKHOAN
    {
        private string maLoaiTaiKhoan;
        public string MaLoaiTaiKhoan
        {
            get => maLoaiTaiKhoan;
            set => maLoaiTaiKhoan = value;
        }

        private string tenLoaiTaiKhoan;
        public string TenLoaiTaiKhoan
        {
            get => tenLoaiTaiKhoan;
            set => tenLoaiTaiKhoan = value;
        }

        private string mieuTa;
        public string MieuTa
        {
            get => mieuTa;
            set => mieuTa = value;
        }
    }
}
