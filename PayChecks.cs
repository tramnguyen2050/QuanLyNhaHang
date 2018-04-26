using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhanVien
{
    public class PayChecks
    {
        public int MaNV { get; set; }
        public string HoVaTenNV { get; set; }
        public Boolean GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public int SoCaLam { get; set; }
        public int HeSoLuong { get; set; }
        public int LuongThang { get; set; }
        public string SDT { get; set; }

        public PayChecks(int maNV, string hotenNV, Boolean gioitinh, string chucvu, int socalam, int hesoluong, int luong, string sdt)
        {
            this.MaNV = maNV;
            this.HoVaTenNV = hotenNV;
            this.GioiTinh = gioitinh;
            this.ChucVu = chucvu;
            this.SoCaLam = socalam;
            this.HeSoLuong = hesoluong;
            this.LuongThang = luong;
            this.SDT = sdt;
        }
    }
}
