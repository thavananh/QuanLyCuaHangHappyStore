using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoaiChucVuAccess:DatabaseAccess
    {
        public bool CreateLoaiChucVu(LOAICHUCVU loaiChucVu)
        {
            return DatabaseAccess.CreateLoaiChucVu(loaiChucVu);
        }
        public List<LOAICHUCVU> ReadLoaiChucVu()
        {
            return DatabaseAccess.ReadLoaiChucVu();
        }
        public LOAICHUCVU ReadLoaiChucVuById(string maChucVu)
        {
            return DatabaseAccess.ReadLoaiChucVuById(maChucVu);
        }
        public bool UpdateLoaiChucVu(LOAICHUCVU loaiChucVu)
        {
            return DatabaseAccess.UpdateLoaiChucVu(loaiChucVu);
        }
        public bool DeleteLoaiChucVu(string maLoaiChucVu)
        {
            return DatabaseAccess.DeleteLoaiChucVu(maLoaiChucVu);
        }
    }
}
