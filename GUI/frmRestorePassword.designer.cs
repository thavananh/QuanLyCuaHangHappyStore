
namespace GUI
{
    partial class frmRestorePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGetOTP = new System.Windows.Forms.Button();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVerifyPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOTP = new System.Windows.Forms.TextBox();
            this.btnRestorePassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetOTP
            // 
            this.btnGetOTP.Location = new System.Drawing.Point(201, 124);
            this.btnGetOTP.Name = "btnGetOTP";
            this.btnGetOTP.Size = new System.Drawing.Size(75, 23);
            this.btnGetOTP.TabIndex = 5;
            this.btnGetOTP.Text = "Get OTP";
            this.btnGetOTP.UseVisualStyleBackColor = true;
            this.btnGetOTP.Click += new System.EventHandler(this.btnGetOTP_Click);
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(32, 47);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(71, 13);
            this.lbMatKhauMoi.TabIndex = 1;
            this.lbMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(116, 18);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(158, 20);
            this.tbUserId.TabIndex = 0;
            this.tbUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xác nhận mật khẩu";
            // 
            // tbVerifyPassword
            // 
            this.tbVerifyPassword.Location = new System.Drawing.Point(116, 70);
            this.tbVerifyPassword.Name = "tbVerifyPassword";
            this.tbVerifyPassword.PasswordChar = '*';
            this.tbVerifyPassword.Size = new System.Drawing.Size(158, 20);
            this.tbVerifyPassword.TabIndex = 2;
            this.tbVerifyPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVerifyPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã OTP";
            // 
            // tbOTP
            // 
            this.tbOTP.Location = new System.Drawing.Point(116, 124);
            this.tbOTP.Name = "tbOTP";
            this.tbOTP.Size = new System.Drawing.Size(79, 20);
            this.tbOTP.TabIndex = 4;
            this.tbOTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOTP_KeyPress);
            // 
            // btnRestorePassword
            // 
            this.btnRestorePassword.Location = new System.Drawing.Point(116, 150);
            this.btnRestorePassword.Name = "btnRestorePassword";
            this.btnRestorePassword.Size = new System.Drawing.Size(75, 23);
            this.btnRestorePassword.TabIndex = 6;
            this.btnRestorePassword.Text = "Khôi phục";
            this.btnRestorePassword.UseVisualStyleBackColor = true;
            this.btnRestorePassword.Click += new System.EventHandler(this.btnRestorePassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(201, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(116, 44);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(158, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tài khoản:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(116, 96);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(158, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRestorePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 184);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOTP);
            this.Controls.Add(this.tbVerifyPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestorePassword);
            this.Controls.Add(this.btnGetOTP);
            this.Name = "frmRestorePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore Password";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetOTP;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVerifyPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOTP;
        private System.Windows.Forms.Button btnRestorePassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}