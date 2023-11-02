using Buoi02_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<SinhVien> listSinhVien = NhapDSSinhVien();

            XuatDSSinhvien(listSinhVien);

            DSSVCNTT(listSinhVien);

            DSSVLONHON5(listSinhVien);
            DSSVSAPXEP(listSinhVien);


            Console.ReadKey();
        }
        private static List<SinhVien> NhapDSSinhVien()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.Write("Nhập tổng số sinh viên n=");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ===Nhập danh sách sinh viên ===");
            for (int i = 0; i < N; i++)
            {
                Console.Write(" Nhập sinh viên thứ {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;


        }
        private static void XuatDSSinhvien(List<SinhVien> listSinhVien)
        {
            Console.WriteLine("\n ***danh sách sinh viên***");
            foreach (SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }

        }
        private static void DSSVCNTT(List<SinhVien> ListSinhVien)
        {
            List<SinhVien> listCNTT1 = ListSinhVien.Where(t => t.Khoa == "CNTT" ).ToList();
            List<SinhVien> listCNTT2 = (from s in ListSinhVien where s.Khoa == "CNTT" select s).ToList();

            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("Khong có sinh vien khoa CNTT");

            }
            else
            {
                Console.WriteLine("\n=== Danh sách sinh viên thuộc khoa CNTT ===");

                XuatDSSinhvien(listCNTT1);

            }
            if (listCNTT2.Count() == 0)
            {
                Console.WriteLine("không có sinh viên khoa CNTT");
            }
            else
            {
                Console.WriteLine("\n=== Danh sách sinh viên thuộc khoa CNTT ===");
                XuatDSSinhvien(listCNTT2);
            }

        }
        private static void DSSVLONHON5(List<SinhVien> ListSinhVien)
        {
            List<SinhVien> listSV = ListSinhVien.Where(p => p.DiemTB >= 5).ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên có điểm >= 5");
            }
            else
            {
                Console.WriteLine("\n=== Danh sách sinh viên có điểm >= 5 ===");
                XuatDSSinhvien(listSV);
            }
        }
        private static void DSSVSAPXEP(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            Console.WriteLine("\n=== Danh sách sinh viên sau khi sắp xếp ===");
            XuatDSSinhvien(listSV);
        }
    }
}