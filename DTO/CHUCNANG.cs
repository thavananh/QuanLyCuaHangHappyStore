using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHUCNANG
    {
        private string maChucNang;
        public string MaChucNang
        {
            get  => maChucNang;
            set => maChucNang = value;
        }
        private string tenChucNang;
        public string TenChucNang
        {
            get => tenChucNang;
            set => tenChucNang = value;
        }
        private string mieuTa;
        public string MieuTa
        {
            get => mieuTa;
            set => mieuTa = value;
        }
        public CHUCNANG()
        {

        }
       
    }
}
