using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_2
{
    internal class Program
    {
        static void Main(string[] args) // Hàm Main là hàm chính của chương trình, nó được thực thi khi chương trình bắt đầu.
        {
            Console.Write("Nhap thang: "); // Hiển thị thông báo để nhập tháng.
            int thang = Convert.ToInt32(Console.ReadLine()); // Đọc và chuyển đổi dữ liệu nhập từ bàn phím thành số nguyên và lưu vào biến thang.

            Console.Write("Nhap nam: "); // Hiển thị thông báo để nhập năm.
            int nam = Convert.ToInt32(Console.ReadLine()); // Đọc và chuyển đổi dữ liệu nhập từ bàn phím thành số nguyên và lưu vào biến nam.

            int soNgay = DemSoNgayTrongThang(thang, nam); // Gọi hàm DemSoNgayTrongThang để tính số ngày trong tháng và lưu kết quả vào biến soNgay.

            if (thang < 1 || thang > 12)
            {
                Console.WriteLine("Thang khong ton tai. Thang phai nam trong khoang tu 1 den 12.");
            }
            else
            {
               
                Console.WriteLine("So ngay trong thang {0}/{1} la: {2}", thang, nam, soNgay);
            } // Xuất kết quả số ngày trong tháng ra màn hình.

            Console.ReadKey(); // Dừng chương trình để chờ người dùng nhấn một phím bất kỳ trước khi thoát.
        }

        static bool CheckNamNhuan(int nam) // Định nghĩa hàm kiểm tra năm nhuận, nhận một số nguyên (năm) và trả về giá trị kiểu bool (true nếu là năm nhuận, false nếu không phải).
        {
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0); // Kiểm tra điều kiện để xác định năm nhuận.
        }

        static int DemSoNgayTrongThang(int thang, int nam) // Định nghĩa hàm tính số ngày trong tháng, nhận tháng và năm làm đối số và trả về số ngày trong tháng đó.
        {
            switch (thang) // Bắt đầu một câu lệnh switch dựa vào giá trị của biến thang.
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31; // Nếu tháng là 1,3,5,7,8,10 hoặc 12, trả về 31 ngày.
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30; // Nếu tháng là 4,6,9 hoặc 11, trả về 30 ngày.
                case 2:
                    if (CheckNamNhuan(nam)) // Nếu tháng là 2 và năm nhuận, sử dụng hàm CheckNamNhuan để kiểm tra.
                        return 29; // Nếu là năm nhuận, trả về 29 ngày.
                    else
                        return 28; // Nếu không phải năm nhuận, trả về 28 ngày.
                default:
                    return -1; // Nếu tháng không nằm trong khoảng từ 1 đến 12, trả về -1 để biểu thị là giá trị không hợp lệ.
            }
        }
    }
}
