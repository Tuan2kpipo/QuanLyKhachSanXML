
namespace QuanLyKhachSan
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.QLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.QLKH,
            this.QLNV,
            this.menuTaiKhoan,
            this.QLHD});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home
            // 
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(71, 20);
            this.Home.Text = "Trang chủ";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // QLKH
            // 
            this.QLKH.Name = "QLKH";
            this.QLKH.Size = new System.Drawing.Size(82, 20);
            this.QLKH.Text = "Khách hàng";
            this.QLKH.Click += new System.EventHandler(this.QLKH_Click);
            // 
            // QLNV
            // 
            this.QLNV.Name = "QLNV";
            this.QLNV.Size = new System.Drawing.Size(73, 20);
            this.QLNV.Text = "Nhân viên";
            this.QLNV.Click += new System.EventHandler(this.QLNV_Click);
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(70, 20);
            this.menuTaiKhoan.Text = "Tài Khoản";
            this.menuTaiKhoan.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.MinimumSize = new System.Drawing.Size(593, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 341);
            this.label1.TabIndex = 1;
            // 
            // QLHD
            // 
            this.QLHD.Name = "QLHD";
            this.QLHD.Size = new System.Drawing.Size(66, 20);
            this.QLHD.Text = "Hóa Đơn";
            this.QLHD.Click += new System.EventHandler(this.QLHD_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.ToolStripMenuItem QLKH;
        private System.Windows.Forms.ToolStripMenuItem QLNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem QLHD;
    }
}

