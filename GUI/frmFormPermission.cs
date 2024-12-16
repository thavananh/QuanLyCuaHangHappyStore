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

        // BLL
        private QuyenTaiKhoanBLL quyenTaiKhoanBLL = new QuyenTaiKhoanBLL();
        private ChucNangBLL chucNangBLL = new ChucNangBLL();
        private ChucNang_QuyenTaiKhoanBLL chucNang_QuyenTaiKhoanBLL = new ChucNang_QuyenTaiKhoanBLL();
        public static string tenChucNang = "phan_quyen_chuc_nang";
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
            
            listChucNang = chucNangBLL.LayTatCaChucNang();
            cboChucNang.DisplayMember = "MaChucNang";
            cboChucNang.ValueMember = "TenChucNang";
            cboChucNang.DataSource = listChucNang;



            // Lấy tất cả các quyền tài khoản
            listQuyenTaiKhoan = quyenTaiKhoanBLL.GetAllQuyenTaiKhoan();


            // Đăng ký sự kiện khi chọn loại tài khoản thay đổi
            cboChucNang.SelectedIndexChanged += CboChucNang_SelectedIndexChanged;

            // Nếu có loại tài khoản được chọn mặc định, load quyền tương ứng
            if (cboChucNang.Items.Count > 0)
            {
                cboChucNang.SelectedIndex = 0;
            }
        }

        private void CboChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPermissionsForSelectedChucNang();
        }

        private void LoadPermissionsForSelectedChucNang()
        {
            // Lấy loại tài khoản được chọn
            CHUCNANG selectedLoai = (CHUCNANG)cboChucNang.SelectedItem;

            if (selectedLoai != null)
            {
                // Lấy danh sách quyền đã được gán cho loại tài khoản
                List<CHUCNANG_QUYENTAIKHOAN> existingAssignments = chucNang_QuyenTaiKhoanBLL.GetAllChucNang_QuyenTaiKhoan_ById(selectedLoai.MaChucNang);

                // Lấy danh sách quyền đã chọn dựa trên các gán hiện tại
                listAssignedQuyenTaiKhoan = listQuyenTaiKhoan
                    .Where(q => existingAssignments.Any(a => a.MaQuyenTaiKhoan == q.MaQuyenTaiKhoan))
                    .ToList();

                // Lấy danh sách quyền còn lại để có sẵn
                listAvailableQuyenTaiKhoan = listQuyenTaiKhoan
                    .Where(q => !existingAssignments.Any(a => a.MaQuyenTaiKhoan == q.MaQuyenTaiKhoan))
                    .ToList();

                // Cập nhật ComboBox Quyền Có Sẵn
                cboChonQuyenChucNang.DisplayMember = "TenQuyenTaiKhoan";
                cboChonQuyenChucNang.ValueMember = "MaQuyenTaiKhoan";
                cboChonQuyenChucNang.DataSource = null;
                cboChonQuyenChucNang.DataSource = listAvailableQuyenTaiKhoan;

                // Cập nhật ComboBox Quyền Đã Chọn
                cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
                cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";
                cboQuyenDaChon.DataSource = null;
                cboQuyenDaChon.DataSource = listAssignedQuyenTaiKhoan;
            }
        }

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            if (cboChonQuyenChucNang.SelectedItem != null)
            {
                // Lấy quyền được chọn từ ComboBox quyền có sẵn
                QUYENTAIKHOAN selectedQuyen = (QUYENTAIKHOAN)cboChonQuyenChucNang.SelectedItem;

                // Thêm quyền vào danh sách quyền đã chọn
                listAssignedQuyenTaiKhoan.Add(selectedQuyen);

                // Xóa quyền khỏi danh sách quyền có sẵn
                listAvailableQuyenTaiKhoan.Remove(selectedQuyen);

                // Cập nhật lại DataSource cho các ComboBox
                cboChonQuyenChucNang.DataSource = null;
                cboChonQuyenChucNang.DataSource = listAvailableQuyenTaiKhoan;
                cboChonQuyenChucNang.DisplayMember = "TenQuyenTaiKhoan";
                cboChonQuyenChucNang.ValueMember = "MaQuyenTaiKhoan";

                cboQuyenDaChon.DataSource = null;
                cboQuyenDaChon.DataSource = listAssignedQuyenTaiKhoan;
                cboQuyenDaChon.DisplayMember = "TenQuyenTaiKhoan";
                cboQuyenDaChon.ValueMember = "MaQuyenTaiKhoan";
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
                        // Thêm lại quyền vào danh sách quyền có sẵn
                        listAvailableQuyenTaiKhoan.Add(selectedQuyen);
                        // Xóa quyền khỏi danh sách quyền đã chọn
                        listAssignedQuyenTaiKhoan.Remove(selectedQuyen);

                        // Cập nhật lại DataSource cho các ComboBox
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
            // Lấy loại tài khoản được chọn
            CHUCNANG selectedLoai = (CHUCNANG)cboChucNang.SelectedItem;

            if (selectedLoai != null)
            {
                // Lấy danh sách quyền đã chọn
                List<QUYENTAIKHOAN> selectedQuyen = listAssignedQuyenTaiKhoan;

                if (selectedQuyen.Count > 0)
                {
                    // Lấy danh sách quyền hiện tại của loại tài khoản từ cơ sở dữ liệu
                    List<CHUCNANG_QUYENTAIKHOAN> existingQuyen = chucNang_QuyenTaiKhoanBLL.GetAllChucNang_QuyenTaiKhoan_ById(selectedLoai.MaChucNang);

                    bool isSuccess = true;
                    List<string> failedQuyen = new List<string>();

                    foreach (var quyen in selectedQuyen)
                    {
                        // Kiểm tra quyền đã được gán hay chưa
                        bool alreadyAssigned = existingQuyen.Exists(q => q.MaQuyenTaiKhoan == quyen.MaQuyenTaiKhoan);
                        if (!alreadyAssigned)
                        {
                            CHUCNANG_QUYENTAIKHOAN entry = new CHUCNANG_QUYENTAIKHOAN
                            {
                                MaQuyenTaiKhoan = quyen.MaQuyenTaiKhoan,
                                MaChucNang = selectedLoai.MaChucNang
                            };

                            bool result = chucNang_QuyenTaiKhoanBLL.AddChucNang_QuyenTaiKhoan(entry);
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
                    }
                    else
                    {
                        string failedMessage = "Cấp quyền thất bại đối với các quyền sau: " + string.Join(", ", failedQuyen);
                        MessageBox.Show(failedMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Reload permissions để cập nhật danh sách đã chọn và có sẵn
                    LoadPermissionsForSelectedChucNang();
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
    }
}
