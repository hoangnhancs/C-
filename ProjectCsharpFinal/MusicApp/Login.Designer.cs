namespace MusicApp
{
    partial class Login
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
            this.button_closeLogin = new System.Windows.Forms.Button();
            this.panel_space = new System.Windows.Forms.Panel();
            this.textBox_userid = new System.Windows.Forms.TextBox();
            this.label_userid = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_closeLogin
            // 
            this.button_closeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.button_closeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_closeLogin.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_closeLogin.ForeColor = System.Drawing.Color.White;
            this.button_closeLogin.Location = new System.Drawing.Point(449, 0);
            this.button_closeLogin.Name = "button_closeLogin";
            this.button_closeLogin.Size = new System.Drawing.Size(30, 30);
            this.button_closeLogin.TabIndex = 0;
            this.button_closeLogin.TabStop = false;
            this.button_closeLogin.Text = "X";
            this.button_closeLogin.UseVisualStyleBackColor = false;
            this.button_closeLogin.Click += new System.EventHandler(this.button_closeLogin_Click);
            // 
            // panel_space
            // 
            this.panel_space.BackColor = System.Drawing.Color.White;
            this.panel_space.Location = new System.Drawing.Point(0, 36);
            this.panel_space.Name = "panel_space";
            this.panel_space.Size = new System.Drawing.Size(479, 2);
            this.panel_space.TabIndex = 1;
            // 
            // textBox_userid
            // 
            this.textBox_userid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userid.Location = new System.Drawing.Point(224, 109);
            this.textBox_userid.Multiline = true;
            this.textBox_userid.Name = "textBox_userid";
            this.textBox_userid.Size = new System.Drawing.Size(194, 29);
            this.textBox_userid.TabIndex = 2;
            // 
            // label_userid
            // 
            this.label_userid.AutoSize = true;
            this.label_userid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userid.ForeColor = System.Drawing.Color.White;
            this.label_userid.Location = new System.Drawing.Point(42, 114);
            this.label_userid.Name = "label_userid";
            this.label_userid.Size = new System.Drawing.Size(144, 24);
            this.label_userid.TabIndex = 3;
            this.label_userid.Text = "Tên đăng nhập";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(42, 165);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(92, 24);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Mật khẩu";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(224, 160);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(194, 29);
            this.textBox_password.TabIndex = 4;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(160)))), ((int)(((byte)(238)))));
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(145, 245);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(185, 50);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Đăng nhập";
            this.button_Login.UseVisualStyleBackColor = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(179, 6);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(122, 24);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Đăng Nhập";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(479, 348);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_userid);
            this.Controls.Add(this.textBox_userid);
            this.Controls.Add(this.panel_space);
            this.Controls.Add(this.button_closeLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_closeLogin;
        private System.Windows.Forms.Panel panel_space;
        private System.Windows.Forms.TextBox textBox_userid;
        private System.Windows.Forms.Label label_userid;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_title;
    }
}