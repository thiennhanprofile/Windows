using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ax^2 + bx + c = 0");

            Console.Write("Nhập giá trị a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập giá trị b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập giá trị c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có hai nghiệm phân biệt:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có một nghiệm kép:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Phương trình không có nghiệm thực.");
            }
            Console.ReadKey();
        }
    }
}