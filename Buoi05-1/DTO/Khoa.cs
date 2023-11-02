using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_1
{
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string GhiChu { get; set; }

        public Khoa(string maKhoa, string tenKhoa, string ghiChu)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
            this.GhiChu = ghiChu;
        }
    }

}
