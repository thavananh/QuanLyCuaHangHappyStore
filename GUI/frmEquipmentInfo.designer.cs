
namespace GUI
{
    partial class frmEquipmentInfo
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
            this.tbEquipmentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEquipmentType = new System.Windows.Forms.ComboBox();
            this.cbEquipmentCondition = new System.Windows.Forms.ComboBox();
            this.tbEquipmentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.btnCameraCapture = new System.Windows.Forms.Button();
            this.btnExportQR = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ptbTB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(349, 313);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 118;
            this.label1.Text = "Tình trạng";
            // 
            // tbEquipmentId
            // 
            this.tbEquipmentId.Location = new System.Drawing.Point(438, 201);
            this.tbEquipmentId.Margin = new System.Windows.Forms.Padding(2);
            this.tbEquipmentId.Name = "tbEquipmentId";
            this.tbEquipmentId.Size = new System.Drawing.Size(287, 20);
            this.tbEquipmentId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(342, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 115;
            this.label3.Text = "Tên thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(349, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 114;
            this.label2.Text = "Mã thiết bị";
            // 
            // cbEquipmentType
            // 
            this.cbEquipmentType.FormattingEnabled = true;
            this.cbEquipmentType.Location = new System.Drawing.Point(438, 271);
            this.cbEquipmentType.Margin = new System.Windows.Forms.Padding(2);
            this.cbEquipmentType.Name = "cbEquipmentType";
            this.cbEquipmentType.Size = new System.Drawing.Size(141, 21);
            this.cbEquipmentType.TabIndex = 2;
            this.cbEquipmentType.SelectedValueChanged += new System.EventHandler(this.cmbloaithietbi_SelectedValueChanged);
            // 
            // cbEquipmentCondition
            // 
            this.cbEquipmentCondition.FormattingEnabled = true;
            this.cbEquipmentCondition.Items.AddRange(new object[] {
            "TOT",
            "BAOTRI"});
            this.cbEquipmentCondition.Location = new System.Drawing.Point(439, 313);
            this.cbEquipmentCondition.Margin = new System.Windows.Forms.Padding(2);
            this.cbEquipmentCondition.Name = "cbEquipmentCondition";
            this.cbEquipmentCondition.Size = new System.Drawing.Size(141, 21);
            this.cbEquipmentCondition.TabIndex = 3;
            this.cbEquipmentCondition.SelectedValueChanged += new System.EventHandler(this.cmbTinhTrang_SelectedValueChanged);
            // 
            // tbEquipmentName
            // 
            this.tbEquipmentName.Location = new System.Drawing.Point(438, 237);
            this.tbEquipmentName.Margin = new System.Windows.Forms.Padding(2);
            this.tbEquipmentName.Name = "tbEquipmentName";
            this.tbEquipmentName.Size = new System.Drawing.Size(287, 20);
            this.tbEquipmentName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(339, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 125;
            this.label4.Text = "Loại thiết bị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 16);
            this.label5.TabIndex = 128;
            this.label5.Text = "Developed by HappyStore Dev";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label6.Location = new System.Drawing.Point(290, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 31);
            this.label6.TabIndex = 129;
            this.label6.Text = "Thông tin thiết bị";
            // 
            // cbCamera
            // 
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(99, 367);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(121, 21);
            this.cbCamera.TabIndex = 131;
            // 
            // btnCameraCapture
            // 
            this.btnCameraCapture.Location = new System.Drawing.Point(226, 367);
            this.btnCameraCapture.Name = "btnCameraCapture";
            this.btnCameraCapture.Size = new System.Drawing.Size(94, 23);
            this.btnCameraCapture.TabIndex = 130;
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
            this.btnExportQR.Location = new System.Drawing.Point(476, 363);
            this.btnExportQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportQR.Name = "btnExportQR";
            this.btnExportQR.Size = new System.Drawing.Size(115, 49);
            this.btnExportQR.TabIndex = 155;
            this.btnExportQR.UseVisualStyleBackColor = false;
            this.btnExportQR.Click += new System.EventHandler(this.btnExportQR_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.AutoSize = true;
            this.btnChinhSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChinhSua.BackgroundImage = global::GUI.Properties.Resources.Chinhsua;
            this.btnChinhSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Location = new System.Drawing.Point(595, 363);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(130, 49);
            this.btnChinhSua.TabIndex = 4;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(799, 407);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ptbTB
            // 
            this.ptbTB.Image = global::GUI.Properties.Resources.machine;
            this.ptbTB.Location = new System.Drawing.Point(99, 183);
            this.ptbTB.Margin = new System.Windows.Forms.Padding(2);
            this.ptbTB.Name = "ptbTB";
            this.ptbTB.Size = new System.Drawing.Size(221, 179);
            this.ptbTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTB.TabIndex = 46;
            this.ptbTB.TabStop = false;
            this.ptbTB.Click += new System.EventHandler(this.ptbTB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // frmEquipmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 456);
            this.Controls.Add(this.btnExportQR);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.btnCameraCapture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEquipmentName);
            this.Controls.Add(this.cbEquipmentCondition);
            this.Controls.Add(this.cbEquipmentType);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEquipmentId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbTB);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEquipmentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEquipmentInfo_FormClosing);
            this.Load += new System.EventHandler(this.fThongtinTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEquipmentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.ComboBox cbEquipmentType;
        private System.Windows.Forms.ComboBox cbEquipmentCondition;
        private System.Windows.Forms.TextBox tbEquipmentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Button btnCameraCapture;
        private System.Windows.Forms.Button btnExportQR;
    }
}