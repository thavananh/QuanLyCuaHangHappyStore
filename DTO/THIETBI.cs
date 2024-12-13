using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 ____   ___  _____ _______        ___    ____  _____ 
/ ___| / _ \|  ___|_   _\ \      / / \  |  _ \| ____|
\___ \| | | | |_    | |  \ \ /\ / / _ \ | |_) |  _|  
 ___) | |_| |  _|   | |   \ V  V / ___ \|  _ <| |___ 
|____/ \___/|_|__ __|_|  _ \_/\_/_/   \_\_| \_\_____|
/ ___|| | | / ___|_   _|/ \  |_ _| \ | |             
\___ \| | | \___ \ | | / _ \  | ||  \| |             
 ___) | |_| |___) || |/ ___ \ | || |\  |             
|____/ \___/|____/ |_/_/   \_\___|_| \_|     

DEVELOPED AND MAINTAINED BY SOFTWARE SUSTAIN
*/

namespace DTO
{
    public class THIETBI
    {
        private string mathietbi;
        public string Mathietbi
        {
            get => mathietbi;
            set => mathietbi = value;
        }
        private Byte[] anh;
        public Byte[] Anh
        {
            get => anh;
            set => anh = value;
        }
        private string tenthietbi;
        public string Tenthietbi
        {
            get => tenthietbi;
            set => tenthietbi = value;
        }
        private string tinhtrang;
        public string Tinhtrang
        {
            get => tinhtrang;
            set => tinhtrang = value;
        }
        private int soluong;
        public int Soluong
        {
            get => soluong;
            set => soluong = value;
        }
        private string donvi;
        public string Donvi
        {
            get => donvi;
            set => donvi = value;
        }
        private string loaithietbi;
        public string Loaithietbi
        {
            get => loaithietbi;
            set => loaithietbi = value;
        }

        public THIETBI()
        {
            soluong = 1;
            donvi = "Đơn vị";
        }
        ~THIETBI() { }
    }
}
