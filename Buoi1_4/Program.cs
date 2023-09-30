using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen c: ");
            int c = int.Parse(Console.ReadLine());

            if (IsTriangle(a, b, c))
            {
                double chuVi = CalculatePerimeter(a, b, c);
                double dienTich = CalculateArea(a, b, c);

                Console.WriteLine("Day la 3 canh cua tam giac.");
                Console.WriteLine("Chu vi cua tam giac la: " + chuVi);
                Console.WriteLine("Dien tich: " + dienTich);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Day khong phai la tam giac.");
            }
        }

        static bool IsTriangle(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static double CalculatePerimeter(int a, int b, int c)
        {
            return a + b + c;
        }

        static double CalculateArea(int a, int b, int c)
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}