using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Org.BouncyCastle.Crypto.Generators;

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
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbVerifyPassword.PasswordChar = '*';
        }
        private string otpCode = "";
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (tbUserId.Text.Trim().Length != 0 && tbPassword.Text.Trim().Length != 0 && tbEmail.Text.Trim().Length != 0 && tbSpecialPassword.Text.Trim().Length != 0 && tbOTP.Text.Trim().Length != 0 && (rdbNV.Checked || rdbQTV.Checked))
            {
                if (tbPassword.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Mật khẩu yếu, vui lòng tạo tài khoản trên 8 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TaiKhoan taikhoan = new TaiKhoan();
                    taikhoan.MaTaiKhoan = tbUserId.Text.Trim();
                    taikhoan.MatKhau = tbPassword.Text.Trim();
                    if (rdbQTV.Checked)
                    {
                        taikhoan.LoaiTK = 1;
                    }
                    else
                    {
                        taikhoan.LoaiTK = 0;
                    }
                    taikhoan.Email = tbEmail.Text.Trim();
                    if (ConditionClass.IsValidEmail(tbEmail.Text.Trim()) == false)
                    {
                        MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (TKBLL.checkEmail(tbEmail.Text.Trim()) > 0)
                    {
                        MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (otpCode == tbOTP.Text.Trim() && TKBLL.checkSpecialPassword(tbSpecialPassword.Text.Trim()))
                    {
                        if (TKBLL.AddAccount(taikhoan))
                        {
                            MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            otpCode = "khongtontaikkkk";
                            tbOTP.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại hoặc có lỗi xảy ra, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetOTP_Click(object sender, EventArgs e)
        {
            if (ConditionClass.IsValidEmail(tbEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbEmail.Text.Trim().Length == 0) { return; }
            if (TKBLL.checkEmail(tbEmail.Text.Trim()) > 0)
            {
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EmailOTPBLL sendEmail = new EmailOTPBLL();
                otpCode = sendEmail.sendOTP(tbEmail.Text.Trim());
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

        private void tbSpecialPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbSpecialPassword, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbSpecialPassword, "");
            }
        }
    }
}
