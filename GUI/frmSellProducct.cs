using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using iText.Layout;
using System.Windows.Forms;
using DTO;
using System.Globalization;
using BLL;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using ZXing.Common;
using ZXing;
using OpenCvSharp.Aruco;

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
    public partial class frmSellProducct : Form
    {
        public frmSellProducct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isExportRecipe <= 0 && dtgDSSP.Rows.Count > 0)
            {
                MessageBox.Show("Vui lòng xuất biên lai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
        }
        SanPhamBLL spbll = new SanPhamBLL();
        BienlaiBLL blbll = new BienlaiBLL();
        KHBLL khbll = new KHBLL();
        HoaDonBLL hdbll = new HoaDonBLL();
        private string loaisp;
        List<SanPham> lsp = new List<SanPham>();
        int demanh1 = 0;
        int demanh2 = 1;
        int demanh3 = 2;
        int slsp1 = 0;
        int slsp2 = 0;
        int slsp3 = 0;
        int stt = 0;
        int rowindex = -1;
        HOADON hoadon= new HOADON();
        CultureInfo culture = new CultureInfo("vi-VN");
        LoaiSanPhamBLL loaiSanPhamBLL = new LoaiSanPhamBLL();
        List<LOAISANPHAM> listLoaiSanPham = new List<LOAISANPHAM>();
        public static string tenChucNang = "ban_san_pham";
        private void loadLoaiSanPham()
        {
            listLoaiSanPham = loaiSanPhamBLL.xemLoaiSanPham();
            LOAISANPHAM temp = new LOAISANPHAM
            {
                MaLoaiSanPham = "Xem tất cả",
                TenLoaiSanPham = "Xem tất cả"
            };
            cmbLoaiSP.ValueMember = "MaLoaiSanPham";
            cmbLoaiSP.DisplayMember = "TenLoaiSanPham";
            listLoaiSanPham.Add(temp);
            cmbLoaiSP.DataSource = listLoaiSanPham;
            foreach (var item in cmbLoaiSP.Items)
            {

                // Lấy mã thiết bị
                LOAISANPHAM temp123 = item as LOAISANPHAM;
                if (temp123.MaLoaiSanPham == "Xem tất cả")
                {
                    cmbLoaiSP.SelectedItem = item;
                    break;
                }
            }
        }

        private void LoadGioHang()
        { 
            dtgDSSP.Columns.Add("MASP", "Mã sản phẩm");
            dtgDSSP.Columns.Add("TENSP", "Tên sản phẩm");
            dtgDSSP.Columns.Add("SOLUONG", "Số lượng");
            dtgDSSP.Columns.Add("GIATIEN", "Giá tiền");
        }
        int count = 0;
        private void cmbLoaiSP_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        private void LoadListSPtheoLoai(string loaiSP)
        {
            lsp = spbll.xemListSPtheoLoai(loaiSP);
            //autoLoadRow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //autoLoadRow();
        }
        private void RefreshData()
        {
            lsp = spbll.xemListSP();
        }
        private void ThemSanPhamBan()
        {
            if (demanh1 < lsp.Count)
            {
                using (MemoryStream ms = new MemoryStream(lsp[demanh1].Anh))
                {
                    ptbSP1.Image = System.Drawing.Image.FromStream(ms);
                    lbTenSP1.Text = lsp[demanh1].TenSP;
                    lbSLSP1.Text = "0";
                    lbGiaThanhSP1.Text = lsp[demanh1].GiaThanh.ToString();
                }
                if (demanh2 < lsp.Count)
                {
                    using (MemoryStream ms = new MemoryStream(lsp[demanh2].Anh))
                    {
                        ptbSP2.Image = System.Drawing.Image.FromStream(ms);
                        lbTenSP2.Text = lsp[demanh2].TenSP;
                        lbSLSP2.Text = "0";
                        lbGiaThanhSP2.Text = lsp[demanh2].GiaThanh.ToString();
                        btnCongSP2.Enabled = true;
                        btnTruSP2.Enabled = true;
                    }
                    if (demanh3 < lsp.Count)
                    {
                        using (MemoryStream ms = new MemoryStream(lsp[demanh3].Anh))
                        {
                            ptbSP3.Image = System.Drawing.Image.FromStream(ms);
                            lbtenSP3.Text = lsp[demanh3].TenSP;
                            lbSLSP3.Text = "0";
                            lbGiaThanhSP3.Text = lsp[demanh3].GiaThanh.ToString();
                            btnCongSP3.Enabled = true;
                            btnTruSP3.Enabled = true;
                        }

                    }
                    else
                    {
                        ptbSP3.Image = Properties.Resources.product;
                        lbtenSP3.Text = "Không";
                        lbSLSP3.Text = "0";
                        lbGiaThanhSP3.Text = "0";
                        btnCongSP3.Enabled = false;
                        btnTruSP3.Enabled = false;
                    }

                }
                else
                {
                    ptbSP2.Image = Properties.Resources.product;
                    lbTenSP2.Text = "Không";
                    lbSLSP2.Text = "0";
                    lbGiaThanhSP2.Text = "0";
                    btnCongSP2.Enabled = false;
                    btnTruSP2.Enabled = false;

                    ptbSP3.Image = Properties.Resources.product;
                    lbtenSP3.Text = "Không";
                    lbSLSP3.Text = "0";
                    lbGiaThanhSP3.Text = "0";
                    btnCongSP3.Enabled = false;
                    btnTruSP3.Enabled = false;
                }
            }
           
        }

        private void fBanSP_LocationChanged(object sender, EventArgs e)
        {

        }

        private void fBanSP_Load(object sender, EventArgs e)
        {
            lblTongTien.Text = hoadon.TongTien.ToString("C", culture);
            LoadGioHang();
            foreach(string mathe in LoadListKH())
            {
                cmbMaKH.Items.Add(mathe);
            }
            
            loadLoaiSanPham();
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            demanh1 = demanh1 + 3;
            demanh2 = demanh2 + 3;
            demanh3 = demanh3 + 3;

            if (demanh1 < lsp.Count)
            {
                using (MemoryStream ms = new MemoryStream(lsp[demanh1].Anh))
                {
                    ptbSP1.Image = System.Drawing.Image.FromStream(ms);
                    lbTenSP1.Text = lsp[demanh1].TenSP;
                    lbSLSP1.Text = "0";
                    lbGiaThanhSP1.Text = lsp[demanh1].GiaThanh.ToString();
                }
                if (demanh2 < lsp.Count)
                {
                    using (MemoryStream ms = new MemoryStream(lsp[demanh2].Anh))
                    {
                        ptbSP2.Image = System.Drawing.Image.FromStream(ms);
                        lbTenSP2.Text = lsp[demanh2].TenSP;
                        lbSLSP2.Text = "0";
                        lbGiaThanhSP2.Text = lsp[demanh2].GiaThanh.ToString();
                        btnCongSP2.Enabled = true;
                        btnTruSP2.Enabled = true;
                    }
                    if (demanh3 < lsp.Count)
                    {
                        using (MemoryStream ms = new MemoryStream(lsp[demanh3].Anh))
                        {
                            ptbSP3.Image = System.Drawing.Image.FromStream(ms);
                            lbtenSP3.Text = lsp[demanh3].TenSP;
                            lbSLSP3.Text = "0";
                            lbGiaThanhSP3.Text = lsp[demanh3].GiaThanh.ToString();
                            btnCongSP3.Enabled = true;
                            btnTruSP3.Enabled = true;
                        }
                    }
                    else
                    {
                        ptbSP3.Image = Properties.Resources.product;
                        lbtenSP3.Text = "Không";
                        lbSLSP3.Text = "0";
                        lbGiaThanhSP3.Text = "0";
                        btnCongSP3.Enabled = false;
                        btnTruSP3.Enabled = false;
                    }    
                }
                else
                {
                    ptbSP2.Image = Properties.Resources.product;
                    lbTenSP2.Text = "Không";
                    lbSLSP2.Text = "0";
                    lbGiaThanhSP2.Text = "0";
                    btnCongSP2.Enabled = false;
                    btnTruSP2.Enabled = false;

                    ptbSP3.Image = Properties.Resources.product;
                    lbtenSP3.Text = "Không";
                    lbSLSP3.Text = "0";
                    lbGiaThanhSP3.Text = "0";
                    btnCongSP3.Enabled = false;
                    btnTruSP3.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Đã hết sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                demanh1 = demanh1 - 3;
                demanh2 = demanh2 - 3;
                demanh3 = demanh3 - 3;
                return;
            }

        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            demanh1 = demanh1 - 3;
            demanh2 = demanh2 - 3;
            demanh3 = demanh3 - 3;
            if (demanh1 >= 0)
            {  
                btnTruSP1.Enabled = true;
                btnTruSP2.Enabled = true;
                btnTruSP3.Enabled = true;
                btnCongSP1.Enabled = true;
                btnCongSP2.Enabled = true;
                btnCongSP3.Enabled = true;
                using (MemoryStream ms = new MemoryStream(lsp[demanh1].Anh))
                {
                    ptbSP1.Image = System.Drawing.Image.FromStream(ms);
                    lbTenSP1.Text = lsp[demanh1].TenSP;
                    lbSLSP1.Text = "0";
                    lbGiaThanhSP1.Text = lsp[demanh1].GiaThanh.ToString();
                }
                using (MemoryStream ms = new MemoryStream(lsp[demanh2].Anh))
                {
                    ptbSP2.Image = System.Drawing.Image.FromStream(ms);
                    lbTenSP2.Text = lsp[demanh2].TenSP;
                    lbSLSP2.Text = "0";
                    lbGiaThanhSP2.Text = lsp[demanh2].GiaThanh.ToString();
                }
                    
                using (MemoryStream ms = new MemoryStream(lsp[demanh3].Anh))
                {
                    ptbSP3.Image = System.Drawing.Image.FromStream(ms);
                    lbtenSP3.Text = lsp[demanh3].TenSP;
                    lbSLSP3.Text = "0";
                    lbGiaThanhSP3.Text = lsp[demanh3].GiaThanh.ToString();
                }
            }
            else
            {
                MessageBox.Show("Đã quay lại sản phẩm ban đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                demanh1 = demanh1 + 3;
                demanh2 = demanh2 + 3;
                demanh3 = demanh3 + 3;
                return;
            }
        }
        private void btnCongSP1_Click(object sender, EventArgs e)
        {
            if (demanh1 < lsp.Count)
            {
                slsp1++;
                lbSLSP1.Text = (slsp1).ToString();
                dtgDSSP.Rows.Add(lsp[demanh1].MaSP, lsp[demanh1].TenSP, "1", lsp[demanh1].GiaThanh);
                hoadon.TongTien = hoadon.TongTien + lsp[demanh1].GiaThanh;
                lblTongTien.Text = hoadon.TongTien.ToString("C", culture);
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTruSP1_Click(object sender, EventArgs e)
        {
           if (slsp1 <= 0)
           {
                return;
           }
           slsp1--;
           lbSLSP1.Text = (slsp1).ToString();
           string valuecheck = lsp[demanh1].MaSP;
           foreach(DataGridViewRow row in dtgDSSP.Rows)
           {
             string cellvalue = row.Cells["MASP"].Value.ToString();
             if(cellvalue == valuecheck)
             {
                 dtgDSSP.Rows.Remove(row);
                 hoadon.TongTien -= lsp[demanh1].GiaThanh;
                 break;
             }
           }
           lblTongTien.Text = hoadon.TongTien.ToString("C", culture);
        }

        private void btnCongSP2_Click(object sender, EventArgs e)
        {
            if (demanh2 < lsp.Count)
            {
                slsp2++;
                lbSLSP2.Text = (slsp2).ToString();
                dtgDSSP.Rows.Add(lsp[demanh2].MaSP, lsp[demanh2].TenSP, "1", lsp[demanh2].GiaThanh);
                hoadon.TongTien = hoadon.TongTien + lsp[demanh2].GiaThanh;
                lblTongTien.Text = hoadon.TongTien.ToString("C", culture);
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTruSP2_Click(object sender, EventArgs e)
        {
            if (slsp2 <= 0)
            {
                return;
            }
            slsp2--;
            lbSLSP2.Text = (slsp2).ToString();
            string valuecheck = lsp[demanh2].MaSP;
            foreach (DataGridViewRow row in dtgDSSP.Rows)
            {
                string cellvalue = row.Cells["MASP"].Value.ToString();
                if (cellvalue == valuecheck)
                {
                    dtgDSSP.Rows.Remove(row);
                    hoadon.TongTien -= lsp[demanh2].GiaThanh;
                    break;
                }
            }
            lblTongTien.Text = hoadon.TongTien.ToString("C", culture);
        }

        private void btnCongSP3_Click(object sender, EventArgs e)
        {
            if (demanh3 < lsp.Count)
            {
                slsp3++;
                lbSLSP3.Text = (slsp3).ToString();
                dtgDSSP.Rows.Add(lsp[demanh3].MaSP, lsp[demanh3].TenSP, "1", lsp[demanh3].GiaThanh);
                hoadon.TongTien = hoadon.TongTien + lsp[demanh3].GiaThanh;
                lblTongTien.Text = hoadon.TongTien.ToString("C", culture);
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTruSP3_Click(object sender, EventArgs e)
        {
            if (slsp3 <= 0)
            {
                return;
            }
            slsp3--;
            lbSLSP3.Text = (slsp3).ToString();
            string valuecheck = lsp[demanh3].MaSP;
            foreach (DataGridViewRow row in dtgDSSP.Rows)
            {
                string cellvalue = row.Cells["MASP"].Value.ToString();
                if (cellvalue == valuecheck)
                {
                    dtgDSSP.Rows.Remove(row);
                    hoadon.TongTien -= lsp[demanh3].GiaThanh;
                    break;
                }
            }
            lblTongTien.Text = hoadon.TongTien.ToString("C", culture);
        }

        bool isSellProduct = false;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(cmbMaKH.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                hoadon.MaThe = cmbMaKH.SelectedItem.ToString();
            }    
            foreach(DataGridViewRow row in dtgDSSP.Rows)
            {
                string cellvalue = row.Cells["MASP"].Value.ToString();
                hoadon.MaSP += cellvalue + "_";
            }
            bool check = hdbll.themHoaDon(hoadon);
            if (check == true)
            {
                MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSellProduct = true;
                return;
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            
        }

        private void cmbMaKH_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        private  List<string> LoadListKH()
        {
            return khbll.xemListMaThe();
        }

        private void autoLoadRow()
        {
            while (dtgDSSP.Rows.Count < 20)
            {
                dtgDSSP.Rows.Add();
            }
        }

        private void cmbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiSP.SelectedValue.ToString() == "Xem tất cả")
            {
                RefreshData();
                ThemSanPhamBan();
            }
            else
            {
                loaisp = cmbLoaiSP.SelectedValue.ToString();
                LoadListSPtheoLoai(loaisp);
                ThemSanPhamBan();
            }
            
        }
        int isExportRecipe = 0;
        private void btnXuatBienLai_Click(object sender, EventArgs e)
        {
            if (isSellProduct == false)
            {
                MessageBox.Show("Vui lòng thanh toán giỏ hàng trước khi xuất hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Chọn đường dẫn lưu hoá đơn";
                saveFileDialog.Filter = "Tệp tin PDF|*.pdf";
                DateTime now = DateTime.Now;
                saveFileDialog.FileName = "BL" + cmbMaKH.SelectedItem.ToString() + now.Year.ToString() + now.Month.ToString("D2") + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    PdfWriter writer = new PdfWriter(path);
                    PdfDocument pdfDoc = new PdfDocument(writer);
                    Document doc = new Document(pdfDoc);

                    // Tải phông chữ tiếng Việt
                    string fontPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
                    PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                    Paragraph heading = new Paragraph("HOÁ ĐƠN")
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFontSize(40)
                        .SetFont(font);
                    doc.Add(heading);

                    Paragraph mabl = new Paragraph("Mã hoá đơn: " + hoadon.MaHoaDon)
                        .SetFont(font);
                    doc.Add(mabl);

                    Paragraph makh = new Paragraph("Mã khách hàng thanh toán: " + cmbMaKH.SelectedItem.ToString()).SetFont(font);
                    doc.Add(makh);

                    Paragraph dssp = new Paragraph("Danh sách sản phẩm: ")
                        .SetFont(font);
                    doc.Add(dssp);
                    /*object value = dgvCoach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;*/
                    Dictionary<string, int> lsp_tmp = new Dictionary<string, int>();
                    for (int i = 0; i < dtgDSSP.Rows.Count; i++)
                    {
                        string tmp = dtgDSSP.Rows[i].Cells[0].Value.ToString() + " - " + dtgDSSP.Rows[i].Cells[1].Value.ToString();
                        if (lsp_tmp.ContainsKey(tmp) == false)
                        {
                            lsp_tmp.Add(tmp, 1);
                        }
                        else
                        {
                            lsp_tmp[tmp]++;
                        }
                    }

                    foreach (KeyValuePair<string, int> kvp in lsp_tmp)
                    {
                        Paragraph item = new Paragraph(kvp.Key + ": " + kvp.Value)
                            .SetFont(font)
                            .SetMarginLeft(20); // Thiết lập thụt đầu dòng
                        doc.Add(item);
                    }

                    Paragraph tongtien = new Paragraph("TỔNG SỐ TIỀN THANH TOÁN: " + hoadon.TongTien.ToString("C", culture))
                        .SetFont(font);
                    doc.Add(tongtien);

                    Paragraph ngaythanhtoan = new Paragraph("NGÀY THANH TOÁN: " + hoadon.NgayThanhToan.Date.ToString("dd/MM/yyyy"))
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                        .SetFont(font);
                    doc.Add(ngaythanhtoan);

                    Paragraph phonggym = new Paragraph("----------- PHÒNG GYM HCMUE - NÂNG CAO ĐỜI SỐNG KHÁCH HÀNG -----------")
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFont(font);
                    doc.Add(phonggym);

                    // Tạo mã QR
                    BarcodeWriter qrWriter = new BarcodeWriter();
                    qrWriter.Format = BarcodeFormat.QR_CODE;
                    EncodingOptions options = new EncodingOptions
                    {
                        Width = 100,
                        Height = 100
                    };
                    qrWriter.Options = options;
                    Bitmap qrCodeImage = qrWriter.Write("https://thavananh.github.io/SoftwareSustainIntro/");
                    string qrPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "qrcode.png");
                    qrCodeImage.Save(qrPath, System.Drawing.Imaging.ImageFormat.Png);
                    ImageData qrImageData = ImageDataFactory.Create(qrPath);
                    iText.Layout.Element.Image qrImage = new iText.Layout.Element.Image(qrImageData)
                        .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    doc.Add(qrImage);
                    doc.Close();
                    pdfDoc.Close();
                    isExportRecipe++;
                }
            }
        }

        private void frmSellProducct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExportRecipe <= 0 && dtgDSSP.Rows.Count > 0)
            {
                MessageBox.Show("Vui lòng xuất biên lai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
        }
    }
}
