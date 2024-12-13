
namespace GUI
{
    partial class frmManageCompanyEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageCompanyEmployee));
            this.btnRegisterEmployee = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDSNV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterEmployee
            // 
            this.btnRegisterEmployee.AutoSize = true;
            this.btnRegisterEmployee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegisterEmployee.BackgroundImage")));
            this.btnRegisterEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegisterEmployee.FlatAppearance.BorderSize = 0;
            this.btnRegisterEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterEmployee.Location = new System.Drawing.Point(292, 377);
            this.btnRegisterEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterEmployee.Name = "btnRegisterEmployee";
            this.btnRegisterEmployee.Size = new System.Drawing.Size(302, 58);
            this.btnRegisterEmployee.TabIndex = 23;
            this.btnRegisterEmployee.UseVisualStyleBackColor = false;
            this.btnRegisterEmployee.Click += new System.EventHandler(this.btnRegisterEmployee_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(801, 562);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDSNV
            // 
            this.btnDSNV.AutoSize = true;
            this.btnDSNV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDSNV.BackgroundImage = global::GUI.Properties.Resources.danhsachnhanvien;
            this.btnDSNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDSNV.FlatAppearance.BorderSize = 0;
            this.btnDSNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSNV.Location = new System.Drawing.Point(292, 306);
            this.btnDSNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.Size = new System.Drawing.Size(302, 58);
            this.btnDSNV.TabIndex = 20;
            this.btnDSNV.UseVisualStyleBackColor = false;
            this.btnDSNV.Click += new System.EventHandler(this.btnDSNV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 16);
            this.label5.TabIndex = 129;
            this.label5.Text = "Developed by HappyStore Dev";
            // 
            // frmManageCompanyEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegisterEmployee);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDSNV);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageCompanyEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fQuanlidansucs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDSNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegisterEmployee;
        private System.Windows.Forms.Label label5;
    }
}