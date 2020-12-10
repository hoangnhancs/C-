namespace btth3
{
    partial class formplaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formplaylist));
            this.comboBoxPlaylist = new System.Windows.Forms.ComboBox();
            this.dataGridViewSong = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button_addplaylist = new System.Windows.Forms.Button();
            this.button_addsong = new System.Windows.Forms.Button();
            this.textBox_addsong = new System.Windows.Forms.TextBox();
            this.button_import = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_songname = new System.Windows.Forms.TextBox();
            this.textBox_deletesong = new System.Windows.Forms.TextBox();
            this.button_deletesong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPlaylist
            // 
            this.comboBoxPlaylist.FormattingEnabled = true;
            this.comboBoxPlaylist.Location = new System.Drawing.Point(84, 15);
            this.comboBoxPlaylist.Name = "comboBoxPlaylist";
            this.comboBoxPlaylist.Size = new System.Drawing.Size(139, 24);
            this.comboBoxPlaylist.TabIndex = 0;
            this.comboBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewSong
            // 
            this.dataGridViewSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSong.Location = new System.Drawing.Point(229, 12);
            this.dataGridViewSong.Name = "dataGridViewSong";
            this.dataGridViewSong.RowHeadersWidth = 51;
            this.dataGridViewSong.RowTemplate.Height = 24;
            this.dataGridViewSong.Size = new System.Drawing.Size(1033, 611);
            this.dataGridViewSong.TabIndex = 1;
            this.dataGridViewSong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_addplaylist
            // 
            this.button_addplaylist.Location = new System.Drawing.Point(81, 146);
            this.button_addplaylist.Name = "button_addplaylist";
            this.button_addplaylist.Size = new System.Drawing.Size(139, 33);
            this.button_addplaylist.TabIndex = 3;
            this.button_addplaylist.Text = "Thêm playlist";
            this.button_addplaylist.UseVisualStyleBackColor = true;
            this.button_addplaylist.Click += new System.EventHandler(this.button_addplaylist_Click);
            // 
            // button_addsong
            // 
            this.button_addsong.Location = new System.Drawing.Point(12, 427);
            this.button_addsong.Name = "button_addsong";
            this.button_addsong.Size = new System.Drawing.Size(211, 33);
            this.button_addsong.TabIndex = 4;
            this.button_addsong.Text = "Thêm BH";
            this.button_addsong.UseVisualStyleBackColor = true;
            this.button_addsong.Click += new System.EventHandler(this.button_addsong_Click);
            // 
            // textBox_addsong
            // 
            this.textBox_addsong.Location = new System.Drawing.Point(81, 107);
            this.textBox_addsong.Multiline = true;
            this.textBox_addsong.Name = "textBox_addsong";
            this.textBox_addsong.Size = new System.Drawing.Size(139, 33);
            this.textBox_addsong.TabIndex = 5;
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(98, 213);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(122, 53);
            this.button_import.TabIndex = 6;
            this.button_import.Text = "+";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 397);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn playlist";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(9, 282);
            this.textBox_path.Multiline = true;
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(211, 33);
            this.textBox_path.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên bài hát";
            // 
            // textBox_songname
            // 
            this.textBox_songname.Location = new System.Drawing.Point(9, 341);
            this.textBox_songname.Multiline = true;
            this.textBox_songname.Name = "textBox_songname";
            this.textBox_songname.Size = new System.Drawing.Size(211, 33);
            this.textBox_songname.TabIndex = 13;
            // 
            // textBox_deletesong
            // 
            this.textBox_deletesong.Location = new System.Drawing.Point(12, 478);
            this.textBox_deletesong.Multiline = true;
            this.textBox_deletesong.Name = "textBox_deletesong";
            this.textBox_deletesong.Size = new System.Drawing.Size(211, 33);
            this.textBox_deletesong.TabIndex = 14;
            this.textBox_deletesong.TextChanged += new System.EventHandler(this.textBox_deletesong_TextChanged);
            // 
            // button_deletesong
            // 
            this.button_deletesong.Location = new System.Drawing.Point(12, 516);
            this.button_deletesong.Name = "button_deletesong";
            this.button_deletesong.Size = new System.Drawing.Size(211, 33);
            this.button_deletesong.TabIndex = 15;
            this.button_deletesong.Text = "Xóa BH";
            this.button_deletesong.UseVisualStyleBackColor = true;
            this.button_deletesong.Click += new System.EventHandler(this.button_deletesong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 611);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(9, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 72);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(9, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 72);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(9, 204);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 72);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // formplaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1464, 624);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_deletesong);
            this.Controls.Add(this.textBox_deletesong);
            this.Controls.Add(this.textBox_songname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.textBox_addsong);
            this.Controls.Add(this.button_addsong);
            this.Controls.Add(this.button_addplaylist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSong);
            this.Controls.Add(this.comboBoxPlaylist);
            this.MaximizeBox = false;
            this.Name = "formplaylist";
            this.Text = "Danh sách phát";
            this.Load += new System.EventHandler(this.formplaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlaylist;
        private System.Windows.Forms.DataGridView dataGridViewSong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_addplaylist;
        private System.Windows.Forms.Button button_addsong;
        private System.Windows.Forms.TextBox textBox_addsong;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_songname;
        private System.Windows.Forms.TextBox textBox_deletesong;
        private System.Windows.Forms.Button button_deletesong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}