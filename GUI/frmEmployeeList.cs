using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DTO;
using BLL;
using OfficeOpenXml;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

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
    public partial class frmEmployeeList : Form
    {
        public frmEmployeeList()
        {
            InitializeComponent();
        }
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        NhanVienBLL nvbll = new NhanVienBLL();
        List<NHANVIEN> lNV = new List<NHANVIEN>();
        LoaiChucVuBLL loaiChucVuBLL = new LoaiChucVuBLL();
        List<LOAICHUCVU> listLoaiChucVu = new List<LOAICHUCVU>();

        public static string tenChucNang = "danh_sach_nhan_vien";
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void LoadList()
        {
            int i = 1;
            dgvEmployee.Columns.Clear();
            lNV = nvbll.xemNhanVienTheoLoaiChucVu(cbJobtitle.SelectedValue.ToString());
            dgvEmployee.Columns.Add("STT", "STT");
            dgvEmployee.Columns.Add("MANHANVIEN", "Mã nhân viên");
            dgvEmployee.Columns.Add("HOTEN", "Họ tên");
            dgvEmployee.Columns.Add("SDT", "Số ĐT");
            dgvEmployee.Columns.Add("CMND", "CMND");
            dgvEmployee.Columns.Add("CHUCVU", "Chức vụ");
            
            foreach (NHANVIEN nhanvien in lNV)
            {
                LOAICHUCVU tmp = loaiChucVuBLL.ReadLoaiChucVuById(nhanvien.MaLoaiChucVu);
                dgvEmployee.Rows.Add(i, nhanvien.maNhanVien, nhanvien.Hoten, nhanvien.SDT, nhanvien.CMND, tmp.TenLoaiChucVu);
                i++;
            }
            autoLoadRow();
        }

        private void loadComboBox()
        {
            
            listLoaiChucVu = loaiChucVuBLL.ReadLoaiChucVu();

            cbJobtitle.DisplayMember = "TenLoaiChucVu";
            cbJobtitle.ValueMember = "MaLoaiChucVu";
            cbJobtitle.DataSource = listLoaiChucVu;
        }

        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            loadComboBox(); 
            
            LoadList();
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                object value = dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value == null)
                {
                    return;
                }
                string maNV = value.ToString();
                frmEmployeeInfo fttnv = new frmEmployeeInfo();
                frmEmployeeInfo.maNV = maNV;
                this.Hide();
                fttnv.ShowDialog();
                this.Show();
            }
        }
        private void autoLoadRow()
        {
            while (dgvEmployee.Rows.Count < 20)
            {
                dgvEmployee.Rows.Add();
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string filepath = "";
            // Tạo saveDiaglouge
            SaveFileDialog save = new SaveFileDialog();
            // file filter
            save.Filter = "Excel Workbook|*.xlsx ";
            string selectedJobTitle = cbJobtitle.GetItemText(cbJobtitle.SelectedItem); ;
            DateTime now = DateTime.Now;
            save.FileName = "DS-" + selectedJobTitle + "-" + now.Year.ToString() + now.Month.ToString("D2") + now.Day.ToString("D2") + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
            if (save.ShowDialog() == DialogResult.OK)
            {
                filepath = save.FileName;
            }
            if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                using (ExcelPackage excel = new ExcelPackage())
                {
                    excel.Workbook.Properties.Author = "HappyStore";
                    string title = "Danh sách " + selectedJobTitle;
                    excel.Workbook.Properties.Title = title;
                    excel.Workbook.Worksheets.Add(title);
                    ExcelWorksheet ws = excel.Workbook.Worksheets[0];
                    ws.Name = title;
                    ws.Cells.Style.Font.Size = 13;
                    ws.Cells.Style.Font.Name = "Tahoma";
                    string[] arrColumnheader =
                    {
                        "Mã nhân viên",
                        "Họ tên",
                        "Ngày sinh",
                        "Số ĐT",
                        "Giới tính",
                        "Địa chỉ",
                        "Email",
                        "CMND",
                        "Chức vụ",
                        "Ghi chú",
                    };
                    var countColumnHeader = arrColumnheader.Count();
                    // Merge và đặt tên cho cell 1
                    ws.Cells[1, 1].Value = "THỐNG KÊ DANH SÁCH " + selectedJobTitle;
                    ws.Cells[1, 1, 1, countColumnHeader].Merge = true;
                    ws.Cells[1, 1, 1, countColumnHeader].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, countColumnHeader].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    int cot = 1;
                    int hang = 2;
                    foreach (var item in arrColumnheader)
                    {
                        var cell = ws.Cells[hang, cot];
                        cell.Style.Font.Bold = true;
                        cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        // Tự động điều chỉnh độ rộng của ô dựa trên nội dung
                        cell.Value = item;
                        cell.AutoFitColumns();
                        cot++;
                    }
                    
                    foreach (var item in lNV)
                    {
                        LOAICHUCVU tmp = loaiChucVuBLL.ReadLoaiChucVuById(item.MaLoaiChucVu);
                        cot = 1;
                        hang++;
                        ws.Cells[hang, cot++].Value = item.maNhanVien;
                        ws.Cells[hang, cot++].Value = item.Hoten;
                        ws.Cells[hang, cot++].Value = item.Ngaysinh.ToString("dd/MM/yyyy");
                        ws.Cells[hang, cot++].Value = item.SDT;
                        ws.Cells[hang, cot++].Value = item.Gioitinh;
                        ws.Cells[hang, cot++].Value = item.diaChi;
                        ws.Cells[hang, cot++].Value = item.Email;
                        ws.Cells[hang, cot++].Value = item.CMND;
                        ws.Cells[hang, cot++].Value = tmp.TenLoaiChucVu;
                        ws.Cells[hang, cot++].Value = item.GhiChu;
                        ws.Cells.AutoFitColumns();
                    }
                    // Lưu file
                    Byte[] bin = excel.GetAsByteArray();
                    File.WriteAllBytes(filepath, bin);
                }
                MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
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

            if (result != null)
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
                    string employeeId = value.ToString();
                    if (nvbll.ifEmployeeExistsInDB(employeeId) <= 0)
                    {
                        MessageBox.Show("Nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    frmEmployeeInfo employeeInfo = new frmEmployeeInfo();
                    frmEmployeeInfo.maNV = employeeId;
                    this.Hide();
                    employeeInfo.ShowDialog();
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void modifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvEmployee.CurrentRow.Index;
            object value = dgvEmployee.Rows[i].Cells[1].Value;
            if (value == null)
            {
                return;
            }
            string maNV = value.ToString();
            frmEmployeeInfo fttnv = new frmEmployeeInfo();
            frmEmployeeInfo.maNV = maNV;
            this.Hide();
            fttnv.ShowDialog();
            this.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvEmployee.CurrentRow.Index;
            object value = dgvEmployee.Rows[i].Cells[1].Value;
            if (value == null)
            {
                return;
            }
            string maNV = value.ToString();
            bool check = nvbll.XoaNV(maNV);
            if (check == true)
            {
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
                MessageBox.Show("Xóa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void cbJobtitle_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbJobtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
