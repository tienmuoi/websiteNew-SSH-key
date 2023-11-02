using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_1
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public int MaKhoa { get; set; }

        public SinhVien(string maSV, string hoTen, double diemTB, int maKhoa)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.DiemTB = diemTB;
            this.MaKhoa = maKhoa;
        }

        public SinhVien(string masv, string hoten, int makhoa, double diemtb)
        {
            MaSV = masv;
            HoTen = hoten;
            MaKhoa = makhoa;
            DiemTB = diemtb;
        }
    }

}
