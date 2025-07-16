namespace QuanLySieuThiDienMay
{
    partial class FormBanhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbThongtinchung = new GroupBox();
            cbManv = new ComboBox();
            btnThemKhachHang = new Button();
            lblTongThanhTien = new Label();
            dtpNgayTao = new DateTimePicker();
            cbmakhachhang = new ComboBox();
            txtMaHd = new TextBox();
            btnThemSanPham = new Button();
            grbThongTinSanPham = new GroupBox();
            txtTonKho = new TextBox();
            nudsoluong = new NumericUpDown();
            txtTenSanpham = new TextBox();
            txtDonGia = new TextBox();
            cbMasanpham = new ComboBox();
            dgvThongTinSanPham = new DataGridView();
            btnTaoHoaDon = new Button();
            btnXoaSanPham = new Button();
            grbThongtinchung.SuspendLayout();
            grbThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudsoluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinSanPham).BeginInit();
            SuspendLayout();
            // 
            // grbThongtinchung
            // 
            grbThongtinchung.Controls.Add(cbManv);
            grbThongtinchung.Controls.Add(btnThemKhachHang);
            grbThongtinchung.Controls.Add(lblTongThanhTien);
            grbThongtinchung.Controls.Add(dtpNgayTao);
            grbThongtinchung.Controls.Add(cbmakhachhang);
            grbThongtinchung.Controls.Add(txtMaHd);
            grbThongtinchung.Location = new Point(28, 26);
            grbThongtinchung.Name = "grbThongtinchung";
            grbThongtinchung.Size = new Size(1108, 71);
            grbThongtinchung.TabIndex = 0;
            grbThongtinchung.TabStop = false;
            grbThongtinchung.Text = "Thông tin chung";
            // 
            // cbManv
            // 
            cbManv.FormattingEnabled = true;
            cbManv.Location = new Point(138, 25);
            cbManv.Name = "cbManv";
            cbManv.Size = new Size(96, 28);
            cbManv.TabIndex = 6;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackgroundImage = Properties.Resources.icons8_add_48;
            btnThemKhachHang.BackgroundImageLayout = ImageLayout.Zoom;
            btnThemKhachHang.Location = new Point(378, 28);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(54, 29);
            btnThemKhachHang.TabIndex = 5;
            btnThemKhachHang.UseVisualStyleBackColor = true;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // lblTongThanhTien
            // 
            lblTongThanhTien.AutoSize = true;
            lblTongThanhTien.Location = new Point(793, 34);
            lblTongThanhTien.Name = "lblTongThanhTien";
            lblTongThanhTien.Size = new Size(50, 20);
            lblTongThanhTien.TabIndex = 4;
            lblTongThanhTien.Text = "label1";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(475, 29);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(250, 27);
            dtpNgayTao.TabIndex = 2;
            // 
            // cbmakhachhang
            // 
            cbmakhachhang.FormattingEnabled = true;
            cbmakhachhang.Location = new Point(256, 27);
            cbmakhachhang.Name = "cbmakhachhang";
            cbmakhachhang.Size = new Size(96, 28);
            cbmakhachhang.TabIndex = 1;
            // 
            // txtMaHd
            // 
            txtMaHd.Location = new Point(19, 26);
            txtMaHd.Name = "txtMaHd";
            txtMaHd.PlaceholderText = "Ma hoa don";
            txtMaHd.Size = new Size(84, 27);
            txtMaHd.TabIndex = 0;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Location = new Point(793, 24);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(263, 29);
            btnThemSanPham.TabIndex = 3;
            btnThemSanPham.Text = "Them san pham ";
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // grbThongTinSanPham
            // 
            grbThongTinSanPham.Controls.Add(txtTonKho);
            grbThongTinSanPham.Controls.Add(nudsoluong);
            grbThongTinSanPham.Controls.Add(txtTenSanpham);
            grbThongTinSanPham.Controls.Add(txtDonGia);
            grbThongTinSanPham.Controls.Add(btnThemSanPham);
            grbThongTinSanPham.Controls.Add(cbMasanpham);
            grbThongTinSanPham.Location = new Point(28, 103);
            grbThongTinSanPham.Name = "grbThongTinSanPham";
            grbThongTinSanPham.Size = new Size(1108, 71);
            grbThongTinSanPham.TabIndex = 7;
            grbThongTinSanPham.TabStop = false;
            grbThongTinSanPham.Text = "Thông tin sản phẩm";
            // 
            // txtTonKho
            // 
            txtTonKho.Location = new Point(475, 28);
            txtTonKho.Name = "txtTonKho";
            txtTonKho.PlaceholderText = "Tồn kho";
            txtTonKho.Size = new Size(115, 27);
            txtTonKho.TabIndex = 8;
            // 
            // nudsoluong
            // 
            nudsoluong.Location = new Point(624, 27);
            nudsoluong.Name = "nudsoluong";
            nudsoluong.Size = new Size(101, 27);
            nudsoluong.TabIndex = 7;
            // 
            // txtTenSanpham
            // 
            txtTenSanpham.Location = new Point(138, 28);
            txtTenSanpham.Name = "txtTenSanpham";
            txtTenSanpham.PlaceholderText = "Ten san pham";
            txtTenSanpham.Size = new Size(144, 27);
            txtTenSanpham.TabIndex = 6;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(316, 25);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.PlaceholderText = "Don gia";
            txtDonGia.Size = new Size(116, 27);
            txtDonGia.TabIndex = 0;
            // 
            // cbMasanpham
            // 
            cbMasanpham.FormattingEnabled = true;
            cbMasanpham.Location = new Point(19, 27);
            cbMasanpham.Name = "cbMasanpham";
            cbMasanpham.Size = new Size(96, 28);
            cbMasanpham.TabIndex = 1;
            cbMasanpham.SelectedIndexChanged += cbMasanpham_SelectedIndexChanged;
            // 
            // dgvThongTinSanPham
            // 
            dgvThongTinSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinSanPham.Location = new Point(28, 195);
            dgvThongTinSanPham.Name = "dgvThongTinSanPham";
            dgvThongTinSanPham.RowHeadersWidth = 51;
            dgvThongTinSanPham.Size = new Size(1108, 209);
            dgvThongTinSanPham.TabIndex = 8;
            dgvThongTinSanPham.CellContentClick += dgvThongTinSanPham_CellContentClick;
            dgvThongTinSanPham.CellEndEdit += dgvThongTinSanPham_CellEndEdit;
            dgvThongTinSanPham.CellValueChanged += dgvThongTinSanPham_CellValueChanged;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Location = new Point(429, 436);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(263, 29);
            btnTaoHoaDon.TabIndex = 9;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.Location = new Point(1005, 271);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(109, 44);
            btnXoaSanPham.TabIndex = 10;
            btnXoaSanPham.Text = "Xóa";
            btnXoaSanPham.UseVisualStyleBackColor = true;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // FormBanhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 504);
            Controls.Add(btnXoaSanPham);
            Controls.Add(btnTaoHoaDon);
            Controls.Add(dgvThongTinSanPham);
            Controls.Add(grbThongTinSanPham);
            Controls.Add(grbThongtinchung);
            Name = "FormBanhang";
            Text = "FormBanhang";
            Load += FormBanhang_Load;
            grbThongtinchung.ResumeLayout(false);
            grbThongtinchung.PerformLayout();
            grbThongTinSanPham.ResumeLayout(false);
            grbThongTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudsoluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbThongtinchung;
        private Button btnThemKhachHang;
        private Label lblTongThanhTien;
        private DateTimePicker dtpNgayTao;
        private ComboBox cbmakhachhang;
        private TextBox txtMaHd;
        private Button btnThemSanPham;
        private GroupBox grbThongTinSanPham;
        private NumericUpDown nudsoluong;
        private TextBox txtTenSanpham;
        private TextBox txtDonGia;
        private ComboBox cbMasanpham;
        private DataGridView dgvThongTinSanPham;
        private Button btnTaoHoaDon;
        private TextBox txtTonKho;
        private ComboBox cbManv;
        private Button btnXoaSanPham;
    }
}