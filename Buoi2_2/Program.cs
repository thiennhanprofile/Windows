using Buoi02_2;
using Buoi2_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<SinhVien> list = NhapDSSinhVien();
            Console.Write("danh sach sinh vien: ");
            XuatDSSinhVien(list);
            Console.Write("sinh vien khoa CNTT: ");
            DSSVCNTT(list);
            Console.Write("sinh vien khoa diem tb > 5: ");
            DSSVLONHON5(list);
            Console.Write("sinh vien cos diem tang dan: ");
            DSSVSAPXEP(list);
            Console.ReadKey();
        }

        private static List<SinhVien> NhapDSSinhVien()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            Console.Write("Nhap tong so sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ========== Nhap dah sach sinh vien=========");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap sinh viên thứ {0}", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSV.Add(sv);
            }
            return listSV;
        }
        private static void XuatDSSinhVien(List<SinhVien> listSV)
        {
            Console.WriteLine("=====> XUAT DANH SANH>====");
            foreach (SinhVien sv in listSV)
            {
                sv.XuatSV();
            }
        }
        private static void DSSVCNTT(List<SinhVien> listSV)
        {

            List<SinhVien> ListCNTT1 = listSV.Where(p => p.Khoa == "CNTT").ToList();
            List<SinhVien> ListCNTT2 = (from s in listSV where s.Khoa == "CNTT" select s).ToList();
            if (ListCNTT1.Count() == 0)
            {

                Console.WriteLine("khong co sv kho cntt");

            }
            else
            {
                XuatDSSinhVien(ListCNTT1);
            }
            if (ListCNTT2.Count() == 0)
            {
                Console.WriteLine("khong co sv kho cntt");
            }
            else
            {
                XuatDSSinhVien(ListCNTT2);
            }
        }

        private static void DSSVLONHON5(List<SinhVien> listSV)
        {
            List<SinhVien> svLH5 = listSV.Where(p => p.DiemTB > 5).ToList();
            if (svLH5.Count() == 0)
            {
                Console.WriteLine(" khong co hoc sinh nao lon hon 5 diem");

            }
            else
            {
                XuatDSSinhVien(svLH5);
            }
        }

        private static void DSSVSAPXEP(List<SinhVien> listSV)
        {
            List<SinhVien> dssapxep = listSV.OrderBy(p => p.DiemTB).ToList();
            XuatDSSinhVien(dssapxep);
        }
    }
}