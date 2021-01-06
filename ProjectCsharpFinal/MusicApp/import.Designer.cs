namespace MusicApp
{
    partial class import
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
            this.label_importPC = new System.Windows.Forms.Label();
            this.button_addPC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.button_download = new System.Windows.Forms.Button();
            this.richTextBox_urlDownload = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_importPC
            // 
            this.label_importPC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_importPC.AutoSize = true;
            this.label_importPC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_importPC.ForeColor = System.Drawing.Color.White;
            this.label_importPC.Location = new System.Drawing.Point(54, 130);
            this.label_importPC.Name = "label_importPC";
            this.label_importPC.Size = new System.Drawing.Size(398, 24);
            this.label_importPC.TabIndex = 0;
            this.label_importPC.Text = "Thêm nhạc có sẵn trong máy tính của bạn :";
            this.label_importPC.Click += new System.EventHandler(this.label_importPC_Click);
            // 
            // button_addPC
            // 
            this.button_addPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.button_addPC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_addPC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addPC.ForeColor = System.Drawing.Color.White;
            this.button_addPC.Location = new System.Drawing.Point(525, 119);
            this.button_addPC.Name = "button_addPC";
            this.button_addPC.Size = new System.Drawing.Size(169, 46);
            this.button_addPC.TabIndex = 4;
            this.button_addPC.TabStop = false;
            this.button_addPC.Text = "Thêm vào";
            this.button_addPC.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tải nhạc từ url :";
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(230, 25);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(377, 34);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Thêm nhạc vào phần mền";
            // 
            // button_download
            // 
            this.button_download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.button_download.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_download.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_download.ForeColor = System.Drawing.Color.White;
            this.button_download.Location = new System.Drawing.Point(525, 315);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(169, 46);
            this.button_download.TabIndex = 8;
            this.button_download.TabStop = false;
            this.button_download.Text = "Tải xuống";
            this.button_download.UseVisualStyleBackColor = false;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // richTextBox_urlDownload
            // 
            this.richTextBox_urlDownload.Location = new System.Drawing.Point(213, 220);
            this.richTextBox_urlDownload.Name = "richTextBox_urlDownload";
            this.richTextBox_urlDownload.Size = new System.Drawing.Size(481, 34);
            this.richTextBox_urlDownload.TabIndex = 9;
            this.richTextBox_urlDownload.Text = "";
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(803, 732);
            this.Controls.Add(this.richTextBox_urlDownload);
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_addPC);
            this.Controls.Add(this.label_importPC);
            this.Name = "import";
            this.Text = "import";
            this.Load += new System.EventHandler(this.import_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_importPC;
        private System.Windows.Forms.Button button_addPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.RichTextBox richTextBox_urlDownload;
    }
}