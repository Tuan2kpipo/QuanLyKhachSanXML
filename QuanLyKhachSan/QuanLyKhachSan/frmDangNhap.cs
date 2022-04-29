using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static QuanLyKhachSan.frmTaiKhoan;

namespace QuanLyKhachSan
{
    public partial class frmDangNhap : Form
    {
        List<TaiKhoan> list = new List<TaiKhoan>();
       XDocument doc;

        public static TaiKhoan currAcc;

        public frmDangNhap()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            list.Clear();
            if (File.Exists(path))
            {
                doc = XDocument.Load(path);
                var list = doc.Descendants("TaiKhoan");
                if (list.Count() > 0)
                {
                    foreach (XElement node in list)
                    {
                        if (node.Element("TenTaiKhoan").Value.Equals("admin")) continue;
                        TaiKhoan tk = new TaiKhoan()
                        {
                            Username = node.Element("TenTaiKhoan").Value,
                            Password = node.Element("MatKhau").Value,
                            Role = node.Element("QuyenHan").Value,
                        };
                        this.list.Add(tk);
                    }
                }
            }
            this.list.Add(new TaiKhoan("admin", "1", "BQT"));
        }

        public bool checkInput()
        {
            if(txtUsername.Text.Length <= 0)
            {
                MessageBox.Show("Nhập vào ô tài khoản!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(txtPass.Text.Length <= 0)
            {
                MessageBox.Show("Nhập vào ô mật khẩu!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        
        private TaiKhoan KiemTraDangNhap(string username, string password)
        {
            foreach(var tk in list)
            {
                if (tk.Username.ToLower().Equals(username.ToLower()) && tk.Password.Equals(password)) return tk;
            }
            return null;
        }

        private void loginButt_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;
            var username = txtUsername.Text.Trim();
            var password = txtPass.Text.Trim();
            TaiKhoan tk;
            if ((tk = KiemTraDangNhap(username, password)) != null)
            {
                this.Visible = false;
                currAcc = tk;
                new frmTrangChu(this).Show();
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtUsername.Text = "";
            txtPass.Text = "";
        }

        private void frmDangNhap_VisibleChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
