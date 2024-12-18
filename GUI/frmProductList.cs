using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using ZXing;
using System.IO;
using OfficeOpenXml;

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
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }
        SanPhamBLL spbll = new SanPhamBLL();
        private string loaisp;
        List<SanPham> lsp = new List<SanPham>();
        LoaiSanPhamBLL loaiSanPhamBLL = new LoaiSanPhamBLL();
        public static string tenChucNang = "danh_sach_san_pham";
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
  
        private void fDanhSachSP_Load(object sender, EventArgs e)
        {
            loadProductList();
            autoLoadRow();
            loadLoaiSanPham();
        }

        private void loadLoaiSanPham()
        {
            List<LOAISANPHAM> listLoaiSanPham = loaiSanPhamBLL.xemLoaiSanPham();
            LOAISANPHAM temp = new LOAISANPHAM
            {
                MaLoaiSanPham = "Gói thành viên",
                TenLoaiSanPham = "Gói thành viên"
            };

            List<LOAISANPHAM> tmp = new List<LOAISANPHAM>();
            foreach (var item in listLoaiSanPham)
            {
                tmp.Add(item);
            }

            foreach (var item in tmp)
            {
                if (item.TenLoaiSanPham == "Gói thành viên")
                {
                    listLoaiSanPham.Remove(item);
                    break;
                }
            }

            cbProductType.DisplayMember = "TenLoaiSanPham";
            cbProductType.ValueMember = "MaLoaiSanPham";
            cbProductType.DataSource = listLoaiSanPham;
           
        }

        private void loadProductList()
        {
            int count = 0;
            lsp = spbll.xemListSP();
            dgvProduct.Columns.Add("STT", "STT");
            dgvProduct.Columns.Add("MASP", "Mã sản phẩm");
            dgvProduct.Columns.Add("LOAISP", "Loại sản phẩm");
            dgvProduct.Columns.Add("TENSP", "Tên sản phẩm");
            dgvProduct.Columns.Add("SOLUONG", "Số lượng");
            dgvProduct.Columns.Add("DONVI", "Đơn vị");
            foreach(SanPham sp in lsp)
            {
                count++;
                dgvProduct.Rows.Add(count.ToString(),sp.MaSP,sp.LoaiSP,sp.TenSP,sp.SL,"Đơn vị");
            }

        }
        private void LoadListSPtheoLoai(string loaiSP)
        {
            int count = 0;
            dgvProduct.Rows.Clear();
            lsp = spbll.xemListSPtheoLoai(loaiSP);
           
            foreach (SanPham sp in lsp)
            {
                count++;
                dgvProduct.Rows.Add(count.ToString(), sp.MaSP, sp.LoaiSP, sp.TenSP, sp.SL, "Đơn vị");
            }
        }
        private void refreshData()
        {
            int count = 0;
            dgvProduct.Rows.Clear();
            List<SanPham> lsp = new List<SanPham>();

            lsp = spbll.xemListSP();

            foreach (SanPham sp in lsp)
            {
                count++;
                dgvProduct.Rows.Add(count.ToString(), sp.MaSP, sp.LoaiSP, sp.TenSP, sp.SL, "Đơn vị");
            }

        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                object value = dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value == null)
                {
                    return;
                }
                string maSP = (string)value;
                frmProductInfo fttsp = new frmProductInfo();
                frmProductInfo.masp = maSP;
                this.Hide();
                fttsp.ShowDialog();
                this.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
            autoLoadRow();
        }
        
        private void autoLoadRow()
        {
            while (dgvProduct.Rows.Count < 20)
            {
                dgvProduct.Rows.Add();
            }
        }

        private void modifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvProduct.CurrentRow.Index;
            if (dgvProduct.Rows[i].Cells[1].Value == null)
            {
                return;
            }
            frmProductInfo fttsp = new frmProductInfo();
            frmProductInfo.masp = dgvProduct.Rows[i].Cells[1].Value.ToString();
            this.Hide();
            fttsp.ShowDialog();
            this.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvProduct.CurrentRow.Index;
            if (dgvProduct.Rows[i].Cells[1].Value == null)
            {
                return;
            }
            if (spbll.XoaThongTinSanPham(dgvProduct.Rows[i].Cells[1].Value.ToString()))
            {
                MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string productId = value.ToString();
                    if (spbll.ifProductExitsInDB(productId) <= 0)
                    {
                        MessageBox.Show("Sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    frmProductInfo prd = new frmProductInfo();
                    frmProductInfo.masp = productId;
                    this.Hide();
                    prd.ShowDialog();
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
            DateTime now = DateTime.Now;
            save.FileName = "DSSP" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
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
                    excel.Workbook.Properties.Author = "GymHCMUE";
                    excel.Workbook.Properties.Title = "Danh sách sản phẩm";
                    excel.Workbook.Worksheets.Add("Danh sách sản phẩm");
                    ExcelWorksheet ws = excel.Workbook.Worksheets[0];
                    ws.Name = "Danh sách sản phẩm";
                    ws.Cells.Style.Font.Size = 13;
                    ws.Cells.Style.Font.Name = "Tahoma";
                    /*
                     * ws.Cells[hang, cot++].Value = item.MaSP;
                        ws.Cells[hang, cot++].Value = item.LoaiSP;
                        ws.Cells[hang, cot++].Value = item.TenSP;
                        ws.Cells[hang, cot++].Value = item.GiaNhap;
                        ws.Cells[hang, cot++].Value = item.GiaThanh;
                        ws.Cells[hang, cot++].Value = item.SL;
                     */
                    string[] arrColumnheader =
                    {
                        "Mã sản phẩm",
                        "Loại sản phẩm",
                        "Tên sản phẩm",
                        "Giá nhập",
                        "Giá thành",
                        "Số lượng"
                    };
                    var countColumnHeader = arrColumnheader.Count();
                    //Merge va dat ten cho cell 1
                    ws.Cells[1, 1].Value = "Thống kê danh sách thiết bị";
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
                        cot++;
                        cell.AutoFitColumns();
                    }
                    foreach (var item in lsp)
                    {
                        cot = 1;
                        hang++;
                        ws.Cells[hang, cot++].Value = item.MaSP;
                        ws.Cells[hang, cot++].Value = item.LoaiSP;
                        ws.Cells[hang, cot++].Value = item.TenSP;
                        ws.Cells[hang, cot++].Value = item.GiaNhap;
                        ws.Cells[hang, cot++].Value = item.GiaThanh;
                        ws.Cells[hang, cot++].Value = item.SL;
                        ws.Cells.AutoFitColumns();
                    }
                    // lu file
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

        private void cbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaisp = cbProductType.SelectedValue.ToString(); 
            LoadListSPtheoLoai(loaisp);
            autoLoadRow();
        }
    }
}

