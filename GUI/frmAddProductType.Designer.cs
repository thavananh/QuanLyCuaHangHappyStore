namespace GUI
{
    partial class frmAddProductType
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
            this.tbLoaiSanPham = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbLoaiSanPhamDeXuat = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLoaiSanPham
            // 
            this.tbLoaiSanPham.Location = new System.Drawing.Point(195, 116);
            this.tbLoaiSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoaiSanPham.Name = "tbLoaiSanPham";
            this.tbLoaiSanPham.Size = new System.Drawing.Size(233, 20);
            this.tbLoaiSanPham.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(14, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Loại sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(14, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 17);
            this.label7.TabIndex = 84;
            this.label7.Text = "Loại sản phẩm đề xuất";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label12.Location = new System.Drawing.Point(36, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(378, 31);
            this.label12.TabIndex = 153;
            this.label12.Text = "Thông tin loại sản phẩm mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 154;
            this.label1.Text = "Developed by HappyStore Dev";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(352, 224);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 155;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbLoaiSanPhamDeXuat
            // 
            this.cmbLoaiSanPhamDeXuat.FormattingEnabled = true;
            this.cmbLoaiSanPhamDeXuat.Items.AddRange(new object[] {
            "Đồ ăn nhanh",
            "Đồ uống giải khát",
            "Bánh kẹo",
            "Đồ dùng cá nhân",
            "Đồ dùng gia đình",
            "Thực phẩm đông lạnh",
            "Thực phẩm tươi sống",
            "Tự đề xuất loại sản phẩm"});
            this.cmbLoaiSanPhamDeXuat.Location = new System.Drawing.Point(195, 84);
            this.cmbLoaiSanPhamDeXuat.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoaiSanPhamDeXuat.Name = "cmbLoaiSanPhamDeXuat";
            this.cmbLoaiSanPhamDeXuat.Size = new System.Drawing.Size(233, 21);
            this.cmbLoaiSanPhamDeXuat.TabIndex = 156;
            this.cmbLoaiSanPhamDeXuat.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiSanPhamDeXuat_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.BackgroundImage = global::GUI.Properties.Resources.luu;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(316, 150);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 45);
            this.btnSave.TabIndex = 157;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 272);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbLoaiSanPhamDeXuat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbLoaiSanPham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "frmAddProductType";
            this.Text = "frmAddProductType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoaiSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbLoaiSanPhamDeXuat;
        private System.Windows.Forms.Button btnSave;
    }
}