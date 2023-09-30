using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            int tong = 0;

            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                tong += i;
            }

            Console.WriteLine("Tong cac so le tu 1 den 2n-1: " + tong);
            Console.ReadKey();
        }
    }
}