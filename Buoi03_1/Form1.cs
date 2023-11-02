using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không được để trống hoặc phải số ");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không được để trống hoặc phải là số");
                }
                txtKetQua.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không được để trống hoặc phải số ");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không được để trống hoặc phải là số");
                }
                txtKetQua.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không được để trống hoặc phải số ");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không được để trống hoặc phải là số");
                }
                txtKetQua.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không được để trống hoặc phải số ");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không được để trống hoặc phải là số");
                }
                txtKetQua.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }
    }
}
