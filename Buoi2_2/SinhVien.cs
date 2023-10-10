using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_2
{
    internal class SinhVien
    {
        //khai bao thuoc tinh

        public string Khoa { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public SinhVien() { }

        public SinhVien(string msv, string ht, double diem, string khoa)
        {
            this.MaSV = msv;
            this.HoTen = ht;
            this.DiemTB = diem;
            this.Khoa = khoa;
        }

        public SinhVien(SinhVien sinhVien)
        {
            this.MaSV = sinhVien.MaSV;
            this.HoTen = sinhVien.HoTen;
            this.DiemTB = sinhVien.DiemTB;
            this.Khoa = sinhVien.Khoa;
        }
        public void NhapSV()
        {
            Console.Write("nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.Write("nhap dien trung binh sinh vien: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("nhap khoa cua sinh vien: ");
            Khoa = Console.ReadLine();

        }

        public void XuatSV()
        {
            Console.WriteLine("{0} \t{1} \t{2} \t{3} \n ", MaSV, HoTen, DiemTB, Khoa);
        }
    }
}