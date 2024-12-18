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
            // Lấy tất cả các loại tài khoản
            

            tmp = new List<QUYENTAIKHOAN>();

            // Lấy tất cả các quyền tài khoản
            listQuyenTaiKhoan = quyenTaiKhoanBLL.GetAllQuyenTaiKhoan();
            listQuyenTaiKhoan_LoaiTaiKhoan = quyenTaiKhoan_LoaiTaiKhoanBLL.GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(cboLoaiTaiKhoan.SelectedValue.ToString());

            List<QUYENTAIKHOAN> tmp1 = new List<QUYENTAIKHOAN>();

            foreach (var item in listQuyenTaiKhoan)
            {
                tmp1.Add(item);
            }

            foreach (var item in tmp1)
            {
                foreach (var item1 in listQuyenTaiKhoan_LoaiTaiKhoan)
                {
                    if (item.MaQuyenTaiKhoan == item1.MaQuyenTaiKhoan)
                    {
                        tmp.Add(item);
                        listQuyenTaiKhoan.Remove(item);
                    }
                }
            }

            cbChonQuyenLoaiTaiKhoan.DataSource = null;
            cboQuyenDaChon.DataSource = null;

            // Xóa sạch dữ liệu trong các combo box
            cbChonQuyenLoaiTaiKhoan.Items.Clear();
            cboQuyenDaChon.Items.Clear();

            cbChonQuyenLoaiTaiKhoan.DisplayMember = "TenQuyenTaiKhoan";
            cbChonQuyenLoaiTaiKhoan.ValueMember = "MaQuyenTaiKhoan";
            
            cbChonQuyenLoaiTaiKhoan.DataSource = listQuyenTaiKhoan;

            cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
            cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";
            
            cboQuyenDaChon.DataSource = tmp;

            // Nếu có loại tài khoản được chọn mặc định, load quyền tương ứng
            
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
                // Lấy quyền được chọn từ ComboBox quyền có sẵn
                QUYENTAIKHOAN selectedQuyen = (QUYENTAIKHOAN)cbChonQuyenLoaiTaiKhoan.SelectedItem;

                // Thêm quyền vào danh sách quyền đã chọn
                listAssignedQuyenTaiKhoan.Add(selectedQuyen);

                // Xóa quyền khỏi danh sách quyền có sẵn
                listAvailableQuyenTaiKhoan.Remove(selectedQuyen);

                // Cập nhật lại DataSource cho các ComboBox
                cbChonQuyenLoaiTaiKhoan.DataSource = null;
                cbChonQuyenLoaiTaiKhoan.DataSource = listAvailableQuyenTaiKhoan;
                cbChonQuyenLoaiTaiKhoan.DisplayMember = "TenQuyenTaiKhoan";
                cbChonQuyenLoaiTaiKhoan.ValueMember = "MaQuyenTaiKhoan";

                cboQuyenDaChon.DataSource = null;
                cboQuyenDaChon.DataSource = listAssignedQuyenTaiKhoan;
                cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
                cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";
                cboQuyenDaChon.SelectedIndex = cboQuyenDaChon.Items.Count - 1;
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
                LOAITAIKHOAN selectedLoai = (LOAITAIKHOAN)cboLoaiTaiKhoan.SelectedItem;

                if (selectedLoai != null)
                {
                    bool result = quyenTaiKhoan_LoaiTaiKhoanBLL.DeleteQuyenTaiKhoan_LoaiTaiKhoan(selectedQuyen.MaQuyenTaiKhoan, selectedLoai.MaLoaiTaiKhoan);

                    if (result)
                    {
                        // Thêm lại quyền vào danh sách quyền có sẵn
                        listAvailableQuyenTaiKhoan.Add(selectedQuyen);
                        // Xóa quyền khỏi danh sách quyền đã chọn
                        listAssignedQuyenTaiKhoan.Remove(selectedQuyen);

                        // Cập nhật lại DataSource cho các ComboBox
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
            // Lấy loại tài khoản được chọn
            LOAITAIKHOAN selectedLoai = (LOAITAIKHOAN)cboLoaiTaiKhoan.SelectedItem;

            if (selectedLoai != null)
            {
                // Lấy danh sách quyền đã chọn
                List<QUYENTAIKHOAN> selectedQuyen = listAssignedQuyenTaiKhoan;

                if (selectedQuyen.Count > 0)
                {
                    // Lấy danh sách quyền hiện tại của loại tài khoản từ cơ sở dữ liệu
                    List<QUYENTAIKHOAN_LOAITAIKHOAN> existingQuyen = quyenTaiKhoan_LoaiTaiKhoanBLL.GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(selectedLoai.MaLoaiTaiKhoan);

                    bool isSuccess = true;
                    List<string> failedQuyen = new List<string>();

                    foreach (var quyen in selectedQuyen)
                    {
                        // Kiểm tra quyền đã được gán hay chưa
                        bool alreadyAssigned = existingQuyen.Exists(q => q.MaQuyenTaiKhoan == quyen.MaQuyenTaiKhoan);
                        if (!alreadyAssigned)
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
                        else
                        {
                            // Quyền đã được gán, bạn có thể thông báo hoặc bỏ qua
                        }
                    }

                    if (isSuccess)
                    {
                        MessageBox.Show("Cấp quyền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadComboBox();
                        
                    }
                    else
                    {
                        string failedMessage = "Cấp quyền thất bại đối với các quyền sau: " + string.Join(", ", failedQuyen);
                        MessageBox.Show(failedMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Reload permissions để cập nhật danh sách đã chọn và có sẵn
                    LoadPermissionsForSelectedLoaiTaiKhoan();
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
