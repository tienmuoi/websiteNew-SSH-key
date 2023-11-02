using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_6
{
    //Viết chương trình giải phương trình ax2+bx+c=0
    internal class Program
    {
        static void TPTB2(int a, int b, int c)
        {
            double denta = b * b - 4 * a * c;
            if (denta > 0)
            {
                double x1 = (-b + Math.Sqrt(denta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(denta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem x1={0}, x2={1}", x1, x2);
            }
            else if (denta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co 1 nghiem kep x={0}", x);

            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");

            }

        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Nhap so a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so c= ");
            c = Convert.ToInt32(Console.ReadLine());

            TPTB2(a, b, c);
            Console.ReadKey();
        }
    }
}
