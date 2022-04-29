using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmTrangChu : Form
    {
        Form parent;
        public frmTrangChu(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            frmTrangChu tc = new frmTrangChu(parent);
            tc.Show();
        }

        private void QLKH_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            frmKhachHang kh = new frmKhachHang(parent);
            kh.Show();
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            frmNhanVien nv = new frmNhanVien(parent);
            nv.Show();
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            new frmTaiKhoan(parent).Show();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if(frmDangNhap.currAcc.Role.Equals("BQT"))
            {
                QLNV.Visible = false;
                QLKH.Visible = false;
                QLHD.Visible = false;
            } else if(frmDangNhap.currAcc.Role.Equals("CCH"))
            {
                QLKH.Visible = false;
                menuTaiKhoan.Visible = false;
                QLHD.Visible = false;
            } else
            {
                QLNV.Visible = false;
                menuTaiKhoan.Visible = false;
            }
            
        }

        private void QLHD_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmHoaDon hd = new frmHoaDon(parent);
            hd.Show();
        }
    }
}
