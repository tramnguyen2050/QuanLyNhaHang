using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhanVien
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaKhachHang { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime NgayGioDat { get; set; }
        public string BanSo { get; set; }

        public HoaDon(int mahoadon, int makhachhang, int manhanvien, DateTime ngaygiodat, string banso)
        {
            this.MaHoaDon = mahoadon;
            this.MaKhachHang = makhachhang;
            this.MaNhanVien = manhanvien;
            this.NgayGioDat = ngaygiodat;
            this.BanSo = banso;
        }
    }
}
