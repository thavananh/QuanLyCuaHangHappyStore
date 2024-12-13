using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using iText;
using iText.Kernel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Globalization;
using BLL;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Geom;
using iText.License;
using AForge.Video;
using AForge.Video.DirectShow;
using OpenCvSharp;
using OpenCvSharp.Dnn;
using OpenCvSharp.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.IO.Image;
using ZXing.Common;
using ZXing;
using iText.Commons.Utils;

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
    public partial class frmMemberRegistrationForm : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public frmMemberRegistrationForm()
        {
            InitializeComponent();
            loadGoiThanhVien();
        }
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        KHBLL kHBLL = new KHBLL();
        BienlaiBLL blbll = new BienlaiBLL();
        GoiTapBLL gtbll = new GoiTapBLL();
        KHACHHANG kh = new KHACHHANG();
        private int isCustomerRegister = 0;
        private int isExportRecipe = 0;
        Net faceNet, ageNet, genderNet;
        string[] ageList = { "0-2", "4-6", "8-12", "15-20", "25-32", "38-43", "48-53", "60-80" };
        string[] genderList = { "NAM", "NU" };
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isCustomerRegister == 0)
            {
                this.Hide();
                videoCaptureDevice.Stop();
            }
            else
            {
                if (isExportRecipe != 0)
                {
                    this.Hide();
                    videoCaptureDevice.Stop();
                }
                else
                {
                    MessageBox.Show("Chưa xuất biên lai cho khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        ImageFormat imgF;

        private void loadGoiThanhVien()
        {
            List<String> goiTap = gtbll.xemGoiThanhVien();
            cbMembership.DataSource = goiTap;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tbFullName.Text))
            { kh.Hoten = tbFullName.Text; }
            if (!string.IsNullOrEmpty(tbDOB.Text))
            {
                DateTime tmp;
                if (DateTime.TryParseExact(tbDOB.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp))
                {
                    kh.Ngaysinh = tmp;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (cmbGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return;
            }
            
            if (cbMembership.SelectedIndex != -1 && cbMembership.Visible == true)
            {
                kh.MaGoiThanhVien = cbMembership.SelectedItem.ToString();
            }
            if (!string.IsNullOrEmpty(tbNationalId.Text))
            { kh.CMND = tbNationalId.Text; }
            if (!string.IsNullOrEmpty(tbAddress.Text))
            { kh.diaChi = tbAddress.Text; }
            if (!string.IsNullOrEmpty(tbPhoneNumber.Text))
            { kh.SDT = tbPhoneNumber.Text; }
            if (!string.IsNullOrEmpty(tbEMail.Text))
            { kh.Email = tbEMail.Text; }
            if (!string.IsNullOrEmpty(tbNote.Text))
            { kh.GhiChu = tbNote.Text; }
            DateTime currentTime = DateTime.Now;
            kh.NgayBatDau = currentTime;
            string seconds = Math.Round((currentTime.Year * 525948.766 + currentTime.Month * 43829.0639 + currentTime.Day * 1440) / (1000)).ToString();
            kh.Seconds = seconds;
            kh.NgayHetHan = kh.NgayBatDau.AddMonths(gtbll.layThangGoiThanhVien(kh.MaGoiThanhVien));
            if (!string.IsNullOrEmpty(tbMembershipDuration.Text.Trim()))
            {
                DateTime tmp;
                if (DateTime.TryParseExact(tbMembershipDuration.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp))
                {
                    kh.ThoiHan = tmp;
                }
                else
                {
                    MessageBox.Show("Nhập lại Thời hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            kh.Anh = imageToByteArray(ptbAvatar);
            string getupdate = kHBLL.CheckthemKH(kh);
            switch (getupdate)
            {
                case "success":
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isCustomerRegister++;
                    return;
                case "fail":
                    MessageBox.Show("Trùng mã thẻ rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "Nhapnbd":
                    MessageBox.Show("Vui lòng nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "Sailoai":
                    MessageBox.Show("Sai gói tập rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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

        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog moFile = new OpenFileDialog();
            moFile.Title = "Chọn ảnh khách hàng";
            moFile.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf)|*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf";
            if (moFile.ShowDialog() == DialogResult.OK)
            {
                ptbAvatar.ImageLocation = moFile.FileName;
            }

        }

        private void btnXuatBienLai_Click(object sender, EventArgs e)
        {
            if (isCustomerRegister == 0)
            {
                MessageBox.Show("Vui lòng lưu thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BIENLAI pienlai = new BIENLAI();
                pienlai = blbll.xemBienlai();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Chọn đường dẫn lưu biên lai";
                saveFileDialog.Filter = "Tệp tin PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    PdfWriter writer = new PdfWriter(path);
                    PdfDocument pdfDoc = new PdfDocument(writer);
                    Document doc = new Document(pdfDoc);

                    // Tải phông chữ tiếng Việt
                    string fontPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
                    PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                    Paragraph heading = new Paragraph("BIÊN LAI")
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFontSize(40)
                        .SetFont(font);
                    doc.Add(heading);

                    Paragraph mabl = new Paragraph("MÃ BIÊN LAI: " + pienlai.MaBienLai)
                        .SetFont(font);
                    doc.Add(mabl);

                    Paragraph magoitap = new Paragraph("MÃ GÓI THÀNH VIÊN: " + pienlai.MaGoiThanhVien)
                        .SetFont(font);
                    doc.Add(magoitap);

                    Paragraph tongtien = new Paragraph("TỔNG SỐ TIỀN THANH TOÁN: " + pienlai.TongTien.ToString() + " vnd")
                        .SetFont(font);
                    doc.Add(tongtien);

                    Paragraph ngaythanhtoan = new Paragraph("NGÀY THANH TOÁN: " + pienlai.NgayThanhToan.Date.ToString("dd/MM/yyyy"))
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                        .SetFont(font);
                    doc.Add(ngaythanhtoan);

                    Paragraph phonggym = new Paragraph("----------- HAPPYSTORE - LUÔN LÀM HÀI LÒNG KHÁCH HÀNG -----------")
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


        private void LoadModels()
        {
            string modelDir = AppDomain.CurrentDomain.BaseDirectory + "models\\";
            faceNet = CvDnn.ReadNetFromTensorflow(modelDir + "opencv_face_detector_uint8.pb", modelDir + "opencv_face_detector.pbtxt");
            ageNet = CvDnn.ReadNetFromCaffe(modelDir + "age_deploy.prototxt", modelDir + "age_net.caffemodel");
            genderNet = CvDnn.ReadNetFromCaffe(modelDir + "gender_deploy.prototxt", modelDir + "gender_net.caffemodel");
        }

        private void btnCameraCapture_Click(object sender, EventArgs e)
        {
            openCVAgeGenderDetection();
        }

        private void SaveQRCodeToFile()
        {
            if (isCustomerRegister <= 0 || kh.Mathe == "0") { MessageBox.Show("Vui lòng tạo tài khoản trước khi xuất QR", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            string maThe = kh.Mathe;
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

        private void tbDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space || e.KeyChar == '-')
            {
                this.errorProvider1.SetError(tbDOB, "Không được nhấn dấu cách hoặc dấu '-'. Hãy nhập ngày sinh theo cú pháp sau ngày/tháng/năm !!!");
                e.Handled = true;
            }
            else
            {
                this.errorProvider1.SetError(tbDOB, "");
            }
        }

        private void cmbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGioiTinh.SelectedItem.ToString() == "NAM")
            {
                kh.Gioitinh = "NAM";
            }
            else
            {
                kh.Gioitinh = "NU";
            }
        }

        private void openCVAgeGenderDetection()
        {
            var capture = new OpenCvSharp.VideoCapture(cboCameraSelect.SelectedIndex);
            if (!capture.IsOpened())
            {
                Console.WriteLine("Không thể mở camera!");
                return;
            }
            var window = new OpenCvSharp.Window("Age Gender Detection");
            while (true)
            {
                Mat frame = new OpenCvSharp.Mat();
                capture.Read(frame);

                if (frame.Empty())
                    break;

                // Tạo một bản sao của khung hình gốc để ptbAvatar sử dụng
                Mat originalFrame = frame.Clone();

                // Phát hiện khuôn mặt
                var blob = CvDnn.BlobFromImage(frame, 1.0, new OpenCvSharp.Size(300, 300), new OpenCvSharp.Scalar(104, 117, 123), false, false);
                faceNet.SetInput(blob);
                var detections = faceNet.Forward();

                for (int i = 0; i < detections.Size(2); i++)
                {
                    float confidence = detections.At<float>(0, 0, i, 2);

                    if (confidence > 0.7)
                    {
                        int x1 = Math.Max(0, (int)(detections.At<float>(0, 0, i, 3) * frame.Cols));
                        int y1 = Math.Max(0, (int)(detections.At<float>(0, 0, i, 4) * frame.Rows));
                        int x2 = Math.Min(frame.Cols - 1, (int)(detections.At<float>(0, 0, i, 5) * frame.Cols));
                        int y2 = Math.Min(frame.Rows - 1, (int)(detections.At<float>(0, 0, i, 6) * frame.Rows));

                        Rect faceRect = new OpenCvSharp.Rect(new OpenCvSharp.Point(x1, y1), new OpenCvSharp.Size(x2 - x1, y2 - y1));

                        // Kiểm tra kích thước của Rect trước khi cắt ảnh
                        if (faceRect.Width > 0 && faceRect.Height > 0)
                        {
                            Mat face = new OpenCvSharp.Mat(frame, faceRect);

                            // Chuẩn hóa dữ liệu đầu vào cho mô hình giới tính
                            var genderBlob = CvDnn.BlobFromImage(face, 1.0, new OpenCvSharp.Size(227, 227), new OpenCvSharp.Scalar(104, 117, 123), false, false);
                            genderNet.SetInput(genderBlob);
                            var genderPreds = genderNet.Forward();
                            Cv2.MinMaxLoc(genderPreds, out double minVal, out double maxVal, out OpenCvSharp.Point minLoc, out OpenCvSharp.Point maxLoc);
                            int genderIndex = maxLoc.X;
                            string gender = genderList[genderIndex];

                            // Chuẩn hóa dữ liệu đầu vào cho mô hình tuổi
                            var ageBlob = CvDnn.BlobFromImage(face, 1.0, new OpenCvSharp.Size(227, 227), new OpenCvSharp.Scalar(104, 117, 123), false, false);
                            ageNet.SetInput(ageBlob);
                            var agePreds = ageNet.Forward();
                            Cv2.MinMaxLoc(agePreds, out minVal, out maxVal, out minLoc, out maxLoc);
                            int ageIndex = maxLoc.X;
                            string age = ageList[ageIndex];

                            Cv2.Rectangle(frame, faceRect, Scalar.Green, 2);
                            Cv2.PutText(frame, $"{gender}, {age}", new OpenCvSharp.Point(x1, y1 - 10), HersheyFonts.HersheySimplex, 0.9, Scalar.Red, 2);
                        }
                    }
                }
                window.ShowImage(frame);
                ptbAvatar.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(originalFrame);
                int key = Cv2.WaitKey(1);
                if (key == 27 || key==25) // ESC key to break
                    break;
            }
            capture.Release();
            capture.Dispose();
            Cv2.DestroyAllWindows();
        }


        private void frmMemberRegistrationForm_Load(object sender, EventArgs e)
        {
            LoadModels();
            cmbGioiTinh.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboCameraSelect.Items.Add(filterInfo.Name);
            }
            cboCameraSelect.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }
    }
}
