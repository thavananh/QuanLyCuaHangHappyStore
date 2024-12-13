using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamAccess loaiSanPhamAccess = new LoaiSanPhamAccess();
        public bool themLoaiSanPham(LOAISANPHAM loaiSanPham)
        {
            return loaiSanPhamAccess.themLoaiSanPham(loaiSanPham);
        }
        public List<LOAISANPHAM> xemLoaiSanPham()
        {
            return loaiSanPhamAccess.xemLoaiSanPham();
        }
    }
}
