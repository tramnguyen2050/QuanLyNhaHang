using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhanVien
{
    public class NguyenVatLieu
    {
        public string MaNVL { get; set; }
        public string TenNVL { get; set; }
        public string TenLoaiNVL { get; set; }
        public string QuyCach { get; set; }
        
        public double SoLuongTrongKho { get; set; }
        public double SoLuongToiThieuDatLai { get; set; }
        public string DonViTinh { get; set; }

        public NguyenVatLieu(string maNVL, string tenNVL, string tenloaiNVL, string quycach, double SoLuongTrongKho, double SoLuongToiThieuDatLai, string donvitinh)
        {
            this.MaNVL = maNVL;
            this.TenNVL = tenNVL;
            this.TenLoaiNVL = tenloaiNVL;
            this.QuyCach = quycach;
            
            this.SoLuongTrongKho = SoLuongTrongKho;
            this.SoLuongToiThieuDatLai = SoLuongToiThieuDatLai;
            this.DonViTinh = donvitinh;
        }
    }
}
