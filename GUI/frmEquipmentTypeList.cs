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
    public partial class frmEquipmentTypeList : Form
    {
        public frmEquipmentTypeList()
        {
            InitializeComponent();
        }
        ThietBiBLL tbbll = new ThietBiBLL();
        private List<THIETBI> lTB = new List<THIETBI>();
        public static string equipmentType { get; set; }
        private void fLoaiThietBi_Load(object sender, EventArgs e)
        {
            loadList();
            autoLoadRow();
        }
        private void loadList()
        {
            lTB = tbbll.xemDSTBtheoloai(equipmentType);
            int i = 0;
            int countbt = 0;
            dgvEquipmentTypeList.Columns.Add("STT", "STT");
            dgvEquipmentTypeList.Columns.Add("MATHIETBI", "Mã thiết bị");
            dgvEquipmentTypeList.Columns.Add("TENTHIETBI", "Tên thiết bị");
            dgvEquipmentTypeList.Columns.Add("SOLUONG", "Số lượng");
            dgvEquipmentTypeList.Columns.Add("DONVI", "Đơn vị");
            dgvEquipmentTypeList.Columns.Add("TINHTRANG", "Tình trạng");
            lblEquipmentCount.Text = lTB.Count.ToString();
            lblEquipmentType.Text = equipmentType;
            dgvEquipmentTypeList.Rows.Clear();
            foreach (THIETBI tb in lTB)
            {
                i++;
                dgvEquipmentTypeList.Rows.Add(i,tb.Mathietbi, tb.Tenthietbi, tb.Soluong, tb.Donvi, tb.Tinhtrang);
                if(tb.Tinhtrang == "BAOTRI")
                {
                    countbt++;
                }    
            }
            lbmaintenanceEquipment.Text = countbt.ToString();
        }

        private void refresh()
        {
            lTB = tbbll.xemDSTBtheoloai(equipmentType);
            int i = 0;
            int countbt = 0;
            lblEquipmentCount.Text = lTB.Count.ToString();
            lblEquipmentType.Text = equipmentType;
            dgvEquipmentTypeList.Rows.Clear();
            foreach (THIETBI tb in lTB)
            {
                i++;
                dgvEquipmentTypeList.Rows.Add(i, tb.Mathietbi, tb.Tenthietbi, tb.Soluong, tb.Donvi, tb.Tinhtrang);
                if (tb.Tinhtrang == "BAOTRI")
                {
                    countbt++;
                }
            }
            lbmaintenanceEquipment.Text = countbt.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvEquipmentTypeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                object value = dgvEquipmentTypeList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value == null)
                {
                    return;
                }
                string maTB = (string)value;
                frmEquipmentInfo ftttb = new frmEquipmentInfo(maTB);
                this.Hide();
                ftttb.ShowDialog();
                this.Show();
            }
        }
        
        private void autoLoadRow()
        {
            while (dgvEquipmentTypeList.Rows.Count < 20)
            {
                dgvEquipmentTypeList.Rows.Add();
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
            save.FileName = "DS" + equipmentType + now.Year.ToString() + now.Month.ToString("D2") + now.Day.ToString("D2") + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString();
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
                    string title = "Danh sách thiết bị " + equipmentType;
                    excel.Workbook.Properties.Title = title;
                    excel.Workbook.Worksheets.Add(title);
                    ExcelWorksheet ws = excel.Workbook.Worksheets[0];
                    ws.Name = title;
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
                    ws.Cells[1, 1].Value = "Thống kê danh sách thiết bị " + equipmentType;
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
                        cell.Value = item;
                        cot++;
                        cell.AutoFitColumns();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
            autoLoadRow();
        }
    }
}
