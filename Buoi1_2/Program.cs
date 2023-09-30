using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_2
{
    internal class Program
    {
        static bool CheckNamNhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int thang, nam, songay;
            Console.WriteLine("Nhap thang:");
            thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap nam:");
            nam = Convert.ToInt32(Console.ReadLine());
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    songay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    songay = 30;
                    break;
                case 2:
                    if (CheckNamNhuan(nam))
                        songay = 29;
                    else
                        songay = 28;
                    break;
                default:
                    Console.WriteLine("Thang khong hop le");
                    return;
            }
            Console.WriteLine("So ngay: " + songay);
            Console.ReadKey();
        }
    }
}