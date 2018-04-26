using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace NhanVien
{
    public class DatHang
    {
        public string MaNVL { get; set; }
        public string TenNVL { get; set; }
        public string LoaiNVL { get; set; }
        public string TenNCC { get; set; }
        public string Quycach { get; set; }
        public double SoLuongTrongKho { get; set; }
        public string DVT { get; set; }

        public DatHang(string Ma_NVL, string Ten_NVL, string Loai_NVL, string Ten_NCC, string Quycach_NVL, double SLTrongKho, string dvt)
        {
            this.MaNVL = Ma_NVL;
            this.TenNVL = Ten_NVL;
            this.LoaiNVL = Loai_NVL;
            this.TenNCC = Ten_NCC;
            this.Quycach = Quycach_NVL;
            this.SoLuongTrongKho = SLTrongKho;
            this.DVT = dvt;
        }
    }
}
