using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_1
{
    internal class SinhVien
    {
        private string MaSV { get; set; }
        private string HoTen { get; set; }
        private double DiemTB { get; set; }
        private string Khoa { get; set; }

        public SinhVien() { }
        public SinhVien(string masv, string hoten, double diemtb, string khoa)
        {
            MaSV = masv;
            HoTen = hoten;
            DiemTB = diemtb;
            Khoa = khoa;


        }
        public SinhVien(SinhVien sv)
        {
            MaSV = sv.MaSV;
            HoTen = sv.HoTen;
            DiemTB = sv.DiemTB;
            Khoa = sv.Khoa;

        }
        public void NhapSV()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap MaDiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
       public void XuatSV()
        {
            Console.WriteLine("MaSV:{0} \t HoTen:{1} \t DiemTB:{2} \t Khoa:{3}" ,MaSV, HoTen, DiemTB, Khoa);
        }
    }

}
