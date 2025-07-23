using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLySieuThiDienMay
{
    public class DangNhapResult
    {
        public bool thanhCong { get; set; }
        public string chucVu { get; set; }
        public string maNhanVien { get; set; }
    }

    public class DangNhapService
    {
        private string connStr = "server=localhost;user=root;database=sieuthidienmay;password=;";

        public DangNhapResult KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            var result = new DangNhapResult();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT chucVu, maNhanVien FROM tt_nhanvien WHERE tenDangNhap = @user AND matKhau = @pass";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", tenDangNhap);
                    cmd.Parameters.AddWithValue("@pass", matKhau);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        result.thanhCong = true;
                        result.chucVu = reader["chucVu"].ToString();
                        result.maNhanVien = reader["maNhanVien"].ToString();
                    }
                    else
                    {
                        result.thanhCong = false;
                        result.chucVu = "";
                        result.maNhanVien = "";
                    }
                }
                catch (Exception)
                {
                    result.thanhCong = false;
                    result.chucVu = "";
                    result.maNhanVien = "";
                }
            }

            return result;
        }
    }

    public class DangNhapServiceTest
    {
        public static void KiemTraDangNhap_TaiKhoanDung_ThanhCong()
        {
            var service = new DangNhapService();
            var result = service.KiemTraDangNhap("admin", "123");

            bool pass = result.thanhCong &&
                        result.chucVu == "Quản lý" &&
                        !string.IsNullOrEmpty(result.maNhanVien);

            Console.WriteLine("Test Đăng nhập đúng: " + (pass ? "PASSED" : "FAILED"));
        }

        public static void KiemTraDangNhap_TaiKhoanSai_ThatBai()
        {
            var service = new DangNhapService();
            var result = service.KiemTraDangNhap("saiuser", "saimk");

            bool pass = !result.thanhCong &&
                        result.chucVu == "" &&
                        result.maNhanVien == "";

            Console.WriteLine("Test Đăng nhập sai: " + (pass ? "PASSED" : "FAILED"));
        }
    }
}

