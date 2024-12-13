namespace GUI
{
    partial class frmRevenueReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevenueReport));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dtgDoanhThu7Ngay = new System.Windows.Forms.DataGridView();
            this.STT_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENTHU_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTONGKETDOANHTHU_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitleRevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDoiBieuDo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRight30Ngay = new System.Windows.Forms.Button();
            this.btnLeft30Ngay = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRevenueDay = new System.Windows.Forms.Label();
            this.lblRevenueMonth = new System.Windows.Forms.Label();
            this.ckbChiPhi = new System.Windows.Forms.CheckBox();
            this.ckbDoanhThu = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoanhThu7Ngay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 134;
            this.label1.Text = "Developed by HappyStore Dev";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1037, 83);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 130;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dtgDoanhThu7Ngay
            // 
            this.dtgDoanhThu7Ngay.AllowUserToAddRows = false;
            this.dtgDoanhThu7Ngay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDoanhThu7Ngay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoanhThu7Ngay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT_1,
            this.TIENTHU_1,
            this.NGAYTONGKETDOANHTHU_1});
            this.dtgDoanhThu7Ngay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dtgDoanhThu7Ngay.Location = new System.Drawing.Point(0, 421);
            this.dtgDoanhThu7Ngay.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDoanhThu7Ngay.Name = "dtgDoanhThu7Ngay";
            this.dtgDoanhThu7Ngay.RowHeadersVisible = false;
            this.dtgDoanhThu7Ngay.RowHeadersWidth = 51;
            this.dtgDoanhThu7Ngay.RowTemplate.Height = 24;
            this.dtgDoanhThu7Ngay.Size = new System.Drawing.Size(679, 254);
            this.dtgDoanhThu7Ngay.TabIndex = 129;
            // 
            // STT_1
            // 
            this.STT_1.HeaderText = "Số thứ tự";
            this.STT_1.Name = "STT_1";
            this.STT_1.ReadOnly = true;
            // 
            // TIENTHU_1
            // 
            this.TIENTHU_1.HeaderText = "Tiền thu";
            this.TIENTHU_1.Name = "TIENTHU_1";
            this.TIENTHU_1.ReadOnly = true;
            // 
            // NGAYTONGKETDOANHTHU_1
            // 
            this.NGAYTONGKETDOANHTHU_1.HeaderText = "Ngày tổng kết doanh thu";
            this.NGAYTONGKETDOANHTHU_1.Name = "NGAYTONGKETDOANHTHU_1";
            this.NGAYTONGKETDOANHTHU_1.ReadOnly = true;
            // 
            // lblTitleRevenue
            // 
            this.lblTitleRevenue.AutoSize = true;
            this.lblTitleRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleRevenue.Location = new System.Drawing.Point(412, 382);
            this.lblTitleRevenue.Name = "lblTitleRevenue";
            this.lblTitleRevenue.Size = new System.Drawing.Size(216, 24);
            this.lblTitleRevenue.TabIndex = 138;
            this.lblTitleRevenue.Text = "Doanh thu trong 30 ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(907, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 178;
            this.label4.Text = "Đổi dạng biểu đồ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1153, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 179;
            this.label5.Text = "Lọc theo ngày";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::GUI.Properties.Resources.add;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(684, 631);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 44);
            this.pictureBox3.TabIndex = 181;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnDoiBieuDo
            // 
            this.btnDoiBieuDo.AutoSize = true;
            this.btnDoiBieuDo.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiBieuDo.BackgroundImage = global::GUI.Properties.Resources.f5;
            this.btnDoiBieuDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoiBieuDo.FlatAppearance.BorderSize = 0;
            this.btnDoiBieuDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiBieuDo.Location = new System.Drawing.Point(874, 116);
            this.btnDoiBieuDo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoiBieuDo.Name = "btnDoiBieuDo";
            this.btnDoiBieuDo.Size = new System.Drawing.Size(28, 24);
            this.btnDoiBieuDo.TabIndex = 177;
            this.btnDoiBieuDo.UseVisualStyleBackColor = false;
            this.btnDoiBieuDo.Click += new System.EventHandler(this.btnDoiBieuDo_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(1180, 672);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 38);
            this.btnBack.TabIndex = 131;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.tileQTV;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // btnRight30Ngay
            // 
            this.btnRight30Ngay.BackColor = System.Drawing.Color.Transparent;
            this.btnRight30Ngay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRight30Ngay.BackgroundImage")));
            this.btnRight30Ngay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight30Ngay.FlatAppearance.BorderSize = 0;
            this.btnRight30Ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight30Ngay.Location = new System.Drawing.Point(996, 379);
            this.btnRight30Ngay.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight30Ngay.Name = "btnRight30Ngay";
            this.btnRight30Ngay.Size = new System.Drawing.Size(44, 34);
            this.btnRight30Ngay.TabIndex = 185;
            this.btnRight30Ngay.UseVisualStyleBackColor = false;
            this.btnRight30Ngay.Click += new System.EventHandler(this.btnRight30Ngay_Click);
            // 
            // btnLeft30Ngay
            // 
            this.btnLeft30Ngay.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft30Ngay.BackgroundImage = global::GUI.Properties.Resources.back;
            this.btnLeft30Ngay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft30Ngay.FlatAppearance.BorderSize = 0;
            this.btnLeft30Ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft30Ngay.Location = new System.Drawing.Point(940, 379);
            this.btnLeft30Ngay.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft30Ngay.Name = "btnLeft30Ngay";
            this.btnLeft30Ngay.Size = new System.Drawing.Size(44, 34);
            this.btnLeft30Ngay.TabIndex = 184;
            this.btnLeft30Ngay.UseVisualStyleBackColor = false;
            this.btnLeft30Ngay.Click += new System.EventHandler(this.btnLeft30Ngay_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(2, 141);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(1033, 233);
            this.chart2.TabIndex = 136;
            this.chart2.Text = "chart2";
            // 
            // lblRevenueDay
            // 
            this.lblRevenueDay.AutoSize = true;
            this.lblRevenueDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueDay.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblRevenueDay.Location = new System.Drawing.Point(691, 488);
            this.lblRevenueDay.Name = "lblRevenueDay";
            this.lblRevenueDay.Size = new System.Drawing.Size(228, 24);
            this.lblRevenueDay.TabIndex = 186;
            this.lblRevenueDay.Text = "Doanh thu của ngày ... là: ";
            // 
            // lblRevenueMonth
            // 
            this.lblRevenueMonth.AutoSize = true;
            this.lblRevenueMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueMonth.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblRevenueMonth.Location = new System.Drawing.Point(691, 548);
            this.lblRevenueMonth.Name = "lblRevenueMonth";
            this.lblRevenueMonth.Size = new System.Drawing.Size(234, 24);
            this.lblRevenueMonth.TabIndex = 187;
            this.lblRevenueMonth.Text = "Doanh thu của tháng ... là: ";
            // 
            // ckbChiPhi
            // 
            this.ckbChiPhi.AutoSize = true;
            this.ckbChiPhi.Location = new System.Drawing.Point(1041, 276);
            this.ckbChiPhi.Name = "ckbChiPhi";
            this.ckbChiPhi.Size = new System.Drawing.Size(60, 17);
            this.ckbChiPhi.TabIndex = 188;
            this.ckbChiPhi.Text = "Chi phí";
            this.ckbChiPhi.UseVisualStyleBackColor = true;
            // 
            // ckbDoanhThu
            // 
            this.ckbDoanhThu.AutoSize = true;
            this.ckbDoanhThu.Location = new System.Drawing.Point(1041, 299);
            this.ckbDoanhThu.Name = "ckbDoanhThu";
            this.ckbDoanhThu.Size = new System.Drawing.Size(76, 17);
            this.ckbDoanhThu.TabIndex = 189;
            this.ckbDoanhThu.Text = "Doanh thu";
            this.ckbDoanhThu.UseVisualStyleBackColor = true;
            // 
            // frmRevenueReport
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 721);
            this.Controls.Add(this.ckbDoanhThu);
            this.Controls.Add(this.ckbChiPhi);
            this.Controls.Add(this.lblRevenueMonth);
            this.Controls.Add(this.lblRevenueDay);
            this.Controls.Add(this.btnRight30Ngay);
            this.Controls.Add(this.btnLeft30Ngay);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDoiBieuDo);
            this.Controls.Add(this.lblTitleRevenue);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dtgDoanhThu7Ngay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRevenueReport";
            this.Load += new System.EventHandler(this.frmRevenueReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoanhThu7Ngay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dtgDoanhThu7Ngay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitleRevenue;
        private System.Windows.Forms.Button btnDoiBieuDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENTHU_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTONGKETDOANHTHU_1;
        private System.Windows.Forms.Button btnRight30Ngay;
        private System.Windows.Forms.Button btnLeft30Ngay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblRevenueDay;
        private System.Windows.Forms.Label lblRevenueMonth;
        private System.Windows.Forms.CheckBox ckbChiPhi;
        private System.Windows.Forms.CheckBox ckbDoanhThu;
    }
}