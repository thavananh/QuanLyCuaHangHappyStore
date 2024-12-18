using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmFormPermission : Form
    {
        // Danh sách quyền có sẵn và quyền đã chọn
        private List<QUYENTAIKHOAN> listQuyenTaiKhoan = new List<QUYENTAIKHOAN>();
        private List<CHUCNANG> listChucNang = new List<CHUCNANG>();
        private List<QUYENTAIKHOAN> listAvailableQuyenTaiKhoan = new List<QUYENTAIKHOAN>();
        private List<QUYENTAIKHOAN> listAssignedQuyenTaiKhoan = new List<QUYENTAIKHOAN>();

        private List<CHUCNANG_QUYENTAIKHOAN> listChucNang_QuyenTaiKhoan = new List<CHUCNANG_QUYENTAIKHOAN>();
        private List<QUYENTAIKHOAN> tmp = new List<QUYENTAIKHOAN>();

        // BLL
        private QuyenTaiKhoanBLL quyenTaiKhoanBLL = new QuyenTaiKhoanBLL();
        private ChucNangBLL chucNangBLL = new ChucNangBLL();
        private ChucNang_QuyenTaiKhoanBLL chucNang_QuyenTaiKhoanBLL = new ChucNang_QuyenTaiKhoanBLL();
        public static string tenChucNang = "phan_quyen_chuc_nang";
        private bool isFirstTime = true;
        public frmFormPermission()
        {
            InitializeComponent();
        }

        private void frmFormPermission_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            if (isFirstTime)
            {
                // Load all functions (Chức Năng)
                listChucNang = chucNangBLL.LayTatCaChucNang();
                cboChucNang.DisplayMember = "MieuTa"; // Assuming "MieuTa" is the description
                cboChucNang.ValueMember = "MaChucNang"; // Primary key
                cboChucNang.DataSource = listChucNang;
                isFirstTime = false;
            }

            // Fetch all available permissions
            listQuyenTaiKhoan = quyenTaiKhoanBLL.GetAllQuyenTaiKhoan();

            // Fetch all permission assignments for the selected function
            string selectedMaChucNang = cboChucNang.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedMaChucNang))
            {
                // Handle cases where no function is selected
                listAssignedQuyenTaiKhoan = new List<QUYENTAIKHOAN>();
                listAvailableQuyenTaiKhoan = new List<QUYENTAIKHOAN>();
            }
            else
            {
                listChucNang_QuyenTaiKhoan = chucNang_QuyenTaiKhoanBLL.GetAllChucNang_QuyenTaiKhoan_ById(selectedMaChucNang);

                // Determine assigned permissions using LINQ Join
                listAssignedQuyenTaiKhoan = listChucNang_QuyenTaiKhoan
                    .Join(listQuyenTaiKhoan,
                          ql => ql.MaQuyenTaiKhoan,
                          q => q.MaQuyenTaiKhoan,
                          (ql, q) => q)
                    .ToList();

                // Determine available permissions by excluding assigned ones
                listAvailableQuyenTaiKhoan = listQuyenTaiKhoan
                    .Where(q => !listAssignedQuyenTaiKhoan.Any(a => a.MaQuyenTaiKhoan == q.MaQuyenTaiKhoan))
                    .ToList();
            }

            // Update ComboBox for Available Permissions
            cboChonQuyenChucNang.DataSource = null;
            cboChonQuyenChucNang.DisplayMember = "TenQuyenTaiKhoan";
            cboChonQuyenChucNang.ValueMember = "MaQuyenTaiKhoan";
            cboChonQuyenChucNang.DataSource = listAvailableQuyenTaiKhoan;

            // Update ComboBox for Assigned Permissions
            cboQuyenDaChon.DataSource = null;
            cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
            cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";
            cboQuyenDaChon.DataSource = listAssignedQuyenTaiKhoan;
        }



        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            if (cboChonQuyenChucNang.SelectedItem != null)
            {
                // Lấy quyền được chọn từ ComboBox quyền có sẵn
                QUYENTAIKHOAN selectedQuyen = (QUYENTAIKHOAN)cboChonQuyenChucNang.SelectedItem;

                if (!listAssignedQuyenTaiKhoan.Any(q => q.MaQuyenTaiKhoan == selectedQuyen.MaQuyenTaiKhoan))
                {
                    listAssignedQuyenTaiKhoan.Add(selectedQuyen);

                    listAvailableQuyenTaiKhoan.Remove(selectedQuyen);

                    cboChonQuyenChucNang.DataSource = null;
                    cboChonQuyenChucNang.DataSource = listAvailableQuyenTaiKhoan;
                    cboChonQuyenChucNang.DisplayMember = "TenQuyenTaiKhoan";
                    cboChonQuyenChucNang.ValueMember = "MaQuyenTaiKhoan";

                    cboQuyenDaChon.DataSource = null;
                    cboQuyenDaChon.DataSource = listAssignedQuyenTaiKhoan;
                    cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
                    cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";
                    cboQuyenDaChon.SelectedIndex = cboQuyenDaChon.Items.Count - 1;
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một quyền để cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboQuyenDaChon.SelectedItem != null)
            {
                // Lấy quyền được chọn từ ComboBox quyền đã chọn
                QUYENTAIKHOAN selectedQuyen = (QUYENTAIKHOAN)cboQuyenDaChon.SelectedItem;
                CHUCNANG selectedLoai = (CHUCNANG)cboChucNang.SelectedItem;

                if (selectedLoai != null)
                {
                    bool result = chucNang_QuyenTaiKhoanBLL.DeleteChucNang_QuyenTaiKhoan(selectedLoai.MaChucNang, selectedQuyen.MaQuyenTaiKhoan);

                    if (result)
                    {
                        // Add the permission back to available list if not already present
                        if (!listAvailableQuyenTaiKhoan.Any(q => q.MaQuyenTaiKhoan == selectedQuyen.MaQuyenTaiKhoan))
                        {
                            listAvailableQuyenTaiKhoan.Add(selectedQuyen);
                        }

                        // Remove from assigned list
                        listAssignedQuyenTaiKhoan.Remove(selectedQuyen);

                        // Update ComboBoxes
                        cboChonQuyenChucNang.DataSource = null;
                        cboChonQuyenChucNang.DataSource = listAvailableQuyenTaiKhoan;
                        cboChonQuyenChucNang.DisplayMember = "TenQuyenTaiKhoan";
                        cboChonQuyenChucNang.ValueMember = "MaQuyenTaiKhoan";

                        cboQuyenDaChon.DataSource = null;
                        cboQuyenDaChon.DataSource = listAssignedQuyenTaiKhoan;
                        cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
                        cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";

                        MessageBox.Show("Xoá quyền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xoá quyền thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn chức năng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một quyền để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the selected function
            CHUCNANG selectedChucNang = (CHUCNANG)cboChucNang.SelectedItem;

            if (selectedChucNang != null)
            {
                // Get the list of permissions to assign
                List<QUYENTAIKHOAN> selectedQuyen = listAssignedQuyenTaiKhoan;

                if (selectedQuyen.Count > 0)
                {
                    // Fetch existing permissions from the database
                    List<CHUCNANG_QUYENTAIKHOAN> existingAssignments = chucNang_QuyenTaiKhoanBLL.GetAllChucNang_QuyenTaiKhoan_ById(selectedChucNang.MaChucNang);

                    // Create a HashSet for efficient lookup
                    HashSet<string> existingQuyenSet = new HashSet<string>(existingAssignments.Select(q => q.MaQuyenTaiKhoan));

                    bool isSuccess = true;
                    List<string> failedQuyen = new List<string>();

                    foreach (var quyen in selectedQuyen)
                    {
                        if (!existingQuyenSet.Contains(quyen.MaQuyenTaiKhoan))
                        {
                            CHUCNANG_QUYENTAIKHOAN entry = new CHUCNANG_QUYENTAIKHOAN
                            {
                                MaQuyenTaiKhoan = quyen.MaQuyenTaiKhoan,
                                MaChucNang = selectedChucNang.MaChucNang
                            };

                            bool result = chucNang_QuyenTaiKhoanBLL.AddChucNang_QuyenTaiKhoan(entry);

                            if (!result)
                            {
                                isSuccess = false;
                                failedQuyen.Add(quyen.TenQuyenTaiKhoan);
                            }
                        }
                    }

                    if (isSuccess)
                    {
                        MessageBox.Show("Cấp quyền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string failedMessage = "Cấp quyền thất bại đối với các quyền sau: " + string.Join(", ", failedQuyen);
                        MessageBox.Show(failedMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Reload the ComboBoxes to reflect changes
                    LoadComboBox();
                }
                else
                {
                    MessageBox.Show("Không có quyền nào được chọn để cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức năng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboChonQuyenChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboChucNang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadComboBox();
        }
    }
}
