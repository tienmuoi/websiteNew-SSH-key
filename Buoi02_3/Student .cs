using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Student : Person
    {
        public string MaSV { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }
        public void NhapSinhVien()
        {
            Console.Write("Nhập CNMD: ");
            CNMD = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập Địa chỉ: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhập Mã SV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhập Điểm TB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhập Khoa: ");
            Khoa = Console.ReadLine();
        }
    }
    }
