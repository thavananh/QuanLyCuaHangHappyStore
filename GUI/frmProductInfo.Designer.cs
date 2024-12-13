
namespace GUI
{
    partial class frmProductInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNOP = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ptbProduct = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.btnCameraCapture = new System.Windows.Forms.Button();
            this.btnExportQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // tbNOP
            // 
            this.tbNOP.Location = new System.Drawing.Point(254, 334);
            this.tbNOP.Margin = new System.Windows.Forms.Padding(2);
            this.tbNOP.Name = "tbNOP";
            this.tbNOP.Size = new System.Drawing.Size(115, 20);
            this.tbNOP.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(254, 304);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(175, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(255, 213);
            this.tbProductName.Margin = new System.Windows.Forms.Padding(2);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(174, 20);
            this.tbProductName.TabIndex = 1;
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "Thực phẩm",
            "Dụng cụ hỗ trợ"});
            this.cbProductType.Location = new System.Drawing.Point(254, 244);
            this.cbProductType.Margin = new System.Windows.Forms.Padding(2);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(115, 21);
            this.cbProductType.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(164, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 147;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(164, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 146;
            this.label6.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(164, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 145;
            this.label5.Text = "Tên SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(164, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 144;
            this.label4.Text = "Loại";
            // 
            // ptbProduct
            // 
            this.ptbProduct.Image = ((System.Drawing.Image)(resources.GetObject("ptbProduct.Image")));
            this.ptbProduct.Location = new System.Drawing.Point(485, 160);
            this.ptbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.ptbProduct.Name = "ptbProduct";
            this.ptbProduct.Size = new System.Drawing.Size(237, 205);
            this.ptbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProduct.TabIndex = 152;
            this.ptbProduct.TabStop = false;
            this.ptbProduct.Click += new System.EventHandler(this.ptbProduct_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(799, 424);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.BackgroundImage = global::GUI.Properties.Resources.luu;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(602, 398);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 47);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(164, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 155;
            this.label1.Text = "Mã SP";
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(254, 177);
            this.tbProductId.Margin = new System.Windows.Forms.Padding(2);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(175, 20);
            this.tbProductId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 157;
            this.label2.Text = "Developed by HappyStore Dev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(287, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 31);
            this.label3.TabIndex = 158;
            this.label3.Text = "Thông tin sản phẩm";
            // 
            // cbCamera
            // 
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(485, 370);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(137, 21);
            this.cbCamera.TabIndex = 160;
            // 
            // btnCameraCapture
            // 
            this.btnCameraCapture.Location = new System.Drawing.Point(628, 368);
            this.btnCameraCapture.Name = "btnCameraCapture";
            this.btnCameraCapture.Size = new System.Drawing.Size(94, 23);
            this.btnCameraCapture.TabIndex = 159;
            this.btnCameraCapture.Text = "Camera Capture";
            this.btnCameraCapture.UseVisualStyleBackColor = true;
            this.btnCameraCapture.Click += new System.EventHandler(this.btnCameraCapture_Click);
            // 
            // btnExportQR
            // 
            this.btnExportQR.AutoSize = true;
            this.btnExportQR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportQR.BackgroundImage = global::GUI.Properties.Resources.Xuat;
            this.btnExportQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportQR.FlatAppearance.BorderSize = 0;
            this.btnExportQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportQR.Location = new System.Drawing.Point(485, 396);
            this.btnExportQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportQR.Name = "btnExportQR";
            this.btnExportQR.Size = new System.Drawing.Size(105, 49);
            this.btnExportQR.TabIndex = 161;
            this.btnExportQR.UseVisualStyleBackColor = false;
            this.btnExportQR.Click += new System.EventHandler(this.btnExportQR_Click);
            // 
            // frmProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 466);
            this.Controls.Add(this.btnExportQR);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.btnCameraCapture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.ptbProduct);
            this.Controls.Add(this.tbNOP);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.cbProductType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductInfo_FormClosing);
            this.Load += new System.EventHandler(this.frmProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNOP;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptbProduct;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Button btnCameraCapture;
        private System.Windows.Forms.Button btnExportQR;
    }
}