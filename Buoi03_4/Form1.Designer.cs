namespace Buoi03_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDSMon = new System.Windows.Forms.ListView();
            this.lvSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvDSDatMon = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(593, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẶT MÓN ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDSMon);
            this.groupBox1.Location = new System.Drawing.Point(43, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 587);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Món";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lvDSMon
            // 
            this.lvDSMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvSTT,
            this.lvTenMon,
            this.lvGia});
            this.lvDSMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvDSMon.GridLines = true;
            this.lvDSMon.HideSelection = false;
            this.lvDSMon.Location = new System.Drawing.Point(29, 39);
            this.lvDSMon.Name = "lvDSMon";
            this.lvDSMon.Size = new System.Drawing.Size(507, 520);
            this.lvDSMon.TabIndex = 0;
            this.lvDSMon.UseCompatibleStateImageBehavior = false;
            this.lvDSMon.View = System.Windows.Forms.View.Details;
            this.lvDSMon.SelectedIndexChanged += new System.EventHandler(this.lvDSMon_SelectedIndexChanged);
            this.lvDSMon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvDSMon_MouseClick);
            // 
            // lvSTT
            // 
            this.lvSTT.Text = "STT";
            // 
            // lvTenMon
            // 
            this.lvTenMon.Text = "Giá";
            this.lvTenMon.Width = 107;
            // 
            // lvGia
            // 
            this.lvGia.Text = "Tên Món";
            this.lvGia.Width = 181;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.cbBan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(620, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 587);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Món";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(35, 199);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(148, 26);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Items.AddRange(new object[] {
            "Chọn Bàn",
            "Bàn 1",
            "Bàn 2",
            "Bàn 3",
            "Bàn 4",
            "Bàn 5",
            "Bàn 6",
            "Bàn 7",
            "Bàn 8",
            "Bàn 9",
            "Bàn 10"});
            this.cbBan.Location = new System.Drawing.Point(35, 76);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(148, 28);
            this.cbBan.TabIndex = 1;
            this.cbBan.Visible = false;
            this.cbBan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bàn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvDSDatMon);
            this.groupBox3.Location = new System.Drawing.Point(890, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 587);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Đặt Món ";
            // 
            // lvDSDatMon
            // 
            this.lvDSDatMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvDSDatMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvDSDatMon.GridLines = true;
            this.lvDSDatMon.HideSelection = false;
            this.lvDSDatMon.Location = new System.Drawing.Point(23, 25);
            this.lvDSDatMon.Name = "lvDSDatMon";
            this.lvDSDatMon.Size = new System.Drawing.Size(619, 520);
            this.lvDSDatMon.TabIndex = 0;
            this.lvDSDatMon.UseCompatibleStateImageBehavior = false;
            this.lvDSDatMon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bàn";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên Món";
            this.columnHeader5.Width = 309;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số Lượng";
            this.columnHeader6.Width = 139;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá";
            this.columnHeader7.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 718);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvDSMon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvDSDatMon;
        private System.Windows.Forms.ColumnHeader lvSTT;
        private System.Windows.Forms.ColumnHeader lvTenMon;
        private System.Windows.Forms.ColumnHeader lvGia;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

