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
    public partial class frmAddProductType : Form
    {
        public frmAddProductType()
        {
            InitializeComponent();
            tbLoaiSanPham.Enabled = false;
        }

        LOAISANPHAM loaiSanPham = new LOAISANPHAM();
        LoaiSanPhamBLL loaiSanPhamBLL = new LoaiSanPhamBLL();

        public static string tenChucNang = "them_san_pham";

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            loaiSanPham.MaLoaiSanPham = Guid.NewGuid().ToString();
            if (cmbLoaiSanPhamDeXuat.SelectedItem.ToString() != "Tự đề xuất loại sản phẩm")
            {
                loaiSanPham.TenLoaiSanPham = cmbLoaiSanPhamDeXuat.SelectedItem.ToString();
                if (loaiSanPhamBLL.themLoaiSanPham(loaiSanPham))
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm loại sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (tbLoaiSanPham.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Loại sản phẩm không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string pattern = @"[@#$%^&*!]"; // Mẫu kiểm tra các ký tự đặc biệt
                // Kiểm tra nếu chuỗi chứa ít nhất một trong các ký tự đặc biệt
                bool containsSpecialChar = Regex.IsMatch(tbLoaiSanPham.Text.Trim(), pattern);

                if (containsSpecialChar)
                {
                    MessageBox.Show("Vui lòng đặt tên loại sản phẩm không có các ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                loaiSanPham.TenLoaiSanPham = tbLoaiSanPham.Text.Trim();
                if(loaiSanPhamBLL.themLoaiSanPham(loaiSanPham))
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm loại sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void cmbLoaiSanPhamDeXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiSanPhamDeXuat.SelectedItem.ToString() == "Tự đề xuất loại sản phẩm")
            {
                tbLoaiSanPham.Enabled = true;
            }
            else
            {
                tbLoaiSanPham.Enabled = false;
            }
        }
    }
}
