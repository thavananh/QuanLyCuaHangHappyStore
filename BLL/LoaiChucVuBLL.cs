using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoaiChucVuBLL
    {
        LoaiChucVuAccess loaiChucVuAccess = new LoaiChucVuAccess();
        public bool CreateLoaiChucVu(LOAICHUCVU loaiChucVu)
        {
            return loaiChucVuAccess.CreateLoaiChucVu(loaiChucVu);
        }
        public List<LOAICHUCVU> ReadLoaiChucVu()
        {
            return loaiChucVuAccess.ReadLoaiChucVu();
        }
        public bool UpdateLoaiChucVu(LOAICHUCVU loaiChucVu)
        {
            return loaiChucVuAccess.UpdateLoaiChucVu(loaiChucVu);
        }
        public bool DeleteLoaiChucVu(string maLoaiChucVu)
        {
            return loaiChucVuAccess.DeleteLoaiChucVu(maLoaiChucVu);
        }
    }
}
