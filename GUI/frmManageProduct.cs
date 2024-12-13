using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            sellProduct.ShowDialog();
            this.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
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
            this.Hide();
            addProductType.ShowDialog();
            this.Show();
        }
    }
}
