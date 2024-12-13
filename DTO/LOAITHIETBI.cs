using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LOAITHIETBI
    {
        private string maLoaiThietBi;
        public string MaLoaiThietBi
        {
            get => maLoaiThietBi;
            set => maLoaiThietBi = value;
        }
        private string tenLoaiThietBi;
        public string TenLoaiThietBi
        {
            get => tenLoaiThietBi;
            set => tenLoaiThietBi = value;
        }
        public LOAITHIETBI() { }
        ~LOAITHIETBI() { }
    }
}
