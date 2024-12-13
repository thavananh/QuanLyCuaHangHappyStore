
namespace GUI
{
    partial class frmAddEquipment
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
            this.tbEquipmentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEquipmentType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEquipmentCondition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCameraCapture = new System.Windows.Forms.Button();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.btnExportQR = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ptbEquipment = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEquipmentName
            // 
            this.tbEquipmentName.Location = new System.Drawing.Point(260, 201);
            this.tbEquipmentName.Margin = new System.Windows.Forms.Padding(2);
            this.tbEquipmentName.Name = "tbEquipmentName";
            this.tbEquipmentName.Size = new System.Drawing.Size(233, 20);
            this.tbEquipmentName.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(162, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(162, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tình trạng";
            // 
            // cbEquipmentType
            // 
            this.cbEquipmentType.FormattingEnabled = true;
            this.cbEquipmentType.Items.AddRange(new object[] {
            "MÁY CARDIO",
            "MÁY TẬP NGỰC",
            "MÁY TẬP VAI",
            "MÁY TẬP TAY",
            "MAY TẬP BỤNG",
            "MÁY TẬP CHÂN",
            "MÁY TẬP LƯNG",
            "MÁY TẬP XÔ",
            "MÁY TẬP TỔNG HỢP",
            "DÀN RACK",
            "TẠ ĐƠN",
            "TẠ ĐÒN"});
            this.cbEquipmentType.Location = new System.Drawing.Point(260, 240);
            this.cbEquipmentType.Margin = new System.Windows.Forms.Padding(2);
            this.cbEquipmentType.Name = "cbEquipmentType";
            this.cbEquipmentType.Size = new System.Drawing.Size(182, 21);
            this.cbEquipmentType.TabIndex = 113;
            this.cbEquipmentType.SelectedValueChanged += new System.EventHandler(this.cmbloaithietbi_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(162, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 114;
            this.label4.Text = "Loại thiết bị";
            // 
            // cbEquipmentCondition
            // 
            this.cbEquipmentCondition.FormattingEnabled = true;
            this.cbEquipmentCondition.Items.AddRange(new object[] {
            "TOT",
            "BAOTRI"});
            this.cbEquipmentCondition.Location = new System.Drawing.Point(260, 281);
            this.cbEquipmentCondition.Margin = new System.Windows.Forms.Padding(2);
            this.cbEquipmentCondition.Name = "cbEquipmentCondition";
            this.cbEquipmentCondition.Size = new System.Drawing.Size(126, 21);
            this.cbEquipmentCondition.TabIndex = 115;
            this.cbEquipmentCondition.SelectedValueChanged += new System.EventHandler(this.cmbTinhTrang_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 123;
            this.label2.Text = "Developed by HappyStore Dev";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label5.Location = new System.Drawing.Point(336, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 31);
            this.label5.TabIndex = 124;
            this.label5.Text = "Thêm thiết bị";
            // 
            // btnCameraCapture
            // 
            this.btnCameraCapture.Location = new System.Drawing.Point(659, 352);
            this.btnCameraCapture.Name = "btnCameraCapture";
            this.btnCameraCapture.Size = new System.Drawing.Size(94, 23);
            this.btnCameraCapture.TabIndex = 125;
            this.btnCameraCapture.Text = "Camera Capture";
            this.btnCameraCapture.UseVisualStyleBackColor = true;
            this.btnCameraCapture.Click += new System.EventHandler(this.btnCameraCapture_Click);
            // 
            // cbCamera
            // 
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(532, 352);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(121, 21);
            this.cbCamera.TabIndex = 126;
            // 
            // btnExportQR
            // 
            this.btnExportQR.AutoSize = true;
            this.btnExportQR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportQR.BackgroundImage = global::GUI.Properties.Resources.Xuat;
            this.btnExportQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportQR.FlatAppearance.BorderSize = 0;
            this.btnExportQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportQR.Location = new System.Drawing.Point(527, 389);
            this.btnExportQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportQR.Name = "btnExportQR";
            this.btnExportQR.Size = new System.Drawing.Size(105, 53);
            this.btnExportQR.TabIndex = 156;
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
            this.btnBack.Location = new System.Drawing.Point(799, 447);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 112;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::GUI.Properties.Resources.luu;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(634, 392);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 48);
            this.btnSave.TabIndex = 111;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ptbEquipment
            // 
            this.ptbEquipment.Image = global::GUI.Properties.Resources.machine;
            this.ptbEquipment.Location = new System.Drawing.Point(532, 168);
            this.ptbEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.ptbEquipment.Name = "ptbEquipment";
            this.ptbEquipment.Size = new System.Drawing.Size(221, 179);
            this.ptbEquipment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEquipment.TabIndex = 42;
            this.ptbEquipment.TabStop = false;
            this.ptbEquipment.Click += new System.EventHandler(this.ptbTB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 489);
            this.Controls.Add(this.btnExportQR);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.btnCameraCapture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEquipmentCondition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEquipmentType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ptbEquipment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEquipmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Equipment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEquipment_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbEquipmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbEquipment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbEquipmentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEquipmentCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCameraCapture;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Button btnExportQR;
    }
}