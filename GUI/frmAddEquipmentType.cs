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
    public partial class frmAddEquipmentType : Form
    {
        public frmAddEquipmentType()
        {
            InitializeComponent();
            tbLoaiVatDung.Enabled = false;
        }

        LOAITHIETBI loaiThietBi = new LOAITHIETBI();
        LoaiThietBiBLL loaiThietBiBLL = new LoaiThietBiBLL();

        private void btnSave_Click(object sender, EventArgs e)
        {
            loaiThietBi.MaLoaiThietBi = Guid.NewGuid().ToString();
            if (cmbLoaiVatDungDeXuat.SelectedItem.ToString() != "Tự đề xuất loại vật dụng")
            {
                loaiThietBi.TenLoaiThietBi = cmbLoaiVatDungDeXuat.SelectedItem.ToString();
                bool isTHemLoaiThietBi = loaiThietBiBLL.themLoaiThietBi(loaiThietBi);
                if (isTHemLoaiThietBi)
                {
                    MessageBox.Show("Thêm loại thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm loại thiết bị thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (tbLoaiVatDung.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Loại sản phẩm không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string pattern = @"[@#$%^&*!]"; // Mẫu kiểm tra các ký tự đặc biệt
                // Kiểm tra nếu chuỗi chứa ít nhất một trong các ký tự đặc biệt
                bool containsSpecialChar = Regex.IsMatch(tbLoaiVatDung.Text.Trim(), pattern);

                if (containsSpecialChar)
                {
                    MessageBox.Show("Vui lòng đặt tên loại sản phẩm không có các ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                loaiThietBi.TenLoaiThietBi = tbLoaiVatDung.Text.Trim();
                bool isTHemLoaiThietBi = loaiThietBiBLL.themLoaiThietBi(loaiThietBi);
                if (isTHemLoaiThietBi)
                {
                    MessageBox.Show("Thêm loại thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm loại thiết bị thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbLoaiVatDungDeXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiVatDungDeXuat.SelectedItem.ToString() == "Tự đề xuất loại vật dụng")
            {
                tbLoaiVatDung.Enabled = true;
            }
            else
            {
                tbLoaiVatDung.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
