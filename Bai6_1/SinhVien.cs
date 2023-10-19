using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_1
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int Makhoa { get; set; }
        public double DiemTB { get; set; }
        public SinhVien() { }
        public SinhVien(string masv, string hoten, int makhoa, double diemtb)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.Makhoa = makhoa;
            this.DiemTB = diemtb;
        }
    }
}
