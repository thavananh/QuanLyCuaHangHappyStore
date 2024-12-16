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

/*
 ____   ___  _____ _______        ___    ____  _____ 
/ ___| / _ \|  ___|_   _\ \      / / \  |  _ \| ____|
\___ \| | | | |_    | |  \ \ /\ / / _ \ | |_) |  _|  
 ___) | |_| |  _|   | |   \ V  V / ___ \|  _ <| |___ 
|____/ \___/|_|__ __|_|  _ \_/\_/_/   \_\_| \_\_____|
/ ___|| | | / ___|_   _|/ \  |_ _| \ | |             
\___ \| | | \___ \ | | / _ \  | ||  \| |             
 ___) | |_| |___) || |/ ___ \ | || |\  |             
|____/ \___/|____/ |_/_/   \_\___|_| \_|     

DEVELOPED AND MAINTAINED BY SOFTWARE SUSTAIN
*/

namespace GUI
{
    public partial class frmManageProduct : Form
    {
        public frmManageProduct()
        {
            InitializeComponent();
        }
        QuanLyQuyenHanChucNang quanLyQuyenHanChucNang = new QuanLyQuyenHanChucNang();
        private string maTaiKhoan = "";
        private string maLoaiTaiKhoan = "";

        public frmManageProduct(string inputMaTaiKhoan, string inputMaLoaiTaiKhoan)
        {
            InitializeComponent();
            this.maTaiKhoan = inputMaTaiKhoan;
            this.maLoaiTaiKhoan = inputMaLoaiTaiKhoan;
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            frmProductList productList = new frmProductList();
            this.Hide();
            productList.ShowDialog();
            this.Show();
        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            frmSellProducct sellProduct = new frmSellProducct();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmSellProducct.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            sellProduct.ShowDialog();
            this.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmAddProduct.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            addProduct.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddProductType addProductType = new frmAddProductType();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmAddProductType.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            addProductType.ShowDialog();
            this.Show();
        }
    }
}
