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
    public partial class frmManageCompanyEmployee : Form
    {
        public frmManageCompanyEmployee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            frmEmployeeList fdsnv = new frmEmployeeList();
            this.Hide();
            fdsnv.ShowDialog();
            this.Show();
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeRegistration FDKNV = new frmEmployeeRegistration();
            this.Hide();
            FDKNV.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEmployeeType frmadd = new frmAddEmployeeType();
            this.Hide();
            frmadd.ShowDialog();
            this.Show();
        }

        private void frmManageCompanyEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPermissionManage permissionManage = new frmPermissionManage();
            this.Hide();
            permissionManage.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddEmployeeAccountType addEmployeeAccountType = new frmAddEmployeeAccountType();
            this.Hide();
            addEmployeeAccountType.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
