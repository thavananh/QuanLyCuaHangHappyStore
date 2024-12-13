
namespace GUI
{
    partial class frmMainPage
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
            this.btnBackupDB = new System.Windows.Forms.Button();
            this.btnRestoreDB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnManageCompanyEmployee = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnManageEquipment = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "Developed by HappyStore Dev";
            // 
            // btnBackupDB
            // 
            this.btnBackupDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupDB.ForeColor = System.Drawing.Color.Red;
            this.btnBackupDB.Location = new System.Drawing.Point(758, 580);
            this.btnBackupDB.Name = "btnBackupDB";
            this.btnBackupDB.Size = new System.Drawing.Size(116, 23);
            this.btnBackupDB.TabIndex = 120;
            this.btnBackupDB.Text = "Backup Database";
            this.btnBackupDB.UseVisualStyleBackColor = true;
            this.btnBackupDB.Click += new System.EventHandler(this.btnBackupDB_Click);
            // 
            // btnRestoreDB
            // 
            this.btnRestoreDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRestoreDB.Location = new System.Drawing.Point(630, 580);
            this.btnRestoreDB.Name = "btnRestoreDB";
            this.btnRestoreDB.Size = new System.Drawing.Size(126, 23);
            this.btnRestoreDB.TabIndex = 122;
            this.btnRestoreDB.Text = "Restore Database";
            this.btnRestoreDB.UseVisualStyleBackColor = true;
            this.btnRestoreDB.Click += new System.EventHandler(this.btnRestoreDB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.AutoSize = true;
            this.btnManageProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageProduct.BackgroundImage = global::GUI.Properties.Resources.IconQuanLySanPham;
            this.btnManageProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageProduct.FlatAppearance.BorderSize = 0;
            this.btnManageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProduct.Location = new System.Drawing.Point(494, 329);
            this.btnManageProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(141, 141);
            this.btnManageProduct.TabIndex = 116;
            this.btnManageProduct.UseVisualStyleBackColor = false;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // btnManageCompanyEmployee
            // 
            this.btnManageCompanyEmployee.AutoSize = true;
            this.btnManageCompanyEmployee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageCompanyEmployee.BackgroundImage = global::GUI.Properties.Resources.IconQuanLyNhanSu;
            this.btnManageCompanyEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageCompanyEmployee.FlatAppearance.BorderSize = 0;
            this.btnManageCompanyEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCompanyEmployee.Location = new System.Drawing.Point(239, 326);
            this.btnManageCompanyEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageCompanyEmployee.Name = "btnManageCompanyEmployee";
            this.btnManageCompanyEmployee.Size = new System.Drawing.Size(141, 141);
            this.btnManageCompanyEmployee.TabIndex = 114;
            this.btnManageCompanyEmployee.UseVisualStyleBackColor = false;
            this.btnManageCompanyEmployee.Click += new System.EventHandler(this.btnManageCompanyEmployee_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.AutoSize = true;
            this.btnStatistic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatistic.BackgroundImage = global::GUI.Properties.Resources.IconThongKeDoanhThu;
            this.btnStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Location = new System.Drawing.Point(374, 166);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(141, 141);
            this.btnStatistic.TabIndex = 113;
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnManageEquipment
            // 
            this.btnManageEquipment.AutoSize = true;
            this.btnManageEquipment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageEquipment.BackgroundImage = global::GUI.Properties.Resources.IconQuanLyThietBi;
            this.btnManageEquipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageEquipment.FlatAppearance.BorderSize = 0;
            this.btnManageEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEquipment.Location = new System.Drawing.Point(142, 163);
            this.btnManageEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageEquipment.Name = "btnManageEquipment";
            this.btnManageEquipment.Size = new System.Drawing.Size(141, 141);
            this.btnManageEquipment.TabIndex = 112;
            this.btnManageEquipment.UseVisualStyleBackColor = false;
            this.btnManageEquipment.Click += new System.EventHandler(this.btnManageEquipment_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.AutoSize = true;
            this.btnManageCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageCustomer.BackgroundImage = global::GUI.Properties.Resources.IconQuanLyKhachHang;
            this.btnManageCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageCustomer.FlatAppearance.BorderSize = 0;
            this.btnManageCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCustomer.Location = new System.Drawing.Point(603, 166);
            this.btnManageCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(141, 141);
            this.btnManageCustomer.TabIndex = 111;
            this.btnManageCustomer.UseVisualStyleBackColor = false;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.btnRestoreDB);
            this.Controls.Add(this.btnBackupDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnManageProduct);
            this.Controls.Add(this.btnManageCompanyEmployee);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnManageEquipment);
            this.Controls.Add(this.btnManageCustomer);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Button btnManageEquipment;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnManageCompanyEmployee;
        private System.Windows.Forms.Button btnManageProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackupDB;
        private System.Windows.Forms.Button btnRestoreDB;
    }
}