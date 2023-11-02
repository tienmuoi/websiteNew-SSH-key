using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbSinhVien.Items.Add("Nguyễn Văn An ");
            lbSinhVien.Items.Add("Lê Văn Be ");
            lbSinhVien.Items.Add("Trần Văn Chính ");
            lbSinhVien.Items.Add("Mai Hữu Danh ");
            lbSinhVien.Items.Add("Hồ Văn En");
            cbKhoa.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLop.Items)
            {
               
                
                    lvLop.Items.Remove(item);
                    lbSinhVien.Items.Add(item.Text);
                }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLop.Items)
            {


                lvLop.Items.Remove(item);
                lbSinhVien.Items.Add(item.Text);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text.Length == 0)
                {
                    throw new Exception("Họ tên Chưa Nhập ");
                }

                // Lấy thông tin
                string hoten = txtHoTen.Text;
                lbSinhVien.Items.Add(hoten);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int Chon;
        private void button3_Click(object sender, EventArgs e)
        {
            if (Chon != -1)
            {
                string hoten = lbSinhVien.SelectedItem.ToString();
                string khoa = lbSinhVien.SelectedItem.ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvLop.Items.Add(item);
                lbSinhVien.Items.RemoveAt(lbSinhVien.SelectedIndex);
                Chon = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = lbSinhVien.Items.Count;
            for (int vt = 0; vt < count; vt++)
            {
                string khoa = cbKhoa.SelectedItem.ToString();
                string hoten = lbSinhVien.Items[vt].ToString();
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                lvLop.Items.Add(item);
            }
            lbSinhVien.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLop.Items)
            {
                if (item.Selected)
                {
                    lvLop.Items.Remove(item);
                    lbSinhVien.Items.Add(item.Text);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbSinhVien_MouseClick(object sender, MouseEventArgs e)
        {
            Chon = 1;
        }

        private void lvLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
