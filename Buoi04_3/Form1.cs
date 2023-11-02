using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_3
{
    public partial class Form1 : Form
    {
        int rowchoose = -1;

        String[] loaisp = { "Áo nam", "Áo nữ", "Quần nam", "Quần nữ" };
        String[] donvitinh = { "Cái", "Cặp", "Sỉ", "Lẻ" };

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowchoose = e.RowIndex;
            if (rowchoose != -1 && rowchoose < dgvDanhSach.Rows.Count - 1)
            {
                txtMaSP.Text = dgvDanhSach.Rows[rowchoose].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowchoose].Cells["TenSP"].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[rowchoose].Cells["SoLuong"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[rowchoose].Cells["Gia"].Value.ToString();
                cbLoaiSP.Text = dgvDanhSach.Rows[rowchoose].Cells["LoaiSanPham"].Value.ToString();
                cbDonViTinh.Text = dgvDanhSach.Rows[rowchoose].Cells["DonVi"].Value.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = loaisp;
            cbDonViTinh.DataSource = donvitinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtMaSP.Text.Length < 0)
                {
                    throw new Exception("Chưa điền mã sản phẩm");
                }
                if (txtTenSP.Text.Length < 0)
                {
                    throw new Exception("Chưa điền tên sản phẩm");
                }
                if (txtSoLuong.Text.Length < 0)
                {
                    throw new Exception("Chưa điền số lượng");
                }
                if (txtGia.Text.Length < 0)
                {
                    throw new Exception("Chưa điền giá");
                }

                string MaSP = txtMaSP.Text;
                string TenSP = txtTenSP.Text;
                int SoLuong = Convert.ToInt32(txtSoLuong.Text);
                int Gia = Convert.ToInt32(txtGia.Text);
                int ThanhTien = SoLuong * Gia;
                string LoaiSanPham = cbLoaiSP.Text;
                string DonVi = cbDonViTinh.Text;
                int rowindex = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value = MaSP;
                dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value = TenSP;
                dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value = SoLuong;
                dgvDanhSach.Rows[rowindex].Cells["Gia"].Value = Gia;
                dgvDanhSach.Rows[rowindex].Cells["ThanhTien"].Value = ThanhTien;
                dgvDanhSach.Rows[rowindex].Cells["LoaiSanPham"].Value = LoaiSanPham;
                dgvDanhSach.Rows[rowindex].Cells["DonVi"].Value = DonVi;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm cần sửa");
                }

                if (txtMaSP.Text.Length < 0)
                {
                    throw new Exception("Chưa điền mã sản phẩm");
                }
                if (txtTenSP.Text.Length < 0)
                {
                    throw new Exception("Chưa điền tên sản phẩm");
                }
                if (txtSoLuong.Text.Length < 0)
                {
                    throw new Exception("Chưa điền số lượng");
                }
                if (txtGia.Text.Length < 0)
                {
                    throw new Exception("Chưa điền giá");
                }

                string MaSP = txtMaSP.Text;
                string TenSP = txtTenSP.Text;
                string SoLuong = txtSoLuong.Text;
                string Gia = txtGia.Text;
                string LoaiSanPham = cbLoaiSP.Text;
                string DonVi = cbDonViTinh.Text;

                dgvDanhSach.Rows[rowchoose].Cells["MaSP"].Value = MaSP;
                dgvDanhSach.Rows[rowchoose].Cells["TenSP"].Value = TenSP;
                dgvDanhSach.Rows[rowchoose].Cells["SoLuong"].Value = SoLuong;
                dgvDanhSach.Rows[rowchoose].Cells["Gia"].Value = Gia;
                dgvDanhSach.Rows[rowchoose].Cells["LoaiSanPham"].Value = LoaiSanPham;
                dgvDanhSach.Rows[rowchoose].Cells["DonVi"].Value = DonVi;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm cần xóa");
                }
                dgvDanhSach.Rows.RemoveAt(rowchoose);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Bạn thiệt sự muốn rời ra tui :<",
              "Thông báo",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
              );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
