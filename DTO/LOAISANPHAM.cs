using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LOAISANPHAM
    {
        private string maLoaiSanPham;
        public string MaLoaiSanPham
        {
            get => maLoaiSanPham;
            set => maLoaiSanPham = value;
        }

        private string tenLoaiSanPham;
        public string TenLoaiSanPham
        {
            get => tenLoaiSanPham;
            set => tenLoaiSanPham = value;
        }

        public LOAISANPHAM(){}
        ~LOAISANPHAM() {}

    }
}
