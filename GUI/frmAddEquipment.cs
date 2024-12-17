using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class frmAddEquipment : Form
    {
        public frmAddEquipment()
        {
            InitializeComponent();
            loadThietBi();
            
        }

        public static string tenChucNang = "them_vat_dung";

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        THIETBI tb = new THIETBI();
        ThietBiBLL tbll = new ThietBiBLL();
        LoaiThietBiBLL loaiThietBiBLL = new LoaiThietBiBLL();
        private bool ptbClicked = false;

        bool isAddEquipment = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbEquipmentType.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn loại thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEquipmentCondition.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn tình trạng thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tbEquipmentName.Text))
            {
                MessageBox.Show("Nhập tên thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                tb.Tenthietbi = tbEquipmentName.Text;
            }
            tb.Anh = imageToByteArray(ptbEquipment);
            tb.Loaithietbi = cbEquipmentType.SelectedValue.ToString();
            bool getinsert = tbll.themdulieu(tb);
            switch(getinsert)
            {
                case true:
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isAddEquipment = true;
                    return;
                case false:
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
        }

        private void loadThietBi()
        {
            List<LOAITHIETBI> listLoaiThietBi = loaiThietBiBLL.xemLoaiThietBi();
            cbEquipmentType.DataSource = listLoaiThietBi;
            cbEquipmentType.DisplayMember = "TenLoaiThietBi";
            cbEquipmentType.ValueMember = "MaLoaiThietBi";
            
        }

        private byte[] imageToByteArray(PictureBox ptb)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ptb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void ptbTB_Click(object sender, EventArgs e)
        {
            OpenFileDialog moFile = new OpenFileDialog();
            moFile.Title = "Chọn ảnh khách hàng";
            moFile.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf)|*.gif;*.jpg;*.jpeg;*.bmp;*.png;*.wmf";
            if (moFile.ShowDialog() == DialogResult.OK)
            {
                ptbClicked = true;
                ptbEquipment.ImageLocation = moFile.FileName;
            }
        }

        private void cmbloaithietbi_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbEquipmentCondition.SelectedItem.ToString() == "TOT")
            {
                tb.Tinhtrang = "TOT";
            }
            else if (cbEquipmentCondition.SelectedItem.ToString() == "BAOTRI")
            {
                tb.Tinhtrang = "BAOTRI";
            }
        }

        private VideoCaptureDevice videoCapture;
        private FilterInfoCollection filterInfo;
        bool cameraCapture = false;
        private void btnCameraCapture_Click(object sender, EventArgs e)
        {
            if (cbCamera.Items.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy camera", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cameraCapture == true)
            {
                videoCapture.Stop();
                cameraCapture = false;
            }
            else
            {
                cameraCapture = true;
                videoCapture = new VideoCaptureDevice(filterInfo[cbCamera.SelectedIndex].MonikerString);
                videoCapture.NewFrame += videoCapture_NewFrame;
                videoCapture.Start();
            }
        }

        private void videoCapture_NewFrame(object sender, NewFrameEventArgs e)
        {
            ptbEquipment.Image = (Bitmap)e.Frame.Clone();
        }

        private void frmAddEquipment_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCaptureDevice();
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfo)
            {
                cbCamera.Items.Add(filterInfo.Name);
            }
            if (cbCamera.Items.Count > 0) { cbCamera.SelectedIndex = 0; }
        }

        private void frmAddEquipment_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCapture.Stop();
        }

        private void SaveQRCodeToFile()
        {
            if (isAddEquipment == false || tb.Mathietbi == null)
            {
                MessageBox.Show("Vui lòng thêm thiết bị trước khi tạo mã QR cho thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maThe = tb.Mathietbi;
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

        private void cbEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEquipmentType.SelectedItem != null)
            {
                tb.Loaithietbi = cbEquipmentType.SelectedItem.ToString();
            }
        }
    }
}
