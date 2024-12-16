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
using ZXing;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing.Common;

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
    public partial class frmEmployeeInfo : Form
    {


        NhanVienBLL nvbll = new NhanVienBLL();
        NHANVIEN nv = new NHANVIEN();
        public bool checkupdateanh = false;
        public static string maNV { get; set; }
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }
        private void LoadThongTin()
        {
            
            nv = nvbll.xemThongTinNV(maNV);
            tbHoTen.Text = nv.Hoten;
            tbMaNV.Text = nv.maNhanVien.ToString();
            tbMaNV.Enabled = false;
            tbNgaysinh.Text = nv.Ngaysinh.ToString("dd/MM/yyyy");
            tbGioiTinh.Text = nv.Gioitinh;
            tbCCCD.Text = nv.CMND.ToString();
            tbDiachi.Text = nv.diaChi;
            tbSDT.Text = nv.SDT.ToString();
            tbEMail.Text = nv.Email;
            tbGHichu.Text = nv.GhiChu;
            tbChucVu.Text = nv.MaLoaiChucVu;
            tbChucVu.Enabled = false;
            using (MemoryStream ms = new MemoryStream(nv.Anh))
            {
                ptbAvatar.Image = Image.FromStream(ms);
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fThongTinNhanvien_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCaptureDevice();
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfo)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            if (cbCamera.Items.Count > 0) { cbCamera.SelectedIndex = 0; }
            LoadThongTin();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHoTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền lại họ tên");
                return;
            }
            else
            { nv.Hoten = tbHoTen.Text; }
            if (string.IsNullOrEmpty(tbNgaysinh.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền lại ngày sinh");
                return;
            }
            else
            {
                DateTime tmp;
                if (DateTime.TryParseExact(tbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp))
                {
                    nv.Ngaysinh = tmp;
                }
                else
                {
                    MessageBox.Show("Vui lòng điền lại ngày sinh");
                    return;
                }
            }
            if (string.IsNullOrEmpty(tbGioiTinh.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền lại giới tính");
                return;
            }   
            else
            { nv.Gioitinh = tbGioiTinh.Text; }
            if (string.IsNullOrEmpty(tbCCCD.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền lại CCCD");
                return;
            }
            else
            { nv.CMND = (string)tbCCCD.Text; }
            if (string.IsNullOrEmpty(tbDiachi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền lại địa chỉ");
                return;
            }
            else
            { nv.diaChi = tbDiachi.Text; }
            if (string.IsNullOrEmpty(tbSDT.Text.Trim()))
            {
                MessageBox.Show("Điền SDT");
                return;
            }
            else
            { nv.SDT = (string)tbSDT.Text; }
            if (string.IsNullOrEmpty(tbEMail.Text.Trim()))
            {
                MessageBox.Show("Điền Số EMAIL");
                return;
            }    
            else
            { nv.Email = tbEMail.Text; }
            if (string.IsNullOrEmpty(tbGHichu.Text.Trim()))
            {
                MessageBox.Show("Điền ghi chú");
                return;
            }    
            else
            { nv.GhiChu = tbGHichu.Text; }
            
            nv.Anh = imageToByteArray(ptbAvatar);    
            
            string getupdate = nvbll.checkcapnhat(nv);
            switch (getupdate)
            {

                case "success":
                    MessageBox.Show("Thay đổi thành công");
                    return;
                case "fail":
                    MessageBox.Show("Thay đổi thất bại");
                    return;
            }
        }

        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog moFile = new OpenFileDialog();
            moFile.Title = "Chọn ảnh khách hàng";
            moFile.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf)|*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf";
            if (moFile.ShowDialog() == DialogResult.OK)
            {
                checkupdateanh = true;
                ptbAvatar.ImageLocation = moFile.FileName;
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

        //private void btnXuatThongtin_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    bool check = nvbll.XoaNV(maNV);
        //    if (check == true)
        //    {
        //        MessageBox.Show("Xóa thất bại");
        //    }
        //    else { MessageBox.Show("Xóa thành công"); }

        //}

        private VideoCaptureDevice videoCapture;
        private FilterInfoCollection filterInfo;
        bool camera = false;
        private void btnCameraCapture_Click(object sender, EventArgs e)
        {
            if (cbCamera.Items.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy camera");
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
            ptbAvatar.Image = (Bitmap)e.Frame.Clone();
        }

        private void SaveQRCodeToFile()
        {
            string maThe = nv.maNhanVien;
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

        private void frmEmployeeInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCapture.Stop();
        }
    }
}
