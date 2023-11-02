﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_2
{
    public partial class Form1 : Form
    {
        int rowindex;
        string[] listKhoa = { "Công Nghệ Thông Tin", "Kế Toán", "Điện tử", "NGOẠI NGỮ" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            
            cbKhoa.DataSource = listKhoa;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;

            try
            {
                if (!txtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên 10 ký tự ");

                }
                if (this.checkMaSV(txtMaSV.Text) == false)
                {
                    throw new Exception("Mã sinh viên đã tồn tại ");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ Tên Hong Được Để Trống ");

                }
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Diem TB không phải số ");

                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;
                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[row].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[row].Cells["DiemTB"].Value = diemtb;
                dgvDanhSach.Rows[row].Cells["Khoa"].Value = khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
        public bool checkMaSV(string masv)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;

            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSV"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;

            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                txtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                string tenkhoa = dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value.ToString();
                int i = 0;
                while (i < listKhoa.Length && listKhoa[i] != tenkhoa)


                {
                    i++;
                }
                cbKhoa.SelectedIndex = i;
            }
     



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            double diemtb;

            try
            {
                if (rowindex != -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa Chọn Sinh Viên Cần Xóa!");

                }
                if (!txtMaSV.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên 10 ký tự ");

                }
                if (this.checkMaSV(txtMaSV.Text) == false && txtMaSV.Text!= dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString())
                {
                    throw new Exception("Mã sinh viên đã tồn tại ");
                }
                if (!txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ Tên Hong Được Để Trống ");

                }
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Diem TB không phải số ");

                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;
                
                dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value = diemtb;
                dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value = khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa Chọn Sinh Viên Cần Xóa!");

                }
                dgvDanhSach.Rows.RemoveAt(rowindex);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Bạn có muốn thoát không ",
              "Thông Báo ",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
