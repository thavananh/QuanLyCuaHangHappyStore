using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
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
    
    public partial class frmLogin : Form
    {
        SqlConnection sqlconnect;
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        LoaiTaiKhoanBLL loaiTaiKhoanBLL = new LoaiTaiKhoanBLL();

        

        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
            btnCreateAccount.Visible = false;
            btnCreateAccount.Enabled = false;   
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            taikhoan.MaTaiKhoan = tbUserId.Text;
            taikhoan.MatKhau = tbPassword.Text;
            if (TKBLL.Checklogin(taikhoan))
            {
                //AccountPriority(TKBLL.CheckAccountType(taikhoan));
                TaiKhoan tmp = TKBLL.layTaiKhoanTheoMa(taikhoan.MaTaiKhoan);
                this.Hide();
                frmMainPage fTC = new frmMainPage(tmp.MaTaiKhoan, tmp.LoaiTK);
                fTC.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void AccountPriority(int ltk)
        {
            //if (ltk == 1)
            //{
            //    this.Hide();
            //    frmMainPage fTC = new frmMainPage(1);
            //    fTC.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    this.Hide();
            //    frmMainPage fTC = new frmMainPage(0);
            //    fTC.ShowDialog();
            //    this.Show();
            //}
            frmMainPage fTC = new frmMainPage();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnRestorePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRestorePassword restorePassword = new frmRestorePassword();
            restorePassword.ShowDialog();
            this.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            frmCreateAccount.ShowDialog();
            this.Show();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            if (FirstRunChecker.IsFirstRun() == true)
            {
                MessageBox.Show("Xin chào người dùng mới. Cảm ơn bạn đã sử dụng phần mềm. Tên tài khoản đăng nhập mặc định là admin. Mật khẩu đăng nhập mặc định là admin123 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.SetText(FirstRunChecker.userSpecialPass);
            }
        }

        private void tbUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbUserId, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbUserId, "");
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbPassword, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbPassword, "");
            }
        }
    }
}
