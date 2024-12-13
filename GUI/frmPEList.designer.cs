
namespace GUI
{
    partial class frmPEList
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
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.contextMenuStripPEList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotalEquipment = new System.Windows.Forms.TextBox();
            this.tbMaintenanceEquipment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEquipmentType = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnMaintenanceEquipmenetList = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCheckQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.contextMenuStripPEList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.AllowUserToAddRows = false;
            this.dgvEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.ContextMenuStrip = this.contextMenuStripPEList;
            this.dgvEquipment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvEquipment.GridColor = System.Drawing.Color.Black;
            this.dgvEquipment.Location = new System.Drawing.Point(356, 156);
            this.dgvEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.RowHeadersVisible = false;
            this.dgvEquipment.RowHeadersWidth = 51;
            this.dgvEquipment.RowTemplate.Height = 24;
            this.dgvEquipment.Size = new System.Drawing.Size(519, 328);
            this.dgvEquipment.TabIndex = 36;
            this.dgvEquipment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipment_CellDoubleClick);
            // 
            // contextMenuStripPEList
            // 
            this.contextMenuStripPEList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifiedToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStripPEList.Name = "contextMenuStripDSDCTD";
            this.contextMenuStripPEList.Size = new System.Drawing.Size(95, 48);
            // 
            // modifiedToolStripMenuItem
            // 
            this.modifiedToolStripMenuItem.Name = "modifiedToolStripMenuItem";
            this.modifiedToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.modifiedToolStripMenuItem.Text = "Sửa";
            this.modifiedToolStripMenuItem.Click += new System.EventHandler(this.modifiedToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.removeToolStripMenuItem.Text = "Xóa";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(41, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tổng số TB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(41, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "TB bảo trì:";
            // 
            // tbTotalEquipment
            // 
            this.tbTotalEquipment.Location = new System.Drawing.Point(140, 209);
            this.tbTotalEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalEquipment.Name = "tbTotalEquipment";
            this.tbTotalEquipment.Size = new System.Drawing.Size(117, 20);
            this.tbTotalEquipment.TabIndex = 0;
            // 
            // tbMaintenanceEquipment
            // 
            this.tbMaintenanceEquipment.Location = new System.Drawing.Point(140, 261);
            this.tbMaintenanceEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaintenanceEquipment.Name = "tbMaintenanceEquipment";
            this.tbMaintenanceEquipment.Size = new System.Drawing.Size(117, 20);
            this.tbMaintenanceEquipment.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(275, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "cái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(275, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "cái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(603, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 127;
            this.label5.Text = "Loại thiết bị";
            // 
            // cmbEquipmentType
            // 
            this.cmbEquipmentType.FormattingEnabled = true;
            this.cmbEquipmentType.Items.AddRange(new object[] {
            "Máy Tính Tiền",
            "Máy Pha Cà Phê",
            "Tủ Lạnh",
            "Kệ A",
            "Kệ B",
            "Bàn Dãy A Lầu 1"});
            this.cmbEquipmentType.Location = new System.Drawing.Point(699, 131);
            this.cmbEquipmentType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEquipmentType.Name = "cmbEquipmentType";
            this.cmbEquipmentType.Size = new System.Drawing.Size(126, 21);
            this.cmbEquipmentType.TabIndex = 5;
            this.cmbEquipmentType.SelectedIndexChanged += new System.EventHandler(this.cmbEquipmentType_SelectedIndexChanged);
            this.cmbEquipmentType.SelectedValueChanged += new System.EventHandler(this.cbEquipmentType_SelectedValueChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AutoSize = true;
            this.btnExportExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportExcel.BackgroundImage = global::GUI.Properties.Resources.Xuat;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Location = new System.Drawing.Point(202, 393);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(112, 49);
            this.btnExportExcel.TabIndex = 4;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnMaintenanceEquipmenetList
            // 
            this.btnMaintenanceEquipmenetList.AutoSize = true;
            this.btnMaintenanceEquipmenetList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaintenanceEquipmenetList.BackgroundImage = global::GUI.Properties.Resources.DSTBBT;
            this.btnMaintenanceEquipmenetList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaintenanceEquipmenetList.FlatAppearance.BorderSize = 0;
            this.btnMaintenanceEquipmenetList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceEquipmenetList.Location = new System.Drawing.Point(30, 315);
            this.btnMaintenanceEquipmenetList.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaintenanceEquipmenetList.Name = "btnMaintenanceEquipmenetList";
            this.btnMaintenanceEquipmenetList.Size = new System.Drawing.Size(303, 49);
            this.btnMaintenanceEquipmenetList.TabIndex = 2;
            this.btnMaintenanceEquipmenetList.UseVisualStyleBackColor = false;
            this.btnMaintenanceEquipmenetList.Click += new System.EventHandler(this.btnMaintenanceEquipmentList_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::GUI.Properties.Resources.f5;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(839, 130);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 24);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.AutoSize = true;
            this.btnAddEquipment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddEquipment.BackgroundImage = global::GUI.Properties.Resources.ThemTB;
            this.btnAddEquipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEquipment.FlatAppearance.BorderSize = 0;
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipment.Location = new System.Drawing.Point(44, 393);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(126, 49);
            this.btnAddEquipment.TabIndex = 3;
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(808, 547);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 38);
            this.btnBack.TabIndex = 33;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 128;
            this.label6.Text = "Developed by HappyStore Dev";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label7.Location = new System.Drawing.Point(89, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 24);
            this.label7.TabIndex = 129;
            this.label7.Text = "Danh Sách Thiết Bị";
            // 
            // btnCheckQR
            // 
            this.btnCheckQR.AutoSize = true;
            this.btnCheckQR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckQR.BackgroundImage = global::GUI.Properties.Resources.checkKH;
            this.btnCheckQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckQR.FlatAppearance.BorderSize = 0;
            this.btnCheckQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckQR.Location = new System.Drawing.Point(351, 488);
            this.btnCheckQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckQR.Name = "btnCheckQR";
            this.btnCheckQR.Size = new System.Drawing.Size(117, 49);
            this.btnCheckQR.TabIndex = 130;
            this.btnCheckQR.UseVisualStyleBackColor = false;
            this.btnCheckQR.Click += new System.EventHandler(this.btnCheckQR_Click);
            // 
            // frmPEList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 593);
            this.Controls.Add(this.btnCheckQR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEquipmentType);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnMaintenanceEquipmenetList);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaintenanceEquipment);
            this.Controls.Add(this.tbTotalEquipment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEquipment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPEList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pe List";
            this.Load += new System.EventHandler(this.frmPeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.contextMenuStripPEList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotalEquipment;
        private System.Windows.Forms.TextBox tbMaintenanceEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMaintenanceEquipmenetList;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEquipmentType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPEList;
        private System.Windows.Forms.ToolStripMenuItem modifiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Button btnCheckQR;
    }
}