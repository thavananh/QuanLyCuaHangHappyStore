using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoaiThietBiAccess:DatabaseAccess
    {
        public bool themLoaiThietBi(LOAITHIETBI loaiThietBi)
        {
            return DatabaseAccess.themLoaiThietBi(loaiThietBi);
        }
        public List<LOAITHIETBI> xemLoaiThietBi()
        {
            return DatabaseAccess.xemLoaiThietBi();
        }
    }
}
