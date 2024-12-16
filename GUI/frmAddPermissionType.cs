using BLL;
using DTO;
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

namespace GUI
{
    public partial class frmAddPermissionType : Form
    {
        public frmAddPermissionType()
        {
            InitializeComponent();
        }

        List<QUYENTAIKHOAN> listQuyenTaiKhoan = new List<QUYENTAIKHOAN>();
        QuyenTaiKhoanBLL quyenTaiKhoanBll = new QuyenTaiKhoanBLL();
        QUYENTAIKHOAN quyenTaiKhoan = new QUYENTAIKHOAN();
        //private void LoadComboBox()
        //{
        //    listQuyenTaiKhoan = quyenTaiKhoanBll.GetAllQuyenTaiKhoan();
        //    cboQuyenDeXuat.DisplayMember = "TenQuyenTaiKhoan";
        //    cboQuyenDeXuat.ValueMember = "MaQuyenTaiKhoan";
        //    cboQuyenDeXuat.DataSource = listQuyenTaiKhoan;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            quyenTaiKhoan.MaQuyenTaiKhoan = Guid.NewGuid().ToString();
            if (cboQuyenDeXuat.SelectedItem.ToString() != "Tự đề xuất loại quyền")
            {
                quyenTaiKhoan.TenQuyenTaiKhoan = cboQuyenDeXuat.SelectedItem.ToString();
                bool isTHemLoaiThietBi = quyenTaiKhoanBll.CreateQuyenTaiKhoan(quyenTaiKhoan);
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
                if (tbQuyen.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Loại chức vụ không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string pattern = @"[@#$%^&*!]"; // Mẫu kiểm tra các ký tự đặc biệt
                // Kiểm tra nếu chuỗi chứa ít nhất một trong các ký tự đặc biệt
                bool containsSpecialChar = Regex.IsMatch(tbQuyen.Text.Trim(), pattern);

                if (containsSpecialChar)
                {
                    MessageBox.Show("Vui lòng đặt tên loại chức vụ không có các ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                quyenTaiKhoan.TenQuyenTaiKhoan = tbQuyen.Text.Trim();
                bool isTHemLoaiThietBi = quyenTaiKhoanBll.CreateQuyenTaiKhoan(quyenTaiKhoan);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddPermissionType_Load(object sender, EventArgs e)
        {
            
        }

        private void cboQuyenDeXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuyenDeXuat.SelectedItem.ToString() == "Tự đề xuất loại quyền")
            {
                tbQuyen.Enabled = true;
            }
            else
            {
                tbQuyen.Enabled=false;
            }
        }
    }
}
