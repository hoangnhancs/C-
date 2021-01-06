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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            button_closeLogin.FlatAppearance.BorderSize = 0;
        }

        private void button_closeLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
