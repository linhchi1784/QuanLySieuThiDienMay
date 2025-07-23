using DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN1
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            LoadReport();

        }


        private void FormThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKeTongQuan();
        }
        private void LoadThongKeTongQuan()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=sieuthidienmay;password=;"))
            {
                conn.Open();

                // Tổng sản phẩm đã bán
                MySqlCommand cmdSPB = new MySqlCommand("SELECT SUM(soLuong) FROM tt_chitiet_hoadon", conn);
                int tongSPBan = Convert.ToInt32(cmdSPB.ExecuteScalar() ?? 0);
                lbltongspb.Text = "" + tongSPBan;

                // Tổng doanh thu
                MySqlCommand cmdDT = new MySqlCommand("SELECT SUM(tongThanhTien) FROM hoadon", conn);
                decimal tongDoanhThu = Convert.ToDecimal(cmdDT.ExecuteScalar() ?? 0);
                lbltongdoanhthu.Text = "" + tongDoanhThu.ToString("N0") + " VNĐ";

                // Tổng tiền nhập (chỉ nhập - NhapXuat = 1)
                string queryNhap = @"
            SELECT SUM(ctnx.soLuong * sp.donGiaNhap) 
            FROM tt_chitiet_nxkho ctnx
            JOIN tt_sanpham sp ON ctnx.maSanPham = sp.maSanPham
            WHERE ctnx.NhapXuat = 1";
                MySqlCommand cmdNhap = new MySqlCommand(queryNhap, conn);
                decimal tongTienNhap = Convert.ToDecimal(cmdNhap.ExecuteScalar() ?? 0);
                lbltongtiennhap.Text = "" + tongTienNhap.ToString("N0") + " VNĐ";

                // Lợi nhuận
                decimal loiNhuan = tongDoanhThu - tongTienNhap;
                lblloinhuan.Text = "" + loiNhuan.ToString("N0") + " VNĐ";
            }
        }

        private void LoadReport()
        {

        }
        
        private void btnloinhuan_Click(object sender, EventArgs e)
        {
            new FormLoiNhuan().Show(this);
        }

        private void btnBaocaobanhang_Click(object sender, EventArgs e)
        {
            new FormBaoCaoBanHang().Show(this);

        }

        private void btnLuongnv_Click(object sender, EventArgs e)
        {
            new FormThongKeLuong().Show(this);
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            new FormDoanhThu().Show(this);

        }

        private void btnnhapxuatkho_Click(object sender, EventArgs e)
        {
            new FormNhapXuatKho().Show(this);

        }
    }
}
