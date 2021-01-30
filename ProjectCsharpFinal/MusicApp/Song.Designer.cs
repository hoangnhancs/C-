namespace MusicApp
{
    partial class Song
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Song));
            this.panel_inforSong = new System.Windows.Forms.Panel();
            this.panel_textSong = new System.Windows.Forms.Panel();
            this.label_author = new System.Windows.Forms.Label();
            this.label_singers = new System.Windows.Forms.Label();
            this.label_nameSong = new System.Windows.Forms.Label();
            this.label_Song = new System.Windows.Forms.Label();
            this.panel_space = new System.Windows.Forms.Panel();
            this.panel_pictureSong = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox_song = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_miniLyricSong = new System.Windows.Forms.Panel();
            this.label_detail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_lyricSong = new System.Windows.Forms.Panel();
            this.textBox_lyric = new System.Windows.Forms.TextBox();
            this.panel_fullLyric = new System.Windows.Forms.Panel();
            this.panel_inforSong.SuspendLayout();
            this.panel_textSong.SuspendLayout();
            this.panel_pictureSong.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_song)).BeginInit();
            this.panel_miniLyricSong.SuspendLayout();
            this.panel_lyricSong.SuspendLayout();
            this.panel_fullLyric.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_inforSong
            // 
            this.panel_inforSong.Controls.Add(this.panel_textSong);
            this.panel_inforSong.Controls.Add(this.panel_space);
            this.panel_inforSong.Controls.Add(this.panel_pictureSong);
            this.panel_inforSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_inforSong.Location = new System.Drawing.Point(0, 0);
            this.panel_inforSong.Name = "panel_inforSong";
            this.panel_inforSong.Size = new System.Drawing.Size(780, 305);
            this.panel_inforSong.TabIndex = 0;
            // 
            // panel_textSong
            // 
            this.panel_textSong.Controls.Add(this.label_author);
            this.panel_textSong.Controls.Add(this.label_singers);
            this.panel_textSong.Controls.Add(this.label_nameSong);
            this.panel_textSong.Controls.Add(this.label_Song);
            this.panel_textSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_textSong.Location = new System.Drawing.Point(318, 0);
            this.panel_textSong.Name = "panel_textSong";
            this.panel_textSong.Size = new System.Drawing.Size(462, 305);
            this.panel_textSong.TabIndex = 2;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.ForeColor = System.Drawing.Color.White;
            this.label_author.Location = new System.Drawing.Point(142, 157);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(180, 24);
            this.label_author.TabIndex = 4;
            this.label_author.Text = "Myke Towers, Juhn";
            // 
            // label_singers
            // 
            this.label_singers.AutoSize = true;
            this.label_singers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_singers.ForeColor = System.Drawing.Color.White;
            this.label_singers.Location = new System.Drawing.Point(43, 157);
            this.label_singers.Name = "label_singers";
            this.label_singers.Size = new System.Drawing.Size(66, 24);
            this.label_singers.TabIndex = 3;
            this.label_singers.Text = "Ca sĩ :";
            // 
            // label_nameSong
            // 
            this.label_nameSong.AutoSize = true;
            this.label_nameSong.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nameSong.ForeColor = System.Drawing.Color.White;
            this.label_nameSong.Location = new System.Drawing.Point(141, 111);
            this.label_nameSong.Name = "label_nameSong";
            this.label_nameSong.Size = new System.Drawing.Size(110, 29);
            this.label_nameSong.TabIndex = 1;
            this.label_nameSong.Text = "Bandido";
            // 
            // label_Song
            // 
            this.label_Song.AutoSize = true;
            this.label_Song.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Song.ForeColor = System.Drawing.Color.White;
            this.label_Song.Location = new System.Drawing.Point(43, 116);
            this.label_Song.Name = "label_Song";
            this.label_Song.Size = new System.Drawing.Size(92, 24);
            this.label_Song.TabIndex = 0;
            this.label_Song.Text = "Bài hát : ";
            // 
            // panel_space
            // 
            this.panel_space.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_space.Location = new System.Drawing.Point(305, 0);
            this.panel_space.Name = "panel_space";
            this.panel_space.Size = new System.Drawing.Size(13, 305);
            this.panel_space.TabIndex = 1;
            // 
            // panel_pictureSong
            // 
            this.panel_pictureSong.Controls.Add(this.flowLayoutPanel1);
            this.panel_pictureSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_pictureSong.Location = new System.Drawing.Point(0, 0);
            this.panel_pictureSong.Name = "panel_pictureSong";
            this.panel_pictureSong.Size = new System.Drawing.Size(305, 305);
            this.panel_pictureSong.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox_song);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 285);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox_song
            // 
            this.pictureBox_song.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_song.Image")));
            this.pictureBox_song.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_song.Name = "pictureBox_song";
            this.pictureBox_song.Size = new System.Drawing.Size(276, 276);
            this.pictureBox_song.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_song.TabIndex = 0;
            this.pictureBox_song.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel_miniLyricSong
            // 
            this.panel_miniLyricSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panel_miniLyricSong.Controls.Add(this.label_detail);
            this.panel_miniLyricSong.Controls.Add(this.label2);
            this.panel_miniLyricSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_miniLyricSong.Location = new System.Drawing.Point(0, 0);
            this.panel_miniLyricSong.Name = "panel_miniLyricSong";
            this.panel_miniLyricSong.Size = new System.Drawing.Size(739, 68);
            this.panel_miniLyricSong.TabIndex = 2;
            // 
            // label_detail
            // 
            this.label_detail.AutoSize = true;
            this.label_detail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_detail.Location = new System.Drawing.Point(3, 34);
            this.label_detail.Name = "label_detail";
            this.label_detail.Size = new System.Drawing.Size(99, 21);
            this.label_detail.TabIndex = 5;
            this.label_detail.Text = "Xem chi tiết";
            this.label_detail.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lời bài hát :";
            // 
            // panel_lyricSong
            // 
            this.panel_lyricSong.AutoScroll = true;
            this.panel_lyricSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panel_lyricSong.Controls.Add(this.textBox_lyric);
            this.panel_lyricSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_lyricSong.Location = new System.Drawing.Point(0, 68);
            this.panel_lyricSong.Name = "panel_lyricSong";
            this.panel_lyricSong.Size = new System.Drawing.Size(739, 337);
            this.panel_lyricSong.TabIndex = 3;
            this.panel_lyricSong.Visible = false;
            // 
            // textBox_lyric
            // 
            this.textBox_lyric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.textBox_lyric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_lyric.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_lyric.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lyric.ForeColor = System.Drawing.Color.White;
            this.textBox_lyric.Location = new System.Drawing.Point(0, 0);
            this.textBox_lyric.Multiline = true;
            this.textBox_lyric.Name = "textBox_lyric";
            this.textBox_lyric.ReadOnly = true;
            this.textBox_lyric.Size = new System.Drawing.Size(718, 718);
            this.textBox_lyric.TabIndex = 3;
            this.textBox_lyric.Text = "Hiện không có lời bài hát này";
            // 
            // panel_fullLyric
            // 
            this.panel_fullLyric.AutoScroll = true;
            this.panel_fullLyric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.panel_fullLyric.Controls.Add(this.panel_lyricSong);
            this.panel_fullLyric.Controls.Add(this.panel_miniLyricSong);
            this.panel_fullLyric.Location = new System.Drawing.Point(17, 322);
            this.panel_fullLyric.Name = "panel_fullLyric";
            this.panel_fullLyric.Size = new System.Drawing.Size(739, 405);
            this.panel_fullLyric.TabIndex = 4;
            // 
            // Song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(780, 711);
            this.Controls.Add(this.panel_fullLyric);
            this.Controls.Add(this.panel_inforSong);
            this.Name = "Song";
            this.Text = "Song";
            this.Load += new System.EventHandler(this.Song_Load);
            this.panel_inforSong.ResumeLayout(false);
            this.panel_textSong.ResumeLayout(false);
            this.panel_textSong.PerformLayout();
            this.panel_pictureSong.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_song)).EndInit();
            this.panel_miniLyricSong.ResumeLayout(false);
            this.panel_miniLyricSong.PerformLayout();
            this.panel_lyricSong.ResumeLayout(false);
            this.panel_lyricSong.PerformLayout();
            this.panel_fullLyric.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_inforSong;
        private System.Windows.Forms.Panel panel_textSong;
        private System.Windows.Forms.Panel panel_space;
        private System.Windows.Forms.Panel panel_pictureSong;
        private System.Windows.Forms.PictureBox pictureBox_song;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_singers;
        private System.Windows.Forms.Label label_nameSong;
        private System.Windows.Forms.Label label_Song;
        private System.Windows.Forms.Panel panel_miniLyricSong;
        private System.Windows.Forms.Label label_detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_lyricSong;
        private System.Windows.Forms.TextBox textBox_lyric;
        private System.Windows.Forms.Panel panel_fullLyric;
    }
}