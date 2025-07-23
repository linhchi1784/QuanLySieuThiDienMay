using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;


namespace QuanLySieuThiDienMay
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=sieuthidienmay;password=;";
            string username = txtTenDangNhap.Text.Trim();  // textbox người dùng nhập
            string password = txtMatKhau.Text.Trim();  // textbox mật khẩu
            DialogResult result = DialogResult.None;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                
                try
                {
                    conn.Open();
                    string query = "SELECT chucVu, maNhanVien FROM tt_nhanvien WHERE tenDangNhap = @user AND matKhau = @pass";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // nếu có dòng dữ liệu trả về
                    {
                        string chucVu = reader["chucVu"].ToString();
                        string maNhanVien = reader["maNhanVien"].ToString();

                        if (chucVu == "Quản lý")
                        {
                            TrangChu formAdmin = new TrangChu();
                            this.Hide();
                            result = formAdmin.ShowDialog();
                        }
                        else if (chucVu == "Nhân viên")
                        {
                            TrangChu_User formUser = new TrangChu_User(maNhanVien);
                            this.Hide();
                            result = formUser.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

            //Sau khi đóng form trang chủ
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
