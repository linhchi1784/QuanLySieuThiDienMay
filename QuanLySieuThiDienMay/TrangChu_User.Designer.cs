namespace QuanLySieuThiDienMay
{
    partial class TrangChu_User
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu_User));
            menuStrip1 = new MenuStrip();
            quảnLýHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            lậpHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhoToolStripMenuItem = new ToolStripMenuItem();
            thôngTinKoToolStripMenuItem = new ToolStripMenuItem();
            thôngYinNhàToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnDangXuat = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýHóaĐơnToolStripMenuItem, quảnLýKhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(831, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            quảnLýHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lậpHóaĐơnToolStripMenuItem, thôngTinHóaĐơnToolStripMenuItem });
            quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            quảnLýHóaĐơnToolStripMenuItem.Size = new Size(132, 24);
            quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // lậpHóaĐơnToolStripMenuItem
            // 
            lậpHóaĐơnToolStripMenuItem.Name = "lậpHóaĐơnToolStripMenuItem";
            lậpHóaĐơnToolStripMenuItem.Size = new Size(224, 26);
            lậpHóaĐơnToolStripMenuItem.Text = "Lập hóa đơn";
            // 
            // thôngTinHóaĐơnToolStripMenuItem
            // 
            thôngTinHóaĐơnToolStripMenuItem.Name = "thôngTinHóaĐơnToolStripMenuItem";
            thôngTinHóaĐơnToolStripMenuItem.Size = new Size(224, 26);
            thôngTinHóaĐơnToolStripMenuItem.Text = "Thông tin hóa đơn";
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            quảnLýKhoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinKoToolStripMenuItem, thôngYinNhàToolStripMenuItem });
            quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            quảnLýKhoToolStripMenuItem.Size = new Size(101, 24);
            quảnLýKhoToolStripMenuItem.Text = "Quản lý kho";
            // 
            // thôngTinKoToolStripMenuItem
            // 
            thôngTinKoToolStripMenuItem.Name = "thôngTinKoToolStripMenuItem";
            thôngTinKoToolStripMenuItem.Size = new Size(247, 26);
            thôngTinKoToolStripMenuItem.Text = "Thông tin kho";
            // 
            // thôngYinNhàToolStripMenuItem
            // 
            thôngYinNhàToolStripMenuItem.Name = "thôngYinNhàToolStripMenuItem";
            thôngYinNhàToolStripMenuItem.Size = new Size(247, 26);
            thôngYinNhàToolStripMenuItem.Text = "Thông tin nhà cung cấp";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnDangXuat });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(30, 541);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnDangXuat
            // 
            btnDangXuat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageTransparentColor = Color.Magenta;
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(27, 24);
            btnDangXuat.Text = "toolStripButton1";
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // TrangChu_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 569);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TrangChu_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem lậpHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem thôngTinHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private ToolStripMenuItem thôngTinKoToolStripMenuItem;
        private ToolStripMenuItem thôngYinNhàToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnDangXuat;
    }
}
