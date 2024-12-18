using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmPermissionManage : Form
    {
        public frmPermissionManage()
        {
            InitializeComponent();
        }
        string maTaiKhoan = "";
        string maLoaiTaiKhoan = "";

        public frmPermissionManage(string inputMaTaiKhoan, string inputMaLoaiTaiKhoan)
        {
            InitializeComponent();
            this.maTaiKhoan = inputMaTaiKhoan;
            this.maLoaiTaiKhoan = inputMaLoaiTaiKhoan;
        }

        // Danh sách quyền có sẵn và quyền đã chọn
        private List<QUYENTAIKHOAN> listQuyenTaiKhoan = new List<QUYENTAIKHOAN>();
        private List<LOAITAIKHOAN> listLoaiTaiKhoan = new List<LOAITAIKHOAN>();
        private List<QUYENTAIKHOAN> listAvailableQuyenTaiKhoan = new List<QUYENTAIKHOAN>();
        private List<QUYENTAIKHOAN> listAssignedQuyenTaiKhoan = new List<QUYENTAIKHOAN>();
        private List<QUYENTAIKHOAN> tmp = new List<QUYENTAIKHOAN>();
        private List<QUYENTAIKHOAN_LOAITAIKHOAN> listQuyenTaiKhoan_LoaiTaiKhoan = new List<QUYENTAIKHOAN_LOAITAIKHOAN>();
        private bool isFirstTime = true;

        // BLL
        private QuyenTaiKhoanBLL quyenTaiKhoanBLL = new QuyenTaiKhoanBLL();
        private LoaiTaiKhoanBLL loaiTaiKhoanBLL = new LoaiTaiKhoanBLL();
        private QuyenTaiKhoan_LoaiTaiKhoanBLL quyenTaiKhoan_LoaiTaiKhoanBLL = new QuyenTaiKhoan_LoaiTaiKhoanBLL();

        public static string tenChucNang = "them_quyen_tai_khoan";

        private void frmPermissionManage_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            if (isFirstTime)
            {
                listLoaiTaiKhoan = loaiTaiKhoanBLL.GetAllLoaiTaiKhoan();
                cboLoaiTaiKhoan.DisplayMember = "TenLoaiTaiKhoan";
                cboLoaiTaiKhoan.ValueMember = "MaLoaiTaiKhoan";
                cboLoaiTaiKhoan.DataSource = listLoaiTaiKhoan;
                isFirstTime = false;
            }

            // Fetch all permissions
            listQuyenTaiKhoan = quyenTaiKhoanBLL.GetAllQuyenTaiKhoan();
            listQuyenTaiKhoan_LoaiTaiKhoan = quyenTaiKhoan_LoaiTaiKhoanBLL.GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(cboLoaiTaiKhoan.SelectedValue.ToString());

            // Determine assigned and available permissions
            listAssignedQuyenTaiKhoan = listQuyenTaiKhoan_LoaiTaiKhoan
                .Join(listQuyenTaiKhoan,
                      ql => ql.MaQuyenTaiKhoan,
                      q => q.MaQuyenTaiKhoan,
                      (ql, q) => q)
                .ToList();

            listAvailableQuyenTaiKhoan = listQuyenTaiKhoan
                .Where(q => !listAssignedQuyenTaiKhoan.Any(a => a.MaQuyenTaiKhoan == q.MaQuyenTaiKhoan))
                .ToList();

            // Update ComboBoxes
            cbChonQuyenLoaiTaiKhoan.DataSource = null;
            cbChonQuyenLoaiTaiKhoan.DisplayMember = "TenQuyenTaiKhoan";
            cbChonQuyenLoaiTaiKhoan.ValueMember = "MaQuyenTaiKhoan";
            cbChonQuyenLoaiTaiKhoan.DataSource = listAvailableQuyenTaiKhoan;

            cboQuyenDaChon.DataSource = null;
            cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
            cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";
            cboQuyenDaChon.DataSource = listAssignedQuyenTaiKhoan;
        }




        private void LoadPermissionsForSelectedLoaiTaiKhoan()
        {
            // Lấy loại tài khoản được chọn
            LOAITAIKHOAN selectedLoai = (LOAITAIKHOAN)cboLoaiTaiKhoan.SelectedItem;

            if (selectedLoai != null)
            {
                // Lấy danh sách quyền đã được gán cho loại tài khoản
                List<QUYENTAIKHOAN_LOAITAIKHOAN> existingAssignments = quyenTaiKhoan_LoaiTaiKhoanBLL.GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(selectedLoai.MaLoaiTaiKhoan);

                // Lấy danh sách quyền đã chọn dựa trên các gán hiện tại
                listAssignedQuyenTaiKhoan = listQuyenTaiKhoan
                    .Where(q => existingAssignments.Any(a => a.MaQuyenTaiKhoan == q.MaQuyenTaiKhoan))
                    .ToList();

                // Lấy danh sách quyền còn lại để có sẵn
                listAvailableQuyenTaiKhoan = listQuyenTaiKhoan
                    .Where(q => !existingAssignments.Any(a => a.MaQuyenTaiKhoan == q.MaQuyenTaiKhoan))
                    .ToList();

                // Cập nhật ComboBox Quyền Có Sẵn
                cbChonQuyenLoaiTaiKhoan.DisplayMember = "TenQuyenTaiKhoan";
                cbChonQuyenLoaiTaiKhoan.ValueMember = "MaQuyenTaiKhoan";
                cbChonQuyenLoaiTaiKhoan.DataSource = null;
                cbChonQuyenLoaiTaiKhoan.DataSource = listAvailableQuyenTaiKhoan;

                // Cập nhật ComboBox Quyền Đã Chọn
                cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
                cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";
                cboQuyenDaChon.DataSource = null;
                cboQuyenDaChon.DataSource = listAssignedQuyenTaiKhoan;
            }
        }

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            if (cbChonQuyenLoaiTaiKhoan.SelectedItem != null)
            {
                // Get the selected permission
                QUYENTAIKHOAN selectedQuyen = (QUYENTAIKHOAN)cbChonQuyenLoaiTaiKhoan.SelectedItem;

                // Add to assigned permissions if not already present
                if (!listAssignedQuyenTaiKhoan.Any(q => q.MaQuyenTaiKhoan == selectedQuyen.MaQuyenTaiKhoan))
                {
                    listAssignedQuyenTaiKhoan.Add(selectedQuyen);
                    listAvailableQuyenTaiKhoan.Remove(selectedQuyen);

                    // Update ComboBoxes
                    cbChonQuyenLoaiTaiKhoan.DataSource = null;
                    cbChonQuyenLoaiTaiKhoan.DataSource = listAvailableQuyenTaiKhoan;
                    cbChonQuyenLoaiTaiKhoan.DisplayMember = "TenQuyenTaiKhoan";
                    cbChonQuyenLoaiTaiKhoan.ValueMember = "MaQuyenTaiKhoan";

                    cboQuyenDaChon.DataSource = null;
                    cboQuyenDaChon.DataSource = listAssignedQuyenTaiKhoan;
                    cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
                    cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";

                    // Optionally, select the newly added item
                    cboQuyenDaChon.SelectedIndex = cboQuyenDaChon.Items.Count - 1;
                }
                else
                {
                    MessageBox.Show("Quyền này đã được cấp trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // Get the selected permission to remove
                QUYENTAIKHOAN selectedQuyen = (QUYENTAIKHOAN)cboQuyenDaChon.SelectedItem;
                LOAITAIKHOAN selectedLoai = (LOAITAIKHOAN)cboLoaiTaiKhoan.SelectedItem;

                if (selectedLoai != null)
                {
                    bool result = quyenTaiKhoan_LoaiTaiKhoanBLL.DeleteQuyenTaiKhoan_LoaiTaiKhoan(selectedQuyen.MaQuyenTaiKhoan, selectedLoai.MaLoaiTaiKhoan);

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
                        cbChonQuyenLoaiTaiKhoan.DataSource = null;
                        cbChonQuyenLoaiTaiKhoan.DataSource = listAvailableQuyenTaiKhoan;
                        cbChonQuyenLoaiTaiKhoan.DisplayMember = "TenQuyenTaiKhoan";
                        cbChonQuyenLoaiTaiKhoan.ValueMember = "MaQuyenTaiKhoan";

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
                    MessageBox.Show("Vui lòng chọn loại tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một quyền để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the selected account type
            LOAITAIKHOAN selectedLoai = (LOAITAIKHOAN)cboLoaiTaiKhoan.SelectedItem;

            if (selectedLoai != null)
            {
                // Get the list of permissions to assign
                List<QUYENTAIKHOAN> selectedQuyen = listAssignedQuyenTaiKhoan;

                if (selectedQuyen.Count > 0)
                {
                    // Fetch existing permissions from the database
                    List<QUYENTAIKHOAN_LOAITAIKHOAN> existingAssignments = quyenTaiKhoan_LoaiTaiKhoanBLL.GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(selectedLoai.MaLoaiTaiKhoan);

                    // Create a HashSet for efficient lookup
                    HashSet<string> existingQuyenSet = new HashSet<string>(existingAssignments.Select(q => q.MaQuyenTaiKhoan));

                    bool isSuccess = true;
                    List<string> failedQuyen = new List<string>();

                    foreach (var quyen in selectedQuyen)
                    {
                        if (!existingQuyenSet.Contains(quyen.MaQuyenTaiKhoan))
                        {
                            QUYENTAIKHOAN_LOAITAIKHOAN entry = new QUYENTAIKHOAN_LOAITAIKHOAN
                            {
                                MaQuyenTaiKhoan = quyen.MaQuyenTaiKhoan,
                                MaLoaiTaiKhoan = selectedLoai.MaLoaiTaiKhoan
                            };

                            bool result = quyenTaiKhoan_LoaiTaiKhoanBLL.ThemQuyenTaiKhoan_LoaiTaiKhoan(entry);
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
                MessageBox.Show("Vui lòng chọn loại tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboLoaiTaiKhoan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadComboBox();
        }
    }
}
