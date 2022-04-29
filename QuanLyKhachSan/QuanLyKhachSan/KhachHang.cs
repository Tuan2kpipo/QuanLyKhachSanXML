using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace QuanLyKhachSan
{
    class KhachHang
    {
        public XDocument open(string url)
        {
            try
            {
                return XDocument.Load(url);
            }
            catch
            {
                return null;
            }
        }
        QuanLy Fxml = new QuanLy();
        
        public bool kiemtra(string MaKhachHang)
        {
            XmlTextReader reader = new XmlTextReader("KhachHang.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_KhachHang_x0027_[maKH='" + MaKhachHang + "']");
            reader.Close();
            bool kq = true;
            if (node != null)
            {
                return kq = true;
            }
            else
            {
                return kq = false;
            }
        }
        
        public void themKH(string MaKhachHang, string TenKhachHang, string DiaChi, string SDT, string CanCuoc, string GioiTinh)
        {
            string noiDung = "<_x0027_KhachHang_x0027_>" +
                    "<maKH>" + MaKhachHang + "</maKH>" +
                    "<hoTen>" + TenKhachHang + "</hoTen>" +
                    "<diaChi>" + DiaChi + "</diaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<canCuoc>" + CanCuoc + "</canCuoc>" +
                    "<gioiTinh>" + GioiTinh + "</gioiTinh>" +
                    "</_x0027_KhachHang_x0027_>";
            Fxml.Them("KhachHang.xml", noiDung);
        }

        public void suaKH(string maKH, string TenKhachHang, string DiaChi, string SDT, string CanCuoc, string GioiTinh)
        {
            string noiDung = "<maKH>" + maKH + "</maKH>" +
                    "<hoTen>" + TenKhachHang + "</hoTen>" +
                    "<diaChi>" + DiaChi + "</diaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<canCuoc>" + CanCuoc + "</canCuoc>" +
                    "<gioiTinh>" + GioiTinh + "</gioiTinh>";
            Fxml.Sua("KhachHang.xml", "_x0027_KhachHang_x0027_", "maKH", maKH, noiDung);
        }
        public void xoaKH(string maKH)
        {
            Fxml.Xoa("KhachHang.xml", "_x0027_KhachHang_x0027_", "maKH", maKH);
        }
    }
}
