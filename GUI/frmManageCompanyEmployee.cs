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
    public partial class frmManageCompanyEmployee : Form
    {
        QuanLyQuyenHanChucNang quanLyQuyenHanChucNang = new QuanLyQuyenHanChucNang();
        private string maTaiKhoan = "";
        private string maLoaiTaiKhoan = "";
        public frmManageCompanyEmployee()
        {
            InitializeComponent();
        }

        public frmManageCompanyEmployee(string inputMaTaiKhoan, string inputMaLoaiTaikhoan)
        {
            InitializeComponent();
            this.maTaiKhoan = inputMaTaiKhoan;
            this.maLoaiTaiKhoan = inputMaLoaiTaikhoan;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            frmEmployeeList fdsnv = new frmEmployeeList();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmEmployeeList.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            this.Hide();
            fdsnv.ShowDialog();
            this.Show();
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeRegistration FDKNV = new frmEmployeeRegistration();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmEmployeeRegistration.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            FDKNV.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEmployeeType frmadd = new frmAddEmployeeType();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmAddEmployeeType.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            frmadd.ShowDialog();
            this.Show();
        }

        private void frmManageCompanyEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPermissionManage permissionManage = new frmPermissionManage(maTaiKhoan, maLoaiTaiKhoan);
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmPermissionManage.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            permissionManage.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddEmployeeAccountType addEmployeeAccountType = new frmAddEmployeeAccountType();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmAddEmployeeAccountType.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            addEmployeeAccountType.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFormPermission formPermission = new frmFormPermission();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmFormPermission.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            formPermission.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAddPermissionType addPermissionType = new frmAddPermissionType();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmAddPermissionType.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            addPermissionType.ShowDialog();
            this.Show();
        }
    }
}
