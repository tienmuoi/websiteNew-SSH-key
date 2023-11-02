using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_4
{

public class QuanLyKhuDat
    {
        private List<KhuDat> danhSachKhuDat;

        public QuanLyKhuDat()
        {
            danhSachKhuDat = new List<KhuDat>();
        }

        public void ThemKhuDat(KhuDat khuDat)
        {
            danhSachKhuDat.Add(khuDat);
        }

        public void XuatDanhSachKhuDat()
        {
            foreach (var khuDat in danhSachKhuDat)
            {
                Console.WriteLine($"Địa điểm: {khuDat.DiaDiem}");
                Console.WriteLine($"Giá bán: {khuDat.GiaBan} VND");
                Console.WriteLine($"Diện tích: {khuDat.DienTich} m2");
                Console.WriteLine();
            }
        }

        public void XuatDanhSachKhuDatTheoDienTichTangDan()
        {
            var khuDatTheoDienTich = danhSachKhuDat.OrderBy(kd => kd.DienTich).ToList();
            XuatDanhSachKhuDat(khuDatTheoDienTich);
        }

        public void XuatDanhSachKhuDatGiaDuoi1TrieuDienTichLonHon60m2()
        {
            var khuDatGiaDuoi1Trieu = danhSachKhuDat.Where(kd => kd.GiaBan < 1000000000M && kd.DienTich >= 60).ToList();
            XuatDanhSachKhuDat(khuDatGiaDuoi1Trieu);
        }

        public decimal TinhDonGiaTrungBinhLonHon1000m2()
        {
            var khuDatLonHon1000m2 = danhSachKhuDat.Where(kd => kd.DienTich > 1000).ToList();
            if (khuDatLonHon1000m2.Any())
            {
                decimal tongGia = khuDatLonHon1000m2.Sum(kd => kd.GiaBan);
                double tongDienTich = khuDatLonHon1000m2.Sum(kd => kd.DienTich);
                return tongGia / (decimal)tongDienTich;
            }
            return 0M;
        }

        private void XuatDanhSachKhuDat(List<KhuDat> danhSach)
        {
            foreach (var khuDat in danhSach)
            {
                Console.WriteLine($"Địa điểm: {khuDat.DiaDiem}");
                Console.WriteLine($"Giá bán: {khuDat.GiaBan} VND");
                Console.WriteLine($"Diện tích: {khuDat.DienTich} m2");
                Console.WriteLine();
            }
        }
    }

}

