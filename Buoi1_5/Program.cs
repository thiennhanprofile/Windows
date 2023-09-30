using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            string[] dsSinhVien = NhapSV(n);
            XuatSV(dsSinhVien, n);
        }

        static string[] NhapSV(int n)
        {
            string[] dsSinhVien = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ho ten sinh vien: ");
                dsSinhVien[i] = Console.ReadLine();
            }

            return dsSinhVien;
        }

        static void XuatSV(string[] dsSinhVien, int n)
        {
            Console.WriteLine("Danh sach sinh vien:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien: {dsSinhVien[i]}");
                Console.ReadKey();
            }
        }
    }
}