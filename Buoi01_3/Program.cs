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
            Console.WriteLine("Nhap vao so nguyen duong  n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Vui long nhap so nguyen duong n:");

            }
            else
            {
                int tong = tinhtongsole(n);
                Console.WriteLine("Tong cac so nguyen duong n tu 1 den 2n-1 la: {0}", tong);

            }
            Console.ReadKey();

        }
        static int tinhtongsole(int n)
        {
            
                int tong = 0;

                for (int i = 1; i <= 2 * n - 1; i += 2)
                {
                    tong += i;
                }

                return tong;
            }
        }
    }
