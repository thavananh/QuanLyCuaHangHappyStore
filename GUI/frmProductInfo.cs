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
using System.Windows.Forms;
using DTO;
using System.Globalization;
using BLL;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing.Common;
using ZXing;

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
    public partial class frmProductInfo : Form
    {
        public frmProductInfo()
        {
            InitializeComponent();
        }
        public static string masp { get; set; }
        SanPhamBLL spbll = new SanPhamBLL();
        SanPham sp = new SanPham();
        bool checkluuanh = false;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbProductType.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

                if (int.TryParse(tbPrice.Text, out thamso) == true)
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

            if (string.IsNullOrEmpty(tbNOP.Text))
            {
                MessageBox.Show("Điền số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int thamso;
                if (int.TryParse((tbNOP.Text), out thamso) == true)
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
                    MessageBox.Show("Số lượng phải là số nguyên dương ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            sp.Anh = imageToByteArray(ptbProduct);
            string getupdate = spbll.updateSP(sp);
            if(getupdate == "success")
            {
                MessageBox.Show("Update sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(getupdate == "fail")
            {
                MessageBox.Show("Update sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
        }

        private void frmProductInfo_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCaptureDevice();
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfo)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            if (cbCamera.Items.Count > 0) { cbCamera.SelectedIndex = 0; }
            loadProduct();
        }
        private void loadProduct()
        {
            sp = spbll.xemSP(masp);
            if(sp.LoaiSP == "DUNGCU")
            {
                string temp = "Dụng cụ hỗ trợ";
                cbProductType.SelectedItem = temp;
            }
            if(sp.LoaiSP == "THUCPHAM")
            {
                string temp = "Thực phẩm";
                cbProductType.SelectedItem = temp;
            }
            tbProductName.Text = sp.TenSP;
            tbProductId.Text = sp.MaSP;
            tbProductId.Enabled = false;
            tbPrice.Text = sp.GiaThanh.ToString();
            tbNOP.Text = sp.SL.ToString();
            using (MemoryStream ms = new MemoryStream(sp.Anh))
            {
                ptbProduct.Image = Image.FromStream(ms);
            }

        }
        private byte[] imageToByteArray(PictureBox ptb)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                /*ptb.Image.Save(ms, ptb.Image.RawFormat);*/ // Thay đổi định dạng ảnh nếu cần thiết
                ptb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void ptbProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Chọn ảnh khách hàng";
            fileOpen.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf)|*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf";
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                checkluuanh = true;
                ptbProduct.ImageLocation = fileOpen.FileName;
            }
        }

        private VideoCaptureDevice videoCapture;
        private FilterInfoCollection filterInfo;
        bool camera = false;
        private void btnCameraCapture_Click(object sender, EventArgs e)
        {
            if (cbCamera.Items.Count <= 0)
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
                videoCapture = new VideoCaptureDevice(filterInfo[cbCamera.SelectedIndex].MonikerString);
                videoCapture.NewFrame += videoCapture_NewFrame;
                videoCapture.Start();
                camera = true;
            }
        }

        private void videoCapture_NewFrame(object sender, NewFrameEventArgs e)
        {
            ptbProduct.Image = (Bitmap)e.Frame.Clone();
        }

        private void SaveQRCodeToFile()
        {
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

        private void frmProductInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCapture.Stop();
        }
    }
}
