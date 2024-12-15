using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmAddEmployeeType : Form
    {
        public frmAddEmployeeType()
        {
            InitializeComponent();
        }

        LoaiChucVuBLL loaiChucVuBLL = new LoaiChucVuBLL();
        LOAICHUCVU loaiChucVu = new LOAICHUCVU();

        private void loadLoaiChucVu()
        {
            List<LOAICHUCVU> loaiChucVu = loaiChucVuBLL.ReadLoaiChucVu();
            cmbLoaiNhanVienDeXuat.DisplayMember = "TenLoaiChucVu";
            cmbLoaiNhanVienDeXuat.ValueMember = "MaLoaiChucVu";
            cmbLoaiNhanVienDeXuat.DataSource = loaiChucVu;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            loaiChucVu.MaLoaiChucVu = Guid.NewGuid().ToString();
            if (cmbLoaiNhanVienDeXuat.SelectedItem.ToString() != "Tự đề xuất loại nhân viên")
            {
                loaiChucVu.TenLoaiChucVu = cmbLoaiNhanVienDeXuat.SelectedItem.ToString();
                bool isTHemLoaiThietBi = loaiChucVuBLL.CreateLoaiChucVu(loaiChucVu);
                if (isTHemLoaiThietBi)
                {
                    MessageBox.Show("Thêm loại chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm loại chức vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (tbLoaiChucVu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Loại chức vụ không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string pattern = @"[@#$%^&*!]"; // Mẫu kiểm tra các ký tự đặc biệt
                // Kiểm tra nếu chuỗi chứa ít nhất một trong các ký tự đặc biệt
                bool containsSpecialChar = Regex.IsMatch(tbLoaiChucVu.Text.Trim(), pattern);

                if (containsSpecialChar)
                {
                    MessageBox.Show("Vui lòng đặt tên loại chức vụ không có các ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                loaiChucVu.TenLoaiChucVu = tbLoaiChucVu.Text.Trim();
                bool isTHemLoaiThietBi = loaiChucVuBLL.CreateLoaiChucVu(loaiChucVu);
                if (isTHemLoaiThietBi)
                {
                    MessageBox.Show("Thêm loại chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm loại chức vụ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbLoaiNhanVienDeXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiNhanVienDeXuat.SelectedItem.ToString() == "Tự đề xuất loại chức vụ")
            {
                tbLoaiChucVu.Enabled = true;
            }
            else
            {
                tbLoaiChucVu.Enabled= false;
            }
        }

        private void frmAddEmployeeType_Load(object sender, EventArgs e)
        {
            loadLoaiChucVu();
            cmbLoaiNhanVienDeXuat.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
