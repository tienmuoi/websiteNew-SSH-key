namespace Buoi03_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbtTieuDE = new System.Windows.Forms.Label();
            this.lblMaSv = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNsinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.txtDanhSach = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkTheThao = new System.Windows.Forms.CheckBox();
            this.checkDuLich = new System.Windows.Forms.CheckBox();
            this.checkMuaSam = new System.Windows.Forms.CheckBox();
            this.rdochecknam = new System.Windows.Forms.RadioButton();
            this.rdBtnNu = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.mtxtMaSinhVien = new System.Windows.Forms.MaskedTextBox();
            this.txtHoTen = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtTieuDE
            // 
            this.lbtTieuDE.AutoSize = true;
            this.lbtTieuDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtTieuDE.ForeColor = System.Drawing.Color.Red;
            this.lbtTieuDE.Location = new System.Drawing.Point(289, 55);
            this.lbtTieuDE.Name = "lbtTieuDE";
            this.lbtTieuDE.Size = new System.Drawing.Size(421, 40);
            this.lbtTieuDE.TabIndex = 0;
            this.lbtTieuDE.Text = "THÔNG TIN SINH VIÊN";
            // 
            // lblMaSv
            // 
            this.lblMaSv.AutoSize = true;
            this.lblMaSv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSv.Location = new System.Drawing.Point(6, 52);
            this.lblMaSv.Name = "lblMaSv";
            this.lblMaSv.Size = new System.Drawing.Size(115, 20);
            this.lblMaSv.TabIndex = 0;
            this.lblMaSv.Text = "Mã Sinh Viên";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(6, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ Tên";
            // 
            // lblNsinh
            // 
            this.lblNsinh.AutoSize = true;
            this.lblNsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNsinh.Location = new System.Drawing.Point(6, 185);
            this.lblNsinh.Name = "lblNsinh";
            this.lblNsinh.Size = new System.Drawing.Size(90, 20);
            this.lblNsinh.TabIndex = 0;
            this.lblNsinh.Text = "Ngày Sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.Location = new System.Drawing.Point(38, 257);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(80, 20);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblSoThich
            // 
            this.lblSoThich.AutoSize = true;
            this.lblSoThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoThich.Location = new System.Drawing.Point(38, 322);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(79, 20);
            this.lblSoThich.TabIndex = 0;
            this.lblSoThich.Text = "Sở Thích";
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.Location = new System.Drawing.Point(33, 44);
            this.txtDanhSach.Multiline = true;
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Size = new System.Drawing.Size(469, 291);
            this.txtDanhSach.TabIndex = 1;
            this.txtDanhSach.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.mtxtMaSinhVien);
            this.groupBox1.Controls.Add(this.rdBtnNu);
            this.groupBox1.Controls.Add(this.rdochecknam);
            this.groupBox1.Controls.Add(this.checkMuaSam);
            this.groupBox1.Controls.Add(this.checkDuLich);
            this.groupBox1.Controls.Add(this.checkTheThao);
            this.groupBox1.Controls.Add(this.lblMaSv);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblSoThich);
            this.groupBox1.Controls.Add(this.lblNsinh);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 523);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOut);
            this.groupBox2.Controls.Add(this.btnDelete2);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(515, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDanhSach);
            this.groupBox3.Location = new System.Drawing.Point(515, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 382);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // checkTheThao
            // 
            this.checkTheThao.AutoSize = true;
            this.checkTheThao.Location = new System.Drawing.Point(132, 318);
            this.checkTheThao.Name = "checkTheThao";
            this.checkTheThao.Size = new System.Drawing.Size(102, 24);
            this.checkTheThao.TabIndex = 2;
            this.checkTheThao.Text = "Thể Thao";
            this.checkTheThao.UseVisualStyleBackColor = true;
            // 
            // checkDuLich
            // 
            this.checkDuLich.AutoSize = true;
            this.checkDuLich.Location = new System.Drawing.Point(131, 369);
            this.checkDuLich.Name = "checkDuLich";
            this.checkDuLich.Size = new System.Drawing.Size(89, 24);
            this.checkDuLich.TabIndex = 2;
            this.checkDuLich.Text = "Du Lịch";
            this.checkDuLich.UseVisualStyleBackColor = true;
            // 
            // checkMuaSam
            // 
            this.checkMuaSam.AutoSize = true;
            this.checkMuaSam.Location = new System.Drawing.Point(131, 421);
            this.checkMuaSam.Name = "checkMuaSam";
            this.checkMuaSam.Size = new System.Drawing.Size(103, 24);
            this.checkMuaSam.TabIndex = 2;
            this.checkMuaSam.Text = "Mua Sắm";
            this.checkMuaSam.UseVisualStyleBackColor = true;
            this.checkMuaSam.CheckedChanged += new System.EventHandler(this.cbMuaSam_CheckedChanged);
            // 
            // rdochecknam
            // 
            this.rdochecknam.AutoSize = true;
            this.rdochecknam.Checked = true;
            this.rdochecknam.Location = new System.Drawing.Point(131, 257);
            this.rdochecknam.Name = "rdochecknam";
            this.rdochecknam.Size = new System.Drawing.Size(67, 24);
            this.rdochecknam.TabIndex = 3;
            this.rdochecknam.TabStop = true;
            this.rdochecknam.Text = "Nam";
            this.rdochecknam.UseVisualStyleBackColor = true;
            this.rdochecknam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdBtnNu
            // 
            this.rdBtnNu.AutoSize = true;
            this.rdBtnNu.Location = new System.Drawing.Point(247, 257);
            this.rdBtnNu.Name = "rdBtnNu";
            this.rdBtnNu.Size = new System.Drawing.Size(54, 24);
            this.rdBtnNu.TabIndex = 3;
            this.rdBtnNu.Text = "Nữ";
            this.rdBtnNu.UseVisualStyleBackColor = true;
            this.rdBtnNu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(46, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm Vào DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete2.Location = new System.Drawing.Point(238, 52);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(84, 37);
            this.btnDelete2.TabIndex = 0;
            this.btnDelete2.Text = "Xóa DS";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOut.Location = new System.Drawing.Point(400, 52);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(82, 36);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // mtxtMaSinhVien
            // 
            this.mtxtMaSinhVien.Location = new System.Drawing.Point(127, 46);
            this.mtxtMaSinhVien.Mask = "2100000000";
            this.mtxtMaSinhVien.Name = "mtxtMaSinhVien";
            this.mtxtMaSinhVien.Size = new System.Drawing.Size(236, 26);
            this.mtxtMaSinhVien.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(127, 107);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(236, 26);
            this.txtHoTen.TabIndex = 4;
            // 
            // mtxtNgaySinh
            // 
            this.mtxtNgaySinh.Location = new System.Drawing.Point(127, 185);
            this.mtxtNgaySinh.Mask = "00/00/0000";
            this.mtxtNgaySinh.Name = "mtxtNgaySinh";
            this.mtxtNgaySinh.Size = new System.Drawing.Size(236, 26);
            this.mtxtNgaySinh.TabIndex = 4;
            this.mtxtNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 705);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbtTieuDE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtTieuDE;
        private System.Windows.Forms.Label lblMaSv;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNsinh;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdochecknam;
        private System.Windows.Forms.CheckBox checkMuaSam;
        private System.Windows.Forms.CheckBox checkDuLich;
        private System.Windows.Forms.CheckBox checkTheThao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdBtnNu;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.MaskedTextBox mtxtNgaySinh;
        private System.Windows.Forms.MaskedTextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtMaSinhVien;
    }
}

