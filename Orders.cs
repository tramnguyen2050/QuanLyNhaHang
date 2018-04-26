using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhanVien
{
    public class Orders
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoLuong {get; set;}
        public int DonGia {get; set;}
        public int ThanhTien { get; set; }

        public Orders(string mamon, string tenmon, int soluong, int dongia, int thanhtien)
        {
            this.MaMon = mamon;
            this.TenMon = tenmon;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }
    }
}
