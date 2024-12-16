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
    public partial class frmAddEmployeeAccountType : Form
    {
        public frmAddEmployeeAccountType()
        {
            InitializeComponent();
        }
        private List<LOAITAIKHOAN> listLoaiTaiKhoan = new List<LOAITAIKHOAN>();
        private LoaiTaiKhoanBLL loaiTaiKhoanBLL = new LoaiTaiKhoanBLL();
        private LOAITAIKHOAN loaiTaiKhoan = new LOAITAIKHOAN();
        public static string tenChucNang = "them_loai_tai_khoan";
        private void loadComboBox()
        {
            listLoaiTaiKhoan = loaiTaiKhoanBLL.GetAllLoaiTaiKhoan();
            cmbLoaiTaiKhoanDeXuat.DisplayMember = "TenLoaiTaiKhoan";
            cmbLoaiTaiKhoanDeXuat.ValueMember = "MaLoaiTaiKhoan";
            cmbLoaiTaiKhoanDeXuat.DataSource = listLoaiTaiKhoan;
        }

        private void frmAddEmployeeAccountType_Load(object sender, EventArgs e)
        {
            loadComboBox();
            tbLoaiTaiKhoan.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            loaiTaiKhoan.MaLoaiTaiKhoan = Guid.NewGuid().ToString();
            if (cmbLoaiTaiKhoanDeXuat.SelectedItem.ToString() != "Tự đề xuất loại vật dụng")
            {
                loaiTaiKhoan.TenLoaiTaiKhoan = cmbLoaiTaiKhoanDeXuat.SelectedItem.ToString();
                bool isTHemLoaiThietBi = loaiTaiKhoanBLL.CreateLoaiTaiKhoan(loaiTaiKhoan);
                if (isTHemLoaiThietBi)
                {
                    MessageBox.Show("Thêm loại tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm loại tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (tbLoaiTaiKhoan.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Loại tài khoản không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string pattern = @"[@#$%^&*!]"; // Mẫu kiểm tra các ký tự đặc biệt
                // Kiểm tra nếu chuỗi chứa ít nhất một trong các ký tự đặc biệt
                bool containsSpecialChar = Regex.IsMatch(tbLoaiTaiKhoan.Text.Trim(), pattern);

                if (containsSpecialChar)
                {
                    MessageBox.Show("Vui lòng đặt tên loại sản phẩm không có các ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                loaiTaiKhoan.TenLoaiTaiKhoan = tbLoaiTaiKhoan.Text.Trim();
                bool isTHemLoaiThietBi = loaiTaiKhoanBLL.CreateLoaiTaiKhoan(loaiTaiKhoan);
                if (isTHemLoaiThietBi)
                {
                    MessageBox.Show("Thêm loại tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm loại tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbLoaiTaiKhoanDeXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiTaiKhoanDeXuat.SelectedItem.ToString() == "Tự đề xuất loại tài khoản")
            {
                tbLoaiTaiKhoan.Enabled = true;
            }
            else
            {
                tbLoaiTaiKhoan.Enabled=false;
            }
        }
    }
}
