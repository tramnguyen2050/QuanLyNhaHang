using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhanVien
{
    public class MonAn
    {
        public string MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string LoaiMon { get; set; }
        public string QuyCach { get; set; }
        public string NuocCham { get; set; }
        public string MonKemTheo { get; set; }
        public int DonGia { get; set; }

        public MonAn(string mamonan,
            string tenmonan,
            string loaimon,
            string quycach,
            string nuoccham,
            string monkemtheo,
            int dongia)
        {
            this.MaMonAn = mamonan;
            this.TenMonAn = tenmonan;
            this.LoaiMon = loaimon;
            this.QuyCach = quycach;
            this.NuocCham = nuoccham;
            this.MonKemTheo = monkemtheo;
            this.DonGia = dongia;
        }
    }
}
