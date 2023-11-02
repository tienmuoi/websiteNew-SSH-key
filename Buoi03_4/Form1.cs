using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem("1");

            // Thêm thông tin "Lớp" và "Khoa" bằng cách sử dụng SubItems
            item1.SubItems.Add("79000");
            item1.SubItems.Add("Lòng Xào Dưa");

            // Thêm ListViewItem vào ListView lvDSMon
            lvDSMon.Items.Add(item1);
            ListViewItem item2 = new ListViewItem("2");

            // Thêm thông tin "Lớp" và "Khoa" bằng cách sử dụng SubItems
            item2.SubItems.Add("99000");
            item2.SubItems.Add("Bò Tái Chanh");

            // Thêm ListViewItem vào ListView lvDSMon
            lvDSMon.Items.Add(item2);
            ListViewItem item3 = new ListViewItem("3");

            // Thêm thông tin "Lớp" và "Khoa" bằng cách sử dụng SubItems
            item3.SubItems.Add("29000");
            item3.SubItems.Add("Mì Xào");

            // Thêm ListViewItem vào ListView lvDSMon
            lvDSMon.Items.Add(item3);

            cbBan.SelectedIndex = 0;
        }

        private void lvDSMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int Chon;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Chon != -1 && lvDSMon.SelectedItems.Count > 0)
            {
                // Lấy ListViewItem được chọn trong lvDSMon
                ListViewItem selectedLVItem = lvDSMon.SelectedItems[0];

                // Lấy thông tin từ các subitems của ListViewItem được chọn
                string hoten = selectedLVItem.Text; // Tên món ăn
                string lop = selectedLVItem.SubItems[1].Text; // Lớp
                string khoa = selectedLVItem.SubItems[2].Text; // Khoa

                // Tạo một ListViewItem mới và thêm thông tin vào nó
                ListViewItem item = new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = lop });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });

                // Thêm ListViewItem mới vào lvDSDatMon
                lvDSDatMon.Items.Add(item);

                Chon = -1;
            }
        }



        private void lvDSMon_MouseClick(object sender, MouseEventArgs e)
        {
            Chon = 1;
        }
    }
}
