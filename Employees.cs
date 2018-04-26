using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NhanVien
{
    public class Employees
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ChucVu { get; set; }
        public string MaChucVu { get; set; }
        public Boolean Sex { get; set; }
        public DateTime NgayBatDauLam { get; set; }
        public int SoCaLam { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        //
        public Employees(int id, string lastName, string firstName, string chucvu, string machucvu,Boolean sex,
            int socalam, string diachi, DateTime ngayvaolam, string phone)
        {
            this.ID = id;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.ChucVu = chucvu;
            this.MaChucVu = machucvu;
            this.Sex = sex;
            this.NgayBatDauLam = ngayvaolam;
            this.SoCaLam = socalam;
            this.Address = diachi;
            this.Phone = phone;
        }
    }
}
