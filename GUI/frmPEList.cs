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
using OfficeOpenXml;
using System.IO;

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
    public partial class frmPEList : Form
    {
        public frmPEList()
        {
            InitializeComponent();
        }
        public static string tenChucNang = "danh_sach_vat_dung_cua_hang";
        

        
        ThietBiBLL tbbll = new ThietBiBLL();
        LoaiThietBiBLL loaiThietBiBLL = new LoaiThietBiBLL();
        private string loaitb;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private List<THIETBI> lTB = new List<THIETBI>();
        
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            frmAddEquipment fttb = new frmAddEquipment();
            this.Hide();
            fttb.ShowDialog();
            this.Show();
        }

        private void frmPeList_Load(object sender, EventArgs e)
        {
            loadList();
            autoLoadRow();
            loadLoaiThietBi();
        }
        private void loadLoaiThietBi()
        {
            List<LOAITHIETBI> listLoaiThietBi = new List<LOAITHIETBI>();
            listLoaiThietBi = loaiThietBiBLL.xemLoaiThietBi();
            cmbEquipmentType.DisplayMember = "TenLoaiThietBi";
            cmbEquipmentType.ValueMember = "MaLoaiThietBi";
            cmbEquipmentType.DataSource = listLoaiThietBi;
            
        }
        private void loadList()
        {
            lTB = tbbll.xemTB();
            dgvEquipment.Columns.Add("MATHIETBI", "Mã thiết bị");
            dgvEquipment.Columns.Add("TENTHIETBI", "Tên thiết bị");
            dgvEquipment.Columns.Add("SOLUONG", "Số lượng");
            dgvEquipment.Columns.Add("DONVI", "Đơn vị");
            dgvEquipment.Columns.Add("TINHTRANG", "Tình trạng");
            tbTotalEquipment.Text = lTB.Count.ToString();
            foreach (THIETBI tb in lTB)
            {
                dgvEquipment.Rows.Add(tb.Mathietbi,tb.Tenthietbi, tb.Soluong, tb.Donvi, tb.Tinhtrang);
            }
            int count = 0;
            for (int i = 0; i < lTB.Count; i++)
            {
                if (lTB[i].Tinhtrang == "BAOTRI")
                {
                    count++;
                }
            }
            tbMaintenanceEquipment.Text = count.ToString();
        }
        private void refreshData()
        {
            dgvEquipment.Rows.Clear();
            List<THIETBI> lTB = new List<THIETBI>();
            
            lTB = tbbll.xemTB();
            tbTotalEquipment.Text = lTB.Count.ToString();
            foreach (THIETBI tb in lTB)
            {
                dgvEquipment.Rows.Add(tb.Mathietbi, tb.Tenthietbi, tb.Soluong, tb.Donvi, tb.Tinhtrang);
            }
            int count = 0;
            for (int i = 0; i < lTB.Count; i++)
            {
                if (lTB[i].Tinhtrang == "BAOTRI")
                {
                    count++;
                }
            }
            tbMaintenanceEquipment.Text = count.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
            autoLoadRow();
        }

        private void btnMaintenanceEquipmentList_Click(object sender, EventArgs e)
        { 
            List<THIETBI> lTBBT = new List<THIETBI>();
            dgvEquipment.Rows.Clear();
            lTBBT = tbbll.xemTBBT();
            tbMaintenanceEquipment.Text = lTBBT.Count.ToString();
            foreach (THIETBI tb in lTBBT)
            {
                dgvEquipment.Rows.Add(tb.Mathietbi, tb.Tenthietbi, tb.Soluong, tb.Donvi, tb.Tinhtrang);
            }
            autoLoadRow();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string filepath = "";
            
            //Tạo saveDiaglouge
            SaveFileDialog save = new SaveFileDialog();
            //file filter
            save.Filter = "Excel Workbook|*.xlsx ";
            DateTime now  = DateTime.Now;
            save.FileName = "DSTB" + now.Year.ToString() + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString(); 
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
                    excel.Workbook.Properties.Title = "Danh sách thiết bị";
                    excel.Workbook.Worksheets.Add("Danh sách thiết bị");
                    ExcelWorksheet ws = excel.Workbook.Worksheets[0];
                    ws.Name = "Danh sách thiết bị";
                    ws.Cells.Style.Font.Size = 13;
                    ws.Cells.Style.Font.Name = "Tahoma";
                    string[] arrColumnheader =
                    {
                        "Mã thiết bị",
                        "Tên thiết bị",
                        "Tình trạng"                      
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
                        cell.AutoFitColumns();

                        cell.Value = item;
                        cot++;
                    }
                    foreach (var item in lTB)
                    {
                        cot = 1;
                        hang++;
                        ws.Cells[hang, cot++].Value = item.Mathietbi;
                        ws.Cells[hang, cot++].Value = item.Tenthietbi;
                        ws.Cells[hang, cot++].Value = item.Tinhtrang;
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

        private void cbEquipmentType_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        

        private void dgvEquipment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                object value = dgvEquipment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value == null)
                {
                    return;
                }
                string equipmentId = (string)value;
                frmEquipmentInfo equipmentInfo = new frmEquipmentInfo(equipmentId);
                this.Hide();
                equipmentInfo.ShowDialog();
                this.Show();
            }
        }

        private void autoLoadRow()
        {
            while (dgvEquipment.Rows.Count < 20)
            {
                dgvEquipment.Rows.Add();
            }
        }

        private void modifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvEquipment.CurrentRow.Index;
            if (dgvEquipment.Rows[i].Cells[0].Value == null)
            {
                return;
            }
            frmEquipmentInfo ftttb = new frmEquipmentInfo(dgvEquipment.Rows[i].Cells[0].Value.ToString());
            this.Hide();
            ftttb.ShowDialog();
            this.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dgvEquipment.CurrentRow.Index;
            if (dgvEquipment.Rows[i].Cells[0].Value == null)
            {
                return;
            }
            if (tbbll.XoaThongTinThietBi(dgvEquipment.Rows[i].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Xóa thông tin thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thông tin thiết bị thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            refreshData();
            autoLoadRow();
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
                    string tbID = value.ToString();
                    if (tbbll.ifEquipmentInDB(tbID) <= 0)
                    {
                        MessageBox.Show("Vật dụng cửa hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    frmEquipmentInfo equipmentInfo = new frmEquipmentInfo(tbID);
                    this.Hide();
                    equipmentInfo.ShowDialog();
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void cmbEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEquipment.Rows.Clear();
            List<THIETBI> listLoaiThietBi = new List<THIETBI>();
            listLoaiThietBi = tbbll.xemDSTBtheoloai(cmbEquipmentType.SelectedValue.ToString());
            tbTotalEquipment.Text = lTB.Count.ToString();
            foreach (THIETBI tb in listLoaiThietBi)
            {
                dgvEquipment.Rows.Add(tb.Mathietbi, tb.Tenthietbi, tb.Soluong, tb.Donvi, tb.Tinhtrang);
            }
            int count = 0;
            for (int i = 0; i < lTB.Count; i++)
            {
                if (lTB[i].Tinhtrang == "BAOTRI")
                {
                    count++;
                }
            }
            tbMaintenanceEquipment.Text = count.ToString();
            autoLoadRow();
        }
    }
}
