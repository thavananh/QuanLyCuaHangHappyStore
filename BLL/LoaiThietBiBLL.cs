using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoaiThietBiBLL
    {
        LoaiThietBiAccess loaiThietBiAccess = new LoaiThietBiAccess();
        public bool themLoaiThietBi(LOAITHIETBI loaiThietBi)
        {
            loaiThietBi.MaLoaiThietBi = Guid.NewGuid().ToString();
            return loaiThietBiAccess.themLoaiThietBi(loaiThietBi);
        }
        public List<LOAITHIETBI> xemLoaiThietBi()
        {
            return loaiThietBiAccess.xemLoaiThietBi();
        }
        //public LOAITHIETBI xemLoaiThietBiTheoMa()
        //{

        //}
    }
}
