using BLL;
using DTO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmRevenueReport : Form
    {
        public frmRevenueReport()
        {
            InitializeComponent();
        }
        List<DOANHTHU> listDoanhThu = new List<DOANHTHU>();
        List<CHIPHI> listChiPhi = new List<CHIPHI>();
        DoanhThuBLL doanhThuBLL = new DoanhThuBLL();
        ChiPhiBLL chiPhiBLL = new ChiPhiBLL();
        DateTime[] daysOfWeek1 = new DateTime[7];
        DateTime[] daysOfWeek2 = new DateTime[7];
        DateTime[] daysofMonth = new DateTime[31];
        DateTime[] daysOfMonth2 = new DateTime[31];
        DataTable dataTableDoanhThu7Ngay = new DataTable();
        DateTime hop1 = DateTime.Now;
        DateTime hop2 = DateTime.Now;
        DateTime hop_month = DateTime.Now;
        DateTime dateTimePicker_Value = new DateTime();
        CultureInfo culture = new CultureInfo("vi-VN");
        int stt1 = 1;

        public static string tenChucNang = "thong_ke_doanh_thu";
        private string maTaiKhoan = "";
        private string maLoaiTaiKhoan = "";
        public frmRevenueReport(string inputMaTaiKhoan, string inputMaLoaiTaiKhoan)
        {
            InitializeComponent();
            this.maTaiKhoan = inputMaTaiKhoan;
            this.maLoaiTaiKhoan = inputMaLoaiTaiKhoan;
        }

        private void updateDaysOfMonth_Chart()
        {
            DateTime startDate = hop_month;

            // Tìm ngày đầu tiên của tháng chứa ngày bắt đầu
            DateTime firstDayOfMonth = new DateTime(startDate.Year, startDate.Month, 1);

            // Tìm ngày cuối cùng của tháng chứa ngày bắt đầu
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            // Tạo mảng chứa các ngày trong tháng
            int daysInMonth = DateTime.DaysInMonth(startDate.Year, startDate.Month);
            daysofMonth = new DateTime[daysInMonth];

            // Cập nhật các ngày trong tháng
            for (int i = 0; i < daysInMonth; i++)
            {
                daysofMonth[i] = firstDayOfMonth.AddDays(i);
            }
        }

        private void updateDaysOfMonth_DateTimePicker()
        {
            DateTime startDate = dateTimePicker_Value;

            // Tìm ngày đầu tiên của tháng chứa ngày bắt đầu
            DateTime firstDayOfMonth = new DateTime(startDate.Year, startDate.Month, 1);

            // Tìm ngày cuối cùng của tháng chứa ngày bắt đầu
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            // Tạo mảng chứa các ngày trong tháng
            int daysInMonth = DateTime.DaysInMonth(startDate.Year, startDate.Month);
            daysofMonth = new DateTime[daysInMonth];

            // Cập nhật các ngày trong tháng
            for (int i = 0; i < daysInMonth; i++)
            {
                daysOfMonth2[i] = firstDayOfMonth.AddDays(i);
            }
        }

        private void updateDayOfWeek_DGV()
        {
            DayOfWeek startOfWeek = DayOfWeek.Monday;
            DateTime startOfWeekDate = hop1;

            while (startOfWeekDate.DayOfWeek != startOfWeek)
            {
                startOfWeekDate = startOfWeekDate.AddDays(-1);
            }

            for (int i = 0; i < 7; i++)
            {
                daysOfWeek1[i] = startOfWeekDate.AddDays(i);
            }
        }

        private void loadDgvData7Days()
        {
            listDoanhThu.Clear();
            for (int i = 0; i < 7; i++)
            {
                DOANHTHU doanhThu = doanhThuBLL.LayDoanhThuTheoNgay(daysOfWeek1[i]);
                if (doanhThu.MaDoanhThu != "null")
                {
                    listDoanhThu.Add(doanhThu);
                }
            }
            listDoanhThu = listDoanhThu.OrderByDescending(x => x.NgayTongKetDoanhThu).ToList();
            foreach (DOANHTHU dt in listDoanhThu)
            {
                dtgDoanhThu7Ngay.Rows.Add(stt1, dt.TienThu.ToString("C", culture), dt.NgayTongKetDoanhThu.ToString("dd/MM/yyy"));
                stt1++;
            }
        }

        private void updateDayOfWeek_Chart()
        {
            DayOfWeek startOfWeek = DayOfWeek.Monday;

            DateTime startOfWeekDate = hop2;
            while (startOfWeekDate.DayOfWeek != startOfWeek)
            {
                startOfWeekDate = startOfWeekDate.AddDays(-1);
            }

            for (int i = 0; i < 7; i++)
            {
                daysOfWeek2[i] = startOfWeekDate.AddDays(i);
            }
        }

        
        private void loadDataChart30Days()
        {
            SeriesChartType currentChartType = SeriesChartType.Column; // default type
            if (chart2.Series.Count > 0)
            {
                currentChartType = chart2.Series[0].ChartType;
            }
            // Clear previous data
            listDoanhThu.Clear();
            listChiPhi.Clear();
            chart2.Series.Clear();
            for (int i = 0; i < daysofMonth.Count(); i++)
            {
                DOANHTHU doanhThu = doanhThuBLL.LayDoanhThuTheoNgay(daysofMonth[i]);
                CHIPHI chiphi = chiPhiBLL.LayChiPhiTheoNgay(daysofMonth[i]);
                listDoanhThu.Add(doanhThu);
                listChiPhi.Add(chiphi);
            }

            var seriesDoanhThu = chart2.Series.Add("Doanh Thu");
            seriesDoanhThu.ChartType = currentChartType;
            
            for (int i = 0; i < daysofMonth.Count(); i++)
            {
                seriesDoanhThu.Points.AddXY(daysofMonth[i].ToString("dd"), listDoanhThu[i].TienThu);
            }

            var seriesChiPhi = chart2.Series.Add("Chi phí");
            seriesChiPhi.ChartType = SeriesChartType.Line;
            for (int i = 0; i < daysofMonth.Count(); i++)
            {
                seriesChiPhi.Points.AddXY(daysofMonth[i].ToString("dd"), listChiPhi[i].TongChiPhi);
            }

            lblTitleRevenue.Text = "Doanh thu trong 30 ngày (tháng " + daysofMonth[0].ToString("MM") + "/" + daysofMonth[0].ToString("yyyy") + ")"; 
        }

        private void loadChartData()
        {
            loadDataChart30Days();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            updateDayOfWeek_DGV();
            updateDaysOfMonth_Chart();
            loadChartData();
            loadDgvData7Days();
            dateTimePicker_Value = monthCalendar1.SelectionStart;
            doMonthCalenderDateChange();
        }

        bool chartTypeLogic = false;
        private void btnDoiBieuDo_Click(object sender, EventArgs e)
        {
            if (chartTypeLogic == false)
            {
                chart2.Series[0].ChartType = SeriesChartType.Line;
                chartTypeLogic = true;
            }
            else
            {
                chart2.Series[0].ChartType = SeriesChartType.Column;
                chartTypeLogic = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hop1 = hop1.AddDays(-7);
            updateDayOfWeek_DGV();
            loadDgvData7Days();
        }

        private void btnLeft30Ngay_Click(object sender, EventArgs e)
        {
            hop_month = hop_month.AddDays(-30);
            updateDaysOfMonth_Chart();
            loadDataChart30Days();
        }

        private void btnRight30Ngay_Click(object sender, EventArgs e)
        {
            hop_month = hop_month.AddDays(30);
            updateDaysOfMonth_Chart();
            loadDataChart30Days();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            doMonthCalenderDateChange();
        }
        private void doMonthCalenderDateChange()
        {
            dateTimePicker_Value = monthCalendar1.SelectionStart;
            updateDaysOfMonth_DateTimePicker();
            double totalRevenueMonth = 0;
            double totalRevenueDay = Convert.ToDouble(doanhThuBLL.LayDoanhThuTheoNgay(monthCalendar1.SelectionStart).TienThu);
           
            for (int i = 0; i < daysofMonth.Count(); i++)
            {
                DOANHTHU doanhThu = doanhThuBLL.LayDoanhThuTheoNgay(daysOfMonth2[i]);
                totalRevenueMonth += doanhThu.TienThu;
            }
            
            lblRevenueDay.Text = "Tổng doanh thu của ngày " + monthCalendar1.SelectionStart.ToString("dd/MM") + ": " + totalRevenueDay.ToString("C", culture);
            lblRevenueMonth.Text = "Tổng doanh thu của tháng " + monthCalendar1.SelectionStart.ToString("MM/yyyy") + ": " + totalRevenueMonth.ToString("C", culture);
        }
    }
}
