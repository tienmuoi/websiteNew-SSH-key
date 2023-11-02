namespace Buoi04_4
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
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.btnLuuFile = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHinh
            // 
            this.pbHinh.Location = new System.Drawing.Point(42, 39);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(361, 424);
            this.pbHinh.TabIndex = 0;
            this.pbHinh.TabStop = false;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(478, 39);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(657, 424);
            this.txtNoiDung.TabIndex = 1;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(42, 533);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(361, 60);
            this.btnChonHinh.TabIndex = 3;
            this.btnChonHinh.Text = "Chọn Hình Ảnh";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(478, 533);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(122, 60);
            this.btnChonFile.TabIndex = 3;
            this.btnChonFile.Text = "Chọn Tập Tin";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.Location = new System.Drawing.Point(750, 533);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(122, 60);
            this.btnLuuFile.TabIndex = 3;
            this.btnLuuFile.Text = "Lưu Tập Tin";
            this.btnLuuFile.UseVisualStyleBackColor = true;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1020, 533);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 60);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 681);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuFile);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.pbHinh);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.Button btnThoat;
    }
}

