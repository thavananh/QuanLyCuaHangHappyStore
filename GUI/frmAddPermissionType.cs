using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        //private void LoadComboBox()
        //{
        //    listQuyenTaiKhoan = quyenTaiKhoanBll.GetAllQuyenTaiKhoan();
        //    cboQuyenDeXuat.DisplayMember = "TenQuyenTaiKhoan";
        //    cboQuyenDeXuat.ValueMember = "MaQuyenTaiKhoan";
        //    cboQuyenDeXuat.DataSource = listQuyenTaiKhoan;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {

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
            if (cboQuyenDeXuat.SelectedItem.ToString() == "")
            {

            }
        }
    }
}
