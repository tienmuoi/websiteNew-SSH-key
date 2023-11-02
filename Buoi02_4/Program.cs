using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_4
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            QuanLyKhuDat quanLyKhuDat = new QuanLyKhuDat();

            // Thêm các khu đất vào danh sách quản lý
            quanLyKhuDat.ThemKhuDat(new KhuDat("Khu Đất A", 900000000M, 80));
            quanLyKhuDat.ThemKhuDat(new KhuDat("Khu Đất B", 1200000000M, 100));
            quanLyKhuDat.ThemKhuDat(new KhuDat("Khu Đất C", 800000000M, 70));
            quanLyKhuDat.ThemKhuDat(new KhuDat("Khu Đất D", 950000000M, 90));

            // Yêu cầu 2: Xuất danh sách thông tin các khu đất có diện tích được sắp xếp tăng dần.
            Console.WriteLine("Danh sách các khu đất có diện tích được sắp xếp tăng dần:");
            quanLyKhuDat.XuatDanhSachKhuDatTheoDienTichTangDan();

            // Yêu cầu 3: Xuất danh sách các khu đất có giá bán < 1 tỷ và diện tích >= 60m2 (nếu có).
            Console.WriteLine("\nDanh sách các khu đất có giá bán < 1 tỷ và diện tích >= 60m2 (nếu có):");
            quanLyKhuDat.XuatDanhSachKhuDatGiaDuoi1TrieuDienTichLonHon60m2();

            // Yêu cầu 4: Tính đơn giá trung bình 1m2 của tất cả các khu đất có diện tích lớn hơn 1000m2 (nếu có).
            decimal donGiaTrungBinh = quanLyKhuDat.TinhDonGiaTrungBinhLonHon1000m2();
            Console.WriteLine($"\nĐơn giá trung bình 1m2 của các khu đất có diện tích lớn hơn 1000m2 là: {donGiaTrungBinh} VND/m2");

            Console.ReadKey();
        }
    }
}

