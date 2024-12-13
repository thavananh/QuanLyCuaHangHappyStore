using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoaiSanPhamAccess:DatabaseAccess
    {
        public bool themLoaiSanPham(LOAISANPHAM loaiSanPham)
        {
            return DatabaseAccess.themLoaiSanPham(loaiSanPham);
        }

        public List<LOAISANPHAM> xemLoaiSanPham()
        {
            return DatabaseAccess.xemLoaiSanPham();
        }
    }
}
