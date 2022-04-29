
namespace QuanLyKhachSan
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLocNhanVien = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtHoatDong = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(180, 45);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(353, 26);
            this.txtTimKiem.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm kiếm nhân viên:";
            // 
            // cbbLocNhanVien
            // 
            this.cbbLocNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLocNhanVien.FormattingEnabled = true;
            this.cbbLocNhanVien.Location = new System.Drawing.Point(638, 45);
            this.cbbLocNhanVien.Name = "cbbLocNhanVien";
            this.cbbLocNhanVien.Size = new System.Drawing.Size(121, 28);
            this.cbbLocNhanVien.TabIndex = 10;
            this.cbbLocNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbLocNhanVien_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(563, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 38);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 84);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(747, 447);
            this.dgvNhanVien.TabIndex = 8;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaCV);
            this.panel1.Controls.Add(this.txtLuong);
            this.panel1.Controls.Add(this.txtHoatDong);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
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
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(778, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 491);
            this.panel1.TabIndex = 7;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaCV.Location = new System.Drawing.Point(102, 447);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(139, 26);
            this.txtMaCV.TabIndex = 23;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.Location = new System.Drawing.Point(102, 405);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(139, 26);
            this.txtLuong.TabIndex = 22;
            // 
            // txtHoatDong
            // 
            this.txtHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoatDong.Location = new System.Drawing.Point(102, 361);
            this.txtHoatDong.Name = "txtHoatDong";
            this.txtHoatDong.Size = new System.Drawing.Size(139, 26);
            this.txtHoatDong.TabIndex = 21;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(102, 317);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(139, 26);
            this.txtMatKhau.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(3, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mã chức vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(3, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mức lương:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(3, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hoạt động:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(3, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mật khẩu:";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(102, 271);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(139, 28);
            this.cbbGioiTinh.TabIndex = 15;
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
            this.label3.Text = "Tên NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã NV:";
            // 
            // txtCanCuoc
            // 
            this.txtCanCuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCanCuoc.Location = new System.Drawing.Point(102, 225);
            this.txtCanCuoc.Name = "txtCanCuoc";
            this.txtCanCuoc.Size = new System.Drawing.Size(139, 26);
            this.txtCanCuoc.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(102, 182);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(139, 26);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(102, 140);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(139, 26);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNV.Location = new System.Drawing.Point(102, 99);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(139, 26);
            this.txtTenNV.TabIndex = 5;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(102, 56);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(139, 26);
            this.txtMaNV.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(203, 3);
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
            this.btnUpdate.Location = new System.Drawing.Point(70, 3);
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
            this.btnDelete.Location = new System.Drawing.Point(138, 3);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.QLKH,
            this.QLNV,
            this.menuTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 29);
            this.menuStrip1.TabIndex = 13;
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
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 536);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLocNhanVien);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLocNhanVien;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvNhanVien;
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
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtHoatDong;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.ToolStripMenuItem QLKH;
        private System.Windows.Forms.ToolStripMenuItem QLNV;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
    }
}