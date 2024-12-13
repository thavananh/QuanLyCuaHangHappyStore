
namespace GUI
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMembershipDuration = new System.Windows.Forms.TextBox();
            this.lblThoiHanGoi = new System.Windows.Forms.Label();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.btnCameraCapture = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.btnExportQR = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ptbProduct = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Teal;
            this.lblSoLuong.Location = new System.Drawing.Point(153, 295);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(72, 17);
            this.lblSoLuong.TabIndex = 139;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(159, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 138;
            this.label6.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(164, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 137;
            this.label5.Text = "Tên SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(183, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 136;
            this.label4.Text = "Loại";
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "Gói thành viên"});
            this.cbProductType.Location = new System.Drawing.Point(228, 229);
            this.cbProductType.Margin = new System.Windows.Forms.Padding(2);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(162, 21);
            this.cbProductType.TabIndex = 1;
            this.cbProductType.SelectedIndexChanged += new System.EventHandler(this.cbProductType_SelectedIndexChanged);
            this.cbProductType.SelectedValueChanged += new System.EventHandler(this.cbProductType_SelectedValueChanged);
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(228, 192);
            this.tbProductName.Margin = new System.Windows.Forms.Padding(2);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(226, 20);
            this.tbProductName.TabIndex = 0;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(228, 264);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(115, 20);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGiaBan_KeyPress);
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(228, 295);
            this.tbSL.Margin = new System.Windows.Forms.Padding(2);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(115, 20);
            this.tbSL.TabIndex = 4;
            this.tbSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSL_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label12.Location = new System.Drawing.Point(265, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(324, 31);
            this.label12.TabIndex = 151;
            this.label12.Text = "Thông tin sản phẩm mới";
            // 
            // tbMembershipDuration
            // 
            this.tbMembershipDuration.Location = new System.Drawing.Point(228, 295);
            this.tbMembershipDuration.Margin = new System.Windows.Forms.Padding(2);
            this.tbMembershipDuration.Name = "tbMembershipDuration";
            this.tbMembershipDuration.Size = new System.Drawing.Size(115, 20);
            this.tbMembershipDuration.TabIndex = 3;
            this.tbMembershipDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbThoiHanGoi_KeyPress);
            // 
            // lblThoiHanGoi
            // 
            this.lblThoiHanGoi.AutoSize = true;
            this.lblThoiHanGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiHanGoi.ForeColor = System.Drawing.Color.Teal;
            this.lblThoiHanGoi.Location = new System.Drawing.Point(68, 295);
            this.lblThoiHanGoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThoiHanGoi.Name = "lblThoiHanGoi";
            this.lblThoiHanGoi.Size = new System.Drawing.Size(157, 17);
            this.lblThoiHanGoi.TabIndex = 154;
            this.lblThoiHanGoi.Text = "Thời hạn gói (tháng)";
            // 
            // cbCamera
            // 
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(551, 362);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(130, 21);
            this.cbCamera.TabIndex = 156;
            // 
            // btnCameraCapture
            // 
            this.btnCameraCapture.Location = new System.Drawing.Point(687, 362);
            this.btnCameraCapture.Name = "btnCameraCapture";
            this.btnCameraCapture.Size = new System.Drawing.Size(101, 23);
            this.btnCameraCapture.TabIndex = 155;
            this.btnCameraCapture.Text = "Camera Capture";
            this.btnCameraCapture.UseVisualStyleBackColor = true;
            this.btnCameraCapture.Click += new System.EventHandler(this.btnCameraCapture_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaNhap.ForeColor = System.Drawing.Color.Teal;
            this.lblGiaNhap.Location = new System.Drawing.Point(347, 264);
            this.lblGiaNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(74, 17);
            this.lblGiaNhap.TabIndex = 159;
            this.lblGiaNhap.Text = "Giá nhập";
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Location = new System.Drawing.Point(425, 261);
            this.tbGiaNhap.Margin = new System.Windows.Forms.Padding(2);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(115, 20);
            this.tbGiaNhap.TabIndex = 160;
            this.tbGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGiaNhap_KeyPress);
            // 
            // btnExportQR
            // 
            this.btnExportQR.AutoSize = true;
            this.btnExportQR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportQR.BackgroundImage = global::GUI.Properties.Resources.Xuat;
            this.btnExportQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportQR.FlatAppearance.BorderSize = 0;
            this.btnExportQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportQR.Location = new System.Drawing.Point(551, 388);
            this.btnExportQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportQR.Name = "btnExportQR";
            this.btnExportQR.Size = new System.Drawing.Size(110, 53);
            this.btnExportQR.TabIndex = 158;
            this.btnExportQR.UseVisualStyleBackColor = false;
            this.btnExportQR.Click += new System.EventHandler(this.btnExportQR_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(799, 436);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.BackgroundImage = global::GUI.Properties.Resources.luu;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(665, 391);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 50);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ptbProduct
            // 
            this.ptbProduct.Image = ((System.Drawing.Image)(resources.GetObject("ptbProduct.Image")));
            this.ptbProduct.Location = new System.Drawing.Point(551, 152);
            this.ptbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.ptbProduct.Name = "ptbProduct";
            this.ptbProduct.Size = new System.Drawing.Size(237, 205);
            this.ptbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProduct.TabIndex = 144;
            this.ptbProduct.TabStop = false;
            this.ptbProduct.Click += new System.EventHandler(this.ptbProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 161;
            this.label2.Text = "Developed by HappyStore Dev";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGiaNhap);
            this.Controls.Add(this.lblGiaNhap);
            this.Controls.Add(this.btnExportQR);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.btnCameraCapture);
            this.Controls.Add(this.tbMembershipDuration);
            this.Controls.Add(this.lblThoiHanGoi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ptbProduct);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.cbProductType);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThemSanPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.PictureBox ptbProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbMembershipDuration;
        private System.Windows.Forms.Label lblThoiHanGoi;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Button btnCameraCapture;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnExportQR;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label label2;
    }
}