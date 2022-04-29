using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace QuanLyKhachSan
{
    public partial class frmNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        QuanLy taoxml = new QuanLy();
        QuanLy hienthi = new QuanLy();
        string MaNV, TenNV, DiaChi, SDT, CanCuoc, GioiTinh, MatKhau, HoatDong, MucLuong, MaCV;
        public string path = "./NhanVien.xml";
        public XDocument doc;
        public int current = 0;
        public int maxRow = 0;
        public string gr = "All";
        Form parent;
        public frmNhanVien(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if (frmDangNhap.currAcc.Role.Equals("BQT"))
            {
                QLNV.Visible = false;
                QLKH.Visible = false;
            }
            else if (frmDangNhap.currAcc.Role.Equals("CCH"))
            {
                QLKH.Visible = false;
                menuTaiKhoan.Visible = false;
            }
            else
            {
                QLNV.Visible = false;
                menuTaiKhoan.Visible = false;
            }
            taoxml.TaoXML("NhanVien");
            initGrid(gr);
            settext(0);
            IEnumerable<XElement> list = null;
            string[] usernames = null;
            if (File.Exists("./TaiKhoan.xml"))
            {
                doc = XDocument.Load("./TaiKhoan.xml");
                list = doc.Descendants("TaiKhoan");
                usernames = new string[list.Count()];
            }
            DataTable dt = new DataTable("TaiKhoan");
            dt.Columns.Add("TenTaiKhoan", typeof(object));
            dt.Columns.Add("MatKhau", typeof(object));
            dt.Columns.Add("QuyenHan", typeof(object));
            if (list != null && list.Count() > 0)
            {
                int i = 0;
                foreach (XElement node in list)
                {
                    frmTaiKhoan.TaiKhoan tk = new frmTaiKhoan.TaiKhoan()
                    {
                        Username = node.Element("TenTaiKhoan").Value,
                        Password = node.Element("MatKhau").Value,
                        Role = node.Element("QuyenHan").Value,
                    };
                    dt.Rows.Add(tk.Username, tk.Password, tk.Role);
                    usernames[i] = tk.Username;
                    i++;
                }
            }
            doc = nv.open(path);
            list = doc.Descendants("_x0027_NhanVien_x0027_");
            string MaNV, mk;
            foreach (XElement node in list)
            {
                MaNV = node.Element("maNV").Value;
                mk = node.Element("matKhau").Value;
                if (CheckDuplicate(usernames, MaNV))
                {
                    dt.Rows.Add(MaNV, mk, "NV");
                }
            }
            dt.WriteXml(Application.StartupPath + "\\TaiKhoan.xml", XmlWriteMode.WriteSchema);
        }

        private bool CheckDuplicate(string[] usernames, string maNV)
        {
            if (usernames != null && usernames.Count() > 0)
            {
                foreach (string username in usernames)
                {
                    if (username.Equals(maNV)) return false;
                }
            }
            return true;
        }
        private void Home_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmTrangChu tc = new frmTrangChu(parent);
            tc.Show();
        }

        private void QLKH_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmKhachHang kh = new frmKhachHang(parent);
            kh.Show();
        }

        private void QLNV_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmNhanVien nv = new frmNhanVien(parent);
            nv.Show();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[d].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[d].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[d].Cells[2].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[d].Cells[3].Value.ToString();
            txtCanCuoc.Text = dgvNhanVien.Rows[d].Cells[4].Value.ToString();
            cbbGioiTinh.Text = dgvNhanVien.Rows[d].Cells[5].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.Rows[d].Cells[6].Value.ToString();
            txtHoatDong.Text = dgvNhanVien.Rows[d].Cells[7].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[d].Cells[8].Value.ToString();
            txtMaCV.Text = dgvNhanVien.Rows[d].Cells[9].Value.ToString();
            if (cbbGioiTinh.Text == "Nam")
            {
                cbbGioiTinh.Items.Clear();
                cbbGioiTinh.Items.Add("Nữ");
            }
            if (cbbGioiTinh.Text == "Nữ")
            {
                cbbGioiTinh.Items.Clear();
                cbbGioiTinh.Items.Add("Nam");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            LoadData();
            if (nv.kiemtra(MaNV) == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            else
            {
                nv.themNV(MaNV, TenNV, DiaChi, SDT, CanCuoc, GioiTinh, MatKhau, HoatDong, MucLuong, MaCV);
                var username = txtMaNV.Text.Trim();
                var password = txtMatKhau.Text.Trim();
                var role = "NV";
                doc = XDocument.Load("./TaiKhoan.xml");
                var list = doc.Descendants("TaiKhoan");
                DataTable dt = new DataTable("TaiKhoan");
                dt.Columns.Add("TenTaiKhoan", typeof(object));
                dt.Columns.Add("MatKhau", typeof(object));
                dt.Columns.Add("QuyenHan", typeof(object));
                if (list.Count() > 0)
                {
                    foreach (XElement node in list)
                    {
                        frmTaiKhoan.TaiKhoan tk = new frmTaiKhoan.TaiKhoan()
                        {
                            Username = node.Element("TenTaiKhoan").Value,
                            Password = node.Element("MatKhau").Value,
                            Role = node.Element("QuyenHan").Value,
                        };
                        dt.Rows.Add(tk.Username, tk.Password, tk.Role);
                    }
                }
                dt.Rows.Add(username, password, role);
                dt.WriteXml(Application.StartupPath + "\\TaiKhoan.xml", XmlWriteMode.WriteSchema);
                MessageBox.Show("Thêm thành công");
                initGrid(gr); settext(0);
                txtMaNV.Focus();
            }
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            new frmTaiKhoan(parent).Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
            nv.suaNV(MaNV, TenNV, DiaChi, SDT, CanCuoc, GioiTinh, MatKhau, HoatDong, MucLuong, MaCV);
            MessageBox.Show("Sửa thành công");
            initGrid(gr); settext(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();
            nv.xoaNV(MaNV);
            MessageBox.Show("Xóa thành công");
            initGrid(gr); settext(0);
        }
        public void initGrid(string gr)
        {
            this.dgvNhanVien.ColumnCount = 10;
            this.dgvNhanVien.Columns[0].Name = "Mã nhân viên";
            this.dgvNhanVien.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvNhanVien.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvNhanVien.Columns[0].Width = 120;

            this.dgvNhanVien.Columns[1].Name = "Họ tên";
            this.dgvNhanVien.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvNhanVien.Columns[1].Width = 120;
                 
            this.dgvNhanVien.Columns[2].Name = "Địa chỉ";
            this.dgvNhanVien.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvNhanVien.Columns[2].Width = 180;
                 
            this.dgvNhanVien.Columns[3].Name = "Số điện thoại";
            this.dgvNhanVien.Columns[3].Width = 100;
            this.dgvNhanVien.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvNhanVien.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                 
            this.dgvNhanVien.Columns[4].Name = "Căn cước";
            this.dgvNhanVien.Columns[4].Width = 100;
            this.dgvNhanVien.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                 
            this.dgvNhanVien.Columns[5].Name = "Giới tính";
            this.dgvNhanVien.Columns[5].Width = 80;
            this.dgvNhanVien.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvNhanVien.Columns[6].Name = "Mật khẩu";
            this.dgvNhanVien.Columns[6].Width = 80;
            this.dgvNhanVien.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvNhanVien.Columns[7].Name = "Hoạt động";
            this.dgvNhanVien.Columns[7].Width = 100;
            this.dgvNhanVien.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvNhanVien.Columns[8].Name = "Mức lương";
            this.dgvNhanVien.Columns[8].Width = 100;
            this.dgvNhanVien.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvNhanVien.Columns[9].Name = "Mã chức vụ";
            this.dgvNhanVien.Columns[9].Width = 100;
            this.dgvNhanVien.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            NhanVien lb = new NhanVien();
            doc = lb.open(path);
            var list = doc.Descendants("_x0027_NhanVien_x0027_");
            string MaNV, name, address, sdt, cc, gt, mk, hd, ml,macv;
            this.dgvNhanVien.Rows.Clear();
            foreach (XElement node in list)
            {
                MaNV = node.Element("maNV").Value;
                if (gr == MaNV || gr == "All")
                {
                    name = node.Element("hoTen").Value;
                    address = node.Element("diaChi").Value;
                    sdt = node.Element("SDT").Value;
                    cc = node.Element("canCuoc").Value;
                    gt = node.Element("gioiTinh").Value;
                    mk = node.Element("matKhau").Value;
                    hd = node.Element("hoatDong").Value;
                    ml = node.Element("mucLuong").Value;
                    macv = node.Element("maCV").Value;
                    this.dgvNhanVien.Rows.Add(MaNV, name, address, sdt, cc, gt, mk, hd, ml, macv);
                }
            }
            maxRow = this.dgvNhanVien.RowCount - 1;
            initCombo();
        }
        public void LoadData()
        {
            MaNV = txtMaNV.Text;
            TenNV = txtTenNV.Text;
            DiaChi = txtDiaChi.Text;
            SDT = txtSDT.Text;
            CanCuoc = txtCanCuoc.Text;
            GioiTinh = cbbGioiTinh.Text;
            MatKhau = txtMatKhau.Text;
            HoatDong = txtHoatDong.Text;
            MucLuong = txtLuong.Text;
            MaCV = txtMaCV.Text;
        }
        public void settext(int cur)
        {
            this.txtMaNV.Text = this.dgvNhanVien.Rows[cur].Cells[0].Value.ToString();
            this.txtTenNV.Text = this.dgvNhanVien.Rows[cur].Cells[1].Value.ToString();
            this.txtDiaChi.Text = this.dgvNhanVien.Rows[cur].Cells[2].Value.ToString();
            this.txtSDT.Text = this.dgvNhanVien.Rows[cur].Cells[3].Value.ToString();
            this.txtCanCuoc.Text = this.dgvNhanVien.Rows[cur].Cells[4].Value.ToString();
            this.cbbGioiTinh.Text = this.dgvNhanVien.Rows[cur].Cells[5].Value.ToString();
            this.txtMatKhau.Text = this.dgvNhanVien.Rows[cur].Cells[6].Value.ToString();
            this.txtHoatDong.Text = this.dgvNhanVien.Rows[cur].Cells[7].Value.ToString();
            this.txtLuong.Text = this.dgvNhanVien.Rows[cur].Cells[8].Value.ToString();
            this.txtMaCV.Text = this.dgvNhanVien.Rows[cur].Cells[9].Value.ToString();
        }
        public void initCombo()
        {
            doc = XDocument.Load(path);
            var list = doc.Descendants("_x0027_NhanVien_x0027_");
            string tmp = "All";
            this.cbbLocNhanVien.Items.Clear();
            this.cbbLocNhanVien.Items.Add("All");
            string group;
            ArrayList myClass = new ArrayList();
            foreach (XElement node in list)
            {
                group = node.Element("maNV").Value;
                if (!tmp.Contains(group))
                {
                    tmp = tmp + "," + group;
                    myClass.Add(group);
                }
            }
            myClass.Sort();
            for (int i = 0; i < myClass.Count - 1; i++)
            {
                this.cbbLocNhanVien.Items.Add(myClass[i]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("NhanVien.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "hoTen";
            reader.Close();
            int index = dv.Find(txtTimKiem.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                txtTimKiem.Text = "";
                txtTimKiem.Focus();
            }
            else
            {
                this.dgvNhanVien.Columns.Clear();
                this.dgvNhanVien.Rows.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã nhân viên");
                dt.Columns.Add("Họ tên");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Số điện thoại");
                dt.Columns.Add("Căn cước");
                dt.Columns.Add("Giới tính");
                dt.Columns.Add("Mật khẩu");
                dt.Columns.Add("Hoạt động");
                dt.Columns.Add("Mức lương");
                dt.Columns.Add("Mã chức vụ");
                object[] list = { dv[index]["maNV"], dv[index]["hoTen"], dv[index]["diaChi"], dv[index]["SDT"], dv[index]["canCuoc"], dv[index]["gioiTinh"], dv[index]["matKhau"], dv[index]["hoatDong"], dv[index]["mucLuong"], dv[index]["maCV"] };
                dt.Rows.Add(list);
                dgvNhanVien.DataSource = dt;
                txtTimKiem.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbLocNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            gr = this.cbbLocNhanVien.Text;
            initGrid(gr);
            settext(0);
        }
    }
}
