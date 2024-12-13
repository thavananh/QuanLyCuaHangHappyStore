
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class frmCustomerList
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDSKH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFindCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterCustomer = new System.Windows.Forms.Button();
            this.btnCheckQR = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.contextMenuStripDSKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.ContextMenuStrip = this.contextMenuStripDSKH;
            this.dgvCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvCustomer.GridColor = System.Drawing.Color.Black;
            this.dgvCustomer.Location = new System.Drawing.Point(30, 172);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(830, 267);
            this.dgvCustomer.TabIndex = 30;
            this.dgvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellDoubleClick);
            // 
            // contextMenuStripDSKH
            // 
            this.contextMenuStripDSKH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifiedToolStripMenuItem,
            this.removeToolStripMenuStrip});
            this.contextMenuStripDSKH.Name = "contextMenuStripDSKH";
            this.contextMenuStripDSKH.Size = new System.Drawing.Size(95, 48);
            // 
            // modifiedToolStripMenuItem
            // 
            this.modifiedToolStripMenuItem.Name = "modifiedToolStripMenuItem";
            this.modifiedToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.modifiedToolStripMenuItem.Text = "Sửa";
            this.modifiedToolStripMenuItem.Click += new System.EventHandler(this.modifiedToolStripMenuItem_Click);
            // 
            // removeToolStripMenuStrip
            // 
            this.removeToolStripMenuStrip.Name = "removeToolStripMenuStrip";
            this.removeToolStripMenuStrip.Size = new System.Drawing.Size(94, 22);
            this.removeToolStripMenuStrip.Text = "Xóa";
            this.removeToolStripMenuStrip.Click += new System.EventHandler(this.removeToolStripMenuStrip_Click);
            // 
            // tbFindCustomer
            // 
            this.tbFindCustomer.Location = new System.Drawing.Point(220, 143);
            this.tbFindCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tbFindCustomer.Name = "tbFindCustomer";
            this.tbFindCustomer.Size = new System.Drawing.Size(134, 20);
            this.tbFindCustomer.TabIndex = 0;
            this.tbFindCustomer.TextChanged += new System.EventHandler(this.tbFindCustomer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(288, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Danh sách khách hàng";
            // 
            // tbFilterDate
            // 
            this.tbFilterDate.Location = new System.Drawing.Point(469, 143);
            this.tbFilterDate.Margin = new System.Windows.Forms.Padding(2);
            this.tbFilterDate.Name = "tbFilterDate";
            this.tbFilterDate.Size = new System.Drawing.Size(138, 20);
            this.tbFilterDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(361, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 118;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(58, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 120;
            this.label1.Text = "Tìm kiếm khách hàng";
            // 
            // btnFilterCustomer
            // 
            this.btnFilterCustomer.Location = new System.Drawing.Point(611, 141);
            this.btnFilterCustomer.Name = "btnFilterCustomer";
            this.btnFilterCustomer.Size = new System.Drawing.Size(97, 23);
            this.btnFilterCustomer.TabIndex = 2;
            this.btnFilterCustomer.Text = "Lọc khách hàng";
            this.btnFilterCustomer.UseVisualStyleBackColor = true;
            this.btnFilterCustomer.Click += new System.EventHandler(this.btnFilterCustomer_Click);
            // 
            // btnCheckQR
            // 
            this.btnCheckQR.AutoSize = true;
            this.btnCheckQR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckQR.BackgroundImage = global::GUI.Properties.Resources.checkKH;
            this.btnCheckQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckQR.FlatAppearance.BorderSize = 0;
            this.btnCheckQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckQR.Location = new System.Drawing.Point(535, 443);
            this.btnCheckQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckQR.Name = "btnCheckQR";
            this.btnCheckQR.Size = new System.Drawing.Size(116, 49);
            this.btnCheckQR.TabIndex = 3;
            this.btnCheckQR.UseVisualStyleBackColor = false;
            this.btnCheckQR.Click += new System.EventHandler(this.btnCheckQR_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::GUI.Properties.Resources.f5;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(30, 141);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 19);
            this.btnRefresh.TabIndex = 31;
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
            this.btnExportExcel.Location = new System.Drawing.Point(672, 443);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(105, 49);
            this.btnExportExcel.TabIndex = 4;
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
            this.btnBack.Location = new System.Drawing.Point(799, 474);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 16);
            this.label5.TabIndex = 129;
            this.label5.Text = "Developed by HappyStore Dev";
            // 
            // frmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 521);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFilterCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilterDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheckQR);
            this.Controls.Add(this.tbFindCustomer);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.frmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.contextMenuStripDSKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbFindCustomer;
        private System.Windows.Forms.Button btnCheckQR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterCustomer;
        private ContextMenuStrip contextMenuStripDSKH;
        private ToolStripMenuItem removeToolStripMenuStrip;
        private ToolStripMenuItem modifiedToolStripMenuItem;
        private Label label5;
    }
}