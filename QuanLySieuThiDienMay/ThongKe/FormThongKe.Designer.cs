namespace DOAN1
{
    partial class FormThongKe
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
            label1 = new Label();
            label3 = new Label();
            lbltongspb = new Label();
            lbltongdoanhthu = new Label();
            label6 = new Label();
            lbltongtiennhap = new Label();
            label8 = new Label();
            lblloinhuan = new Label();
            label10 = new Label();
            btnBaocaobanhang = new Button();
            btnLuongnv = new Button();
            btnDoanhthu = new Button();
            btnnhapxuatkho = new Button();
            btnloinhuan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(400, 61);
            label1.Name = "label1";
            label1.Size = new Size(241, 28);
            label1.TabIndex = 6;
            label1.Text = "THỐNG KÊ VÀ BÁO CÁO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 131);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 10;
            label3.Text = "Tổng sản phẩm bán: ";
            // 
            // lbltongspb
            // 
            lbltongspb.AutoSize = true;
            lbltongspb.Location = new Point(552, 131);
            lbltongspb.Name = "lbltongspb";
            lbltongspb.Size = new Size(140, 20);
            lbltongspb.TabIndex = 11;
            lbltongspb.Text = "Tổng sản phẩm bán";
            // 
            // lbltongdoanhthu
            // 
            lbltongdoanhthu.AutoSize = true;
            lbltongdoanhthu.Location = new Point(552, 176);
            lbltongdoanhthu.Name = "lbltongdoanhthu";
            lbltongdoanhthu.Size = new Size(114, 20);
            lbltongdoanhthu.TabIndex = 13;
            lbltongdoanhthu.Text = "Tổng doanh thu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 176);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 12;
            label6.Text = "Tổng doanh thu: ";
            // 
            // lbltongtiennhap
            // 
            lbltongtiennhap.AutoSize = true;
            lbltongtiennhap.Location = new Point(552, 214);
            lbltongtiennhap.Name = "lbltongtiennhap";
            lbltongtiennhap.Size = new Size(113, 20);
            lbltongtiennhap.TabIndex = 15;
            lbltongtiennhap.Text = "Tổng tiền nhập ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 214);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 14;
            label8.Text = "Tổng tiền nhập: ";
            // 
            // lblloinhuan
            // 
            lblloinhuan.AutoSize = true;
            lblloinhuan.Location = new Point(552, 253);
            lblloinhuan.Name = "lblloinhuan";
            lblloinhuan.Size = new Size(73, 20);
            lblloinhuan.TabIndex = 17;
            lblloinhuan.Text = "Lợi nhuận";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(354, 253);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 16;
            label10.Text = "Lợi nhuận ";
            // 
            // btnBaocaobanhang
            // 
            btnBaocaobanhang.BackColor = Color.Tomato;
            btnBaocaobanhang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBaocaobanhang.ForeColor = SystemColors.ControlLightLight;
            btnBaocaobanhang.Location = new Point(355, 365);
            btnBaocaobanhang.Name = "btnBaocaobanhang";
            btnBaocaobanhang.Size = new Size(338, 48);
            btnBaocaobanhang.TabIndex = 18;
            btnBaocaobanhang.Text = "Báo cáo bán hàng";
            btnBaocaobanhang.UseVisualStyleBackColor = false;
            btnBaocaobanhang.Click += btnBaocaobanhang_Click;
            // 
            // btnLuongnv
            // 
            btnLuongnv.BackColor = Color.Tomato;
            btnLuongnv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuongnv.ForeColor = SystemColors.ControlLightLight;
            btnLuongnv.Location = new Point(355, 323);
            btnLuongnv.Name = "btnLuongnv";
            btnLuongnv.Size = new Size(338, 48);
            btnLuongnv.TabIndex = 19;
            btnLuongnv.Text = "Lương nhân viên";
            btnLuongnv.UseVisualStyleBackColor = false;
            btnLuongnv.Click += btnLuongnv_Click;
            // 
            // btnDoanhthu
            // 
            btnDoanhthu.BackColor = Color.Tomato;
            btnDoanhthu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDoanhthu.ForeColor = SystemColors.ControlLightLight;
            btnDoanhthu.Location = new Point(355, 408);
            btnDoanhthu.Name = "btnDoanhthu";
            btnDoanhthu.Size = new Size(338, 48);
            btnDoanhthu.TabIndex = 21;
            btnDoanhthu.Text = "Doanh thu";
            btnDoanhthu.UseVisualStyleBackColor = false;
            btnDoanhthu.Click += btnDoanhthu_Click;
            // 
            // btnnhapxuatkho
            // 
            btnnhapxuatkho.BackColor = Color.Tomato;
            btnnhapxuatkho.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnnhapxuatkho.ForeColor = SystemColors.ControlLightLight;
            btnnhapxuatkho.Location = new Point(355, 453);
            btnnhapxuatkho.Name = "btnnhapxuatkho";
            btnnhapxuatkho.Size = new Size(338, 48);
            btnnhapxuatkho.TabIndex = 20;
            btnnhapxuatkho.Text = "Nhập / Xuất kho";
            btnnhapxuatkho.UseVisualStyleBackColor = false;
            btnnhapxuatkho.Click += btnnhapxuatkho_Click;
            // 
            // btnloinhuan
            // 
            btnloinhuan.BackColor = Color.Tomato;
            btnloinhuan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnloinhuan.ForeColor = SystemColors.ControlLightLight;
            btnloinhuan.Location = new Point(355, 497);
            btnloinhuan.Name = "btnloinhuan";
            btnloinhuan.Size = new Size(338, 48);
            btnloinhuan.TabIndex = 23;
            btnloinhuan.Text = "Lợi nhuận";
            btnloinhuan.UseVisualStyleBackColor = false;
            btnloinhuan.Click += btnloinhuan_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1029, 643);
            Controls.Add(btnloinhuan);
            Controls.Add(btnDoanhthu);
            Controls.Add(btnnhapxuatkho);
            Controls.Add(btnLuongnv);
            Controls.Add(btnBaocaobanhang);
            Controls.Add(lblloinhuan);
            Controls.Add(label10);
            Controls.Add(lbltongtiennhap);
            Controls.Add(label8);
            Controls.Add(lbltongdoanhthu);
            Controls.Add(label6);
            Controls.Add(lbltongspb);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label lbltongspb;
        private Label lbltongdoanhthu;
        private Label label6;
        private Label lbltongtiennhap;
        private Label label8;
        private Label lblloinhuan;
        private Label label10;
        private Button btnBaocaobanhang;
        private Button btnLuongnv;
        private Button btnDoanhthu;
        private Button btnnhapxuatkho;
        private Button btnloinhuan;
    }
}