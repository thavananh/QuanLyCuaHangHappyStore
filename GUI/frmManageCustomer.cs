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
    public partial class frmManageCustomer : Form
    {
        private string maTaiKhoan = "";
        private string maLoaiTaiKhoan = "";
        public frmManageCustomer()
        {
            InitializeComponent();
        }
        public frmManageCustomer(string inputMaTaiKhoan, string inputMaLoaiTaiKhoan)
        {
            InitializeComponent();
            this.maTaiKhoan = inputMaTaiKhoan;
            this.maLoaiTaiKhoan = inputMaLoaiTaiKhoan;
        }
        QuanLyQuyenHanChucNang quanLyQuyenHanChucNang = new QuanLyQuyenHanChucNang();
        
        private void btnMemberRegistrationForm_Click(object sender, EventArgs e)
        {
            frmMemberRegistrationForm fdktv = new frmMemberRegistrationForm();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmMemberRegistrationForm.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            fdktv.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            frmCustomerList fdskh = new frmCustomerList();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmCustomerList.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            fdskh.ShowDialog();
            this.Show();
        }
    }
}
