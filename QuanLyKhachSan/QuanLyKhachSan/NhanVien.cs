using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace QuanLyKhachSan
{
    class NhanVien
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

        public bool kiemtra(string MaNV)
        {
            XmlTextReader reader = new XmlTextReader("NhanVien.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/_x0027_NhanVien_x0027_[maKH='" + MaNV + "']");
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

        public void themNV(string maNV, string HoTen, string DiaChi, string SDT, string CanCuoc, string GioiTinh, string MatKhau, string HoatDong, string MucLuong, string MaCV)
        {
            string noiDung = "<_x0027_NhanVien_x0027_>" +
                    "<maNV>" + maNV + "</maNV>" +
                    "<hoTen>" + HoTen + "</hoTen>" +
                    "<diaChi>" + DiaChi + "</diaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<canCuoc>" + CanCuoc + "</canCuoc>" +
                    "<gioiTinh>" + GioiTinh + "</gioiTinh>" +
                    "<matKhau>" + MatKhau + "</matKhau>" +
                    "<hoatDong>" + HoatDong + "</hoatDong>" +
                    "<mucLuong>" + MucLuong + "</mucLuong>" +
                    "<maCV>" + MaCV + "</maCV>" +
                    "</_x0027_NhanVien_x0027_>";
            Fxml.Them("NhanVien.xml", noiDung);
        }

        public void suaNV(string maNV, string HoTen, string DiaChi, string SDT, string CanCuoc, string GioiTinh, string MatKhau, string HoatDong, string MucLuong, string MaCV)
        {
            string noiDung = "<maNV>" + maNV + "</maNV>" +
                    "<hoTen>" + HoTen + "</hoTen>" +
                    "<diaChi>" + DiaChi + "</diaChi>" +
                    "<SDT>" + SDT + "</SDT>" +
                    "<canCuoc>" + CanCuoc + "</canCuoc>" +
                    "<gioiTinh>" + GioiTinh + "</gioiTinh>" +
                    "<matKhau>" + MatKhau + "</matKhau>" +
                    "<hoatDong>" + HoatDong + "</hoatDong>" +
                    "<mucLuong>" + MucLuong + "</mucLuong>" +
                    "<maCV>" + MaCV + "</maCV>";
            Fxml.Sua("NhanVien.xml", "_x0027_NhanVien_x0027_", "maNV", maNV, noiDung);
        }
        public void xoaNV(string maNV)
        {
            Fxml.Xoa("NhanVien.xml", "_x0027_NhanVien_x0027_", "maNV", maNV);
        }
    }
}
