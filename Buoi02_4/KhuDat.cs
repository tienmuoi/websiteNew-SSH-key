using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_4
{
    public class KhuDat
    {
        public string DiaDiem { get; set; }
        public decimal GiaBan { get; set; } // Sử dụng decimal cho tiền tệ
        public double DienTich { get; set; } // Diện tích trong m2

        public KhuDat(string diaDiem, decimal giaBan, double dienTich)
        {
            DiaDiem = diaDiem;
            GiaBan = giaBan;
            DienTich = dienTich;
        }
    }

}
