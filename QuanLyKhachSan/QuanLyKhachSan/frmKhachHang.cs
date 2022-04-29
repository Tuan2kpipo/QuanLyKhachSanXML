using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace QuanLyKhachSan
{
    public partial class frmKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        QuanLy taoxml = new QuanLy();
        QuanLy hienthi = new QuanLy();
        Form parent;
        string MaKH, TenKH, DiaChi, SDT, CanCuoc, GioiTinh;
        public string path = "./KhachHang.xml";
        public XDocument doc;
        public int current = 0;
        public int maxRow = 0;
        public string gr = "All";
        public frmKhachHang(Form parent)
        {
            InitializeComponent();
            if (frmDangNhap.currAcc.Role.Equals("BQT"))
            {
                QLNV.Visible = false;
                QLKH.Visible = false;
            } else if(frmDangNhap.currAcc.Role.Equals("CCH"))
            {
                QLKH.Visible = false;
                menuTaiKhoan.Visible = false;
            } else
            {
                QLNV.Visible = false;
                menuTaiKhoan.Visible = false;
            }
            this.parent = parent;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            taoxml.TaoXML("KhachHang");
            initGrid(gr);
            settext(0);
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgvKhachHang.CurrentRow.Index;
            txtMaKH.Text = dgvKhachHang.Rows[d].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[d].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[d].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[d].Cells[3].Value.ToString();
            txtCanCuoc.Text = dgvKhachHang.Rows[d].Cells[4].Value.ToString();
            cbbGioiTinh.Text = dgvKhachHang.Rows[d].Cells[5].Value.ToString();
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
            if (kh.kiemtra(MaKH) == true)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
            }
            else
            {
                kh.themKH(MaKH, TenKH, DiaChi, SDT, CanCuoc, GioiTinh);
                MessageBox.Show("Thêm thành công");
                initGrid(gr); settext(0);
                txtMaKH.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
            kh.suaKH(MaKH, TenKH, DiaChi, SDT, CanCuoc, GioiTinh);
            MessageBox.Show("Sửa thành công");
            initGrid(gr); settext(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();
            kh.xoaKH(MaKH);
            MessageBox.Show("Xóa thành công");
            initGrid(gr); settext(0);
        }
        public void initGrid(string gr)
        {
            this.dgvKhachHang.ColumnCount = 6;
            this.dgvKhachHang.Columns[0].Name = "Mã khách hàng";
            this.dgvKhachHang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvKhachHang.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvKhachHang.Columns[0].Width = 120;

            this.dgvKhachHang.Columns[1].Name = "Họ tên";
            this.dgvKhachHang.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvKhachHang.Columns[1].Width = 120;


            this.dgvKhachHang.Columns[2].Name = "Địa chỉ";
            this.dgvKhachHang.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvKhachHang.Columns[2].Width = 180;

            this.dgvKhachHang.Columns[3].Name = "Số điện thoại";
            this.dgvKhachHang.Columns[3].Width = 100;
            this.dgvKhachHang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvKhachHang.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvKhachHang.Columns[4].Name = "Căn cước";
            this.dgvKhachHang.Columns[4].Width = 100;
            this.dgvKhachHang.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;


            this.dgvKhachHang.Columns[5].Name = "Giới tính";
            this.dgvKhachHang.Columns[5].Width = 80;
            this.dgvKhachHang.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            KhachHang lb = new KhachHang();
            doc = lb.open(path);
            var list = doc.Descendants("_x0027_KhachHang_x0027_");
            string MaKH, name, address, sdt, cc, gt;
            this.dgvKhachHang.Rows.Clear();
            foreach (XElement node in list)
            {
                MaKH = node.Element("maKH").Value;
                if (gr == MaKH || gr == "All")
                {
                    name = node.Element("hoTen").Value;
                    address = node.Element("diaChi").Value;
                    sdt = node.Element("SDT").Value;
                    cc = node.Element("canCuoc").Value;
                    gt = node.Element("gioiTinh").Value;
                    this.dgvKhachHang.Rows.Add(MaKH, name, address, sdt, cc, gt);
                }
            }
            maxRow = this.dgvKhachHang.RowCount - 1;
            initCombo();
        }
        public void initCombo()
        {
            doc = XDocument.Load(path);
            var list = doc.Descendants("_x0027_KhachHang_x0027_");
            string tmp = "All";
            this.cbbLocKhachHang.Items.Clear();
            this.cbbLocKhachHang.Items.Add("All");
            string group;
            ArrayList myClass = new ArrayList();
            foreach (XElement node in list)
            {
                group = node.Element("maKH").Value;
                if (!tmp.Contains(group))
                {
                    tmp = tmp + "," + group;
                    myClass.Add(group);
                }
            }
            myClass.Sort();
            for (int i = 0; i < myClass.Count - 1; i++)
            {
                this.cbbLocKhachHang.Items.Add(myClass[i]);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("KhachHang.xml");
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
                this.dgvKhachHang.Columns.Clear();
                this.dgvKhachHang.Rows.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã Khách hàng");
                dt.Columns.Add("Tên khách hàng");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Số điện thoại");
                dt.Columns.Add("Căn cước");
                dt.Columns.Add("Giới tính");
                object[] list = { dv[index]["maKH"], dv[index]["hoTen"], dv[index]["diaChi"], dv[index]["SDT"], dv[index]["canCuoc"], dv[index]["gioiTinh"] };
                dt.Rows.Add(list);
                dgvKhachHang.DataSource = dt;
                txtTimKiem.Text = "";
            }
        }

        private void cbbLocKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            gr = this.cbbLocKhachHang.Text;
            initGrid(gr);
            settext(0);
        }
        public void settext(int cur)
        {
            this.txtMaKH.Text = this.dgvKhachHang.Rows[cur].Cells[0].Value.ToString();
            this.txtTenKH.Text = this.dgvKhachHang.Rows[cur].Cells[1].Value.ToString();
            this.txtDiaChi.Text = this.dgvKhachHang.Rows[cur].Cells[2].Value.ToString();
            this.txtSDT.Text = this.dgvKhachHang.Rows[cur].Cells[3].Value.ToString();
            this.txtCanCuoc.Text = this.dgvKhachHang.Rows[cur].Cells[4].Value.ToString();
            this.cbbGioiTinh.Text = this.dgvKhachHang.Rows[cur].Cells[5].Value.ToString();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            new frmTaiKhoan(parent).Show();
        }

        private void frmKhachHang_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void LoadData()
        {
            MaKH = txtMaKH.Text;
            TenKH = txtTenKH.Text;
            DiaChi = txtDiaChi.Text;
            SDT = txtSDT.Text;
            CanCuoc = txtCanCuoc.Text;
            GioiTinh = cbbGioiTinh.Text;
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

        private void QLHD_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmHoaDon hd = new frmHoaDon(parent);
            hd.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
