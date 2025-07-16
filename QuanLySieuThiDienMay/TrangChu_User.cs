namespace QuanLySieuThiDienMay
{
    public partial class TrangChu_User : Form
    {
        public TrangChu_User()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}
