namespace MusicApp
{
    partial class homePage
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
            this.panel_slideShow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_slideShow.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_slideShow
            // 
            this.panel_slideShow.Controls.Add(this.label1);
            this.panel_slideShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_slideShow.Location = new System.Drawing.Point(0, 0);
            this.panel_slideShow.Name = "panel_slideShow";
            this.panel_slideShow.Size = new System.Drawing.Size(803, 253);
            this.panel_slideShow.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "panel chứa slide show";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 253);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(803, 479);
            this.panel_main.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "panel main add thêm từng panel nhỏ cho từng mục sử dụng dock để dễ quản lí vs zoo" +
    "m";
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(803, 732);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_slideShow);
            this.Name = "homePage";
            this.Text = "homePage";
            this.panel_slideShow.ResumeLayout(false);
            this.panel_slideShow.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_slideShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label2;
    }
}