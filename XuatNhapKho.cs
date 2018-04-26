using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhanVien
{
    public class XuatNhapKho
    {
        public string Ma_NVL { get; set; }
        public string Ten_NVL { get; set; }
        public string Ten_LoaiNVL { get; set; }
        public string QuyCach { get; set; }
        public double SoLuongCon { get; set; }
        public string DVT { get; set; }

        public XuatNhapKho(string maNVL, string tenNVL, string tenLoaiNVL, string quycach, double soluongcon, string dvt)
        {
            this.Ma_NVL = maNVL;
            this.Ten_NVL = tenNVL;
            this.Ten_LoaiNVL = tenLoaiNVL;
            this.QuyCach = quycach;
            this.SoLuongCon = soluongcon;
            this.DVT = dvt;
        }
    }
}
