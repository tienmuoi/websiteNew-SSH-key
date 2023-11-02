using System;

namespace Buoi1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao canh a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao canh b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao canh c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            bool la1tamgiac = KiemTraTamGiac(a, b, c);

            if (la1tamgiac)
            {
                double chuVi = TinhChuVi(a, b, c);
                double dienTich = TinhDienTich(a, b, c);

                Console.WriteLine("Chu vi cua tam giac la: {0}", chuVi);
                Console.WriteLine("Dien tich cua tam giac la: {0}", dienTich);
            }
            else
            {
                Console.WriteLine("Ba canh {0}, {1}, {2} KHONG the tao thanh mot tam giac.", a, b, c);
            }
            Console.ReadKey();
        }

        static bool KiemTraTamGiac(int a, int b, int c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return true;
            }

            return false;
        }

        static double TinhChuVi(int a, int b, int c)
        {
            return a + b + c;
        }

        static double TinhDienTich(int a, int b, int c)
        {
            double s = TinhChuVi(a, b, c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
