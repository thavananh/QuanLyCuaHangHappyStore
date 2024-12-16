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
using OpenCvSharp;
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
    public partial class frmEmployeeRegistration : Form
    {
        public frmEmployeeRegistration()
        {
            InitializeComponent();
        }
        NHANVIEN nv = new NHANVIEN();
        NhanVienBLL nvbll = new NhanVienBLL();
        public bool checkupdateanh = false;
        private VideoCaptureDevice videoCapture;
        private FilterInfoCollection filterInfo;
        public static string tenChucNang = "dang_ky_nhan_vien";

        //private void loadLoaiChucVu()
        //{
        //    List<LOAICHUCVU> loaiChucVu = loaiChucVuBLL.ReadLoaiChucVu();
        //    cmbLoaiNhanVienDeXuat.DisplayMember = "TenLoaiChucVu";
        //    cmbLoaiNhanVienDeXuat.ValueMember = "MaLoaiChucVu";
        //    cmbLoaiNhanVienDeXuat.DataSource = loaiChucVu;
        //}

        private void cbJobtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbJobtitle.SelectedItem.ToString() == "LETAN" )
            {
                nv.MaLoaiChucVu = "LETAN";
            }
            else if(cbJobtitle.SelectedItem.ToString() == "HUANLUYENVIEN")
            {
                nv.MaLoaiChucVu = "HUANLUYENVIEN";
            }
            else if (cbJobtitle.SelectedItem.ToString() == "BAOVE")
            {
                nv.MaLoaiChucVu = "BAOVE";
            }
        }
        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn ảnh khách hàng";
            openFile.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf)|*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                checkupdateanh = true;
                ptbAvatar.ImageLocation = openFile.FileName;
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

        bool isAddEmployee = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Vui lòng điền lại họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { nv.Hoten = tbName.Text; }
            if (string.IsNullOrEmpty(tbDOB.Text))
            {
                MessageBox.Show("Vui lòng điền lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DateTime tmp;
                if (DateTime.TryParseExact(tbDOB.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp))
                {
                    nv.Ngaysinh = tmp;
                }
            }
            if (string.IsNullOrEmpty(tbGender.Text))
            {
                MessageBox.Show("Vui lòng điền giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { nv.Gioitinh = tbGender.Text; }
            if (string.IsNullOrEmpty(tbNationId.Text))
            {
                MessageBox.Show("Vui lòng điền lại CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { nv.CMND = (string)tbNationId.Text; }
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("Vui lòng điền lại địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { nv.diaChi = tbAddress.Text; }
            if (string.IsNullOrEmpty(tbPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng điền lại số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { nv.SDT = (string)tbPhoneNumber.Text; }
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Vui lòng điền lại Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { nv.Email = tbEmail.Text; }
            if (string.IsNullOrEmpty(tbNote.Text))
            {
                MessageBox.Show("Vui lòng điền lại ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            { nv.GhiChu = tbNote.Text; }
           
             nv.Anh = imageToByteArray(ptbAvatar);
            
            bool check = nvbll.themNV(nv);
           if(check == true)
            {
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isAddEmployee = true;
            }
            else
            {
                MessageBox.Show("Trùng mã nhân viên rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
                
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            ptbAvatar.Image = (Bitmap)e.Frame.Clone();
        }

        private void frmEmployeeRegistration_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCaptureDevice();
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfo)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            if (cbCamera.Items.Count != 0) { cbCamera.SelectedIndex = 0; }
        }

        private void frmEmployeeRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCapture.Stop();
        }

        private void tbDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space || e.KeyChar == '-')
            {
                this.errorProvider1.SetError(tbDOB, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbDOB, "");
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

        private void SaveQRCodeToFile()
        {
            if (isAddEmployee == false || nv.maNhanVien == null)
            {
                MessageBox.Show("Vui lòng thêm nhân viên trước khi xuất QR", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                this.errorProvider1.SetError(tbName, "Không được nhập số !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbName, "");
            }
        }

        private void tbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbGender, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbGender, "");
            }
        }

        private void tbNationId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbNationId, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbNationId, "");
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                this.errorProvider1.SetError(tbEmail, "Không được nhấn dấu cách !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbEmail, "");
            }
        }
    }
}
