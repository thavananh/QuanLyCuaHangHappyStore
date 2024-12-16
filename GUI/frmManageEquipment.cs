using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

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

namespace GUI
{
    public partial class frmManageEquipment : Form
    {
        QuanLyQuyenHanChucNang quanLyQuyenHanChucNang = new QuanLyQuyenHanChucNang();
        private string maTaiKhoan = "";
        private string maLoaiTaiKhoan = "";
        public frmManageEquipment()
        {
            InitializeComponent();
        }

        public frmManageEquipment(string inputMaTaiKhoan, string inputMaLoaiTaiKhoan)
        {
            InitializeComponent();
            this.maTaiKhoan = inputMaTaiKhoan;
            this.maLoaiTaiKhoan = inputMaLoaiTaiKhoan;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPE_Click(object sender, EventArgs e)
        {
            frmPEList peList = new frmPEList();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmPEList.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            peList.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEquipmentType addEquipmentType = new frmAddEquipmentType();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmAddEquipmentType.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            addEquipmentType.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddEquipment fttb = new frmAddEquipment();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmAddEquipment.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            fttb.ShowDialog();
            this.Show();
        }

        private void frmManageEquipment_Load(object sender, EventArgs e)
        {

        }
    }
}
