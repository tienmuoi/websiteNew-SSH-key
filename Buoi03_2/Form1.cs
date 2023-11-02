using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int stt;
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtHoTen.Text.Length == 0)
                {
                    throw new Exception("Họ tên sinh viên không thể rỗng");
                }

                // Lấy thông tin
                string hoten = txtHoTen.Text;
                string mssv = mtxtMaSinhVien.Text;
                string ngaysinh = mtxtNgaySinh.Text;
                string gioitinh = (rdochecknam.Checked) ? "Nam" : "Nữ";
                string sothich = "";

                if (checkDuLich.Checked)
                {
                    sothich += "Du Lịch ";
                }
                if (checkTheThao.Checked)
                {
                    sothich += "Thể Thao ";
                }
                if (checkMuaSam.Checked)
                {
                    sothich += "Mua Sắm ";
                }

                // Xuất thông tin ra TextBox txtDanhSach
                txtDanhSach.Text += stt + ". Họ Tên: " + hoten + " Ngày Sinh: " + ngaysinh + " Giới Tính: " + gioitinh + " Sở Thích: " + sothich + "\r\n";
                stt++;
            }
            catch (Exception ex)
            {
                txtDanhSach.Text = ex.Message;
            }
        
    }

        private void cbMuaSam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            txtDanhSach.Text = "";
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
