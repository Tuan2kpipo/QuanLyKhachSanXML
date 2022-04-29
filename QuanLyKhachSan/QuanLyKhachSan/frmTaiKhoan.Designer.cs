
namespace QuanLyKhachSan
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.bindingButt = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
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
            this.menuTaiKhoan});
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
            // panel1
            // 
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(782, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 462);
            this.panel1.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.statusLabel.Location = new System.Drawing.Point(3, 439);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(84, 20);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Trạng Thái";
            // 
            // txtRole
            // 
            this.txtRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Items.AddRange(new object[] {
            "BQT",
            "CCH",
            "NV"});
            this.txtRole.Location = new System.Drawing.Point(101, 154);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(125, 21);
            this.txtRole.TabIndex = 26;
            this.txtRole.SelectedIndexChanged += new System.EventHandler(this.txtRole_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(2, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quyền Hạn:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.Location = new System.Drawing.Point(87, 60);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 26);
            this.txtUsername.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(2, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tài Khoản:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.Location = new System.Drawing.Point(87, 105);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(139, 26);
            this.txtPass.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(2, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mật khẩu:";
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
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvTaiKhoan.AllowUserToResizeRows = false;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(12, 86);
            this.dgvTaiKhoan.MultiSelect = false;
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(755, 414);
            this.dgvTaiKhoan.TabIndex = 2;
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // bindingButt
            // 
            this.bindingButt.AutoSize = true;
            this.bindingButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingButt.Location = new System.Drawing.Point(611, 44);
            this.bindingButt.Name = "bindingButt";
            this.bindingButt.Size = new System.Drawing.Size(156, 20);
            this.bindingButt.TabIndex = 7;
            this.bindingButt.Text = "Kết nối dữ liệu từ bảng";
            this.bindingButt.UseVisualStyleBackColor = true;
            this.bindingButt.CheckedChanged += new System.EventHandler(this.bingdingButt_CheckedChanged);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 512);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.bindingButt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.ToolStripMenuItem QLKH;
        private System.Windows.Forms.ToolStripMenuItem QLNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox bindingButt;
        private System.Windows.Forms.ComboBox txtRole;
        private System.Windows.Forms.Label statusLabel;
    }
}