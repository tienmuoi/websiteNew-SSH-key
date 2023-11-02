using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_7
{
    internal class Program
    {
        static bool KTNT(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen duong = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            Console.WriteLine($"Cac so nguyen to tu 1 den {n} la:");
            for (int i = 1; i <= n; i++)
            {
                if (KTNT(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
