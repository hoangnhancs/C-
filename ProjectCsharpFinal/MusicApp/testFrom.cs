using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class testFrom : Form
    {
        public testFrom()
        {
            InitializeComponent();
        }


        private Panel addPanel()
        {
            Panel panel_item1 = new System.Windows.Forms.Panel();
            Label label_singer_item1 = new System.Windows.Forms.Label();
            Label label_titel_item1 = new System.Windows.Forms.Label();
            PictureBox pictureBox_karaoke_item1 = new System.Windows.Forms.PictureBox();
            PictureBox pictureBox_item1 = new System.Windows.Forms.PictureBox();
            panel_item1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox_karaoke_item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox_item1)).BeginInit();
            SuspendLayout();

            // 
            // panel_item1
            // 
            panel_item1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel_item1.Controls.Add(pictureBox_karaoke_item1);
            panel_item1.Controls.Add(label_singer_item1);
            panel_item1.Controls.Add(label_titel_item1);
            panel_item1.Controls.Add(pictureBox_item1);
            panel_item1.Dock = System.Windows.Forms.DockStyle.Top;
            panel_item1.Location = new System.Drawing.Point(0, 0);
            panel_item1.Name = "panel_item1";
            panel_item1.Size = new System.Drawing.Size(800, 74);
            panel_item1.TabIndex = 1;
            // 
            // label_singer_item1
            // 
            label_singer_item1.AutoSize = true;
            label_singer_item1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_singer_item1.ForeColor = System.Drawing.Color.White;
            label_singer_item1.Location = new System.Drawing.Point(152, 42);
            label_singer_item1.Name = "label_singer_item1";
            label_singer_item1.Size = new System.Drawing.Size(54, 21);
            label_singer_item1.TabIndex = 2;
            label_singer_item1.Text = "label2";
            // 
            // label_titel_item1
            // 
            label_titel_item1.AutoSize = true;
            label_titel_item1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_titel_item1.ForeColor = System.Drawing.Color.White;
            label_titel_item1.Location = new System.Drawing.Point(152, 9);
            label_titel_item1.Name = "label_titel_item1";
            label_titel_item1.Size = new System.Drawing.Size(64, 24);
            label_titel_item1.TabIndex = 1;
            label_titel_item1.Text = "label1";
            // 
            // pictureBox_karaoke_item1
            // 
            pictureBox_karaoke_item1.Location = new System.Drawing.Point(751, 22);
            pictureBox_karaoke_item1.Name = "pictureBox_karaoke_item1";
            pictureBox_karaoke_item1.Size = new System.Drawing.Size(37, 27);
            pictureBox_karaoke_item1.TabIndex = 3;
            pictureBox_karaoke_item1.TabStop = false;
            // 
            // pictureBox_item1
            // 
            pictureBox_item1.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox_item1.Location = new System.Drawing.Point(0, 0);
            pictureBox_item1.Name = "pictureBox_item1";
            pictureBox_item1.Size = new System.Drawing.Size(83, 72);
            pictureBox_item1.TabIndex = 0;
            pictureBox_item1.TabStop = false;

            return panel_item1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(addPanel());
        }
    }
}
