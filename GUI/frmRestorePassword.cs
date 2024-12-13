using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using DTO;
using BLL;
using System.Data.SqlClient;

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
    public partial class frmRestorePassword : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        EmailOTPBLL emailOTPBLL = new EmailOTPBLL();
        string otpCode = "";
        bool otpLogic = true;
        public frmRestorePassword()
        {
            InitializeComponent();
            
        }

        private void btnGetOTP_Click(object sender, EventArgs e)
        {
            if (tbUserId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!TKBLL.ifAccountExsitsInDB(tbUserId.Text.Trim())) 
                {
                    MessageBox.Show("Mã tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    taikhoan.MaTaiKhoan = tbUserId.Text.Trim();
                }
            }
            if (ConditionClass.IsValidEmail(tbEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Email trước khi gửi OTP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbEmail.Text.Trim() != TKBLL.LayEmailCaNhan(taikhoan))
            {
                MessageBox.Show("Email không khớp với tài khoản đã đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (otpLogic == true)
            {
                otpCode = emailOTPBLL.sendOTP(tbEmail.Text.Trim());
                otpLogic = false;
            }
            else
            {
                MessageBox.Show("Đã gửi OTP, tải lại trang để thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRestorePassword_Click(object sender, EventArgs e)
        {
            if (ConditionClass.IsValidEmail(tbEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbPassword.Text.Trim().Length < 8)
            {
                MessageBox.Show("Mật khẩu phải từ 8 ký tự trở lên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tbPassword.Text == tbVerifyPassword.Text)
            {
                 taikhoan.MatKhau = tbPassword.Text;
            }
            else { 
                MessageBox.Show("Nhập lại xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }
            if(tbOTP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập OTP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            
            if (otpCode == tbOTP.Text.Trim())
            {
                if (TKBLL.UpdatePassword(taikhoan))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    otpLogic = true;
                    otpCode = "khongcotontaikkkk";
                    tbOTP.Clear();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    otpLogic = true;
                }  
            }
            else
            { 
                MessageBox.Show("OTP không chính xác, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tbVerifyPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbVerifyPassword, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbVerifyPassword, "");
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbEmail, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbEmail, "");
            }
        }

        private void tbOTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbOTP, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbOTP, "");
            }
        }
    }
}
