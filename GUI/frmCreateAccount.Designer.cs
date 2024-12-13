namespace GUI
{
    partial class frmCreateAccount
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
            this.tbOTP = new System.Windows.Forms.TextBox();
            this.tbVerifyPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnGetOTP = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbSpecialPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbQTV = new System.Windows.Forms.RadioButton();
            this.rdbNV = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOTP
            // 
            this.tbOTP.Location = new System.Drawing.Point(123, 147);
            this.tbOTP.Name = "tbOTP";
            this.tbOTP.Size = new System.Drawing.Size(85, 20);
            this.tbOTP.TabIndex = 5;
            this.tbOTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOTP_KeyPress);
            // 
            // tbVerifyPassword
            // 
            this.tbVerifyPassword.Location = new System.Drawing.Point(122, 73);
            this.tbVerifyPassword.Name = "tbVerifyPassword";
            this.tbVerifyPassword.PasswordChar = '*';
            this.tbVerifyPassword.Size = new System.Drawing.Size(165, 20);
            this.tbVerifyPassword.TabIndex = 2;
            this.tbVerifyPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVerifyPassword_KeyPress);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(122, 47);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(165, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(123, 21);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(164, 20);
            this.tbUserId.TabIndex = 0;
            this.tbUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserId_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã OTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Xác nhận mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã tài khoản";
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(46, 50);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(71, 13);
            this.lbMatKhauMoi.TabIndex = 9;
            this.lbMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(214, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(122, 198);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(81, 23);
            this.btnCreateAccount.TabIndex = 9;
            this.btnCreateAccount.Text = "Tạo tài khoản";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnGetOTP
            // 
            this.btnGetOTP.Location = new System.Drawing.Point(214, 147);
            this.btnGetOTP.Name = "btnGetOTP";
            this.btnGetOTP.Size = new System.Drawing.Size(75, 23);
            this.btnGetOTP.TabIndex = 6;
            this.btnGetOTP.Text = "Get OTP";
            this.btnGetOTP.UseVisualStyleBackColor = true;
            this.btnGetOTP.Click += new System.EventHandler(this.btnGetOTP_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(122, 124);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(165, 20);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbSpecialPassword
            // 
            this.tbSpecialPassword.Location = new System.Drawing.Point(122, 99);
            this.tbSpecialPassword.Name = "tbSpecialPassword";
            this.tbSpecialPassword.PasswordChar = '*';
            this.tbSpecialPassword.Size = new System.Drawing.Size(164, 20);
            this.tbSpecialPassword.TabIndex = 3;
            this.tbSpecialPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpecialPassword_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mật khẩu đặc biệt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Loại tài khoản";
            // 
            // rdbQTV
            // 
            this.rdbQTV.AutoSize = true;
            this.rdbQTV.Location = new System.Drawing.Point(123, 174);
            this.rdbQTV.Name = "rdbQTV";
            this.rdbQTV.Size = new System.Drawing.Size(85, 17);
            this.rdbQTV.TabIndex = 7;
            this.rdbQTV.TabStop = true;
            this.rdbQTV.Text = "Quản trị viên";
            this.rdbQTV.UseVisualStyleBackColor = true;
            // 
            // rdbNV
            // 
            this.rdbNV.AutoSize = true;
            this.rdbNV.Location = new System.Drawing.Point(214, 175);
            this.rdbNV.Name = "rdbNV";
            this.rdbNV.Size = new System.Drawing.Size(74, 17);
            this.rdbNV.TabIndex = 8;
            this.rdbNV.TabStop = true;
            this.rdbNV.Text = "Nhân viên";
            this.rdbNV.UseVisualStyleBackColor = true;
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 228);
            this.Controls.Add(this.rdbNV);
            this.Controls.Add(this.rdbQTV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSpecialPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbOTP);
            this.Controls.Add(this.tbVerifyPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnGetOTP);
            this.Name = "frmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOTP;
        private System.Windows.Forms.TextBox tbVerifyPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnGetOTP;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbSpecialPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbQTV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbNV;
    }
}