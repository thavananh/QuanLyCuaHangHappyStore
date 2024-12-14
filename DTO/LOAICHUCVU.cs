using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LOAICHUCVU
    {
        private string maLoaiChucVu;
        public string MaLoaiChucVu
        {
            get => maLoaiChucVu;
            set => maLoaiChucVu = value;
        }
        private string tenLoaiChucVu;
        public string TenLoaiChucVu
        {
            get => tenLoaiChucVu;
            set => tenLoaiChucVu = value;
        }
    }
}
