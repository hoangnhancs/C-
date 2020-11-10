namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupNhaplieu = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_them = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_noisinh = new System.Windows.Forms.Label();
            this.label_ngaysinh = new System.Windows.Forms.Label();
            this.radioButton_nu = new System.Windows.Forms.RadioButton();
            this.radioButton_nam = new System.Windows.Forms.RadioButton();
            this.label_gioitinh = new System.Windows.Forms.Label();
            this.textBox_hovaten = new System.Windows.Forms.TextBox();
            this.label_hovaten = new System.Windows.Forms.Label();
            this.label_mahocsinh = new System.Windows.Forms.Label();
            this.textBox_masohocsinh = new System.Windows.Forms.TextBox();
            this.label_danhsachhocsinh = new System.Windows.Forms.Label();
            this.button_luufile = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupNhaplieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupNhaplieu
            // 
            this.groupNhaplieu.Controls.Add(this.dateTimePicker1);
            this.groupNhaplieu.Controls.Add(this.button_them);
            this.groupNhaplieu.Controls.Add(this.comboBox1);
            this.groupNhaplieu.Controls.Add(this.label_noisinh);
            this.groupNhaplieu.Controls.Add(this.label_ngaysinh);
            this.groupNhaplieu.Controls.Add(this.radioButton_nu);
            this.groupNhaplieu.Controls.Add(this.radioButton_nam);
            this.groupNhaplieu.Controls.Add(this.label_gioitinh);
            this.groupNhaplieu.Controls.Add(this.textBox_hovaten);
            this.groupNhaplieu.Controls.Add(this.label_hovaten);
            this.groupNhaplieu.Controls.Add(this.label_mahocsinh);
            this.groupNhaplieu.Controls.Add(this.textBox_masohocsinh);
            this.groupNhaplieu.ForeColor = System.Drawing.Color.Red;
            this.groupNhaplieu.Location = new System.Drawing.Point(29, 24);
            this.groupNhaplieu.Name = "groupNhaplieu";
            this.groupNhaplieu.Size = new System.Drawing.Size(235, 505);
            this.groupNhaplieu.TabIndex = 0;
            this.groupNhaplieu.TabStop = false;
            this.groupNhaplieu.Text = "Nhập liệu";
            this.groupNhaplieu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.ForeColor = System.Drawing.Color.Black;
            this.button_them.Image = ((System.Drawing.Image)(resources.GetObject("button_them.Image")));
            this.button_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_them.Location = new System.Drawing.Point(31, 392);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(146, 58);
            this.button_them.TabIndex = 10;
            this.button_them.Text = "Thêm";
            this.button_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên",
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
            this.comboBox1.Location = new System.Drawing.Point(6, 334);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "TP. Hồ Chí Minh";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_noisinh
            // 
            this.label_noisinh.AutoSize = true;
            this.label_noisinh.ForeColor = System.Drawing.Color.Black;
            this.label_noisinh.Location = new System.Drawing.Point(6, 305);
            this.label_noisinh.Name = "label_noisinh";
            this.label_noisinh.Size = new System.Drawing.Size(63, 17);
            this.label_noisinh.TabIndex = 8;
            this.label_noisinh.Text = "Nơi sinh:";
            // 
            // label_ngaysinh
            // 
            this.label_ngaysinh.AutoSize = true;
            this.label_ngaysinh.ForeColor = System.Drawing.Color.Black;
            this.label_ngaysinh.Location = new System.Drawing.Point(6, 237);
            this.label_ngaysinh.Name = "label_ngaysinh";
            this.label_ngaysinh.Size = new System.Drawing.Size(75, 17);
            this.label_ngaysinh.TabIndex = 7;
            this.label_ngaysinh.Text = "Ngày sinh:";
            this.label_ngaysinh.Click += new System.EventHandler(this.label_ngaysinh_Click);
            // 
            // radioButton_nu
            // 
            this.radioButton_nu.AutoSize = true;
            this.radioButton_nu.ForeColor = System.Drawing.Color.Black;
            this.radioButton_nu.Location = new System.Drawing.Point(83, 203);
            this.radioButton_nu.Name = "radioButton_nu";
            this.radioButton_nu.Size = new System.Drawing.Size(47, 21);
            this.radioButton_nu.TabIndex = 6;
            this.radioButton_nu.Text = "Nữ";
            this.radioButton_nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_nam
            // 
            this.radioButton_nam.AutoSize = true;
            this.radioButton_nam.Checked = true;
            this.radioButton_nam.ForeColor = System.Drawing.Color.Black;
            this.radioButton_nam.Location = new System.Drawing.Point(6, 203);
            this.radioButton_nam.Name = "radioButton_nam";
            this.radioButton_nam.Size = new System.Drawing.Size(58, 21);
            this.radioButton_nam.TabIndex = 5;
            this.radioButton_nam.TabStop = true;
            this.radioButton_nam.Text = "Nam";
            this.radioButton_nam.UseVisualStyleBackColor = true;
            // 
            // label_gioitinh
            // 
            this.label_gioitinh.AutoSize = true;
            this.label_gioitinh.ForeColor = System.Drawing.Color.Black;
            this.label_gioitinh.Location = new System.Drawing.Point(6, 172);
            this.label_gioitinh.Name = "label_gioitinh";
            this.label_gioitinh.Size = new System.Drawing.Size(64, 17);
            this.label_gioitinh.TabIndex = 4;
            this.label_gioitinh.Text = "Giới tính:";
            // 
            // textBox_hovaten
            // 
            this.textBox_hovaten.Location = new System.Drawing.Point(6, 132);
            this.textBox_hovaten.Name = "textBox_hovaten";
            this.textBox_hovaten.Size = new System.Drawing.Size(209, 22);
            this.textBox_hovaten.TabIndex = 3;
            // 
            // label_hovaten
            // 
            this.label_hovaten.AutoSize = true;
            this.label_hovaten.ForeColor = System.Drawing.Color.Black;
            this.label_hovaten.Location = new System.Drawing.Point(6, 101);
            this.label_hovaten.Name = "label_hovaten";
            this.label_hovaten.Size = new System.Drawing.Size(130, 17);
            this.label_hovaten.TabIndex = 2;
            this.label_hovaten.Text = "Họ và tên học sinh:";
            // 
            // label_mahocsinh
            // 
            this.label_mahocsinh.AutoSize = true;
            this.label_mahocsinh.ForeColor = System.Drawing.Color.Black;
            this.label_mahocsinh.Location = new System.Drawing.Point(6, 33);
            this.label_mahocsinh.Name = "label_mahocsinh";
            this.label_mahocsinh.Size = new System.Drawing.Size(88, 17);
            this.label_mahocsinh.TabIndex = 1;
            this.label_mahocsinh.Text = "Mã học sinh:";
            // 
            // textBox_masohocsinh
            // 
            this.textBox_masohocsinh.Location = new System.Drawing.Point(6, 62);
            this.textBox_masohocsinh.Name = "textBox_masohocsinh";
            this.textBox_masohocsinh.Size = new System.Drawing.Size(209, 22);
            this.textBox_masohocsinh.TabIndex = 0;
            this.textBox_masohocsinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_danhsachhocsinh
            // 
            this.label_danhsachhocsinh.AutoSize = true;
            this.label_danhsachhocsinh.ForeColor = System.Drawing.Color.Red;
            this.label_danhsachhocsinh.Location = new System.Drawing.Point(314, 24);
            this.label_danhsachhocsinh.Name = "label_danhsachhocsinh";
            this.label_danhsachhocsinh.Size = new System.Drawing.Size(133, 17);
            this.label_danhsachhocsinh.TabIndex = 1;
            this.label_danhsachhocsinh.Text = "Danh sách học sinh";
            this.label_danhsachhocsinh.Click += new System.EventHandler(this.label_danhsachhocsinh_Click);
            // 
            // button_luufile
            // 
            this.button_luufile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luufile.Image = ((System.Drawing.Image)(resources.GetObject("button_luufile.Image")));
            this.button_luufile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_luufile.Location = new System.Drawing.Point(317, 453);
            this.button_luufile.Name = "button_luufile";
            this.button_luufile.Size = new System.Drawing.Size(153, 76);
            this.button_luufile.TabIndex = 3;
            this.button_luufile.Text = "Lưu file";
            this.button_luufile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_luufile.UseVisualStyleBackColor = true;
            this.button_luufile.Click += new System.EventHandler(this.button_luufile_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoat.Image = ((System.Drawing.Image)(resources.GetObject("button_thoat.Image")));
            this.button_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thoat.Location = new System.Drawing.Point(1051, 453);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(158, 76);
            this.button_thoat.TabIndex = 4;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 365);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1268, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_luufile);
            this.Controls.Add(this.label_danhsachhocsinh);
            this.Controls.Add(this.groupNhaplieu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QUẢN LÝ HỌC SINH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupNhaplieu.ResumeLayout(false);
            this.groupNhaplieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupNhaplieu;
        private System.Windows.Forms.TextBox textBox_masohocsinh;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_noisinh;
        private System.Windows.Forms.Label label_ngaysinh;
        private System.Windows.Forms.RadioButton radioButton_nu;
        private System.Windows.Forms.RadioButton radioButton_nam;
        private System.Windows.Forms.Label label_gioitinh;
        private System.Windows.Forms.TextBox textBox_hovaten;
        private System.Windows.Forms.Label label_hovaten;
        private System.Windows.Forms.Label label_mahocsinh;
        private System.Windows.Forms.Label label_danhsachhocsinh;
        private System.Windows.Forms.Button button_luufile;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

