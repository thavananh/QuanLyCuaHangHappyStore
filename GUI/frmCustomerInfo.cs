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
using ZXing.Common;
using ZXing;
using AForge.Video.DirectShow;
using AForge.Video;

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
    public partial class frmCustomerInfo : Form
    {
        public static string  mathe { get; set; }
     
        KHBLL khbll = new KHBLL();
        KHACHHANG kh = new KHACHHANG();
        PictureBox ptb_copy = new PictureBox();
        GoiTapBLL gtbll = new GoiTapBLL();
        public frmCustomerInfo()
        {
            InitializeComponent();
            
        }
        private bool btnRemoveImgClick = false;
        private bool ptbClicked = false;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void loadInfo()
        {
            DateTime datenow = DateTime.Now;
            kh = khbll.xemThongTinKH(mathe);
            tbCustomerName.Text = kh.Hoten;
            tbCustomerId.Text = kh.Mathe.ToString();
            tbCustomerId.Enabled = false;
            tbDOB.Text = kh.Ngaysinh.Date.ToString("dd/MM/yyyy");
            tbGender.Text = kh.Gioitinh;
            tbGender.Enabled = false;
            tbNationalId.Text = kh.CMND;
            tbAddress.Text = kh.diaChi;
            tbPhoneNumber.Text = kh.SDT;
            tbEMail.Text = kh.Email;
            List<string> listGoitap = gtbll.xemGoiThanhVien();
            foreach (string item in listGoitap)
            {
                cbType.Items.Add(item);
            }
            cbType.SelectedItem = kh.MaGoiThanhVien;


            tbRegisterMembershipDate.Text = kh.NgayBatDau.Date.ToString("dd/MM/yyyy");
            tbEndMembershipDate.Text = kh.NgayHetHan.Date.ToString("dd/MM/yyyy");
            tbPTDate.Text = kh.ThoiHan.Date.ToString("dd/MM/yyyy");
            
            if(kh.ThoiHan == new DateTime(2000,1,1))
            {
                tbPTDate.Text = "0";
            }
            using (MemoryStream ms = new MemoryStream(kh.Anh))
            {
                ptbAvatar.Image = Image.FromStream(ms);
            }   
        }
        private void XoathongtinKH()
        {
            bool check = khbll.xoathongtinKH(mathe);
            if (check == true)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tiếp tục?", "Xác nhận", MessageBoxButtons.OKCancel);
            {
                if (result == DialogResult.OK)
                {
                    XoathongtinKH();
                    this.Hide();
                }
            }
        }

        

        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCaptureDevice();
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfo)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            if (cbCamera.Items.Count > 0) { cbCamera.SelectedIndex = 0; }
            DateTime datenow = DateTime.Now;
            loadInfo();
            if (kh.NgayHetHan < datenow)
            {
                MessageBox.Show("Khách hàng đã hết hạn sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModified_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(tbCustomerName.Text.Trim()))
            { kh.Hoten = tbCustomerName.Text.Trim(); }
            if (!string.IsNullOrEmpty(tbDOB.Text))
            {
                if (tbDOB.Text.Trim() != kh.Ngaysinh.Date.ToString("dd/MM/yyyy"))
                {
                    DateTime tmp;
                    if (DateTime.TryParseExact(tbDOB.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp))
                    {

                        kh.Ngaysinh = tmp;
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                }
            }
            if (!string.IsNullOrEmpty(tbNationalId.Text.Trim()))
            { kh.CMND = tbNationalId.Text; }
            if (!string.IsNullOrEmpty(tbAddress.Text.Trim()))
            { kh.diaChi = tbAddress.Text.Trim(); }
            if (!string.IsNullOrEmpty(tbPhoneNumber.Text))
            { kh.SDT = tbPhoneNumber.Text; }
            if (!string.IsNullOrEmpty(tbEMail.Text))
            { kh.Email = tbEMail.Text; }
            if (!string.IsNullOrEmpty(tbCustomerNote.Text.Trim()))
            { kh.GhiChu = tbCustomerNote.Text.Trim(); }
            if (cbType.SelectedIndex != -1)
            {
                kh.MaGoiThanhVien = cbType.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn gói tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            
            
            if (tbRegisterMembershipDate.Text != kh.NgayBatDau.Date.ToString("dd/MM/yyyy"))
            {
                if (!string.IsNullOrEmpty(tbRegisterMembershipDate.Text))
                {
                    DateTime tmp;
                    if (DateTime.TryParseExact(tbRegisterMembershipDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp))
                    {

                        if (tmp < kh.NgayHetHan)
                        {
                            MessageBox.Show("Nhập lại ngày đăng kí gói tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            kh.NgayBatDau = tmp;
                            kh.NgayHetHan = kh.NgayBatDau.AddMonths(gtbll.layThangGoiThanhVien(kh.MaGoiThanhVien));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại ngày đăng kí gói tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                }
            }
            
            if(!string.IsNullOrEmpty(tbPTDate.Text))
            {
                  DateTime tmp;
                  if (DateTime.TryParseExact(tbRegisterMembershipDate.Text, "dd/MM/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None, out tmp))
                  {

                      kh.ThoiHan = tmp;
                  }
                  else
                  {
                      MessageBox.Show("Nhập lại ngày đăng kí gói tập", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                      return;

                  }
                
            }    
            //if (ptbClicked == true)
            //{
            //    kh.Anh = imageToByteArray(ptbAvatar);

            //}
            //else if (btnRemoveImgClick == true)
            //{
            //    kh.Anh = imageToByteArray(ptbAvatar);
            //}
            kh.Anh = imageToByteArray(ptbAvatar);
            string updateKH = khbll.checkcapnhatKH(kh);
            switch(updateKH)
            {
                case "success":
                    MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "fail":
                    MessageBox.Show("Thay đổi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
        }

        private void btnXoaanh_Click(object sender, EventArgs e)
        {
            btnRemoveImgClick = true;
            ptbAvatar.ImageLocation = "C:/ path / to / avatar_unknow.jpg";

        }
        

        private void ptbAvatar_Click(object sender, EventArgs e)
        {   
            OpenFileDialog moFile = new OpenFileDialog();
            moFile.Title = "Chọn ảnh khách hàng";
            moFile.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf)|*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf";
            if (moFile.ShowDialog() == DialogResult.OK)
            {
                ptbClicked = true;
                
                ptbAvatar.ImageLocation = moFile.FileName;
               

            }
        }
        private byte[] imageToByteArray(PictureBox ptb)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ptb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void SaveQRCodeToFile()
        {
            string maT = mathe;
            // tạo mã QR
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            EncodingOptions options = new EncodingOptions
            {
                Width = 300,
                Height = 300
            };
            writer.Options = options;
            Bitmap qrCodeImage = writer.Write(maT);
            // Hiển thị SaveFileDialog để chọn vị trí và tên file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Save QR Code";
            saveFileDialog.FileName = "QRCode_"+maT+".png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu file
                string filePath = saveFileDialog.FileName;
                qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show("Lưu mã qr thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExportQr_Click(object sender, EventArgs e)
        {
            SaveQRCodeToFile();
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
            ptbAvatar.Image = (Bitmap)e.Frame.Clone();
        }

        private void tbDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbDOB, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbDOB, "");
            }
        }

        private void tbNationalId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbNationalId, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbNationalId, "");
            }
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbPhoneNumber, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbPhoneNumber, "");
            }
        }

        private void tbEMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbEMail, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbEMail, "");
            }
        }

        private void tbRegisterMembershipDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbEMail, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbEMail, "");
            }
        }

        private void tbEndMembershipDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbEndMembershipDate, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbEndMembershipDate, "");
            }
        }

        private void tbPTDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbPTDate, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbPTDate, "");
            }
        }

        private void frmCustomerInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCapture.Stop();
        }
    }
}
