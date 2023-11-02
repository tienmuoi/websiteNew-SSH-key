using Buoi05_1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_1
{
    public partial class Form1 : Form
    {
        SinhVienDAO svDAO = new SinhVienDAO();
        KhoaDAO khDAO = new KhoaDAO();
        String insertupdate = "";

        public object MesageBox { get; private set; }
        public object YesNo { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            mtxtMaSV.Enabled = false;
            btnXoa.Enabled = false;
            loadDSSinhVien();
            loadDSKhoa();
            TongSinhVien();

        }
        private void loadDSSinhVien()
        {
            dgvDanhSach.DataSource = svDAO.getlist();
        }
        private void loadDSKhoa()
        {
            cbKhoa.DataSource = khDAO.getList();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";

        }
        private void TongSinhVien()
        {
            txtTongSV.Text = svDAO.getCount().ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            mtxtMaSV.Enabled = false;
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên ");

                }
                mtxtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            mtxtMaSV.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;

                if (mtxtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên phải có 10 ký tự số");
                }

                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Điểm sinh viên phải là số");
                }

                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
                SinhVien sv = new SinhVien(masv, hoten, makhoa, diemtb); // Lỗi dấu chấm phẩy ở đây

                switch (insertupdate)
                {
                    case "insert":
                        svDAO.InsertTwo(sv);
                        loadDSSinhVien();
                        TongSinhVien();
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        break;

                    case "update":
                        svDAO.UpdateTwo(sv);
                        loadDSSinhVien();
                        TongSinhVien();
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {


            try
            {

                if (mtxtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không đúng");

                }

                string masv = mtxtMaSV.Text;

                loadDSSinhVien();

                TongSinhVien();

                svDAO.DeleteTwo(masv); MessageBox.Show("Xóa thành công", "Thông báo");

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("Bạn Muốn thoát không ?","Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn thoát không ?", "Thông Báo",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int makhoa =int.Parse(cbKhoa.SelectedValue.ToString());
            dgvDanhSach.DataSource=svDAO.getlist(makhoa);
        }
    }
}
        


