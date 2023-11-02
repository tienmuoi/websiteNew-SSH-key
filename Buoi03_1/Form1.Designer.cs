namespace Bai03_1
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
            this.lblChuongTrinh = new System.Windows.Forms.Label();
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChuongTrinh
            // 
            this.lblChuongTrinh.AutoSize = true;
            this.lblChuongTrinh.Location = new System.Drawing.Point(449, 47);
            this.lblChuongTrinh.Name = "lblChuongTrinh";
            this.lblChuongTrinh.Size = new System.Drawing.Size(104, 20);
            this.lblChuongTrinh.TabIndex = 0;
            this.lblChuongTrinh.Text = "Chương Trình";
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(94, 156);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(44, 20);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số A";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(94, 245);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(44, 20);
            this.lblSoB.TabIndex = 0;
            this.lblSoB.Text = "Số B";
            this.lblSoB.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(189, 156);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(759, 26);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSoA_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(189, 429);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(759, 26);
            this.txtKetQua.TabIndex = 1;
            this.txtKetQua.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(189, 337);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(90, 49);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(94, 429);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(67, 20);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = "Kết Quả";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(189, 245);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(759, 26);
            this.txtSoB.TabIndex = 1;
            this.txtSoB.TextChanged += new System.EventHandler(this.txtSoB_TextChanged);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(340, 337);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(90, 49);
            this.btnTru.TabIndex = 2;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(508, 337);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(90, 49);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(669, 337);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(90, 49);
            this.btnChia.TabIndex = 2;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(858, 337);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 49);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1076, 711);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Controls.Add(this.lblChuongTrinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChuongTrinh;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnThoat;
    }
}

