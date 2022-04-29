
namespace QuanLyKhachSan
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.QLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCanCuoc = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbLocKhachHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.QLKH,
            this.QLNV,
            this.menuTaiKhoan,
            this.QLHD});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home
            // 
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(90, 25);
            this.Home.Text = "Trang chủ";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // QLKH
            // 
            this.QLKH.Name = "QLKH";
            this.QLKH.Size = new System.Drawing.Size(103, 25);
            this.QLKH.Text = "Khách hàng";
            this.QLKH.Click += new System.EventHandler(this.QLKH_Click);
            // 
            // QLNV
            // 
            this.QLNV.Name = "QLNV";
            this.QLNV.Size = new System.Drawing.Size(93, 25);
            this.QLNV.Text = "Nhân viên";
            this.QLNV.Click += new System.EventHandler(this.QLNV_Click);
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(88, 25);
            this.menuTaiKhoan.Text = "Tài Khoản";
            this.menuTaiKhoan.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // QLHD
            // 
            this.QLHD.Name = "QLHD";
            this.QLHD.Size = new System.Drawing.Size(84, 25);
            this.QLHD.Text = "Hóa Đơn";
            this.QLHD.Click += new System.EventHandler(this.QLHD_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbGioiTinh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCanCuoc);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(782, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 462);
            this.panel1.TabIndex = 1;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(89, 271);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(137, 28);
            this.cbbGioiTinh.TabIndex = 15;
            this.cbbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbbGioiTinh_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(3, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Căn cước:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã KH:";
            // 
            // txtCanCuoc
            // 
            this.txtCanCuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCanCuoc.Location = new System.Drawing.Point(89, 225);
            this.txtCanCuoc.Name = "txtCanCuoc";
            this.txtCanCuoc.Size = new System.Drawing.Size(137, 26);
            this.txtCanCuoc.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(89, 182);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(137, 26);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(89, 140);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(137, 26);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKH.Location = new System.Drawing.Point(89, 99);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(137, 26);
            this.txtTenKH.TabIndex = 5;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKH.Location = new System.Drawing.Point(89, 56);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(137, 26);
            this.txtMaKH.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(188, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(64, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(38, 38);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(125, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(38, 38);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 86);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(755, 414);
            this.dgvKhachHang.TabIndex = 2;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(574, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbLocKhachHang
            // 
            this.cbbLocKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLocKhachHang.FormattingEnabled = true;
            this.cbbLocKhachHang.Location = new System.Drawing.Point(646, 46);
            this.cbbLocKhachHang.Name = "cbbLocKhachHang";
            this.cbbLocKhachHang.Size = new System.Drawing.Size(121, 28);
            this.cbbLocKhachHang.TabIndex = 4;
            this.cbbLocKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbbLocKhachHang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm khách hàng:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(180, 46);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(368, 26);
            this.txtTimKiem.TabIndex = 6;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 512);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLocKhachHang);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmKhachHang";
            this.Text = "                ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing_1);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.ToolStripMenuItem QLKH;
        private System.Windows.Forms.ToolStripMenuItem QLNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCanCuoc;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbLocKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem QLHD;
    }
}