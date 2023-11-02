using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Teacher:Person
    {
        public string MaGV { get; set; }
        public string Khoa { get; set; }
        public string ChucVu { get; set; }

        public void NhapGiaoVien()
        {
            Console.Write("Nhập CNMD: ");
            CNMD = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập Địa chỉ: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhập Mã GV: ");
            MaGV = Console.ReadLine();
            Console.Write("Nhập Khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhập Chức vụ: ");
            ChucVu = Console.ReadLine();
        }
    }

}
