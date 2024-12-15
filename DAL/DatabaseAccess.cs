using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Configuration;
using System.Net.Mail;
using DTO;
using System.Data.SQLite;
using AForge;
using System.Text.RegularExpressions;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Runtime.Remoting.Messaging;
using System.Data.Entity;
using System.Data.OleDb;

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

namespace DAL
{
    public class InitDatabase
    {
        private string dbName = "Data Source=QuanLyCuaHangHappyStore.db";
        private string maQuyenTaiKhoanMacDinh = Guid.NewGuid().ToString();
        private string maTaiKhoanNhanVienMacDinh = Guid.NewGuid().ToString();
        private string maLoaiTaiKhoanMacDinh = Guid.NewGuid().ToString();
        private string maLoaiChucVuMacDinh = Guid.NewGuid().ToString();
        private List<CHUCNANG> listChucNangMacDinh = new List<CHUCNANG>
        {
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "danh_sach_vat_dung_cua_hang",
                MieuTa = "Danh sách vật dụng cửa hàng"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "them_vat_dung",
                MieuTa = "Thêm vật dụng"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "them_loai_vat_dung",
                MieuTa = "Thêm loại vật dụng"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "thong_ke_doanh_thu",
                MieuTa = "Thống kê doanh thu"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "danh_sach_khach_hang",
                MieuTa = "Danh sách khách hàng"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "dang_ky_thanh_vien",
                MieuTa = "Đăng ký thành viên"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "danh_sach_nhan_vien",
                MieuTa = "Danh sách nhân viên"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "dang_ky_nhan_vien",
                MieuTa = "Đăng ký nhân viên"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "them_loai_chuc_vu",
                MieuTa = "Thêm loại chức vụ"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "them_loai_tai_khoan",
                MieuTa = "Thêm loại tài khoản"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "phan_quyen_tai_khoan",
                MieuTa = "Phân quyền tài khoản"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "phan_quyen_chuc_nang",
                MieuTa = "Phân quyền chức năng"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "danh_sach_san_pham",
                MieuTa = "Danh sách sản phẩm"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "ban_san_pham",
                MieuTa = "Bán sản phẩm"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "them_san_pham",
                MieuTa = "Thêm sản phẩm"
            },
            new CHUCNANG
            {
                MaChucNang = Guid.NewGuid().ToString(),
                TenChucNang = "them_loai_san_pham",
                MieuTa = "Thêm loại sản phẩm"
            },
        };

        public void init()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            { 
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS \"BIENLAI\" (\"MABIENLAI\" TEXT NOT NULL, \"MAGOITHANHVIEN\" TEXT, \"TONGTIEN\" REAL, \"MATHE\" TEXT, \"NGAYTHANHTOAN\" TEXT, \"I_NGAYTHANHTOAN\" INTEGER, \"BL_MAKHACHHANG\" TEXT, CONSTRAINT \"BL_MABIENLAI_PK\" PRIMARY KEY(\"MABIENLAI\"), CONSTRAINT \"BL_KH_MAKHACHAHNG_FK\" FOREIGN KEY(\"BL_MAKHACHHANG\") REFERENCES \"KHACHHANG\"(\"MATHE\"), CONSTRAINT \"BL_KH_MAGOITHANHVIEN_FK\" FOREIGN KEY(\"MAGOITHANHVIEN\") REFERENCES \"GOITHANHVIEN\"(\"MAGOITHANHVIEN\"));";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"DOANHTHU\" (\"MADOANHTHU\" TEXT NOT NULL, \"TIENTHU\" REAL, \"NGAYTONGKETDOANHTHU\" TEXT, \"I_NGAYTONGKETDOANHTHU\" INTEGER, CONSTRAINT \"DT_MADOANHTHU_PK\" PRIMARY KEY(\"MADOANHTHU\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"GOITHANHVIEN\" (\"MAGOITHANHVIEN\" TEXT NOT NULL, \"TENGOITHANHVIEN\" TEXT, \"THANG\" INTEGER, \"CHIPHI\" REAL, CONSTRAINT \"GT_MAGOITAP_PK\" PRIMARY KEY(\"MAGOITHANHVIEN\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"HOADON\" (\"MAHOADON\" TEXT NOT NULL, \"NGAYTHANHTOAN\" TEXT, \"TONGTIEN\" TEXT, \"MASANPHAM\" TEXT, \"MAKHACHHANG\" TEXT, \"I_NGAYTHANHTOAN\" TEXT, CONSTRAINT \"HD_MASANPHAM_FK\" FOREIGN KEY(\"MASANPHAM\") REFERENCES \"SANPHAM\"(\"MASANPHAM\"), CONSTRAINT \"HD_MAKHACHHANG_FK\" FOREIGN KEY(\"MAKHACHHANG\") REFERENCES \"KHACHHANG\"(\"MATHE\"), CONSTRAINT \"HD_MAHOADON_PK\" PRIMARY KEY(\"MAHOADON\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"KHACHHANG\" (\"MATHE\" TEXT NOT NULL, \"HOTEN\" TEXT, \"NGAYSINH\" TEXT, \"CMND\" TEXT, \"SDT\" TEXT, \"EMAIL\" TEXT, \"GHICHU\" TEXT, \"NGAYDANGKI\" TEXT, \"NGAYHETHAN\" TEXT, \"THOIHAN\" TEXT, \"ANH\" BLOB, \"GIOITINH\" TEXT, \"MAGOITHANHVIEN\", \"I_NGAYDANGKI\" INTEGER, \"DIACHI\" TEXT, CONSTRAINT \"KH_MATHE_PK\" PRIMARY KEY(\"MATHE\"), CONSTRAINT \"KH_MAGOITHANHVIEN_FK\" FOREIGN KEY(\"MAGOITHANHVIEN\") REFERENCES \"GOITHANHVIEN\"(\"MAGOITHANHVIEN\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"LOAICHUCVU\" (\"MALOAICHUCVU\" TEXT, \"TENLOAICHUCVU\" INTEGER, CONSTRAINT \"LCV_MaLoaiChucVu_PK\" PRIMARY KEY(\"MALOAICHUCVU\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"NHANVIEN\" (\"MANHANVIEN\" TEXT NOT NULL, \"HOTEN\" TEXT, \"NGAYSINH\" TEXT, \"GIOITINH\" TEXT, \"CMND\" TEXT, \"DIACHI\" TEXT, \"SDT\" TEXT, \"EMAIL\" TEXT, \"GHICHU\" TEXT, \"MALOAICHUCVU\" TEXT, \"ANH\" BLOB, CONSTRAINT \"NV_MaNhanVien_PK\" PRIMARY KEY(\"MANHANVIEN\"), CONSTRAINT \"LCV_MaLoaiChucVu\" FOREIGN KEY(\"MALOAICHUCVU\") REFERENCES \"LOAICHUCVU\"(\"MALOAICHUCVU\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"NHANVIEN\" (\"MANHANVIEN\" TEXT NOT NULL, \"HOTEN\" TEXT, \"NGAYSINH\" TEXT, \"GIOITINH\" TEXT, \"CMND\" TEXT, \"DIACHI\" TEXT, \"SDT\" TEXT, \"EMAIL\" TEXT, \"GHICHU\" TEXT, \"CHUCVU\" TEXT, \"ANH\" BLOB, PRIMARY KEY(\"MANHANVIEN\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"LOAISANPHAM\" (\"MALOAISANPHAM\" TEXT, \"TENLOAISANPHAM\" TEXT, CONSTRAINT \"LSP_MaLoaiSanPham_PK\" PRIMARY KEY(\"MALOAISANPHAM\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"SANPHAM\" (\"MASANPHAM\" TEXT NOT NULL, \"LOAISANPHAM\" TEXT, \"TENSANPHAM\" TEXT, \"GIATHANH\" REAL, \"GIANHAP\" REAL, \"SOLUONG\" INTEGER, \"ANH\" BLOB, CONSTRAINT \"SP_MaSanPham_PK\" PRIMARY KEY(\"MASANPHAM\"), CONSTRAINT \"SP_LSP_MaLoaiSanPham_FK\" FOREIGN KEY(\"LOAISANPHAM\") REFERENCES \"LOAISANPHAM\"(\"MALOAISANPHAM\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"LOAITAIKHOAN\" (\"MALOAITAIKHOAN\" TEXT, \"TENMALOAITAIKHOAN\" TEXT, \"MIEUTA\" TEXT, CONSTRAINT \"LTK_MaLoaiTaiKhoan_PK\" PRIMARY KEY(\"MALOAITAIKHOAN\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"QUYENTAIKHOAN\" (\"MAQUYENTAIKHOAN\" TEXT, \"TENQUYENTAIKHOAN\" TEXT, \"MIEUTA\" TEXT, CONSTRAINT \"QTK_MaQuyenTaiKhoan_PK\" PRIMARY KEY(\"MAQUYENTAIKHOAN\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"QUYENTAIKHOAN_LOAITAIKHOAN\" (\"MAQUYENTAIKHOAN\" TEXT, \"MALOAITAIKHOAN\" TEXT, \"MIEUTA\" TEXT, CONSTRAINT \"QTKLTK_MaQuyenTaiKhoan_MaLoaiTaiKhoan\" PRIMARY KEY(\"MAQUYENTAIKHOAN\",\"MALOAITAIKHOAN\"), CONSTRAINT \"LTK_MaLoaiTaiKhoan\" FOREIGN KEY(\"MALOAITAIKHOAN\") REFERENCES \"LOAITAIKHOAN\"(\"MALOAITAIKHOAN\"), CONSTRAINT \"QTK_MaQuyenTaiKhoan\" FOREIGN KEY(\"MAQUYENTAIKHOAN\") REFERENCES \"QUYENTAIKHOAN\"(\"MAQUYENTAIKHOAN\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();


                sql = "CREATE TABLE IF NOT EXISTS \"CHUCNANG\" (\"MACHUCNANG\" TEXT, \"TENCHUCNANG\" TEXT, \"MIEUTA\" TEXT, CONSTRAINT \"CN_MaChucNang_PK\" PRIMARY KEY(\"MACHUCNANG\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"CHUCNANG_QUYENTAIKHOAN\" (\"MACHUCNANG\" TEXT, \"MAQUYENTAIKHOAN\" TEXT, CONSTRAINT \"CN_QTK_MaChucNang_MaQuyenTaiKhoan\" PRIMARY KEY(\"MACHUCNANG\",\"MAQUYENTAIKHOAN\"), CONSTRAINT \"CN_MaChucNang\" FOREIGN KEY(\"MACHUCNANG\") REFERENCES \"CHUCNANG\"(\"MACHUCNANG\"), CONSTRAINT \"QTK_MaQuyenTaiKhoan\" FOREIGN KEY(\"MAQUYENTAIKHOAN\") REFERENCES \"QUYENTAIKHOAN\"(\"MAQUYENTAIKHOAN\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"TAIKHOAN\" (\"MATAIKHOAN\" TEXT NOT NULL, \"LOAITAIKHOAN\" TEXT, \"MATKHAU\" TEXT NOT NULL, \"EMAILCANHAN\" TEXT, \"MATAIKHOANNHANVIEN\" TEXT, CONSTRAINT \"UC_UserId_PK\" PRIMARY KEY(\"MATAIKHOAN\"), CONSTRAINT \"TK_LTK_MaLoaiTaiKhoan\" FOREIGN KEY(\"LOAITAIKHOAN\") REFERENCES \"LOAITAIKHOAN\"(\"MALOAITAIKHOAN\"), CONSTRAINT \"TK_NV_MaNhanVien_FK\" FOREIGN KEY(\"MATAIKHOANNHANVIEN\") REFERENCES \"NHANVIEN\"(\"MANHANVIEN\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"LOAITHIETBI\" (\"MALOAITHIETBI\" TEXT, \"TENLOAITHIETBI\" TEXT, CONSTRAINT \"LTB_MaLoaiThietBi_PK\" PRIMARY KEY(\"MALOAITHIETBI\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"CHIPHI\" (\"MACHIPHI\" TEXT NOT NULL, \"NGAYPHATSINH\" TEXT, \"TONGCHIPHI\" REAL, \"I_NGAYPHATSINH\" INTEGER, CONSTRAINT \"CP_MACHIPHI_PK\" PRIMARY KEY(\"MACHIPHI\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"THIETBI\" (\"MATHIETBI\" TEXT NOT NULL, \"TENTHIETBI\" TEXT, \"TINHTRANG\" TEXT, \"ANH\" BLOB, \"LOAITHIETBI\" TEXT, CONSTRAINT \"TB_MATHIETBI_PK\" PRIMARY KEY(\"MATHIETBI\"), CONSTRAINT \"TB_LTB_MaLoaiThietBi_PK\" FOREIGN KEY(\"LOAITHIETBI\") REFERENCES \"LOAITHIETBI\"(\"MaLoaiThietBi\"));";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            ThemDoanhThuTheoNgay();
            ThemChiPhiTheoNgay();
        }
        public void khoiTaoMotSoGiaTriMacDinh()
        {
            ThemCacChucNangMacDinh();
            ThemQuyenTaiKhoanMacDinh();
            ThemChucVuMacDinh();
            ThemLoaiTaiKhoanMacDinh();
            ThemQuyenTaiKhoanGanLienVoiLoaiTaiKhoan();
            themQuyenVaoChucNangMacDinh();
            ThemNhanVienMacDinh();
            ThemTaiKhoanMacDinh();
        }
        public bool Backup(string currentFilePath, string currentDBName, string destFilePath)
        {
            try
            {
                var srcFile = Path.Combine(currentFilePath, currentDBName);
                if (File.Exists(destFilePath))
                {
                    File.Delete(destFilePath);
                }
                File.Copy(srcFile, destFilePath);
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            return true;
        }
        public bool Restore(string filePath, string destFileName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                try
                {
                    conn.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    if (File.Exists(destFileName))
                    {
                        File.Delete(destFileName);
                    }
                    File.Move(filePath, destFileName);
                }
                catch (Exception e)
                {
                    return false;
                    throw e;
                }
            }
            return true;
        }
        private void ThemDoanhThuTheoNgay()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                DateTime now = DateTime.Now;
                conn.Open();
                string seconds = Math.Round((now.Year * 525948.766 + now.Month * 43829.0639 + now.Day * 1440) / (1000)).ToString();
                string sql = "SELECT COUNT(*) FROM DOANHTHU WHERE I_NGAYTONGKETDOANHTHU = @seconds";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@seconds", seconds);
                int tmp = Convert.ToInt32(cmd.ExecuteScalar());
                if (tmp != 0)
                {
                    conn.Close();
                    return;
                }
                string maDT = "DT" + now.Year.ToString() + now.Month.ToString("D2") + now.Day.ToString("D2");
                sql = "INSERT OR IGNORE INTO DOANHTHU(MADOANHTHU, TIENTHU, NGAYTONGKETDOANHTHU, I_NGAYTONGKETDOANHTHU) VALUES(@MADOANHTHU, @TIENTHU, @NGAYTONGKETDOANHTHU, @I_NGAYTONGKETDOANHTHU)";
                cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MADOANHTHU", maDT);
                cmd.Parameters.AddWithValue("@TIENTHU", 0);
                cmd.Parameters.AddWithValue("@NGAYTONGKETDOANHTHU", now.Date);
                cmd.Parameters.AddWithValue("@I_NGAYTONGKETDOANHTHU", seconds);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        

        private void ThemTaiKhoanMacDinh()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO TAIKHOAN(MATAIKHOAN, LOAITAIKHOAN, MATKHAU, EMAILCANHAN, MATAIKHOANNHANVIEN) VALUES(@MATAIKHOAN, @LOAITAIKHOAN, @MATKHAU, @EMAILCANHAN, @MATAIKHOANNHANVIEN)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MATAIKHOAN", "admin");
                cmd.Parameters.AddWithValue("@LOAITAIKHOAN", maLoaiTaiKhoanMacDinh);
                cmd.Parameters.AddWithValue("@MATKHAU", BCrypt.Net.BCrypt.HashPassword("admin123"));
                cmd.Parameters.AddWithValue("@EMAILCANHAN", "admin@example.com");
                cmd.Parameters.AddWithValue("@MATAIKHOANNHANVIEN", maTaiKhoanNhanVienMacDinh);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void ThemNhanVienMacDinh()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO NHANVIEN(MANHANVIEN,HOTEN,NGAYSINH,GIOITINH,CMND,DIACHI,SDT,EMAIL,GHICHU,MALOAICHUCVU) VALUES(@MANHANVIEN,@HOTEN,@NGAYSINH,@GIOITINH,@CMND,@DIACHI,@SDT,@EMAIL,@GHICHU,@MALOAICHUCVU)";
                DateTime ngaySinhMacDinh = new DateTime(2000, 1, 1);
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MANHANVIEN", maTaiKhoanNhanVienMacDinh);
                cmd.Parameters.AddWithValue("@HOTEN", "Nguyễn Văn A");
                cmd.Parameters.AddWithValue("@NGAYSINH", ngaySinhMacDinh);
                cmd.Parameters.AddWithValue("@GIOITINH", "Unknown");
                cmd.Parameters.AddWithValue("@CMND", "Unknown");
                cmd.Parameters.AddWithValue("@DIACHI", "Unknown");
                cmd.Parameters.AddWithValue("@SDT", "0123456879");
                cmd.Parameters.AddWithValue("@EMAIL", "Unknown");
                cmd.Parameters.AddWithValue("GHICHU", "Unknown");
                cmd.Parameters.AddWithValue("MALOAICHUCVU", maLoaiChucVuMacDinh);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void ThemChucVuMacDinh()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO LOAICHUCVU(MALOAICHUCVU, TENLOAICHUCVU) VALUES(@MALOAICHUCVU, @TENLOAICHUCVU)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALOAICHUCVU", maLoaiChucVuMacDinh);
                cmd.Parameters.AddWithValue("@TENLOAICHUCVU", "Quản lý");
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void ThemLoaiTaiKhoanMacDinh()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO LOAITAIKHOAN (MALOAITAIKHOAN, TENMALOAITAIKHOAN, MIEUTA) VALUES(@MALOAITAIKHOAN, @TENLOAITAIKHOAN, @MIEUTA)";
                var cmd = new SQLiteCommand(query,conn);
                cmd.Parameters.AddWithValue("@MALOAITAIKHOAN", maLoaiTaiKhoanMacDinh);
                cmd.Parameters.AddWithValue("@TENLOAITAIKHOAN", "Tài khoản admin");
                cmd.Parameters.AddWithValue("MIEUTA", "Có tất cả các quyền");
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void ThemQuyenTaiKhoanMacDinh()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO QUYENTAIKHOAN(MAQUYENTAIKHOAN, TENQUYENTAIKHOAN, MIEUTA) VALUES(@MAQUYENTAIKHOAN, @TENQUYENTAIKHOAN, @MIEUTA)";
                var cmd = new SQLiteCommand(query,conn);
                cmd.Parameters.AddWithValue("@MAQUYENTAIKHOAN", maQuyenTaiKhoanMacDinh);
                cmd.Parameters.AddWithValue("@TENQUYENTAIKHOAN", "admin");
                cmd.Parameters.AddWithValue("@MIEUTA", "Đây là quyền admin");
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        
        private void ThemQuyenTaiKhoanGanLienVoiLoaiTaiKhoan()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO QUYENTAIKHOAN_LOAITAIKHOAN(MAQUYENTAIKHOAN, MALOAITAIKHOAN) VALUES(@MAQUYENTAIKHOAN, @MALOAITAIKHOAN)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAQUYENTAIKHOAN", maQuyenTaiKhoanMacDinh);
                cmd.Parameters.AddWithValue("@MALOAITAIKHOAN", maLoaiTaiKhoanMacDinh);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void ThemCacChucNangMacDinh()
        {
            // Kiểm tra nếu danh sách rỗng thì không thực hiện gì cả
            if (listChucNangMacDinh == null || listChucNangMacDinh.Count == 0)
            {
                Console.WriteLine("Danh sách chức năng rỗng. Không có gì để thêm vào cơ sở dữ liệu.");
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbName))
                {
                    conn.Open();

                    // Sử dụng transaction để tăng hiệu suất khi thêm nhiều bản ghi
                    using (var transaction = conn.BeginTransaction())
                    {
                        string query = @"
                        INSERT OR IGNORE INTO CHUCNANG (MACHUCNANG, TENCHUCNANG, MIEUTA) 
                        VALUES (@MACHUCNANG, @TENCHUCNANG, @MIEUTA)";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            foreach (var chucNang in listChucNangMacDinh)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@MACHUCNANG", chucNang.MaChucNang);
                                cmd.Parameters.AddWithValue("@TENCHUCNANG", chucNang.TenChucNang);
                                cmd.Parameters.AddWithValue("@MIEUTA", chucNang.MieuTa);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Commit transaction sau khi thêm xong tất cả các bản ghi
                        transaction.Commit();
                    }

                    conn.Close();
                }

                Console.WriteLine("Thêm chức năng thành công vào cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi thêm chức năng: {ex.Message}");
                // Bạn có thể xử lý lỗi thêm ở đây, ví dụ ghi log hoặc ném lại ngoại lệ
            }
        }

        private void themQuyenVaoChucNangMacDinh()
        {
            // Kiểm tra nếu danh sách chức năng rỗng thì không thực hiện gì cả
            if (listChucNangMacDinh == null || listChucNangMacDinh.Count == 0)
            {
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbName))
                {
                    conn.Open();

                    // Sử dụng transaction để tăng hiệu suất khi thêm nhiều bản ghi
                    using (var transaction = conn.BeginTransaction())
                    {
                        string query = @"
                        INSERT OR IGNORE INTO CHUCNANG_QUYENTAIKHOAN (MACHUCNANG, MAQUYENTAIKHOAN) 
                        VALUES (@MACHUCNANG, @MAQUYENTAIKHOAN)";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            foreach (var chucNang in listChucNangMacDinh)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@MACHUCNANG", chucNang.MaChucNang);
                                cmd.Parameters.AddWithValue("@MAQUYENTAIKHOAN", maQuyenTaiKhoanMacDinh);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Commit transaction sau khi thêm xong tất cả các bản ghi
                        transaction.Commit();
                    }

                    conn.Close();
                }

                Console.WriteLine("Gán quyền admin mặc định cho tất cả các chức năng thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi gán quyền cho admin: {ex.Message}");
                // Bạn có thể xử lý lỗi thêm ở đây, ví dụ ghi log hoặc ném lại ngoại lệ
            }
        }

        private void ThemChiPhiTheoNgay()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                DateTime now = DateTime.Now;
                conn.Open();
                string seconds = Math.Round((now.Year * 525948.766 + now.Month * 43829.0639 + now.Day * 1440) / (1000)).ToString();
                string sql = "SELECT COUNT(*) FROM CHIPHI WHERE I_NGAYPHATSINH = @seconds";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@seconds", seconds);
                int tmp = Convert.ToInt32(cmd.ExecuteScalar());
                if (tmp != 0)
                {
                    conn.Close();
                    return;
                }
                string maCP = "CP" + now.Year.ToString() + now.Month.ToString("D2") + now.Day.ToString("D2");
                sql = "INSERT OR IGNORE INTO CHIPHI(MACHIPHI, NGAYPHATSINH, TONGCHIPHI, I_NGAYPHATSINH) VALUES(@MACHIPHI, @NGAYPHATSINH, @TONGCHIPHI, @I_NGAYPHATSINH)";
                cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MACHIPHI", maCP);
                cmd.Parameters.AddWithValue("@TONGCHIPHI", 0);
                cmd.Parameters.AddWithValue("@NGAYPHATSINH", now.Date);
                cmd.Parameters.AddWithValue("@I_NGAYPHATSINH", seconds);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        
    }
    public class DatabaseAccess
    {
        // Tác vụ liên quan đến TÀI KHOẢN
        public static string dbName = "Data Source=QuanLyCuaHangHappyStore.db";

        public static int ifEquipmentInDB(string equipmentId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM THIETBI WHERE MATHIETBI=@equipmentId";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                int i = Convert.ToInt16(cmd.ExecuteScalar()); 
                conn.Close();
                return i;
            }
        }
        public static bool AddAccountToDB(TaiKhoan taikhoan)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string sql = "INSERT OR IGNORE INTO TAIKHOAN(MATAIKHOAN, LOAITAIKHOAN, MATKHAU, EMAILCANHAN) " +
                      "VALUES(@MATAIKHOAN, @LOAITAIKHOAN, @MATKHAU, @EMAILCANHAN)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MATAIKHOAN", taikhoan.MaTaiKhoan);
                cmd.Parameters.AddWithValue("@LOAITAIKHOAN", taikhoan.LoaiTK);
                cmd.Parameters.AddWithValue("@MATKHAU", taikhoan.MatKhau);
                cmd.Parameters.AddWithValue("@EMAILCANHAN", taikhoan.Email);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public static int CheckAccountTypeInDB(TaiKhoan taikhoan)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                int loaitk = 0;
                string readInf = "SELECT LOAITAIKHOAN FROM TAIKHOAN WHERE MATAIKHOAN = @MATAIKHOAN";
                var cmd = new SQLiteCommand(readInf, conn);
                cmd.Parameters.AddWithValue("@MATAIKHOAN", taikhoan.MaTaiKhoan);
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    loaitk = Convert.ToInt32(reader["LOAITAIKHOAN"]);
                }
                reader.Close();
                conn.Close();
                return loaitk;
            }
        }

        public static string LayEmailCaNhan(TaiKhoan taikhoan)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string sql = "SELECT EMAILCANHAN FROM TAIKHOAN WHERE MATAIKHOAN = @MATAIKHOAN";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MATAIKHOAN", taikhoan.MaTaiKhoan);
                string rs = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return rs;
            }
        }

        public static string getAccountPasswordInDB(TaiKhoan taikhoan)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string sql = "SELECT MATKHAU FROM TAIKHOAN WHERE MATAIKHOAN=@MATAIKHOAN";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MATAIKHOAN", taikhoan.MaTaiKhoan);
                var reader = cmd.ExecuteReader();
                string password = "";
                if (reader.Read())
                {
                    password = reader["MATKHAU"].ToString();
                }
                reader.Close();
                conn.Close();
                return password;
            }
        }

        public static bool ifAccountExsitsInDB(string maTaiKhoan)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string sql = "SELECT * FROM TAIKHOAN WHERE MATAIKHOAN=@MATAIKHOAN";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MATAIKHOAN", maTaiKhoan);
                var dta = cmd.ExecuteReader();
                bool exists = dta.Read();
                dta.Close();
                conn.Close();
                return exists;
            }
        }

        public static bool updatePasswordToDB(TaiKhoan taikhoan)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string Doimk = "UPDATE TAIKHOAN SET MATKHAU=@MATKHAU WHERE MATAIKHOAN=@MATAIKHOAN";
                var cmd = new SQLiteCommand(Doimk, conn);
                cmd.Parameters.AddWithValue("@MATKHAU", taikhoan.MatKhau);
                cmd.Parameters.AddWithValue("@MATAIKHOAN", taikhoan.MaTaiKhoan);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
        }

        public static int checkEmail(string email)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string Doimk = "SELECT COUNT(*) FROM TAIKHOAN WHERE EMAILCANHAN=@EMAILCANHAN";
                var cmd = new SQLiteCommand(Doimk, conn);
                cmd.Parameters.AddWithValue("@EMAILCANHAN", email);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        // SỬA THÔNG TIN (UPDATE)
        public static string UpdatethongtinKH(KHACHHANG kh)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string updateKH = "UPDATE KHACHHANG SET HOTEN=@HOTEN,CMND=@CMND,NGAYSINH=@NGAYSINH,GIOITINH=@GIOITINH,DIACHI=@DIACHI,SDT=@SDT,EMAIL=@EMAIL,GHICHU=@GHICHU,MAGOITHANHVIEN=@MAGOITHANHVIEN,NGAYDANGKI=@NGAYDANGKI,NGAYHETHAN=@NGAYHETHAN,THOIHAN=@THOIHAN,ANH=@ANH WHERE MATHE=@MATHE";
                var command = new SQLiteCommand(updateKH, conn);
                command.Parameters.AddWithValue("@MATHE", kh.Mathe);
                command.Parameters.AddWithValue("@HOTEN", kh.Hoten);
                command.Parameters.AddWithValue("@NGAYSINH", kh.Ngaysinh);
                
                command.Parameters.AddWithValue("@GIOITINH", kh.Gioitinh);
                command.Parameters.AddWithValue("@CMND", kh.CMND);
                command.Parameters.AddWithValue("@DIACHI", kh.diaChi);
                command.Parameters.AddWithValue("@SDT", kh.SDT);
                command.Parameters.AddWithValue("@EMAIL", kh.Email);
                command.Parameters.AddWithValue("@GHICHU", kh.GhiChu);
                command.Parameters.AddWithValue("@MAGOITHANHVIEN", kh.MaGoiThanhVien);
                command.Parameters.AddWithValue("@THOIHAN", kh.ThoiHan);
                command.Parameters.AddWithValue("@ANH", kh.Anh);
                int rowsAffected = command.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0 ? "success" : "fail";
            }
        }

        public static string UpdatethongtinTB(THIETBI tb)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string updateTB = "UPDATE THIETBI SET TENTHIETBI=@TENTHIETBI,LOAITHIETBI=@LOAITHIETBI,TINHTRANG=@TINHTRANG,ANH=@ANH WHERE MATHIETBI=@MATHIETBI";
                var command = new SQLiteCommand(updateTB, conn);
                command.Parameters.AddWithValue("@MATHIETBI", tb.Mathietbi);
                command.Parameters.AddWithValue("@TENTHIETBI", tb.Tenthietbi);
                command.Parameters.AddWithValue("@LOAITHIETBI", tb.Loaithietbi);
                command.Parameters.AddWithValue("@TINHTRANG", tb.Tinhtrang);
                command.Parameters.AddWithValue("@ANH", tb.Anh);
                int rowsAffected = command.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0 ? "success" : "fail";
            }
        }

        public static string UpdatethongtinSanPham(SanPham sp)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string updateSP = "UPDATE SANPHAM SET MASANPHAM=@MASANPHAM,TENSANPHAM=@TENSANPHAM,GIATHANH=@GIATHANH,SOLUONG=@SOLUONG,LOAISANPHAM=@LOAISANPHAM,ANH=@ANH WHERE MASANPHAM=@MASANPHAM";
                var command = new SQLiteCommand(updateSP, conn);
                command.Parameters.AddWithValue("@MASANPHAM", sp.MaSP);
                command.Parameters.AddWithValue("@TENSANPHAM", sp.TenSP);
                command.Parameters.AddWithValue("@LOAISANPHAM", sp.LoaiSP);
                command.Parameters.AddWithValue("@GIATHANH", sp.GiaThanh);
                command.Parameters.AddWithValue("@SOLUONG", sp.SL);
                command.Parameters.AddWithValue("@ANH", sp.Anh);
                int rowsAffected = command.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0 ? "success" : "fail";
            }
        }

        public static string UpdatethongtinNV(NHANVIEN nv)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string updateNV = "UPDATE NHANVIEN SET MANHANVIEN=@MANHANVIEN,HOTEN=@HOTEN,NGAYSINH=@NGAYSINH,GIOITINH=@GIOITINH,DIACHI=@DIACHI,CMND=@CMND,SDT=@SDT,EMAIL=@EMAIL,GHICHU=@GHICHU,ANH=@ANH WHERE MANHANVIEN=@MANHANVIEN";
                var command = new SQLiteCommand(updateNV, conn);
                command.Parameters.AddWithValue("@MANHANVIEN", nv.maNhanVien);
                command.Parameters.AddWithValue("@HOTEN", nv.Hoten);
                command.Parameters.AddWithValue("@NGAYSINH", nv.Ngaysinh);
                command.Parameters.AddWithValue("@GIOITINH", nv.Gioitinh);
                command.Parameters.AddWithValue("@CMND", nv.CMND);
                command.Parameters.AddWithValue("@DIACHI", nv.diaChi);
                command.Parameters.AddWithValue("@SDT", nv.SDT);
                command.Parameters.AddWithValue("@EMAIL", nv.Email);
                command.Parameters.AddWithValue("@GHICHU", nv.GhiChu);
                command.Parameters.AddWithValue("@ANH", nv.Anh);
                int rowsAffected = command.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0 ? "success" : "fail";
            }
        }

        public static void UpdateDoanhThu(double themDoanhThu)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                DateTime now = DateTime.Now;
                conn.Open();
                DOANHTHU doanhthu = LayDoanhThuTheoNgay(now);
                string seconds = Math.Round((now.Year * 525948.766 + now.Month * 43829.0639 + now.Day * 1440) / (1000)).ToString();
                double tienThu = doanhthu.TienThu + themDoanhThu;
                string sql = "UPDATE DOANHTHU set TIENTHU=@TIENTHU WHERE I_NGAYTONGKETDOANHTHU = @seconds";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TIENTHU", tienThu);
                cmd.Parameters.AddWithValue("@seconds", seconds);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        // XEM THÔNG TIN LIST

        public static DOANHTHU LayDoanhThuTheoNgay(DateTime datetime)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                DOANHTHU doanhThu = new DOANHTHU();
                conn.Open();
                string seconds = Math.Round((datetime.Year * 525948.766 + datetime.Month * 43829.0639 + datetime.Day * 1440) / (1000)).ToString();
                string sql = "SELECT * FROM DOANHTHU WHERE I_NGAYTONGKETDOANHTHU = @seconds";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@seconds", seconds);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    doanhThu = new DOANHTHU
                    {
                        MaDoanhThu = reader["MADOANHTHU"].ToString(),
                        TienThu = Convert.ToDouble(reader["TIENTHU"]),
                        NgayTongKetDoanhThu = Convert.ToDateTime(reader["NGAYTONGKETDOANHTHU"]),
                    };
                }
                conn.Close();
                return doanhThu;
            }
        }
        public static List<string> xemMAHLV(string chucvu)
        {
            List<string> listmaHLV = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readinf = "SELECT MANHANVIEN FROM NHANVIEN WHERE CHUCVU=@CHUCVU";
                var command = new SQLiteCommand(readinf, conn);
                command.Parameters.AddWithValue("@CHUCVU", chucvu);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listmaHLV.Add(reader["MANHANVIEN"].ToString());
                }
                reader.Close();
                conn.Close();
            }
            return listmaHLV;
        }

        public static List<string> xemListMaThe()
        {
            List<string> listmathe = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readinf = "SELECT MATHE FROM KHACHHANG";
                var cmd = new SQLiteCommand(readinf, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listmathe.Add(reader["MATHE"].ToString());
                }
                reader.Close();
                conn.Close();
            }
            return listmathe;
        }

        public static List<string> xemListMaTBBT()
        {
            List<string> listMaTBBT = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readinf = "SELECT MATHIETBI FROM THIETBI WHERE TINHTRANG='BAOTRI'";
                var cmd = new SQLiteCommand(readinf, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listMaTBBT.Add(reader["MATHIETBI"].ToString());
                }
                reader.Close();
                conn.Close();
            }
            return listMaTBBT;
        }

        public static List<string> xemListMaSP()
        {
            List<string> listMaSP = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readinf = "SELECT MASANPHAM FROM SANPHAM";
                var cmd = new SQLiteCommand(readinf, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listMaSP.Add(reader["MASANPHAM"].ToString());
                }
                reader.Close();
                conn.Close();
            }
            return listMaSP;
        }

        public static List<string> xemGoiThanhVien()
        {
            List<string> maGoiTapList = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string sql = "SELECT MAGOITHANHVIEN FROM GOITHANHVIEN";
                var command = new SQLiteCommand(sql, conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    maGoiTapList.Add(reader["MAGOITHANHVIEN"].ToString());
                }
                reader.Close();
                conn.Close();
            }
            return maGoiTapList;
        }

        public static bool themGoiThanhVien(GOITHANHVIEN goitap)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string sql = "INSERT OR IGNORE INTO GOITHANHVIEN(MAGOITHANHVIEN,TENGOITHANHVIEN,THANG,CHIPHI) VALUES(@MAGOITHANHVIEN,@TENGOITHANHVIEN,@THANG,@CHIPHI)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MAGOITHANHVIEN", goitap.MaGoiThanhVien);
                cmd.Parameters.AddWithValue("@TENGOITHANHVIEN", goitap.TenGoiThanhVien);
                cmd.Parameters.AddWithValue("@THANG", goitap.Thang);
                cmd.Parameters.AddWithValue("@CHIPHI", goitap.ChiPhi);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public static int demGoiThanhVien()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM GOITHANHVIEN";
                var cmd = new SQLiteCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        public static List<NHANVIEN> xemNhanVien()
        {
            List<NHANVIEN> listNV = new List<NHANVIEN>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readInf = "SELECT MANHANVIEN,HOTEN,NGAYSINH,GIOITINH,CMND,DIACHI,SDT,EMAIL,GHICHU,CHUCVU FROM NHANVIEN WHERE CHUCVU='LETAN' OR CHUCVU='BAOVE'";
                var cmd = new SQLiteCommand(readInf, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NHANVIEN nhanvien = new NHANVIEN
                    {
                        maNhanVien = reader["MANHANVIEN"].ToString(),
                        Hoten = reader["HOTEN"].ToString(),
                        Ngaysinh = Convert.ToDateTime(reader["NGAYSINH"]),
                        Email = reader["EMAIL"].ToString(),
                        Gioitinh = reader["GIOITINH"].ToString(),
                        CMND = reader["CMND"].ToString(),
                        diaChi = reader["DIACHI"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        GhiChu = reader["GHICHU"].ToString(),
                        Chucvu = reader["CHUCVU"].ToString()
                    };
                    listNV.Add(nhanvien);
                }
                reader.Close();
                conn.Close();
            }
            return listNV;
        }

        public static List<THIETBI> xemDanhsachTB(string loaitb)
        {
            List<THIETBI> lstbtheoloai = new List<THIETBI>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string selectTBtheoloai = "SELECT MATHIETBI,TENTHIETBI,TINHTRANG,LOAITHIETBI FROM THIETBI WHERE LOAITHIETBI=@LOAITHIETBI";
                var cmd = new SQLiteCommand(selectTBtheoloai, conn);
                cmd.Parameters.AddWithValue("@LOAITHIETBI", loaitb);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    THIETBI tb = new THIETBI
                    {
                        Mathietbi = reader["MATHIETBI"].ToString(),
                        Loaithietbi = reader["LOAITHIETBI"].ToString(),
                        Tenthietbi = reader["TENTHIETBI"].ToString(),
                        Tinhtrang = reader["TINHTRANG"].ToString()
                    };
                    lstbtheoloai.Add(tb);
                }
                reader.Close();
                conn.Close();
            }
            return lstbtheoloai;
        }

        public static List<THIETBI> xemTB()
        {
            List<THIETBI> listTB = new List<THIETBI>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readInf = "SELECT MATHIETBI,TENTHIETBI,LOAITHIETBI,TINHTRANG FROM THIETBI";
                var cmd = new SQLiteCommand(readInf, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    THIETBI tb = new THIETBI
                    {
                        Mathietbi = reader["MATHIETBI"].ToString(),
                        Tenthietbi = reader["TENTHIETBI"].ToString(),
                        Loaithietbi = reader["LOAITHIETBI"].ToString(),
                        Tinhtrang = reader["TINHTRANG"].ToString()
                    };
                    listTB.Add(tb);
                }
                reader.Close();
                conn.Close();
            }
            return listTB;
        }

        public static List<THIETBI> xemTBBT()
        {
            List<THIETBI> listTB = new List<THIETBI>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readInf = "SELECT MATHIETBI,TENTHIETBI,TINHTRANG,LOAITHIETBI FROM THIETBI WHERE TINHTRANG='BAOTRI'";
                var cmd = new SQLiteCommand(readInf, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    THIETBI tb = new THIETBI
                    {
                        Mathietbi = reader["MATHIETBI"].ToString(),
                        Tenthietbi = reader["TENTHIETBI"].ToString(),
                        Tinhtrang = reader["TINHTRANG"].ToString(),
                        Loaithietbi = reader["LOAITHIETBI"].ToString()
                    };
                    listTB.Add(tb);
                }
                reader.Close();
                conn.Close();
            }
            return listTB;
        }

        public static List<NHANVIEN> xemHuanLuyenVien(string chucVu)
        {
            List<NHANVIEN> listHLV = new List<NHANVIEN>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readInf = "SELECT MANHANVIEN,HOTEN,NGAYSINH,GIOITINH,CMND,DIACHI,SDT,EMAIL,GHICHU,CHUCVU FROM NHANVIEN WHERE CHUCVU=@CHUCVU";
                var cmd = new SQLiteCommand(readInf, conn);
                cmd.Parameters.AddWithValue("CHUCVU", chucVu);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NHANVIEN nhanvien = new NHANVIEN
                    {
                        maNhanVien = reader["MANHANVIEN"].ToString(),
                        Hoten = reader["HOTEN"].ToString(),
                        Ngaysinh = Convert.ToDateTime(reader["NGAYSINH"]),
                        Email = reader["EMAIL"].ToString(),
                        Gioitinh = reader["GIOITINH"].ToString(),
                        CMND = reader["CMND"].ToString(),
                        diaChi = reader["DIACHI"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        GhiChu = reader["GHICHU"].ToString(),
                        Chucvu = reader["CHUCVU"].ToString()
                    };
                    listHLV.Add(nhanvien);
                }
                reader.Close();
                conn.Close();
            }
            return listHLV;
        }

        public static List<KHACHHANG> XemKH()
        {
            List<KHACHHANG> listKH = new List<KHACHHANG>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readInf = "SELECT MATHE,HOTEN,NGAYSINH,GIOITINH,CMND,DIACHI,SDT,EMAIL,GHICHU,MAGOITHANHVIEN,NGAYDANGKI,NGAYHETHAN,THOIHAN FROM KHACHHANG";
                var cmd = new SQLiteCommand(readInf, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KHACHHANG kh = new KHACHHANG
                    {
                        Mathe = reader["MATHE"].ToString(),
                        Hoten = reader["HOTEN"].ToString(),
                        Ngaysinh = Convert.ToDateTime(reader["NGAYSINH"]),
                        Email = reader["EMAIL"].ToString(),
                        Gioitinh = reader["GIOITINH"].ToString(),
                        CMND = reader["CMND"].ToString(),
                        diaChi = reader["DIACHI"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        GhiChu = reader["GHICHU"].ToString(),
                        MaGoiThanhVien = reader["MAGOITHANHVIEN"].ToString(),
                        //Convert.ToDateTime(reader["NGAYTHANHTOAN"])
                        NgayBatDau = Convert.ToDateTime(reader["NGAYDANGKI"]),
                        NgayHetHan = Convert.ToDateTime(reader["NGAYHETHAN"]),
                        
                        ThoiHan = Convert.ToDateTime(reader["THOIHAN"])
                    };
                    listKH.Add(kh);
                }
                reader.Close();
                conn.Close();
            }
            return listKH;
        }

        public static List<SanPham> xemListSP()
        {
            List<SanPham> lsp = new List<SanPham>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT MASANPHAM,LOAISANPHAM,TENSANPHAM,GIATHANH,SOLUONG,ANH FROM SANPHAM";
                var cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sp = new SanPham
                    {
                        MaSP = reader["MASANPHAM"].ToString(),
                        LoaiSP = reader["LOAISANPHAM"].ToString(),
                        TenSP = reader["TENSANPHAM"].ToString(),
                        GiaThanh = Convert.ToInt32(reader["GIATHANH"]),
                        SL = Convert.ToInt32(reader["SOLUONG"]),
                        Anh = (byte[])reader["ANH"]
                    };
                    lsp.Add(sp);
                }
                reader.Close();
                conn.Close();
            }
            return lsp;
        }

        public static List<SanPham> xemListSPtheoLoai(string loaisp)
        {
            List<SanPham> lsp = new List<SanPham>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT MASANPHAM,LOAISANPHAM,TENSANPHAM,GIATHANH,SOLUONG,ANH FROM SANPHAM WHERE LOAISANPHAM=@LOAISANPHAM";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@LOAISANPHAM", loaisp);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sp = new SanPham
                    {
                        MaSP = reader["MASANPHAM"].ToString(),
                        LoaiSP = reader["LOAISANPHAM"].ToString(),
                        TenSP = reader["TENSANPHAM"].ToString(),
                        GiaThanh = Convert.ToInt32(reader["GIATHANH"]),
                        SL = Convert.ToInt32(reader["SOLUONG"]),
                        Anh = (byte[])reader["ANH"]
                    };
                    lsp.Add(sp);
                }
                reader.Close();
                conn.Close();
            }
            return lsp;
        }       
        
        public static CHIPHI LayChiPhiTheoNgay(DateTime datetime)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                CHIPHI chiPhi = new CHIPHI();
                conn.Open();
                string seconds = Math.Round((datetime.Year * 525948.766 + datetime.Month * 43829.0639 + datetime.Day * 1440) / (1000)).ToString();
                string sql = "SELECT * FROM CHIPHI WHERE I_NGAYPHATSINH = @seconds";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@seconds", seconds);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chiPhi = new CHIPHI
                    {
                        MaChiPhi = reader["MACHIPHI"].ToString(),
                        NgayPhatSinh = Convert.ToDateTime(reader["NGAYPHATSINH"]),
                        TongChiPhi = Convert.ToDouble(reader["TONGCHIPHI"]),
                    };
                }
                conn.Close();
                return chiPhi;
            }
        }

        //THÊM DỮ LIỆU
        public static bool UpdateChiPhi(double chiPhiMoi)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                DateTime now = DateTime.Now;
                conn.Open();
                CHIPHI chiPhi = LayChiPhiTheoNgay(now);
                string seconds = Math.Round((now.Year * 525948.766 + now.Month * 43829.0639 + now.Day * 1440) / (1000)).ToString();
                double tongChiPhi = chiPhi.TongChiPhi + chiPhiMoi;
                string sql = "UPDATE CHIPHI set TONGCHIPHI=@TONGCHIPHI WHERE I_NGAYPHATSINH = @seconds";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TONGCHIPHI", tongChiPhi);
                cmd.Parameters.AddWithValue("@seconds", seconds);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public static bool ThemHoaDon(HOADON hd)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                DateTime hdDT = hd.NgayThanhToan;
                string seconds = Math.Round((hdDT.Year * 525948.766 + hdDT.Month * 43829.0639 + hdDT.Day * 1440) / (1000)).ToString();
                conn.Open();
                string query = "INSERT OR IGNORE INTO HOADON(MAHOADON,MASANPHAM,NGAYTHANHTOAN,TONGTIEN,MAKHACHHANG, I_NGAYTHANHTOAN) VALUES(@MAHOADON,@MASANPHAM,@NGAYTHANHTOAN,@TONGTIEN,@MAKHACHHANG, @I_NGAYTHANHTOAN)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAHOADON", hd.MaHoaDon);
                cmd.Parameters.AddWithValue("@MASANPHAM", hd.MaSP);
                cmd.Parameters.AddWithValue("@NGAYTHANHTOAN", hd.NgayThanhToan);
                cmd.Parameters.AddWithValue("@TONGTIEN", hd.TongTien);
                cmd.Parameters.AddWithValue("@MAKHACHHANG", hd.MaThe);
                cmd.Parameters.AddWithValue("@I_NGAYTHANHTOAN", seconds);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                UpdateDoanhThu((int)hd.TongTien);
                return rowsAffected > 0;
            }

        }

        public static bool themThietBi(THIETBI tb)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO THIETBI(MATHIETBI,TENTHIETBI,LOAITHIETBI,TINHTRANG,ANH) VALUES(@MATHIETBI,@TENTHIETBI,@LOAITHIETBI,@TINHTRANG,@ANH)";
                var command = new SQLiteCommand(query, conn);
                if (CheckDuplicate(tb.Mathietbi))
                {
                    command.Parameters.AddWithValue("@MATHIETBI", tb.Mathietbi);
                    command.Parameters.AddWithValue("@TENTHIETBI", tb.Tenthietbi);
                    command.Parameters.AddWithValue("@TINHTRANG", tb.Tinhtrang);
                    command.Parameters.AddWithValue("@ANH", tb.Anh);
                    command.Parameters.AddWithValue("@LOAITHIETBI", tb.Loaithietbi);
                    int rowsAffected = command.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
                return false;
            }
        }

        public static bool themNhanVien(NHANVIEN nv)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO NHANVIEN(MANHANVIEN,HOTEN,NGAYSINH,GIOITINH,CMND,DIACHI,SDT,EMAIL,GHICHU,CHUCVU,ANH) VALUES(@MANHANVIEN,@HOTEN,@NGAYSINH,@GIOITINH,@CMND,@DIACHI,@SDT,@EMAIL,@GHICHU,@CHUCVU,@ANH)";
                var command = new SQLiteCommand(query, conn);
                if (!kiemtraNhanVien(nv.maNhanVien))
                {
                    command.Parameters.AddWithValue("@MANHANVIEN", nv.maNhanVien);
                    command.Parameters.AddWithValue("@HOTEN", nv.Hoten);
                    command.Parameters.AddWithValue("@NGAYSINH", nv.Ngaysinh);
                    command.Parameters.AddWithValue("@GIOITINH", nv.Gioitinh);
                    command.Parameters.AddWithValue("@CMND", nv.CMND);
                    command.Parameters.AddWithValue("@DIACHI", nv.diaChi);
                    command.Parameters.AddWithValue("@SDT", nv.SDT);
                    command.Parameters.AddWithValue("@EMAIL", nv.Email);
                    command.Parameters.AddWithValue("@GHICHU", nv.GhiChu);
                    command.Parameters.AddWithValue("@CHUCVU", nv.Chucvu);
                    command.Parameters.AddWithValue("@ANH", nv.Anh);
                    int rowsAffected = command.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
                return false;
            }
        }

        public static bool themTaiKhoan(KHACHHANG kh)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO KHACHHANG(MATHE,HOTEN,NGAYSINH,GIOITINH,CMND,DIACHI,SDT,EMAIL,GHICHU,MAGOITHANHVIEN,NGAYDANGKI,NGAYHETHAN,THOIHAN,ANH,I_NGAYDANGKI) VALUES(@MATHE,@HOTEN,@NGAYSINH,@GIOITINH,@CMND,@DIACHI,@SDT,@EMAIL,@GHICHU,@MAGOITHANHVIEN,@NGAYDANGKI,@NGAYHETHAN,@THOIHAN,@ANH,@I_NGAYDANGKI)";
                var command = new SQLiteCommand(query, conn);
                if (!CheckPrimaryKeyDuplicate(kh.Mathe))
                {
                    command.Parameters.AddWithValue("@MATHE", kh.Mathe);
                    command.Parameters.AddWithValue("@HOTEN", kh.Hoten);
                    command.Parameters.AddWithValue("@NGAYSINH", kh.Ngaysinh);
                    command.Parameters.AddWithValue("@GIOITINH", kh.Gioitinh);
                    command.Parameters.AddWithValue("@CMND", kh.CMND);
                    command.Parameters.AddWithValue("@DIACHI", kh.diaChi);
                    command.Parameters.AddWithValue("@SDT", kh.SDT);
                    command.Parameters.AddWithValue("@EMAIL", kh.Email);
                    command.Parameters.AddWithValue("@GHICHU", kh.GhiChu);
                    command.Parameters.AddWithValue("@MAGOITHANHVIEN", kh.MaGoiThanhVien);
                    command.Parameters.AddWithValue("@NGAYDANGKI", kh.NgayBatDau);
                    command.Parameters.AddWithValue("@NGAYHETHAN", kh.NgayHetHan);
                    command.Parameters.AddWithValue("@THOIHAN", kh.ThoiHan);
                    command.Parameters.AddWithValue("@ANH", kh.Anh);
                    command.Parameters.AddWithValue("@I_NGAYDANGKI", kh.Seconds);
                    int rowsAffected = command.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
                return false;
            }
        }

        public static void ThemBienLai(BIENLAI bl)
        {
            int tongtien = 0;
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                DateTime blDT = bl.NgayThanhToan;
                string seconds = Math.Round((blDT.Year * 525948.766 + blDT.Month * 43829.0639 + blDT.Day * 1440) / (1000)).ToString();
                conn.Open();
                string query = "INSERT OR IGNORE INTO BIENLAI(MABIENLAI,MATHE,MAGOITHANHVIEN,TONGTIEN,NGAYTHANHTOAN, I_NGAYTHANHTOAN) VALUES (@MABIENLAI,@MATHE,@MAGOITHANHVIEN,@TONGTIEN,@NGAYTHANHTOAN, @I_NGAYTHANHTOAN)";
                string select = "SELECT CHIPHI FROM GOITHANHVIEN WHERE MAGOITHANHVIEN=@MAGOITHANHVIEN";
                var selectcmd = new SQLiteCommand(select, conn);
                selectcmd.Parameters.AddWithValue("@MAGOITHANHVIEN", bl.MaGoiThanhVien);
                int chiPhiGoiThanhVien = Convert.ToInt32(selectcmd.ExecuteScalar());
                tongtien = chiPhiGoiThanhVien;
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MABIENLAI", bl.MaBienLai);
                cmd.Parameters.AddWithValue("@MATHE", bl.MaThe);
                cmd.Parameters.AddWithValue("@MAGOITHANHVIEN", bl.MaGoiThanhVien);
                cmd.Parameters.AddWithValue("@NGAYTHANHTOAN", bl.NgayThanhToan);
                cmd.Parameters.AddWithValue("@TONGTIEN", tongtien);
                cmd.Parameters.AddWithValue("I_NGAYTHANHTOAN", seconds);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            UpdateDoanhThu(tongtien);
        }

        public static bool ThemSanPham(SanPham sp)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO SANPHAM(MASANPHAM,LOAISANPHAM,TENSANPHAM,GIATHANH, GIANHAP,SOLUONG,ANH) VALUES(@MASANPHAM,@LOAISANPHAM,@TENSANPHAM,@GIATHANH,@GIANHAP,@SOLUONG,@ANH)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MASANPHAM", sp.MaSP);
                cmd.Parameters.AddWithValue("@LOAISANPHAM", sp.LoaiSP);
                cmd.Parameters.AddWithValue("@TENSANPHAM", sp.TenSP);
                cmd.Parameters.AddWithValue("@GIATHANH", sp.GiaThanh);
                cmd.Parameters.AddWithValue("@GIANHAP", sp.GiaNhap);
                cmd.Parameters.AddWithValue("@SOLUONG", sp.SL);
                cmd.Parameters.AddWithValue("@ANH", sp.Anh);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
        }

        // KIỂM TRA PRIMARY KEY && Count dữ liệu
        public static int demsoKH()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KHACHHANG";
                var cmd = new SQLiteCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        public static int demHoaDon()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM HOADON";
                var cmd = new SQLiteCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        public static int demGD(string loaichiphi)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM GIAODICH WHERE LOAICHIPHI=@LOAICHIPHI";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@LOAICHIPHI", loaichiphi);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        public static int demSanPham(string loaisp)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM SANPHAM WHERE LOAISANPHAM=@LOAISANPHAM";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@LOAISANPHAM", loaisp);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        public static int demsoNV(string chucvu)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM NHANVIEN WHERE CHUCVU=@CHUCVU";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@CHUCVU", chucvu);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        public static bool ifEmployeeExistsInDB(string manv)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MANHANVIEN", manv);
                int count = cmd.ExecuteNonQuery();
                conn.Close();
                return count > 0;
            }
        }

        public static int ifCustomerExitsInDB(string maThe)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE MATHE=@MATHE";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MATHE", maThe);
                int count = Convert.ToInt16(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        public static int ifProductExitsInDB(string maSanPham)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM SANPHAM WHERE MASANPHAM=@MASANPHAM";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MASANPHAM", maSanPham);
                int count = Convert.ToInt16(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        public static int demsoTB(string loaitb)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM THIETBI WHERE LOAITHIETBI=@LOAITHIETBI";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@LOAITHIETBI", loaitb);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
        }

        public static bool CheckPrimaryKeyDuplicate(string primaryKey)//Kiem tra khoa chinh
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE MATHE=@MATHE";
                var command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@MATHE", primaryKey);
                int count = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();
                return count != 0;
            }
        }

        public static bool kiemTraGoiThanhVien(string maGoiThanhVien)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM GOITHANHVIEN WHERE MAGOITHANHVIEN=@MAGOITHANHVIEN";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAGOITHANHVIEN", maGoiThanhVien);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count == 0;
            }
        }

        public static bool CheckDuplicate(string primaryKey)//Kiem tra khoa chinh
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM THIETBI WHERE MATHIETBI=@MATHIETBI";
                var command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@MATHIETBI", primaryKey);
                int count = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();
                return count == 0;
            }
        }

        public static bool kiemtraNhanVien(string primaryKey)//Kiem tra khoa chinh
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN";
                var command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@MANHANVIEN", primaryKey);
                int count = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();
                return count != 0;
            }
        }

        // XEM THÔNG TIN CHI TIẾT
        public static KHACHHANG xemThongTinKH(string mathe)
        {
            KHACHHANG kh = new KHACHHANG();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readInf = "SELECT MATHE,MANHANVIEN,HOTEN,NGAYSINH,GIOITINH,CMND,DIACHI,SDT,EMAIL,GHICHU,MAGOITAP,NGAYDANGKI,NGAYHETHAN,TENPT,GOITAPPT,THOIHAN,ANH FROM KHACHHANG WHERE MATHE=@MATHE";
                var cmd = new SQLiteCommand(readInf, conn);
                cmd.Parameters.AddWithValue("@MATHE", mathe);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kh.Mathe = reader["MATHE"].ToString();
                    kh.Hoten = reader["HOTEN"].ToString();
                    kh.Ngaysinh = Convert.ToDateTime(reader["NGAYSINH"]);
                    kh.Email = reader["EMAIL"].ToString();
                    kh.Gioitinh = reader["GIOITINH"].ToString();
                    kh.CMND = reader["CMND"].ToString();
                    kh.diaChi = reader["DIACHI"].ToString();
                    kh.SDT = reader["SDT"].ToString();
                    kh.GhiChu = reader["GHICHU"].ToString();
                    kh.MaGoiThanhVien = reader["MAGOITAP"].ToString();
                    kh.NgayBatDau = Convert.ToDateTime(reader["NGAYDANGKI"]);
                    kh.NgayHetHan = Convert.ToDateTime(reader["NGAYHETHAN"]);
                    kh.ThoiHan = Convert.ToDateTime(reader["THOIHAN"]);
                    kh.Anh = (byte[])reader["ANH"];
                }
                reader.Close();
                conn.Close();
            }
            return kh;
        }

        public static SanPham xemthongtinSP(string masp)
        {
            SanPham sp = new SanPham();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT MASANPHAM,LOAISANPHAM,TENSANPHAM,GIATHANH,SOLUONG,ANH FROM SANPHAM WHERE MASANPHAM=@MASANPHAM";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MASANPHAM", masp);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sp.MaSP = reader["MASANPHAM"].ToString();
                    sp.LoaiSP = reader["LOAISANPHAM"].ToString();
                    sp.TenSP = reader["TENSANPHAM"].ToString();
                    sp.GiaThanh = Convert.ToInt32(reader["GIATHANH"]);
                    sp.SL = Convert.ToInt32(reader["SOLUONG"]);
                    sp.Anh = (byte[])reader["ANH"];
                }
                reader.Close();
                conn.Close();
            }
            return sp;
        }

        public static THIETBI xemThongTinTB(string maTB)
        {
            THIETBI tb = new THIETBI();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readInf = "SELECT MATHIETBI,LOAITHIETBI,TENTHIETBI,TINHTRANG,ANH FROM THIETBI WHERE MATHIETBI=@MATHIETBI";
                var cmd = new SQLiteCommand(readInf, conn);
                cmd.Parameters.AddWithValue("@MATHIETBI", maTB);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tb.Mathietbi = reader["MATHIETBI"].ToString();
                    tb.Loaithietbi = reader["LOAITHIETBI"].ToString();
                    tb.Tenthietbi = reader["TENTHIETBI"].ToString();
                    tb.Tinhtrang = reader["TINHTRANG"].ToString();
                    tb.Anh = (byte[])reader["ANH"];
                }
                reader.Close();
                conn.Close();
            }
            return tb;
        }

        public static int layThangGoiThanhVien(string maGoiThanhVien)
        {
            int soThang = 0;
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readinf = "SELECT THANG FROM GOITHANHVIEN WHERE MAGOITHANHVIEN=@MAGOITHANHVIEN";
                var command = new SQLiteCommand(readinf, conn);
                command.Parameters.AddWithValue("@MAGOITHANHVIEN", maGoiThanhVien);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    soThang = Convert.ToInt32(reader["THANG"]);
                }
                reader.Close();
                conn.Close();
            }
            return soThang;
        }

        public static BIENLAI xembienlai(string mabienlai)
        {
            BIENLAI bl = new BIENLAI();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readinf = "SELECT MABIENLAI,MATHE,MAGOITHANHVIEN,TONGTIEN,NGAYTHANHTOAN FROM BIENLAI WHERE MABIENLAI=@MABIENLAI";
                var cmd = new SQLiteCommand(readinf, conn);
                cmd.Parameters.AddWithValue("@MABIENLAI", mabienlai);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bl.MaBienLai = reader["MABIENLAI"].ToString();
                    bl.MaThe = reader["MATHE"].ToString();
                    bl.MaGoiThanhVien = reader["MAGOITHANHVIEN"].ToString();
                    bl.NgayThanhToan = Convert.ToDateTime(reader["NGAYTHANHTOAN"]);
                    bl.TongTien = Convert.ToInt32(reader["TONGTIEN"]);
                }
                reader.Close();
                conn.Close();
            }
            return bl;
        }

        public static NHANVIEN xemThongTinNV(string manv)
        {
            NHANVIEN nv = new NHANVIEN();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string readInf = "SELECT MANHANVIEN,HOTEN,NGAYSINH,GIOITINH,CMND,DIACHI,SDT,EMAIL,GHICHU,CHUCVU,ANH FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN";
                var cmd = new SQLiteCommand(readInf, conn);
                cmd.Parameters.AddWithValue("@MANHANVIEN", manv);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nv.maNhanVien = reader["MANHANVIEN"].ToString();
                    nv.Hoten = reader["HOTEN"].ToString();
                    nv.Ngaysinh = Convert.ToDateTime(reader["NGAYSINH"]);
                    nv.Email = reader["EMAIL"].ToString();
                    nv.Gioitinh = reader["GIOITINH"].ToString();
                    nv.CMND = reader["CMND"].ToString();
                    nv.diaChi = reader["DIACHI"].ToString();
                    nv.SDT = reader["SDT"].ToString();
                    nv.GhiChu = reader["GHICHU"].ToString();
                    nv.Chucvu = reader["CHUCVU"].ToString();
                    nv.Anh = (byte[])reader["ANH"];
                }
                reader.Close();
                conn.Close();
            }
            return nv;
        }


        // XÓA DỮ LIỆU
        public static bool XoaThongtinKH(string mathe)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "DELETE FROM KHACHHANG WHERE MATHE=@MATHE";
                var command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@MATHE", mathe);
                int count = command.ExecuteNonQuery();
                conn.Close();
                return count > 0;
            }
        }

        public static bool XoaThongtinNV(string manv)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "DELETE FROM NHANVIEN WHERE MANHANVIEN=@MANHANVIEN";
                var command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@MANHANVIEN", manv);
                int count = command.ExecuteNonQuery();
                conn.Close();
                return count > 0;
            }
        }

        public static bool XoaThongTinThietBi(string maThietBi)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "DELETE FROM THIETBI WHERE MATHIETBI=@MATHIETBI";
                var command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@MATHIETBI", maThietBi);
                int count = command.ExecuteNonQuery();
                conn.Close();
                return count > 0;
            }
        }

        public static bool XoaThongTinSanPham(string maSanPham)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "DELETE FROM SANPHAM WHERE MASANPHAM=@MASANPHAM";
                var command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@MASANPHAM", maSanPham);
                int count = command.ExecuteNonQuery();
                conn.Close();
                return count > 0;
            }
        }

        // Thống kê
        public static List<KHACHHANG> thongkeKhachHang(DateTime d1)
        {
            List<KHACHHANG> ltkkh = new List<KHACHHANG>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string seconds = Math.Round((d1.Year * 525948.766 + d1.Month * 43829.0639 + d1.Day * 1440) / (1000)).ToString();
                string query = "SELECT * FROM KHACHHANG WHERE (I_NGAYDANGKI) == " + seconds;
                var command = new SQLiteCommand(query, conn);
               
                
                //string tmpDate2 = d2.Year.ToString() + "-" + d2.Month.ToString() + "-" + d2.Day.ToString();
                //command.Parameters.AddWithValue("@ToDate", tmpDate2);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    KHACHHANG kh = new KHACHHANG
                    {
                        Mathe = reader["MATHE"].ToString(),
                        Hoten = reader["HOTEN"].ToString(),
                        Ngaysinh = Convert.ToDateTime(reader["NGAYSINH"]),
                        Email = reader["EMAIL"].ToString(),
                        Gioitinh = reader["GIOITINH"].ToString(),
                        CMND = reader["CMND"].ToString(),
                        diaChi = reader["DIACHI"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        GhiChu = reader["GHICHU"].ToString(),
                        MaGoiThanhVien = reader["MAGOITAP"].ToString(),
                        NgayBatDau = Convert.ToDateTime(reader["NGAYDANGKI"]),
                        NgayHetHan = Convert.ToDateTime(reader["NGAYHETHAN"]),
                        ThoiHan = Convert.ToDateTime(reader["THOIHAN"])
                    };
                    ltkkh.Add(kh);
                }
                reader.Close();
                conn.Close();
            }
            return ltkkh;
        }

        public static BIENLAI LayBienLaiTheoNgayThanhToan(DateTime dateTime)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string seconds = Math.Round((dateTime.Year * 525948.766 + dateTime.Month * 43829.0639 + dateTime.Day * 1440) / (1000)).ToString();
                DataTable table = new DataTable();
                string sql = "SELECT * FROM BIENLAI WHERE I_NGAYTHANHTOAN = @seconds";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@seconds", seconds);
                SQLiteDataReader reader = cmd.ExecuteReader();
                BIENLAI bienlai = new BIENLAI();
                while (reader.Read())
                {
                    bienlai = new BIENLAI
                    {
                        MaBienLai = reader["MABIENLAI"].ToString(),
                        MaThe = reader["MATHE"].ToString(),
                        MaGoiThanhVien = reader["MAGOITAP"].ToString(),
                        TongTien = Convert.ToInt32(reader["TONGTIEN"].ToString()),
                        NgayThanhToan = Convert.ToDateTime(reader["NGAYTHANHTOAN"]),
                    };

                }
                return bienlai;
            }
        }
        public static DataTable LayHoaDonTheoNgayThanhToan(DateTime dateTime)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string seconds = Math.Round((dateTime.Year * 525948.766 + dateTime.Month * 43829.0639 + dateTime.Day * 1440) / (1000)).ToString();
                DataTable table = new DataTable();
                string sql = "SELECT * FROM HOADON WHERE I_NGAYTHANHTOAN = @seconds";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@seconds", seconds);
                SQLiteDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
                conn.Close();
                return table;
            }
        }
        public static bool themLoaiThietBi(LOAITHIETBI loaiThietBi)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO LOAITHIETBI(MALOAITHIETBI, TENLOAITHIETBI) VALUES (@MALOAITHIETBI, @TENLOAITHIETBI)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALOAITHIETBI", loaiThietBi.MaLoaiThietBi);
                cmd.Parameters.AddWithValue("@TENLOAITHIETBI", loaiThietBi.TenLoaiThietBi);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }
        public static List<LOAITHIETBI> xemLoaiThietBi()
        {
            List<LOAITHIETBI> listLoaiThietBi = new List<LOAITHIETBI>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT * FROM LOAITHIETBI";
                var cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LOAITHIETBI loaiThietBi = new LOAITHIETBI
                    {
                        MaLoaiThietBi = reader["MALOAITHIETBI"].ToString(),
                        TenLoaiThietBi = reader["TENLOAITHIETBI"].ToString()
                    };
                    listLoaiThietBi.Add(loaiThietBi);
                }
                conn.Close();
            }
            
            return listLoaiThietBi;
        }
        public static bool themLoaiSanPham(LOAISANPHAM loaiSanPham)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT OR IGNORE INTO LOAISANPHAM(MALOAISANPHAM, TENLOAISANPHAM) VALUES(@MALOAISANPHAM, @TENLOAISANPHAM)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALOAISANPHAM", loaiSanPham.MaLoaiSanPham);
                cmd.Parameters.AddWithValue("@TENLOAISANPHAM", loaiSanPham.TenLoaiSanPham);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }
        public static List<LOAISANPHAM> xemLoaiSanPham()
        {
            List<LOAISANPHAM> listLoaiSanPham = new List<LOAISANPHAM>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT * FROM LOAISANPHAM";
                var cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LOAISANPHAM loaiSanPham = new LOAISANPHAM
                    {
                        MaLoaiSanPham = reader["MALOAISANPHAM"].ToString(),
                        TenLoaiSanPham = reader["TENLOAISANPHAM"].ToString()
                    };
                    listLoaiSanPham.Add(loaiSanPham);
                }
                conn.Close();
                
            }
            return listLoaiSanPham;
        }




        public static bool CreateQuyenTaiKhoan(QUYENTAIKHOAN quyen)
        {
            string sql = "INSERT INTO QUYENTAIKHOAN (MAQUYENTAIKHOAN, TENQUYENTAIKHOAN, MIEUTA) VALUES (@MaQuyenTaiKhoan, @TenQuyenTaiKhoan, @MIEUTA)";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaQuyenTaiKhoan", quyen.MaQuyenTaiKhoan);
                    cmd.Parameters.AddWithValue("@TenQuyenTaiKhoan", quyen.TenQuyenTaiKhoan);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Read All
        public static List<QUYENTAIKHOAN> GetAllQuyenTaiKhoan()
        {
            List<QUYENTAIKHOAN> list = new List<QUYENTAIKHOAN>();
            string sql = "SELECT MAQUYENTAIKHOAN, TENQUYENTAIKHOAN, MIEUTA FROM QUYENTAIKHOAN";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        QUYENTAIKHOAN quyen = new QUYENTAIKHOAN
                        {
                            MaQuyenTaiKhoan = reader["MAQUYENTAIKHOAN"].ToString(),
                            TenQuyenTaiKhoan = reader["TENQUYENTAIKHOAN"].ToString(),
                            MieuTa = reader["MIEUTA"].ToString()
                        };
                        list.Add(quyen);
                    }
                }
            }
            return list;
        }

        // Read By ID
        public static QUYENTAIKHOAN GetQuyenTaiKhoanById(string maQuyenTaiKhoan)
        {
            QUYENTAIKHOAN quyen = null;
            string sql = "SELECT MAQUYENTAIKHOAN, TENQUYENTAIKHOAN, MIEUTA FROM QUYENTAIKHOAN WHERE MAQUYENTAIKHOAN = @MaQuyenTaiKhoan";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaQuyenTaiKhoan", maQuyenTaiKhoan);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            quyen = new QUYENTAIKHOAN
                            {
                                MaQuyenTaiKhoan = reader["MAQUYENTAIKHOAN"].ToString(),
                                TenQuyenTaiKhoan = reader["TENQUYENTAIKHOAN"].ToString(),
                                MieuTa = reader["MIEUTA"].ToString()
                            };
                        }
                    }
                }
            }
            return quyen;
        }

        // Update
        public static bool UpdateQuyenTaiKhoan(QUYENTAIKHOAN quyen)
        {
            string sql = "UPDATE QUYENTAIKHOAN SET TENQUYENTAIKHOAN = @TenQuyenTaiKhoan, MIEUTA = @MIEUTA WHERE MAQUYENTAIKHOAN = @MaQuyenTaiKhoan";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TenQuyenTaiKhoan", quyen.TenQuyenTaiKhoan);
                    cmd.Parameters.AddWithValue("@MIEUTA", quyen.MieuTa);
                    cmd.Parameters.AddWithValue("@MaQuyenTaiKhoan", quyen.MaQuyenTaiKhoan);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Delete
        public static bool DeleteQuyenTaiKhoan(string maQuyenTaiKhoan)
        {
            string sql = "DELETE FROM QUYENTAIKHOAN WHERE MAQUYENTAIKHOAN = @MaQuyenTaiKhoan";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaQuyenTaiKhoan", maQuyenTaiKhoan);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }


        // Create
        public static bool CreateLoaiTaiKhoan(LOAITAIKHOAN loai)
        {
            string sql = "INSERT INTO LOAITAIKHOAN (MALOAITAIKHOAN, TENMALOAITAIKHOAN, MIEUTA) VALUES (@MaLoaiTaiKhoan, @TenLoaiTaiKhoan, @MieuTa)";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoaiTaiKhoan", loai.MaLoaiTaiKhoan);
                    cmd.Parameters.AddWithValue("@TenLoaiTaiKhoan", loai.TenLoaiTaiKhoan);
                    cmd.Parameters.AddWithValue("@MieuTa", loai.MieuTa);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Read All
        public static List<LOAITAIKHOAN> GetAllLoaiTaiKhoan()
        {
            List<LOAITAIKHOAN> list = new List<LOAITAIKHOAN>();
            string sql = "SELECT MALOAITAIKHOAN, TENMALOAITAIKHOAN, MIEUTA FROM LOAITAIKHOAN";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LOAITAIKHOAN loai = new LOAITAIKHOAN
                        {
                            MaLoaiTaiKhoan = reader["MALOAITAIKHOAN"].ToString(),
                            TenLoaiTaiKhoan = reader["TENMALOAITAIKHOAN"].ToString(),
                            MieuTa = reader["MIEUTA"].ToString()
                        };
                        list.Add(loai);
                    }
                }
            }
            return list;
        }

        // Read By ID
        public static LOAITAIKHOAN GetLoaiTaiKhoanById(string maLoaiTaiKhoan)
        {
            LOAITAIKHOAN loai = null;
            string sql = "SELECT MALOAITAIKHOAN, TENMALOAITAIKHOAN, MIEUTA FROM LOAITAIKHOAN WHERE MALOAITAIKHOAN = @MaLoaiTaiKhoan";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoaiTaiKhoan", maLoaiTaiKhoan);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            loai = new LOAITAIKHOAN
                            {
                                MaLoaiTaiKhoan = reader["MALOAITAIKHOAN"].ToString(),
                                TenLoaiTaiKhoan = reader["TENMALOAITAIKHOAN"].ToString(),
                                MieuTa = reader["MIEUTA"].ToString()
                            };
                        }
                    }
                }
            }
            return loai;
        }

        // Update
        public static bool UpdateLoaiTaiKhoan(LOAITAIKHOAN loai)
        {
            string sql = "UPDATE LOAITAIKHOAN SET TENMALOAITAIKHOAN = @TenLoaiTaiKhoan, MIEUTA = @MieuTa WHERE MALOAITAIKHOAN = @MaLoaiTaiKhoan";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TenLoaiTaiKhoan", loai.TenLoaiTaiKhoan);
                    cmd.Parameters.AddWithValue("@MieuTa", loai.MieuTa);
                    cmd.Parameters.AddWithValue("@MaLoaiTaiKhoan", loai.MaLoaiTaiKhoan);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Delete
        public static bool DeleteLoaiTaiKhoan(string maLoaiTaiKhoan)
        {
            string sql = "DELETE FROM LOAITAIKHOAN WHERE MALOAITAIKHOAN = @MaLoaiTaiKhoan";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoaiTaiKhoan", maLoaiTaiKhoan);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Create
        public static bool ThemQuyenTaiKhoan_LoaiTaiKhoan(QUYENTAIKHOAN_LOAITAIKHOAN qltk)
        {
            string sql = "INSERT INTO QUYENTAIKHOAN_LOAITAIKHOAN (MAQUYENTAIKHOAN, MALOAITAIKHOAN) VALUES (@MaQuyenTaiKhoan, @MaLoaiTaiKhoan)";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaQuyenTaiKhoan", qltk.MaQuyenTaiKhoan);
                    cmd.Parameters.AddWithValue("@MaLoaiTaiKhoan", qltk.MaLoaiTaiKhoan);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Read All
        public static List<QUYENTAIKHOAN_LOAITAIKHOAN> GetAllQuyenTaiKhoan_LoaiTaiKhoan()
        {
            List<QUYENTAIKHOAN_LOAITAIKHOAN> list = new List<QUYENTAIKHOAN_LOAITAIKHOAN>();
            string sql = "SELECT MAQUYENTAIKHOAN, MALOAITAIKHOAN FROM QUYENTAIKHOAN_LOAITAIKHOAN";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        QUYENTAIKHOAN_LOAITAIKHOAN qltk = new QUYENTAIKHOAN_LOAITAIKHOAN
                        {
                            MaQuyenTaiKhoan = reader["MAQUYENTAIKHOAN"].ToString(),
                            MaLoaiTaiKhoan = reader["MALOAITAIKHOAN"].ToString()
                        };
                        list.Add(qltk);
                    }
                }
            }
            return list;
        }

        // Read By IDs
        public static QUYENTAIKHOAN_LOAITAIKHOAN GetQuyenTaiKhoan_LoaiTaiKhoan(string maQuyenTaiKhoan, string maLoaiTaiKhoan)
        {
            QUYENTAIKHOAN_LOAITAIKHOAN qltk = null;
            string sql = "SELECT MAQUYENTAIKHOAN, MALOAITAIKHOAN FROM QUYENTAIKHOAN_LOAITAIKHOAN WHERE MAQUYENTAIKHOAN = @MaQuyenTaiKhoan AND MALOAITAIKHOAN = @MaLoaiTaiKhoan";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaQuyenTaiKhoan", maQuyenTaiKhoan);
                    cmd.Parameters.AddWithValue("@MaLoaiTaiKhoan", maLoaiTaiKhoan);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            qltk = new QUYENTAIKHOAN_LOAITAIKHOAN
                            {
                                MaQuyenTaiKhoan = reader["MAQUYENTAIKHOAN"].ToString(),
                                MaLoaiTaiKhoan = reader["MALOAITAIKHOAN"].ToString()
                            };
                        }
                    }
                }
            }
            return qltk;
        }

        public static List<QUYENTAIKHOAN_LOAITAIKHOAN> GetQuyenTaiKhoan_LoaiTaiKhoan_ByMaLoaiTaiKhoan(string maLoaiTaiKhoan)
        {
            List<QUYENTAIKHOAN_LOAITAIKHOAN> list = new List<QUYENTAIKHOAN_LOAITAIKHOAN>();
            string query = "SELECT MaQuyenTaiKhoan, MaLoaiTaiKhoan FROM QuyenTaiKhoan_LoaiTaiKhoan WHERE MaLoaiTaiKhoan = @MaLoaiTaiKhoan";
            using (SqlConnection conn = new SqlConnection(dbName))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLoaiTaiKhoan", maLoaiTaiKhoan);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        QUYENTAIKHOAN_LOAITAIKHOAN item = new QUYENTAIKHOAN_LOAITAIKHOAN
                        {
                            MaQuyenTaiKhoan = reader["MaQuyenTaiKhoan"].ToString(),
                            MaLoaiTaiKhoan = reader["MaLoaiTaiKhoan"].ToString()
                        };
                        list.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi (log hoặc throw lại)
                }
            }
            return list;
        }

        // Update
        // Note: Since QUYENTAIKHOAN_LOAITAIKHOAN is a junction table with a composite primary key,
        // updating typically involves deleting the old relationship and inserting a new one.
        // Here, we'll implement a simple update that changes the MaLoaiTaiKhoan for a given MaQuyenTaiKhoan.

        public static bool UpdateQuyenTaiKhoan_LoaiTaiKhoan(string maQuyenTaiKhoan, string oldMaLoaiTaiKhoan, string newMaLoaiTaiKhoan)
        {
            string sql = "UPDATE QUYENTAIKHOAN_LOAITAIKHOAN SET MALOAITAIKHOAN = @NewMaLoaiTaiKhoan WHERE MAQUYENTAIKHOAN = @MaQuyenTaiKhoan AND MALOAITAIKHOAN = @OldMaLoaiTaiKhoan";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NewMaLoaiTaiKhoan", newMaLoaiTaiKhoan);
                    cmd.Parameters.AddWithValue("@MaQuyenTaiKhoan", maQuyenTaiKhoan);
                    cmd.Parameters.AddWithValue("@OldMaLoaiTaiKhoan", oldMaLoaiTaiKhoan);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Delete
        public static bool DeleteQuyenTaiKhoan_LoaiTaiKhoan(string maQuyenTaiKhoan, string maLoaiTaiKhoan)
        {
            string sql = "DELETE FROM QUYENTAIKHOAN_LOAITAIKHOAN WHERE MAQUYENTAIKHOAN = @MaQuyenTaiKhoan AND MALOAITAIKHOAN = @MaLoaiTaiKhoan";
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaQuyenTaiKhoan", maQuyenTaiKhoan);
                    cmd.Parameters.AddWithValue("@MaLoaiTaiKhoan", maLoaiTaiKhoan);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public static bool AddChucNang_QuyenTaiKhoan(CHUCNANG_QUYENTAIKHOAN input)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                int i = 0;
                string query = "INSERT INTO CHUCNANG_QUYENTAIGHOAN (MACHUCNANG, MAQUYENTAIKHOAN) VALUES (@MACHUCNANG, @MAQUYENTAIKHOAN)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MACHUCNANG", input.MaChucNang);
                    cmd.Parameters.AddWithValue("@MAQUYENTAIKHOAN", input.MaQuyenTaiKhoan);
                    i = cmd.ExecuteNonQuery();
                    return i > 0;
                }
            }
        }
        public static List<CHUCNANG_QUYENTAIKHOAN> GetAllChucNang_QuyenTaiKhoan()
        {
            List<CHUCNANG_QUYENTAIKHOAN> listChucNang_QuyenTaiKhoan = new List<CHUCNANG_QUYENTAIKHOAN> ();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT * FROM CHUCNANG_QUYENTAIGHOAN";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CHUCNANG_QUYENTAIKHOAN tmp = new CHUCNANG_QUYENTAIKHOAN
                        {
                            MaChucNang = reader["MACHUCNANG"].ToString(),
                            MaQuyenTaiKhoan = reader["MAQUYENTAIKHOAN"].ToString(),

                        };
                        listChucNang_QuyenTaiKhoan.Add(tmp);
                    }
                }
                conn.Close();
            }
            return listChucNang_QuyenTaiKhoan;
        }
        public static List<CHUCNANG_QUYENTAIKHOAN> GetAllChucNang_QuyenTaiKhoan_ById(string maChucNang)
        {
            List<CHUCNANG_QUYENTAIKHOAN> listChucNang_QuyenTaiKhoan = new List<CHUCNANG_QUYENTAIKHOAN>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT * FROM CHUCNANG_QUYENTAIGHOAN WHERE MACHUCNANG=@MACHUCNANG";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@MACHUCNANG", maChucNang);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CHUCNANG_QUYENTAIKHOAN tmp = new CHUCNANG_QUYENTAIKHOAN
                        {
                            MaChucNang = reader["MACHUCNANG"].ToString(),
                            MaQuyenTaiKhoan = reader["MAQUYENTAIKHOAN"].ToString(),

                        };
                        listChucNang_QuyenTaiKhoan.Add(tmp);
                    }
                }
                conn.Close();
            }
            return listChucNang_QuyenTaiKhoan;
        }
        public static bool UpdateChucNang_QuyenTaiKhoan(string maChucNang, string newMaQuyenTaiKhoan, string oldMaQuyenTaiKhoan)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                int row = 0;
                conn.Open();
                string query = "UPDATE CHUCNANG_QUYENTAIKHOAN SET MAQUYENTAIKHOAN = @NEW_MAQUYENTAIKHOAN WHERE MACHUCNANG = @MACHUCNANG AND MAQUYENTAIKHOAN = @OLD_MAQUYENTAIKHOAN";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MACHUCNANG", maChucNang);
                    cmd.Parameters.AddWithValue("@NEW_MAQUYENTAIKHOAN", newMaQuyenTaiKhoan);
                    cmd.Parameters.AddWithValue("@OLD_MAQUYENTAIKHOAN", oldMaQuyenTaiKhoan); 
                    row = cmd.ExecuteNonQuery();
                }
                conn.Close();
                return row > 0;
            }
        }
        public static bool DeleteChucNang_QuyenTaiKhoan(string maChucNang, string maQuyenTaiKhoan)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                int i = 0;
                conn.Open();
                string query = "DELETE FROM CHUCNANG_QUYENTAIGHOAN WHERE MACHUCNANG = @MACHUCNANG AND MAQUYENTAIKHOAN = @MAQUYENTAIKHOAN";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MACHUCNANG", maChucNang);
                    cmd.Parameters.AddWithValue("@MAQUYENTAIKHOAN", maQuyenTaiKhoan);
                    i = cmd.ExecuteNonQuery();
                }
                conn.Close();
                return i > 0;
            }
        }

        // CREATE
        public static bool CreateLoaiChucVu(LOAICHUCVU loaiChucVu)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "INSERT INTO LOAICHUCVU (MALOAICHUCVU, TENLOAICHUCVU) VALUES (@MALOAICHUCVU, @TENLOAICHUCVU);";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    int i = 0;
                    cmd.Parameters.AddWithValue("@MALOAICHUCVU", loaiChucVu.MaLoaiChucVu);
                    cmd.Parameters.AddWithValue("@TENLOAICHUCVU", loaiChucVu.TenLoaiChucVu);
                    i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i > 0;
                }
            }
        }

        // READ
        public static List<LOAICHUCVU> ReadLoaiChucVu()
        {
            List<LOAICHUCVU> listLoaiChucVu = new List<LOAICHUCVU> ();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT * FROM LOAICHUCVU;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LOAICHUCVU loaiChucVu = new LOAICHUCVU
                            {
                                MaLoaiChucVu = reader["MALOAICHUCVU"].ToString(),
                                TenLoaiChucVu = reader["TENLOAICHUCVU"].ToString()
                            };
                            listLoaiChucVu.Add(loaiChucVu);
                        }
                    }
                    conn.Close();
                }
            }
            return listLoaiChucVu;
        }

        // UPDATE
        public static bool UpdateLoaiChucVu(LOAICHUCVU loaiChucVu)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "UPDATE LOAICHUCVU SET TENLOAICHUCVU = @NEW_TENLOAICHUCVU WHERE MALOAICHUCVU = @MALOAICHUCVU;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NEW_TENLOAICHUCVU", loaiChucVu.TenLoaiChucVu);
                    cmd.Parameters.AddWithValue("@MALOAICHUCVU", loaiChucVu.MaLoaiChucVu);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                    
                }
            }
        }

        // DELETE
        public static bool DeleteLoaiChucVu(string maLoaiChucVu)
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "DELETE FROM LOAICHUCVU WHERE MALOAICHUCVU = @MALOAICHUCVU;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOAICHUCVU", maLoaiChucVu);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }
            }
        }
        public static CHUCNANG TimChucNangTheoTen(string tenChucNang)
        {
            CHUCNANG tmp = new CHUCNANG();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT * FROM CHUCNANG WHERE TENCHUCNANG=@TENCHUCNANG";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENCHUCNANG", tenChucNang);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tmp.MaChucNang = reader["MACHUCNANG"].ToString();
                    tmp.TenChucNang = reader["TENCHUCNANG"].ToString();
                }
                conn.Close();
            }
            return tmp;
        }
        public static List<CHUCNANG> LayTatCaChucNang()
        {
            List<CHUCNANG> listChucNang = new List<CHUCNANG>();
            using (SQLiteConnection conn = new SQLiteConnection(dbName))
            {
                conn.Open();
                string query = "SELECT * FROM CHUCNANG";
                var cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CHUCNANG tmp = new CHUCNANG
                    {
                        MaChucNang = reader["MACHUCNANG"].ToString(),
                        TenChucNang = reader["TENCHUCNANG"].ToString(),
                        MieuTa = reader["MIEUTA"].ToString()
                    };
                    listChucNang.Add(tmp);
                }
                conn.Close();
            }
            return listChucNang;
        }
    }
}
