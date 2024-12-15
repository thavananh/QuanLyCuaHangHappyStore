namespace GUI
{
    partial class frmPermissionManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbChonQuyenLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.cboQuyenDaChon = new System.Windows.Forms.ComboBox();
            this.cboLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.btnCapQuyen = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 171;
            this.label1.Text = "Developed by HappyStore Dev";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label12.Location = new System.Drawing.Point(43, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(458, 31);
            this.label12.TabIndex = 170;
            this.label12.Text = "Thông tin quyền loại tài khoản mới";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(13, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 169;
            this.label8.Text = "Loại tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 175;
            this.label2.Text = "Chọn quyền loại tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 177;
            this.label3.Text = "Quyền đã chọn";
            // 
            // cbChonQuyenLoaiTaiKhoan
            // 
            this.cbChonQuyenLoaiTaiKhoan.FormattingEnabled = true;
            this.cbChonQuyenLoaiTaiKhoan.Location = new System.Drawing.Point(223, 117);
            this.cbChonQuyenLoaiTaiKhoan.Name = "cbChonQuyenLoaiTaiKhoan";
            this.cbChonQuyenLoaiTaiKhoan.Size = new System.Drawing.Size(307, 21);
            this.cbChonQuyenLoaiTaiKhoan.TabIndex = 178;
            // 
            // cboQuyenDaChon
            // 
            this.cboQuyenDaChon.FormattingEnabled = true;
            this.cboQuyenDaChon.Location = new System.Drawing.Point(223, 151);
            this.cboQuyenDaChon.Name = "cboQuyenDaChon";
            this.cboQuyenDaChon.Size = new System.Drawing.Size(307, 21);
            this.cboQuyenDaChon.TabIndex = 179;
            // 
            // cboLoaiTaiKhoan
            // 
            this.cboLoaiTaiKhoan.FormattingEnabled = true;
            this.cboLoaiTaiKhoan.Location = new System.Drawing.Point(223, 85);
            this.cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            this.cboLoaiTaiKhoan.Size = new System.Drawing.Size(307, 21);
            this.cboLoaiTaiKhoan.TabIndex = 180;
            // 
            // btnCapQuyen
            // 
            this.btnCapQuyen.AutoSize = true;
            this.btnCapQuyen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapQuyen.BackgroundImage = global::GUI.Properties.Resources.IconCapQuyen;
            this.btnCapQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapQuyen.FlatAppearance.BorderSize = 0;
            this.btnCapQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapQuyen.Location = new System.Drawing.Point(183, 182);
            this.btnCapQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapQuyen.Name = "btnCapQuyen";
            this.btnCapQuyen.Size = new System.Drawing.Size(113, 45);
            this.btnCapQuyen.TabIndex = 182;
            this.btnCapQuyen.UseVisualStyleBackColor = false;
            this.btnCapQuyen.Click += new System.EventHandler(this.btnCapQuyen_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.BackgroundImage = global::GUI.Properties.Resources.Xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(300, 182);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 45);
            this.btnXoa.TabIndex = 181;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.BackgroundImage = global::GUI.Properties.Resources.luu;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(417, 182);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 45);
            this.btnSave.TabIndex = 174;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(454, 242);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 43);
            this.btnBack.TabIndex = 172;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPermissionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 294);
            this.Controls.Add(this.btnCapQuyen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboLoaiTaiKhoan);
            this.Controls.Add(this.cboQuyenDaChon);
            this.Controls.Add(this.cbChonQuyenLoaiTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Name = "frmPermissionManage";
            this.Text = "frmPermissionManage";
            this.Load += new System.EventHandler(this.frmPermissionManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbChonQuyenLoaiTaiKhoan;
        private System.Windows.Forms.ComboBox cboQuyenDaChon;
        private System.Windows.Forms.ComboBox cboLoaiTaiKhoan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapQuyen;
    }
}