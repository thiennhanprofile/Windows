using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_1
{
    internal class SinhVien
    {
        private string _MaSV;
        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }

        }
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            private set { _HoTen = value; }
        }
        private double _DiemTB;
        public double DiemTB
        {
            get { return _DiemTB; }
            private set { _DiemTB = value; }
        }
        private string _Khoa;
        public string Khoa
        {
            get { return _Khoa; }
            private set { _Khoa = value; }
        }
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
            Console.Write("nhap ma sinh vien");
            MaSV = Console.ReadLine();
            Console.Write("nhap ho ten sinh vien");
            HoTen = Console.ReadLine();
            Console.Write("nhap diem trung binh sinh vien");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("nhap khoa sinh vien");
            Khoa = Console.ReadLine();

        }
        public void XuatSV()
        {
            Console.WriteLine("{0} \t{1} \t{2} \t{3} \n", MaSV, HoTen, DiemTB, Khoa);
        }
    }
}