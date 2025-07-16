using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DialogResult result;
            if (this.txtTenDangNhap.Text.Equals("admin") && this.txtMatKhau.Text.Equals("123"))
            {
                TrangChu formAdmin = new TrangChu();
                this.Hide();
                result = formAdmin.ShowDialog();
            }
            else if(this.txtTenDangNhap.Text.Equals("user") && this.txtMatKhau.Text.Equals("789"))
            {
                TrangChu_User formUser = new TrangChu_User();
                this.Hide();
                result = formUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                return;
            }

            //Sau khi đóng form trang chủ
            if (result == DialogResult.Retry)
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
