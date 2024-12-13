using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ZXing;
using ZXing.Common;
using System.Globalization;
using BLL;
using OfficeOpenXml;
using static System.Data.Entity.Infrastructure.Design.Executor;

/*
 ____   ___  _____ _______        ___    ____  _____ 
/ ___| / _ \|  ___|_   _\ \      / / \  |  _ \| ____|
\___ \| | | | |_    | |  \ \ /\ / / _ \ | |_) |  _|  
 ___) | |_| |  _|   | |   \ V  V / ___ \|  _ <| |___ 
|____/ \___/|_|__ __|_|  _ \_/\_/_/   \_\_| \_\_____|
/ ___|| | | / ___|_   _|/ \  |_ _| \ | |             
\___ \| | | \___ \ | | / _ \  | ||  \| |             
 ___) | |_| |___) || |/ ___ \ | || |\  |             
|____/ \___/|____/ |_/_/   \_\___|_| \_|     

DEVELOPED AND MAINTAINED BY SOFTWARE SUSTAIN
*/

namespace GUI
{
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }
        KHBLL khbll = new KHBLL();
        List<KHACHHANG> listExportKH = new List<KHACHHANG>();
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void loadList()
        {
            int i = 1;
            List<KHACHHANG> lKH = new List<KHACHHANG>();
            lKH = khbll.xemKH();
            listExportKH = lKH.ToList(); // tạo hàm 1 hàm filter để lọc khách hàng
            dgvCustomer.Columns.Add("STT", "Số thứ tự");
            dgvCustomer.Columns.Add("MATHE", "Mã thẻ");
            dgvCustomer.Columns.Add("HOTEN", "Họ tên");
            dgvCustomer.Columns.Add("NGAYBATDAU", "Ngày bắt đầu");
            dgvCustomer.Columns.Add("NGAYHETHAN", "Ngày hết hạn");
            foreach (KHACHHANG khachhang in lKH)
            {
                dgvCustomer.Rows.Add(i,khachhang.Mathe, khachhang.Hoten, khachhang.NgayBatDau, khachhang.NgayHetHan);
                i++;
            }
        }
        private void refreshData()
        {
            dgvCustomer.Rows.Clear();
            List<KHACHHANG> lKH = new List<KHACHHANG>();
            lKH = khbll.xemKH();
            int i = 1;
            foreach (KHACHHANG khachhang in lKH)
            {
                dgvCustomer.Rows.Add(i, khachhang.Mathe, khachhang.Hoten, khachhang.NgayBatDau, khachhang.NgayHetHan);
                i++;
            }
        }
        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            tbFilterDate.Text = DateTime.Now.Day.ToString("D2") + "/" + DateTime.Now.Month.ToString("D2") + "/" + DateTime.Now.Year.ToString("D2");
            loadList();
            autoLoadRow();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
            autoLoadRow();
        }

        List<KHACHHANG> ltkKH = new List<KHACHHANG>();
        DateTime fromDate = new DateTime();

        private void loadListKHWithFilter()
        {
            if (!string.IsNullOrEmpty(tbFilterDate.Text))
            {
                DateTime thamchieu;
                
                if (DateTime.TryParseExact(tbFilterDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out thamchieu))
                {
                    fromDate = thamchieu;
                }
                else
                {
                    MessageBox.Show("Nhập lại ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }
            else
            {
                MessageBox.Show("Nhập lại ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            ltkKH = khbll.thongkeKH(fromDate);
            listExportKH = ltkKH;
            dgvCustomer.Rows.Clear();
            int i = 1;
            foreach (KHACHHANG khachhang in ltkKH)
            {
                dgvCustomer.Rows.Add(i, khachhang.Mathe, khachhang.Hoten, khachhang.NgayBatDau, khachhang.NgayHetHan);
                i++;
            }
        }

        private void tbFindCustomer_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbFindCustomer.Text;

                foreach (DataGridViewRow row in dgvCustomer.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchValue))
                        {
                            row.Selected = true;
                            dgvCustomer.CurrentCell = row.Cells[1]; // Di chuyển đến ô đầu tiên của hàng
                            dgvCustomer.FirstDisplayedScrollingRowIndex = row.Index; // Cuộn để hiển thị hàng đầu tiên
                            return;
                        }
                    }
                }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string filepath = "";
            //Tạo saveDiaglouge
            SaveFileDialog save = new SaveFileDialog();
            //file filter
            save.Filter = "Excel Workbook|*.xlsx ";
            if(save.ShowDialog() == DialogResult.OK)
            {
                filepath = save.FileName;
            }
            if(string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ");
                return;
            }
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                using (ExcelPackage excel = new ExcelPackage())
                {
                    excel.Workbook.Properties.Author = "HappyStore";
                    excel.Workbook.Properties.Title = "Danh sách khách hàng";
                    excel.Workbook.Worksheets.Add("Danh sách khách hàng");
                    ExcelWorksheet ws = excel.Workbook.Worksheets[0];
                    ws.Name = "Danh sách khách hàng";
                    ws.Cells.Style.Font.Size = 13;
                    ws.Cells.Style.Font.Name = "Tahoma";
                    string[] arrColumnheader =
                    {
                        "Mã thẻ",
                        "Họ tên",
                        "Ngày sinh",
                        "Giới tính",
                        "CMND",
                        "Địa chỉ",
                        "SDT",
                        "Email",
                        "Ghi chú",
                        "Mã gói thành viên",
                        "Ngày đăng kí",
                        "Ngày hết hạn",
                        "Thời hạn",
                        
                    };
                    var countColumnHeader = arrColumnheader.Count();
                    //Merge va dat ten cho cell 1
                    ws.Cells[1, 1].Value = "THỐNG KÊ DANH SÁCH KHÁCH HÀNG";
                    ws.Cells[1, 1, 1, countColumnHeader].Merge = true;
                    ws.Cells[1, 1, 1, countColumnHeader].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, countColumnHeader].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    int cot = 1;
                    int hang = 2;
                    foreach(var item in arrColumnheader)
                    {
                        var cell = ws.Cells[hang, cot];
                        cell.Style.Font.Bold = true;
                        cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        // Tự động điều chỉnh độ rộng của ô dựa trên nội dung
                        cell.AutoFitColumns();

                        cell.Value = item;
                        cot++;
                    }
                    foreach(var item in listExportKH)
                    {
                        cot = 1;
                        hang++;
                        ws.Cells[hang, cot++].Value = item.Mathe;
                        ws.Cells[hang, cot++].Value = item.Hoten;
                        ws.Cells[hang, cot++].Value = item.Ngaysinh;
                        ws.Cells[hang, cot++].Value = item.Gioitinh;
                        ws.Cells[hang, cot++].Value = item.CMND;
                        ws.Cells[hang, cot++].Value = item.diaChi;
                        ws.Cells[hang, cot++].Value = item.SDT;
                        ws.Cells[hang, cot++].Value = item.Email;
                        ws.Cells[hang, cot++].Value = item.GhiChu;
                        ws.Cells[hang, cot++].Value = item.MaGoiThanhVien;
                        ws.Cells[hang, cot++].Value = item.NgayBatDau.ToShortDateString();
                        ws.Cells[hang, cot++].Value = item.NgayHetHan.ToShortDateString();
                        ws.Cells[hang, cot++].Value = item.ThoiHan.ToShortDateString();
                        ws.Cells.AutoFitColumns();
                    }
                    // lu file
                    Byte[] bin = excel.GetAsByteArray();
                    File.WriteAllBytes(filepath, bin);

                }
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ee)
            {   
                MessageBox.Show("Có lỗi khi lưu file excel" + ee.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string ReadQRCodeFromFile(string filePath)
        {
            // Đọc hình ảnh từ file
            Bitmap qrCodeImage = new Bitmap(filePath);

            // Tạo đối tượng BarcodeReader và cấu hình nó
            BarcodeReader reader = new BarcodeReader();
            reader.Options.PossibleFormats = new BarcodeFormat[] { BarcodeFormat.QR_CODE };

            // Đọc mã QR từ hình ảnh
            Result result = reader.Decode(qrCodeImage);

            if (result != null )
            {
                return result.Text;
            }
            else
            {
                throw new Exception("Có lỗi gì đó đã xảy ra");
            }
        }
       
        private void btnCheckQR_Click(object sender, EventArgs e)
        {
            // Hiển thị OpenFileDialog để chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Image|*.png";
            openFileDialog.Title = "Open QR Code Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Đọc giá trị từ mã QR
                    string value = ReadQRCodeFromFile(filePath);
                    string maTHE = value.ToString();
                    if (khbll.ifCustomerExitsInDB(maTHE) <= 0)
                    {
                        MessageBox.Show("Khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    frmCustomerInfo fthKH = new frmCustomerInfo();
                    frmCustomerInfo.mathe = maTHE;
                    this.Hide();
                    fthKH.ShowDialog();
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                object value = dgvCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value == null)
                {
                    return;
                }
                string maTHE = value.ToString();
                if (khbll.ifCustomerExitsInDB(maTHE) <= 0)
                {
                    MessageBox.Show("Khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                frmCustomerInfo fthKH = new frmCustomerInfo();
                frmCustomerInfo.mathe = maTHE;
                this.Hide();
                fthKH.ShowDialog();
                this.Show();
            }
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterCustomer_Click(object sender, EventArgs e)
        {
            loadListKHWithFilter();
            autoLoadRow();
        }

        private void removeToolStripMenuStrip_Click(object sender, EventArgs e)
        {
            int i = dgvCustomer.CurrentRow.Index;
            if (dgvCustomer.Rows[i].Cells[1].Value == null)
            {
                return;
            }
            if (khbll.xoathongtinKH(dgvCustomer.Rows[i].Cells[1].Value.ToString()))
            {
                MessageBox.Show("Xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xoá khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            refreshData();
        }

        private void modifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvCustomer.CurrentRow.Index;
            if (dgvCustomer.Rows[i].Cells[1].Value == null)
            {
                return;
            }
            frmCustomerInfo fthKH = new frmCustomerInfo();
            frmCustomerInfo.mathe = dgvCustomer.Rows[i].Cells[1].Value.ToString();
            this.Hide();
            fthKH.ShowDialog();
            this.Show();
        }
        private void autoLoadRow()
        {
            while (dgvCustomer.Rows.Count < 20)
            {
                dgvCustomer.Rows.Add();
            }
        }
    }
}
