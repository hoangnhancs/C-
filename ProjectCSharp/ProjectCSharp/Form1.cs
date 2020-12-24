using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ProjectCSharp
{
    public partial class Form1 : Form
    {
        string Dirpath;

        int imgindex;
        int imgindexprev;
        int imgindexnext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {



            listBox1.Items.Clear();

            Dirpath = @"E:\CSharp\song_img_folder";

            string[] files = Directory.GetFiles(Dirpath, "*.Jpg");

            foreach (string file in files)

            {

                int pos = file.LastIndexOf("||");

                string FName = file.Substring(pos + 1);

                listBox1.Items.Add(FName);

            }

            //listBox1.SelectedIndex = imgindex = 0;

            btnprev.Enabled = true;

            btnnext.Enabled = true;
            imgindex = 0;
            imgindexnext = 1;

            imgindexprev = listBox1.Items.Count - 1;
            pictureBox1.ImageLocation = Convert.ToString(listBox1.Items[imgindex]); ;
            pictureBox2.ImageLocation = Convert.ToString(listBox1.Items[imgindexprev]);
            pictureBox3.ImageLocation = Convert.ToString(listBox1.Items[imgindexnext]);
            timer1.Interval = 4 * 1000;

            timer1.Start();

        }



        private void button1_Click(object sender, EventArgs e)

        {

            //DialogResult dr = folderBrowserDialog1.ShowDialog();

            //if (dr != DialogResult.Cancel)

            //{

                

            //}

        }

 



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

            pictureBox1.ImageLocation = Convert.ToString(listBox1.Items[imgindex]); ;
            pictureBox2.ImageLocation = Convert.ToString(listBox1.Items[imgindexprev]);
            pictureBox3.ImageLocation = Convert.ToString(listBox1.Items[imgindexnext]);
            // pictureBox1.ImageLocation = Dirpath + "\\" + listBox1.SelectedItem;

        }



        private void btnprev_Click(object sender, EventArgs e)

        {
            /*
            if (imgindex > 0)

            {

                imgindex -= 1;
                
                if (imgindex == 0)

                {

                    btnprev.Enabled = false;

                }

                if (imgindex < listBox1.Items.Count - 1)

                    btnnext.Enabled = true;
                

                listBox1.SelectedIndex = imgindex;

            }
            else
            {
                imgindex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = imgindex;
            }
            */
            imgindexnext = imgindex;
            imgindex = imgindexprev;
            
            imgindexprev -= 1;
            if (imgindexprev < 0)
            {
                imgindexprev = listBox1.Items.Count - 1;
            }
            pictureBox1.ImageLocation = Convert.ToString(listBox1.Items[imgindex]); ;
            pictureBox2.ImageLocation = Convert.ToString(listBox1.Items[imgindexprev]);
            pictureBox3.ImageLocation = Convert.ToString(listBox1.Items[imgindexnext]);
            timer1.Stop();
            timer1.Start();
        }



        private void btnnext_Click(object sender, EventArgs e)

        {
            /*
            if (imgindex < listBox1.Items.Count - 1)

            {               
                imgindex += 1;

                //if (imgindex == listBox1.Items.Count - 1)

                    //btnnext.Enabled = false;

                //if (imgindex > 0)

                    //btnprev.Enabled = true;

                listBox1.SelectedIndex = imgindex;

            }
            else
            {
                imgindex = 0;
                listBox1.SelectedIndex = imgindex;
            }
            */
            imgindexprev = imgindex;
            imgindex += 1;
            imgindexnext = imgindex + 1;
            
            if (imgindex > listBox1.Items.Count -1)
            {
                imgindex = imgindex - listBox1.Items.Count;
            }
            if (imgindexnext > listBox1.Items.Count -1)
            {
                imgindexnext = imgindexnext - listBox1.Items.Count;
            }
            //listBox1.SelectedIndex = imgindex;
            Console.WriteLine(imgindex);
            Console.WriteLine(imgindexnext);
            Console.WriteLine(imgindexprev);
            pictureBox1.ImageLocation = Convert.ToString(listBox1.Items[imgindex]); ;
            pictureBox2.ImageLocation = Convert.ToString(listBox1.Items[imgindexprev]);
            pictureBox3.ImageLocation = Convert.ToString(listBox1.Items[imgindexnext]);
            timer1.Stop();
            timer1.Start();
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = pictureBox1.Image;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnnext.PerformClick();
        }
    }
}
