using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class frmMainPage : Form
    {
        QuanLyQuyenHanChucNang quanLyQuyenHanChucNang = new QuanLyQuyenHanChucNang();
        string maTaiKhoan = "";
        string maLoaiTaiKhoan = "";
        public frmMainPage()
        {
            InitializeComponent();
        }


        public frmMainPage(string inputMaTaiKhoan, string inputMaLoaiTaiKhoan)
        {
            maTaiKhoan = inputMaTaiKhoan;
            maLoaiTaiKhoan = inputMaLoaiTaiKhoan;
            InitializeComponent();
            
        }

        public frmMainPage(int ltk)
        {
            InitializeComponent();
            if (ltk == 0)
            {
                btnManageCompanyEmployee.Enabled = false;
                btnManageCompanyEmployee.BackColor = Color.Gray;
                btnStatistic.Enabled = false;
                btnStatistic.BackColor = Color.Gray;
            }
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            frmManageCustomer manageCustomer = new frmManageCustomer(maTaiKhoan, maLoaiTaiKhoan);
            this.Hide();
            manageCustomer.ShowDialog();
            this.Show();
        }

        private void btnManageEquipment_Click(object sender, EventArgs e)
        {
            frmManageEquipment manageEquipment = new frmManageEquipment(maTaiKhoan, maLoaiTaiKhoan);
            this.Hide();
            manageEquipment.ShowDialog();
            this.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            frmRevenueReport revenueReport = new frmRevenueReport();
            if (!quanLyQuyenHanChucNang.KiemTraQuyenTruyCapVaoChucNang(frmFormPermission.tenChucNang, maTaiKhoan, maLoaiTaiKhoan))
            {
                MessageBox.Show("Bạn không đủ quyền hạn để sử dụng chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            revenueReport.ShowDialog();
            this.Show();
        }

        private void btnManageCompanyEmployee_Click(object sender, EventArgs e)
        {
            frmManageCompanyEmployee manageCompanyEmployee = new frmManageCompanyEmployee(maTaiKhoan, maLoaiTaiKhoan);
            this.Hide();
            manageCompanyEmployee.ShowDialog();
            this.Show();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            frmManageProduct manageProduct = new frmManageProduct(maTaiKhoan, maLoaiTaiKhoan);
            
            this.Hide();
            manageProduct.ShowDialog();
            this.Show();
        }

        private void btnBackupDB_Click(object sender, EventArgs e)
        {
            InitDatabase _db = new InitDatabase();
            string pickDataBaseFrom = Environment.CurrentDirectory;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DateTime currentTime = DateTime.Now;
                    string backupDBName = "backupCSDLCuaHangHappyStore" + currentTime.Year.ToString() + "_" + currentTime.Month + "_" + currentTime.Day.ToString() + "_" + currentTime.Hour.ToString() + "_" + currentTime.Minute.ToString() + "_" + currentTime.Second.ToString();
                    var backupDatabaseTo = fbd.SelectedPath + "\\" + (Path.GetFileNameWithoutExtension(backupDBName) + ".db");
                    if (_db.Backup(pickDataBaseFrom, "QuanLyCuaHangHappyStore.db", backupDatabaseTo))
                    {
                        MessageBox.Show("Backup thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Backup thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRestoreDB_Click(object sender, EventArgs e)
        {
            InitDatabase _db = new InitDatabase();
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string restoreDatabaseFrom = fileDialog.FileName;
                var restoreDatabaseTo = Environment.CurrentDirectory + "\\" + "QuanLyPhongGym.db";
                if (_db.Restore(restoreDatabaseFrom, restoreDatabaseTo))
                {
                    MessageBox.Show("Restore thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Restore thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
