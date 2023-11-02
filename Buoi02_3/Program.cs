using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.InputEncoding = System.Text.Encoding.UTF8;

                List<Teacher> teachers = NhapDSGiaoVien();
                List<Student> students = NhapDSSinhVien();

                // Yêu cầu 1: Tìm danh sách sinh viên thuộc khoa "CNTT"
                List<Student> svCNTT = students.Where(sv => sv.Khoa == "CNTT").ToList();
                if (svCNTT.Count > 0)
                {
                    Console.WriteLine("Danh sách sinh viên thuộc khoa CNTT:");
                    XuatDSSinhVien(svCNTT);
                }
                else
                {
                    Console.WriteLine("Không có sinh viên thuộc khoa CNTT.");
                }

                // Yêu cầu 3: Xuất danh sách sinh viên có điểm trung bình < 5 và thuộc khoa "CNTT"
                List<Student> svDiemThap = students.Where(sv => sv.Khoa == "CNTT" && sv.DiemTB < 5).ToList();
                if (svDiemThap.Count > 0)
                {
                    Console.WriteLine("\nDanh sách sinh viên có điểm trung bình < 5 và thuộc khoa CNTT:");
                    XuatDSSinhVien(svDiemThap);
                }
                else
                {
                    Console.WriteLine("Không có sinh viên có điểm trung bình < 5 và thuộc khoa CNTT.");
                }

                // Yêu cầu 4: Xuất danh sách giáo viên có địa chỉ chứa thông tin "Quận 9"
                List<Teacher> gvQuan9 = teachers.Where(gv => gv.DiaChi.Contains("Quận 9")).ToList();
                if (gvQuan9.Count > 0)
                {
                    Console.WriteLine("\nDanh sách giáo viên có địa chỉ chứa thông tin 'Quận 9':");
                    XuatDSGiaoVien(gvQuan9);
                }
                else
                {
                    Console.WriteLine("Không có giáo viên có địa chỉ chứa thông tin 'Quận 9'.");
                }

                // Yêu cầu 5: Tìm giáo viên có mã giảng viên là CHN060286
                Teacher gvTimKiem = teachers.FirstOrDefault(gv => gv.MaGV == "CHN060286");
                if (gvTimKiem != null)
                {
                    Console.WriteLine("\nThông tin giáo viên có mã giảng viên CHN060286:");
                    XuatGiaoVien(gvTimKiem);
                }
                else
                {
                    Console.WriteLine("Không có giáo viên có mã giảng viên CHN060286.");
                }

                // Yêu cầu 6: Tìm danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa "CNTT"
                double diemTBMax = svCNTT.Max(sv => sv.DiemTB);
                List<Student> svDiemCaoNhat = svCNTT.Where(sv => sv.DiemTB == diemTBMax).ToList();
                if (svDiemCaoNhat.Count > 0)
                {
                    Console.WriteLine("\nDanh sách sinh viên có điểm trung bình cao nhất và thuộc khoa CNTT:");
                    XuatDSSinhVien(svDiemCaoNhat);
                }
                else
                {
                    Console.WriteLine("Không có sinh viên có điểm trung bình cao nhất và thuộc khoa CNTT.");
                }

                Console.ReadKey();
            }

            // Hàm nhập danh sách giáo viên
            private static List<Teacher> NhapDSGiaoVien()
            {
                List<Teacher> teachers = new List<Teacher>();
                Console.Write("Nhập tổng số giáo viên n=");
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine("\n=== Nhập danh sách giáo viên ===");
                for (int i = 0; i < N; i++)
                {
                    Console.Write("Nhập giáo viên thứ {0}:\n", i + 1);
                    Teacher gv = new Teacher();
                    gv.NhapGiaoVien();
                    teachers.Add(gv);
                }
                return teachers;
            }

            // Hàm xuất danh sách giáo viên
            private static void XuatDSGiaoVien(List<Teacher> teachers)
            {
                foreach (Teacher gv in teachers)
                {
                    XuatGiaoVien(gv);
                }
            }

            // Hàm xuất thông tin giáo viên
            private static void XuatGiaoVien(Teacher gv)
            {
                Console.WriteLine($"CNMD: {gv.CNMD}");
                Console.WriteLine($"Họ tên: {gv.HoTen}");
                Console.WriteLine($"Địa chỉ: {gv.DiaChi}");
                Console.WriteLine($"Mã GV: {gv.MaGV}");
                Console.WriteLine($"Khoa: {gv.Khoa}");
                Console.WriteLine($"Chức vụ: {gv.ChucVu}");
                Console.WriteLine();
            }

            // Hàm nhập danh sách sinh viên
            private static List<Student> NhapDSSinhVien()
            {
                List<Student> students = new List<Student>();
                Console.Write("Nhập tổng số sinh viên n=");
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine("\n=== Nhập danh sách sinh viên ===");
                for (int i = 0; i < N; i++)
                {
                    Console.Write("Nhập sinh viên thứ {0}:\n", i + 1);
                    Student sv = new Student();
                    sv.NhapSinhVien();
                    students.Add(sv);
                }
                return students;
            }

            // Hàm xuất danh sách sinh viên
            private static void XuatDSSinhVien(List<Student> students)
            {
                foreach (Student sv in students)
                {
                    XuatSinhVien(sv);
                }
            }

            // Hàm xuất thông tin sinh viên
            private static void XuatSinhVien(Student sv)
            {
                Console.WriteLine($"CNMD: {sv.CNMD}");
                Console.WriteLine($"Họ tên: {sv.HoTen}");
                Console.WriteLine($"Địa chỉ: {sv.DiaChi}");
                Console.WriteLine($"Mã SV: {sv.MaSV}");
                Console.WriteLine($"Điểm TB: {sv.DiemTB}");
                Console.WriteLine($"Khoa: {sv.Khoa}");
                Console.WriteLine();
            }
        }

    }

