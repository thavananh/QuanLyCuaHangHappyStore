
namespace GUI
{
    partial class frmSellProducct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellProducct));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ptbSP1 = new System.Windows.Forms.PictureBox();
            this.dtgDSSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbSP2 = new System.Windows.Forms.PictureBox();
            this.ptbSP3 = new System.Windows.Forms.PictureBox();
            this.lbTenSP1 = new System.Windows.Forms.Label();
            this.lbTenSP2 = new System.Windows.Forms.Label();
            this.lbtenSP3 = new System.Windows.Forms.Label();
            this.lbGiaThanhSP1 = new System.Windows.Forms.Label();
            this.lbGiaThanhSP2 = new System.Windows.Forms.Label();
            this.lbGiaThanhSP3 = new System.Windows.Forms.Label();
            this.lbSLSP1 = new System.Windows.Forms.Label();
            this.lbSLSP2 = new System.Windows.Forms.Label();
            this.lbSLSP3 = new System.Windows.Forms.Label();
            this.btnCongSP1 = new System.Windows.Forms.Button();
            this.btnTruSP1 = new System.Windows.Forms.Button();
            this.btnCongSP2 = new System.Windows.Forms.Button();
            this.btnTruSP2 = new System.Windows.Forms.Button();
            this.btnTruSP3 = new System.Windows.Forms.Button();
            this.btnCongSP3 = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXuatBienLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSP3)).BeginInit();
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
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Items.AddRange(new object[] {
            "Thực phẩm",
            "Dụng cụ hỗ trợ"});
            this.cmbLoaiSP.Location = new System.Drawing.Point(80, 84);
            this.cmbLoaiSP.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(115, 21);
            this.cmbLoaiSP.TabIndex = 150;
            this.cmbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiSP_SelectedIndexChanged);
            this.cmbLoaiSP.SelectedValueChanged += new System.EventHandler(this.cmbLoaiSP_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(37, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 149;
            this.label4.Text = "Loại";
            // 
            // ptbSP1
            // 
            this.ptbSP1.Image = ((System.Drawing.Image)(resources.GetObject("ptbSP1.Image")));
            this.ptbSP1.Location = new System.Drawing.Point(10, 162);
            this.ptbSP1.Margin = new System.Windows.Forms.Padding(2);
            this.ptbSP1.Name = "ptbSP1";
            this.ptbSP1.Size = new System.Drawing.Size(118, 111);
            this.ptbSP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSP1.TabIndex = 153;
            this.ptbSP1.TabStop = false;
            // 
            // dtgDSSP
            // 
            this.dtgDSSP.AllowUserToAddRows = false;
            this.dtgDSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dtgDSSP.GridColor = System.Drawing.Color.Black;
            this.dtgDSSP.Location = new System.Drawing.Point(462, 128);
            this.dtgDSSP.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDSSP.Name = "dtgDSSP";
            this.dtgDSSP.RowHeadersVisible = false;
            this.dtgDSSP.RowHeadersWidth = 51;
            this.dtgDSSP.RowTemplate.Height = 24;
            this.dtgDSSP.Size = new System.Drawing.Size(413, 299);
            this.dtgDSSP.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(308, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 155;
            this.label1.Text = "Giỏ Hàng";
            // 
            // ptbSP2
            // 
            this.ptbSP2.Image = ((System.Drawing.Image)(resources.GetObject("ptbSP2.Image")));
            this.ptbSP2.Location = new System.Drawing.Point(158, 162);
            this.ptbSP2.Margin = new System.Windows.Forms.Padding(2);
            this.ptbSP2.Name = "ptbSP2";
            this.ptbSP2.Size = new System.Drawing.Size(124, 111);
            this.ptbSP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSP2.TabIndex = 156;
            this.ptbSP2.TabStop = false;
            // 
            // ptbSP3
            // 
            this.ptbSP3.Image = ((System.Drawing.Image)(resources.GetObject("ptbSP3.Image")));
            this.ptbSP3.Location = new System.Drawing.Point(321, 162);
            this.ptbSP3.Margin = new System.Windows.Forms.Padding(2);
            this.ptbSP3.Name = "ptbSP3";
            this.ptbSP3.Size = new System.Drawing.Size(124, 111);
            this.ptbSP3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSP3.TabIndex = 157;
            this.ptbSP3.TabStop = false;
            // 
            // lbTenSP1
            // 
            this.lbTenSP1.AutoEllipsis = true;
            this.lbTenSP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP1.ForeColor = System.Drawing.Color.Teal;
            this.lbTenSP1.Location = new System.Drawing.Point(9, 286);
            this.lbTenSP1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenSP1.Name = "lbTenSP1";
            this.lbTenSP1.Size = new System.Drawing.Size(118, 17);
            this.lbTenSP1.TabIndex = 158;
            this.lbTenSP1.Text = "Loại";
            // 
            // lbTenSP2
            // 
            this.lbTenSP2.AutoEllipsis = true;
            this.lbTenSP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP2.ForeColor = System.Drawing.Color.Teal;
            this.lbTenSP2.Location = new System.Drawing.Point(158, 287);
            this.lbTenSP2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenSP2.Name = "lbTenSP2";
            this.lbTenSP2.Size = new System.Drawing.Size(124, 17);
            this.lbTenSP2.TabIndex = 159;
            this.lbTenSP2.Text = "Loại";
            // 
            // lbtenSP3
            // 
            this.lbtenSP3.AutoEllipsis = true;
            this.lbtenSP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenSP3.ForeColor = System.Drawing.Color.Teal;
            this.lbtenSP3.Location = new System.Drawing.Point(321, 288);
            this.lbtenSP3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtenSP3.Name = "lbtenSP3";
            this.lbtenSP3.Size = new System.Drawing.Size(124, 17);
            this.lbtenSP3.TabIndex = 160;
            this.lbtenSP3.Text = "Loại";
            // 
            // lbGiaThanhSP1
            // 
            this.lbGiaThanhSP1.AutoEllipsis = true;
            this.lbGiaThanhSP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaThanhSP1.ForeColor = System.Drawing.Color.Teal;
            this.lbGiaThanhSP1.Location = new System.Drawing.Point(10, 314);
            this.lbGiaThanhSP1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaThanhSP1.Name = "lbGiaThanhSP1";
            this.lbGiaThanhSP1.Size = new System.Drawing.Size(118, 17);
            this.lbGiaThanhSP1.TabIndex = 161;
            this.lbGiaThanhSP1.Text = "Loại";
            // 
            // lbGiaThanhSP2
            // 
            this.lbGiaThanhSP2.AutoEllipsis = true;
            this.lbGiaThanhSP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaThanhSP2.ForeColor = System.Drawing.Color.Teal;
            this.lbGiaThanhSP2.Location = new System.Drawing.Point(159, 316);
            this.lbGiaThanhSP2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaThanhSP2.Name = "lbGiaThanhSP2";
            this.lbGiaThanhSP2.Size = new System.Drawing.Size(123, 17);
            this.lbGiaThanhSP2.TabIndex = 162;
            this.lbGiaThanhSP2.Text = "Loại";
            // 
            // lbGiaThanhSP3
            // 
            this.lbGiaThanhSP3.AutoEllipsis = true;
            this.lbGiaThanhSP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaThanhSP3.ForeColor = System.Drawing.Color.Teal;
            this.lbGiaThanhSP3.Location = new System.Drawing.Point(322, 316);
            this.lbGiaThanhSP3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaThanhSP3.Name = "lbGiaThanhSP3";
            this.lbGiaThanhSP3.Size = new System.Drawing.Size(123, 17);
            this.lbGiaThanhSP3.TabIndex = 163;
            this.lbGiaThanhSP3.Text = "Loại";
            // 
            // lbSLSP1
            // 
            this.lbSLSP1.AutoEllipsis = true;
            this.lbSLSP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLSP1.ForeColor = System.Drawing.Color.Teal;
            this.lbSLSP1.Location = new System.Drawing.Point(10, 344);
            this.lbSLSP1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSLSP1.Name = "lbSLSP1";
            this.lbSLSP1.Size = new System.Drawing.Size(118, 17);
            this.lbSLSP1.TabIndex = 164;
            this.lbSLSP1.Text = "Loại";
            // 
            // lbSLSP2
            // 
            this.lbSLSP2.AutoEllipsis = true;
            this.lbSLSP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLSP2.ForeColor = System.Drawing.Color.Teal;
            this.lbSLSP2.Location = new System.Drawing.Point(159, 344);
            this.lbSLSP2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSLSP2.Name = "lbSLSP2";
            this.lbSLSP2.Size = new System.Drawing.Size(123, 17);
            this.lbSLSP2.TabIndex = 165;
            this.lbSLSP2.Text = "Loại";
            // 
            // lbSLSP3
            // 
            this.lbSLSP3.AutoEllipsis = true;
            this.lbSLSP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLSP3.ForeColor = System.Drawing.Color.Teal;
            this.lbSLSP3.Location = new System.Drawing.Point(322, 344);
            this.lbSLSP3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSLSP3.Name = "lbSLSP3";
            this.lbSLSP3.Size = new System.Drawing.Size(123, 17);
            this.lbSLSP3.TabIndex = 166;
            this.lbSLSP3.Text = "Loại";
            // 
            // btnCongSP1
            // 
            this.btnCongSP1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCongSP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCongSP1.BackgroundImage")));
            this.btnCongSP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCongSP1.FlatAppearance.BorderSize = 0;
            this.btnCongSP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongSP1.Location = new System.Drawing.Point(76, 375);
            this.btnCongSP1.Margin = new System.Windows.Forms.Padding(2);
            this.btnCongSP1.Name = "btnCongSP1";
            this.btnCongSP1.Size = new System.Drawing.Size(44, 34);
            this.btnCongSP1.TabIndex = 167;
            this.btnCongSP1.UseVisualStyleBackColor = false;
            this.btnCongSP1.Click += new System.EventHandler(this.btnCongSP1_Click);
            // 
            // btnTruSP1
            // 
            this.btnTruSP1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTruSP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTruSP1.BackgroundImage")));
            this.btnTruSP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTruSP1.FlatAppearance.BorderSize = 0;
            this.btnTruSP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruSP1.Location = new System.Drawing.Point(29, 375);
            this.btnTruSP1.Margin = new System.Windows.Forms.Padding(2);
            this.btnTruSP1.Name = "btnTruSP1";
            this.btnTruSP1.Size = new System.Drawing.Size(43, 34);
            this.btnTruSP1.TabIndex = 168;
            this.btnTruSP1.UseVisualStyleBackColor = false;
            this.btnTruSP1.Click += new System.EventHandler(this.btnTruSP1_Click);
            // 
            // btnCongSP2
            // 
            this.btnCongSP2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCongSP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCongSP2.BackgroundImage")));
            this.btnCongSP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCongSP2.FlatAppearance.BorderSize = 0;
            this.btnCongSP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongSP2.Location = new System.Drawing.Point(223, 375);
            this.btnCongSP2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCongSP2.Name = "btnCongSP2";
            this.btnCongSP2.Size = new System.Drawing.Size(44, 34);
            this.btnCongSP2.TabIndex = 169;
            this.btnCongSP2.UseVisualStyleBackColor = false;
            this.btnCongSP2.Click += new System.EventHandler(this.btnCongSP2_Click);
            // 
            // btnTruSP2
            // 
            this.btnTruSP2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTruSP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTruSP2.BackgroundImage")));
            this.btnTruSP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTruSP2.FlatAppearance.BorderSize = 0;
            this.btnTruSP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruSP2.Location = new System.Drawing.Point(176, 375);
            this.btnTruSP2.Margin = new System.Windows.Forms.Padding(2);
            this.btnTruSP2.Name = "btnTruSP2";
            this.btnTruSP2.Size = new System.Drawing.Size(43, 34);
            this.btnTruSP2.TabIndex = 170;
            this.btnTruSP2.UseVisualStyleBackColor = false;
            this.btnTruSP2.Click += new System.EventHandler(this.btnTruSP2_Click);
            // 
            // btnTruSP3
            // 
            this.btnTruSP3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTruSP3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTruSP3.BackgroundImage")));
            this.btnTruSP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTruSP3.FlatAppearance.BorderSize = 0;
            this.btnTruSP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruSP3.Location = new System.Drawing.Point(338, 373);
            this.btnTruSP3.Margin = new System.Windows.Forms.Padding(2);
            this.btnTruSP3.Name = "btnTruSP3";
            this.btnTruSP3.Size = new System.Drawing.Size(43, 34);
            this.btnTruSP3.TabIndex = 171;
            this.btnTruSP3.UseVisualStyleBackColor = false;
            this.btnTruSP3.Click += new System.EventHandler(this.btnTruSP3_Click);
            // 
            // btnCongSP3
            // 
            this.btnCongSP3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCongSP3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCongSP3.BackgroundImage")));
            this.btnCongSP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCongSP3.FlatAppearance.BorderSize = 0;
            this.btnCongSP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongSP3.Location = new System.Drawing.Point(380, 373);
            this.btnCongSP3.Margin = new System.Windows.Forms.Padding(2);
            this.btnCongSP3.Name = "btnCongSP3";
            this.btnCongSP3.Size = new System.Drawing.Size(50, 34);
            this.btnCongSP3.TabIndex = 172;
            this.btnCongSP3.UseVisualStyleBackColor = false;
            this.btnCongSP3.Click += new System.EventHandler(this.btnCongSP3_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrai.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnTrai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrai.FlatAppearance.BorderSize = 0;
            this.btnTrai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrai.Location = new System.Drawing.Point(94, 416);
            this.btnTrai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(44, 34);
            this.btnTrai.TabIndex = 173;
            this.btnTrai.UseVisualStyleBackColor = false;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnPhai
            // 
            this.btnPhai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhai.BackgroundImage")));
            this.btnPhai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhai.FlatAppearance.BorderSize = 0;
            this.btnPhai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhai.Location = new System.Drawing.Point(320, 416);
            this.btnPhai.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(44, 34);
            this.btnPhai.TabIndex = 174;
            this.btnPhai.UseVisualStyleBackColor = false;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(799, 498);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 175;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(743, 88);
            this.cmbMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(128, 21);
            this.cmbMaKH.TabIndex = 177;
            this.cmbMaKH.SelectedValueChanged += new System.EventHandler(this.cmbMaKH_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(679, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 178;
            this.label2.Text = "Mã KH";
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.BackgroundImage = global::GUI.Properties.Resources.luu;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(458, 431);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 45);
            this.btnLuu.TabIndex = 179;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 16);
            this.label3.TabIndex = 180;
            this.label3.Text = "Developed by Software Sustain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 181;
            this.label5.Text = "Tổng số tiền:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTongTien.Location = new System.Drawing.Point(569, 482);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(108, 18);
            this.lblTongTien.TabIndex = 182;
            this.lblTongTien.Text = "000.000.000đ";
            // 
            // btnXuatBienLai
            // 
            this.btnXuatBienLai.AutoSize = true;
            this.btnXuatBienLai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXuatBienLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatBienLai.BackgroundImage")));
            this.btnXuatBienLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuatBienLai.FlatAppearance.BorderSize = 0;
            this.btnXuatBienLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatBienLai.Location = new System.Drawing.Point(570, 429);
            this.btnXuatBienLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatBienLai.Name = "btnXuatBienLai";
            this.btnXuatBienLai.Size = new System.Drawing.Size(128, 49);
            this.btnXuatBienLai.TabIndex = 183;
            this.btnXuatBienLai.UseVisualStyleBackColor = false;
            this.btnXuatBienLai.Click += new System.EventHandler(this.btnXuatBienLai_Click);
            // 
            // frmSellProducct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(886, 545);
            this.Controls.Add(this.btnXuatBienLai);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMaKH);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnCongSP3);
            this.Controls.Add(this.btnTruSP3);
            this.Controls.Add(this.btnTruSP2);
            this.Controls.Add(this.btnCongSP2);
            this.Controls.Add(this.btnTruSP1);
            this.Controls.Add(this.btnCongSP1);
            this.Controls.Add(this.lbSLSP3);
            this.Controls.Add(this.lbSLSP2);
            this.Controls.Add(this.lbSLSP1);
            this.Controls.Add(this.lbGiaThanhSP3);
            this.Controls.Add(this.lbGiaThanhSP2);
            this.Controls.Add(this.lbGiaThanhSP1);
            this.Controls.Add(this.lbtenSP3);
            this.Controls.Add(this.lbTenSP2);
            this.Controls.Add(this.lbTenSP1);
            this.Controls.Add(this.ptbSP3);
            this.Controls.Add(this.ptbSP2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDSSP);
            this.Controls.Add(this.ptbSP1);
            this.Controls.Add(this.cmbLoaiSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSellProducct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBanSP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSellProducct_FormClosing);
            this.Load += new System.EventHandler(this.fBanSP_Load);
            this.LocationChanged += new System.EventHandler(this.fBanSP_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSP3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptbSP1;
        private System.Windows.Forms.DataGridView dtgDSSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbSP2;
        private System.Windows.Forms.PictureBox ptbSP3;
        private System.Windows.Forms.Label lbTenSP1;
        private System.Windows.Forms.Label lbTenSP2;
        private System.Windows.Forms.Label lbtenSP3;
        private System.Windows.Forms.Label lbGiaThanhSP1;
        private System.Windows.Forms.Label lbGiaThanhSP2;
        private System.Windows.Forms.Label lbGiaThanhSP3;
        private System.Windows.Forms.Label lbSLSP1;
        private System.Windows.Forms.Label lbSLSP2;
        private System.Windows.Forms.Label lbSLSP3;
        private System.Windows.Forms.Button btnCongSP1;
        private System.Windows.Forms.Button btnTruSP1;
        private System.Windows.Forms.Button btnCongSP2;
        private System.Windows.Forms.Button btnTruSP2;
        private System.Windows.Forms.Button btnTruSP3;
        private System.Windows.Forms.Button btnCongSP3;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnXuatBienLai;
    }
}