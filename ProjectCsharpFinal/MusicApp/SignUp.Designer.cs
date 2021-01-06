namespace MusicApp
{
    partial class SignUp
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
            this.panel_space = new System.Windows.Forms.Panel();
            this.button_closeSignUp = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_userid = new System.Windows.Forms.Label();
            this.textBox_userid = new System.Windows.Forms.TextBox();
            this.label_repeatPass = new System.Windows.Forms.Label();
            this.textBox_repeatPass = new System.Windows.Forms.TextBox();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_space
            // 
            this.panel_space.BackColor = System.Drawing.Color.White;
            this.panel_space.Location = new System.Drawing.Point(0, 36);
            this.panel_space.Name = "panel_space";
            this.panel_space.Size = new System.Drawing.Size(479, 2);
            this.panel_space.TabIndex = 3;
            // 
            // button_closeSignUp
            // 
            this.button_closeSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.button_closeSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_closeSignUp.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_closeSignUp.ForeColor = System.Drawing.Color.White;
            this.button_closeSignUp.Location = new System.Drawing.Point(449, 0);
            this.button_closeSignUp.Name = "button_closeSignUp";
            this.button_closeSignUp.Size = new System.Drawing.Size(30, 30);
            this.button_closeSignUp.TabIndex = 2;
            this.button_closeSignUp.TabStop = false;
            this.button_closeSignUp.Text = "X";
            this.button_closeSignUp.UseVisualStyleBackColor = false;
            this.button_closeSignUp.Click += new System.EventHandler(this.button_closeLogin_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(201, 6);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(95, 24);
            this.label_title.TabIndex = 8;
            this.label_title.Text = "Đăng Ký";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(46, 151);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(92, 24);
            this.label_password.TabIndex = 12;
            this.label_password.Text = "Mật khẩu";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(231, 146);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(194, 29);
            this.textBox_password.TabIndex = 11;
            // 
            // label_userid
            // 
            this.label_userid.AutoSize = true;
            this.label_userid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userid.ForeColor = System.Drawing.Color.White;
            this.label_userid.Location = new System.Drawing.Point(46, 100);
            this.label_userid.Name = "label_userid";
            this.label_userid.Size = new System.Drawing.Size(144, 24);
            this.label_userid.TabIndex = 10;
            this.label_userid.Text = "Tên đăng nhập";
            // 
            // textBox_userid
            // 
            this.textBox_userid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userid.Location = new System.Drawing.Point(231, 95);
            this.textBox_userid.Multiline = true;
            this.textBox_userid.Name = "textBox_userid";
            this.textBox_userid.Size = new System.Drawing.Size(194, 29);
            this.textBox_userid.TabIndex = 9;
            // 
            // label_repeatPass
            // 
            this.label_repeatPass.AutoSize = true;
            this.label_repeatPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_repeatPass.ForeColor = System.Drawing.Color.White;
            this.label_repeatPass.Location = new System.Drawing.Point(46, 199);
            this.label_repeatPass.Name = "label_repeatPass";
            this.label_repeatPass.Size = new System.Drawing.Size(173, 24);
            this.label_repeatPass.TabIndex = 14;
            this.label_repeatPass.Text = "Nhập lại mật khẩu";
            // 
            // textBox_repeatPass
            // 
            this.textBox_repeatPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_repeatPass.Location = new System.Drawing.Point(231, 194);
            this.textBox_repeatPass.Multiline = true;
            this.textBox_repeatPass.Name = "textBox_repeatPass";
            this.textBox_repeatPass.Size = new System.Drawing.Size(194, 29);
            this.textBox_repeatPass.TabIndex = 13;
            // 
            // button_SignUp
            // 
            this.button_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.button_SignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SignUp.ForeColor = System.Drawing.Color.White;
            this.button_SignUp.Location = new System.Drawing.Point(157, 257);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(185, 50);
            this.button_SignUp.TabIndex = 15;
            this.button_SignUp.Text = "Đăng Ký";
            this.button_SignUp.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(479, 348);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.label_repeatPass);
            this.Controls.Add(this.textBox_repeatPass);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_userid);
            this.Controls.Add(this.textBox_userid);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel_space);
            this.Controls.Add(this.button_closeSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_space;
        private System.Windows.Forms.Button button_closeSignUp;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_userid;
        private System.Windows.Forms.TextBox textBox_userid;
        private System.Windows.Forms.Label label_repeatPass;
        private System.Windows.Forms.TextBox textBox_repeatPass;
        private System.Windows.Forms.Button button_SignUp;
    }
}