namespace QuanLiSinhVien
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
            this.txtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMavung = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAVUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgaysinh);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtMavung);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.Xoa);
            this.groupBox1.Controls.Add(this.Sua);
            this.groupBox1.Controls.Add(this.Them);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Sinh viên";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaysinh.Location = new System.Drawing.Point(140, 158);
            this.txtNgaysinh.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.txtNgaysinh.MinDate = new System.DateTime(1983, 1, 1, 0, 0, 0, 0);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(339, 22);
            this.txtNgaysinh.TabIndex = 19;
            this.txtNgaysinh.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(907, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(118, 21);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Chưa xác định";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(834, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 21);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(761, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 21);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(761, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 22);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(816, 63);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(209, 22);
            this.txtSDT.TabIndex = 14;
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // txtMavung
            // 
            this.txtMavung.Location = new System.Drawing.Point(761, 63);
            this.txtMavung.Name = "txtMavung";
            this.txtMavung.Size = new System.Drawing.Size(39, 22);
            this.txtMavung.TabIndex = 13;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(140, 115);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(339, 22);
            this.txtLop.TabIndex = 12;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(140, 78);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(339, 22);
            this.txtMSSV.TabIndex = 11;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(140, 37);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(339, 22);
            this.txtHoten.TabIndex = 10;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(931, 152);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 9;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(806, 151);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 8;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Update_Click);
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(671, 151);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 23);
            this.Them.TabIndex = 7;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSinhVien);
            this.groupBox2.Location = new System.Drawing.Point(12, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1033, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Sinh viên";
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HOTEN,
            this.MSSV,
            this.LOP,
            this.NGAYSINH,
            this.GIOITINH,
            this.DIENTHOAI,
            this.MAVUNG,
            this.EMAIL});
            this.dataGridViewSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.RowTemplate.Height = 24;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(1027, 149);
            this.dataGridViewSinhVien.TabIndex = 0;
            this.dataGridViewSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinhVien_CellContentClick);
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 215;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // LOP
            // 
            this.LOP.DataPropertyName = "LOP";
            this.LOP.HeaderText = "Lớp";
            this.LOP.Name = "LOP";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 150;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện Thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Width = 120;
            // 
            // MAVUNG
            // 
            this.MAVUNG.DataPropertyName = "MAVUNG";
            this.MAVUNG.HeaderText = "Mã Vùng";
            this.MAVUNG.Name = "MAVUNG";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtNgaysinh;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMavung;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
    }
}

