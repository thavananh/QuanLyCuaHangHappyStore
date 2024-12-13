using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Globalization;
using BLL;
using AForge.Video.DirectShow;
using OpenCvSharp;
using AForge.Video;
using ZXing.Common;
using ZXing;
using OpenCvSharp.Detail;

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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        SanPham sp = new SanPham();
        SanPhamBLL spbll = new SanPhamBLL();
        GOITHANHVIEN gt = new GOITHANHVIEN();
        GoiTapBLL gtBLL = new GoiTapBLL();
        ChiPhiBLL cpBLL = new ChiPhiBLL();
        LoaiSanPhamBLL loaiSanPhamBLL = new LoaiSanPhamBLL();
        private byte[] imageToByteArray(PictureBox ptb)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ptb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void ptbProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog moFile = new OpenFileDialog();
            moFile.Title = "Chọn ảnh khách hàng";
            moFile.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf)|*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf";
            if (moFile.ShowDialog() == DialogResult.OK)
            {
                
                ptbProduct.ImageLocation = moFile.FileName;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void loadLoaiSanPham()
        {
            List<LOAISANPHAM> listLoaiSanPham = loaiSanPhamBLL.xemLoaiSanPham();
            LOAISANPHAM temp = new LOAISANPHAM
            {
                MaLoaiSanPham = "Gói thành viên",
                TenLoaiSanPham = "Gói thành viên"
            };
            listLoaiSanPham.Add(temp);
            cbProductType.DisplayMember = "TenLoaiSanPham";
            cbProductType.ValueMember = "MaLoaiSanPham";
            cbProductType.DataSource = listLoaiSanPham;
            cbProductType.SelectedIndex = 0;
        }

        bool isAddProduct = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cbProductType.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbProductType.SelectedValue.ToString() == "Gói thành viên")
            {
                
                if (string.IsNullOrEmpty(tbProductName.Text))
                {
                    MessageBox.Show("Điền tên gói thành viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    gt.TenGoiThanhVien = tbProductName.Text;
                }

                if (tbMembershipDuration.Text.Trim().Length != 0)
                {
                    int thamso;
                    if (int.TryParse(tbMembershipDuration.Text.Trim(), out thamso) == true)
                    {
                        if (thamso <= 0)
                        {
                            MessageBox.Show("Vui lòng nhập số nguyên dương > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            gt.Thang = thamso;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số nguyên dương > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (string.IsNullOrEmpty(tbPrice.Text))
                {
                    MessageBox.Show("Điền giá bán sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    double thamso;
                    if (double.TryParse(tbPrice.Text.Trim(), out thamso) == true)
                    {
                        if (thamso >= 0)
                        {
                            gt.ChiPhi = thamso;
                        }
                        else
                        {
                            MessageBox.Show("Giá bán không thể âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá tiền phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                gt.MaGoiThanhVien = Guid.NewGuid().ToString();
                if (gtBLL.themGoiThanhVien(gt))
                {
                    MessageBox.Show("Thêm gói thành viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm gói thành viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tbProductName.Text))
                {
                    MessageBox.Show("Điền tên Sản Phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    sp.TenSP = tbProductName.Text;
                }
                if (string.IsNullOrEmpty(tbPrice.Text))
                {
                    MessageBox.Show("Điền giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int thamso;
                    if (int.TryParse(tbPrice.Text.Trim(), out thamso) == true)
                    {
                        if (thamso >= 0)
                        {
                            sp.GiaThanh = thamso;
                        }
                        else
                        {
                            MessageBox.Show("Giá bán không thể âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá tiền phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (string.IsNullOrEmpty(tbGiaNhap.Text))
                {
                    MessageBox.Show("Điền giá nhập sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    double thamso;
                    if (double.TryParse(tbGiaNhap.Text.Trim(), out thamso) == true)
                    {
                        if (thamso >= 0)
                        {
                            sp.GiaNhap = thamso;
                        }
                        else
                        {
                            MessageBox.Show("Giá nhập không thể âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá tiền phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (string.IsNullOrEmpty(tbSL.Text))
                {
                    MessageBox.Show("Điền số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int thamso;
                    if (int.TryParse((tbSL.Text), out thamso) == true)
                    {

                        if (thamso >= 0)
                        {
                            sp.SL = thamso;
                        }
                        else
                        {
                            MessageBox.Show("Số lượng không thể âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                sp.Anh = imageToByteArray(ptbProduct);
                sp.LoaiSP = cbProductType.SelectedValue.ToString();
                sp.MaSP = Guid.NewGuid().ToString(); 
                bool addSP = spbll.themSP(sp);
                if (addSP == true)
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAddProduct = true;
                    cpBLL.UpdateChiPhi(sp.GiaNhap);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }
            
        }
        private void cbProductType_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        private VideoCaptureDevice videoCapture;
        private FilterInfoCollection filterInfo;
        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCaptureDevice();
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfo)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            if (cbCamera.Items.Count != 0) { cbCamera.SelectedIndex = 0; }
            tbMembershipDuration.Visible = false;
            lblThoiHanGoi.Visible = false;
            cbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            loadLoaiSanPham();
        }

        bool camera = false;
        private void btnCameraCapture_Click(object sender, EventArgs e)
        {
            if (cbCamera.Items.Count < 0)
            {
                MessageBox.Show("Không tìm thấy camera", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (camera == true)
            {
                videoCapture.Stop();
                camera = false;
            }
            else
            {
                camera = true;
                videoCapture = new VideoCaptureDevice(filterInfo[cbCamera.SelectedIndex].MonikerString);
                videoCapture.NewFrame += videoCapture_NewFrame;
                videoCapture.Start();
            }
            
        }

        private void videoCapture_NewFrame(object sender, NewFrameEventArgs e)
        {
            ptbProduct.Image = (Bitmap)e.Frame.Clone();
        }

        private void tbGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space || (Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122))
            {
                this.errorProvider1.SetError(tbPrice, "Không được nhấn dấu cách hoặc chữ cái !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbPrice, "");
            }
        }

        private void frmAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCapture.Stop();
        }

        private void tbThoiHanGoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space || (Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122))
            {
                this.errorProvider1.SetError(tbMembershipDuration, "Không được nhấn dấu cách hoặc chữ cái !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbMembershipDuration, "");
            }
        }

        private void tbSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space || (Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122))
            {
                this.errorProvider1.SetError(tbSL, "Không được nhấn dấu cách hoặc chữ cái !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbSL, "");
            }
        }

        private void SaveQRCodeToFile()
        {
            if (isAddProduct == false || sp.MaSP == null)
            {
                MessageBox.Show("Vui lòng thêm thiết bị trước khi tạo mã QR cho thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maThe = sp.MaSP;
            // tạo mã QR
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            EncodingOptions options = new EncodingOptions
            {
                Width = 300,
                Height = 300
            };
            writer.Options = options;
            Bitmap qrCodeImage = writer.Write(maThe);
            // Hiển thị SaveFileDialog để chọn vị trí và tên file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Save QR Code";
            saveFileDialog.FileName = "QRCode_" + maThe + ".png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu file
                string filePath = saveFileDialog.FileName;
                qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Lưu mã qr thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportQR_Click(object sender, EventArgs e)
        {
            SaveQRCodeToFile();
        }

        private void tbGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space || (Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122))
            {
                this.errorProvider1.SetError(tbGiaNhap, "Không được nhấn dấu cách hoặc chữ cái !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbGiaNhap, "");
            }
        }

        private void cbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductType.SelectedValue.ToString() == "Gói thành viên")
            {
                tbMembershipDuration.Visible = true;
                lblThoiHanGoi.Visible = true;
                lblSoLuong.Visible = false;
                tbSL.Visible = false;
                tbGiaNhap.Visible = false;
                lblGiaNhap.Visible = false;
                
                this.errorProvider1.SetError(tbSL, "");
                this.errorProvider1.SetError(tbMembershipDuration, "");
            }
            else
            {
                lblSoLuong.Visible = true;
                tbSL.Visible = true;
                lblThoiHanGoi.Visible = false;
                tbMembershipDuration.Visible = false;
                tbGiaNhap.Visible = true;
                lblGiaNhap.Visible = true;
                
                this.errorProvider1.SetError(tbSL, "");
                this.errorProvider1.SetError(tbMembershipDuration, "");
            }
        }
    }
}
