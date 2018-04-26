using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhanVien
{
    public class OrderDatail
    {
        public int MaHD { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int TinhTien { get; set; }

        public OrderDatail(int maHD, string tenMon, int soLuong, int donGia, int tinhTien)
        {
            this.MaHD = maHD;
            this.TenMon = tenMon;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.TinhTien = tinhTien;
        }
    }
}
