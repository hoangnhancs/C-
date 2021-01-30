namespace MusicApp
{
    partial class Karaoke_record
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
            this.components = new System.ComponentModel.Container();
            this.label_timeRecording = new System.Windows.Forms.Label();
            this.button_playVideo = new System.Windows.Forms.Button();
            this.button_stopRecord = new System.Windows.Forms.Button();
            this.button_recording = new System.Windows.Forms.Button();
            this.countTime = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label_timeRecording
            // 
            this.label_timeRecording.AutoSize = true;
            this.label_timeRecording.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timeRecording.ForeColor = System.Drawing.Color.White;
            this.label_timeRecording.Location = new System.Drawing.Point(931, 596);
            this.label_timeRecording.Name = "label_timeRecording";
            this.label_timeRecording.Size = new System.Drawing.Size(104, 24);
            this.label_timeRecording.TabIndex = 11;
            this.label_timeRecording.Text = "00:00 giây";
            // 
            // button_playVideo
            // 
            this.button_playVideo.Location = new System.Drawing.Point(12, 584);
            this.button_playVideo.Name = "button_playVideo";
            this.button_playVideo.Size = new System.Drawing.Size(125, 55);
            this.button_playVideo.TabIndex = 10;
            this.button_playVideo.Text = "Play";
            this.button_playVideo.UseVisualStyleBackColor = true;
            this.button_playVideo.Click += new System.EventHandler(this.button_playVideo_Click);
            // 
            // button_stopRecord
            // 
            this.button_stopRecord.Location = new System.Drawing.Point(316, 584);
            this.button_stopRecord.Name = "button_stopRecord";
            this.button_stopRecord.Size = new System.Drawing.Size(125, 55);
            this.button_stopRecord.TabIndex = 9;
            this.button_stopRecord.Text = "Dừng / Lưu";
            this.button_stopRecord.UseVisualStyleBackColor = true;
            this.button_stopRecord.Click += new System.EventHandler(this.button_stopRecord_Click);
            // 
            // button_recording
            // 
            this.button_recording.Location = new System.Drawing.Point(162, 584);
            this.button_recording.Name = "button_recording";
            this.button_recording.Size = new System.Drawing.Size(125, 55);
            this.button_recording.TabIndex = 7;
            this.button_recording.Text = "Thu âm";
            this.button_recording.UseVisualStyleBackColor = true;
            this.button_recording.Click += new System.EventHandler(this.button_recording_Click);
            // 
            // countTime
            // 
            this.countTime.Interval = 1000;
            this.countTime.Tick += new System.EventHandler(this.countTime_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1058, 522);
            this.webBrowser1.TabIndex = 8;
            // 
            // Karaoke_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1082, 678);
            this.Controls.Add(this.label_timeRecording);
            this.Controls.Add(this.button_playVideo);
            this.Controls.Add(this.button_stopRecord);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button_recording);
            this.Name = "Karaoke_record";
            this.Text = "Karaoke_record";
            this.Load += new System.EventHandler(this.Karaoke_record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_timeRecording;
        private System.Windows.Forms.Button button_playVideo;
        private System.Windows.Forms.Button button_stopRecord;
        private System.Windows.Forms.Button button_recording;
        private System.Windows.Forms.Timer countTime;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}