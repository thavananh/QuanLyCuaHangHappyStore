
namespace GUI
{
    partial class frmEquipmentTypeList
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEquipmentType = new System.Windows.Forms.Label();
            this.lblEquipmentCount = new System.Windows.Forms.Label();
            this.dgvEquipmentTypeList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbmaintenanceEquipment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(11, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 115;
            this.label2.Text = "Loại Thiết Bị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(11, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 116;
            this.label1.Text = "Số lượng Thiết Bị:";
            // 
            // lblEquipmentType
            // 
            this.lblEquipmentType.AutoSize = true;
            this.lblEquipmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEquipmentType.Location = new System.Drawing.Point(114, 256);
            this.lblEquipmentType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipmentType.Name = "lblEquipmentType";
            this.lblEquipmentType.Size = new System.Drawing.Size(17, 18);
            this.lblEquipmentType.TabIndex = 117;
            this.lblEquipmentType.Text = "0";
            // 
            // lblEquipmentCount
            // 
            this.lblEquipmentCount.AutoSize = true;
            this.lblEquipmentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEquipmentCount.Location = new System.Drawing.Point(155, 303);
            this.lblEquipmentCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipmentCount.Name = "lblEquipmentCount";
            this.lblEquipmentCount.Size = new System.Drawing.Size(17, 18);
            this.lblEquipmentCount.TabIndex = 118;
            this.lblEquipmentCount.Text = "0";
            // 
            // dgvEquipmentTypeList
            // 
            this.dgvEquipmentTypeList.AllowUserToAddRows = false;
            this.dgvEquipmentTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipmentTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipmentTypeList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvEquipmentTypeList.GridColor = System.Drawing.Color.Black;
            this.dgvEquipmentTypeList.Location = new System.Drawing.Point(307, 171);
            this.dgvEquipmentTypeList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipmentTypeList.Name = "dgvEquipmentTypeList";
            this.dgvEquipmentTypeList.RowHeadersVisible = false;
            this.dgvEquipmentTypeList.RowHeadersWidth = 51;
            this.dgvEquipmentTypeList.RowTemplate.Height = 24;
            this.dgvEquipmentTypeList.Size = new System.Drawing.Size(556, 310);
            this.dgvEquipmentTypeList.TabIndex = 122;
            this.dgvEquipmentTypeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipmentTypeList_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(11, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 17);
            this.label3.TabIndex = 123;
            this.label3.Text = "Số lượng Thiết Bị bảo trì:";
            // 
            // lbmaintenanceEquipment
            // 
            this.lbmaintenanceEquipment.AutoSize = true;
            this.lbmaintenanceEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmaintenanceEquipment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbmaintenanceEquipment.Location = new System.Drawing.Point(200, 349);
            this.lbmaintenanceEquipment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmaintenanceEquipment.Name = "lbmaintenanceEquipment";
            this.lbmaintenanceEquipment.Size = new System.Drawing.Size(17, 18);
            this.lbmaintenanceEquipment.TabIndex = 124;
            this.lbmaintenanceEquipment.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label7.Location = new System.Drawing.Point(302, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 29);
            this.label7.TabIndex = 130;
            this.label7.Text = "Thông Tin Thiết Bị";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::GUI.Properties.Resources.f5;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(831, 143);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 24);
            this.btnRefresh.TabIndex = 132;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AutoSize = true;
            this.btnExportExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportExcel.BackgroundImage = global::GUI.Properties.Resources.Xuat;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Location = new System.Drawing.Point(304, 485);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(112, 49);
            this.btnExportExcel.TabIndex = 131;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(799, 516);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 121;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 16);
            this.label5.TabIndex = 133;
            this.label5.Text = "Developed by HappyStore Dev";
            // 
            // frmEquipmentTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 560);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbmaintenanceEquipment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEquipmentTypeList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEquipmentCount);
            this.Controls.Add(this.lblEquipmentType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEquipmentTypeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Equipment Type List";
            this.Load += new System.EventHandler(this.fLoaiThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEquipmentType;
        private System.Windows.Forms.Label lblEquipmentCount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvEquipmentTypeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbmaintenanceEquipment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
    }
}