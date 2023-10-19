using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_5
{

    class Program
    {
        static void Main()
        {
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());

            string[] dssinhvien = new string[n];

            NhapSV(dssinhvien, n);

            Console.WriteLine("Danh sách sinh viên sau khi nhập:");
            XuatSV(dssinhvien, n);
            Console.ReadLine();
        }
        static void NhapSV(string[] dssinhvien, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập họ tên sinh viên thứ {i + 1}: ");
                dssinhvien[i] = Console.ReadLine();
            }
        }

        static void XuatSV(string[] dssinhvien, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Sinh viên thứ {i + 1}: {dssinhvien[i]}");
            }
        }
    }
}