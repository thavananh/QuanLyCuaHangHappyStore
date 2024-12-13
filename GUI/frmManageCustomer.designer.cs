
namespace GUI
{
    partial class frmManageCustomer
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.btnMemberRegistration = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.label1.TabIndex = 122;
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
            this.btnBack.Location = new System.Drawing.Point(799, 563);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.AutoSize = true;
            this.btnCustomerList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerList.BackgroundImage = global::GUI.Properties.Resources.IconDSKH;
            this.btnCustomerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerList.FlatAppearance.BorderSize = 0;
            this.btnCustomerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerList.Location = new System.Drawing.Point(295, 271);
            this.btnCustomerList.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(284, 59);
            this.btnCustomerList.TabIndex = 13;
            this.btnCustomerList.UseVisualStyleBackColor = false;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnMemberRegistration
            // 
            this.btnMemberRegistration.AutoSize = true;
            this.btnMemberRegistration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMemberRegistration.BackgroundImage = global::GUI.Properties.Resources.iconDKTV;
            this.btnMemberRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMemberRegistration.FlatAppearance.BorderSize = 0;
            this.btnMemberRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberRegistration.Location = new System.Drawing.Point(295, 355);
            this.btnMemberRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemberRegistration.Name = "btnMemberRegistration";
            this.btnMemberRegistration.Size = new System.Drawing.Size(284, 58);
            this.btnMemberRegistration.TabIndex = 13;
            this.btnMemberRegistration.UseVisualStyleBackColor = false;
            this.btnMemberRegistration.Click += new System.EventHandler(this.btnMemberRegistrationForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.btnMemberRegistration);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fQuanLiKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMemberRegistration;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}