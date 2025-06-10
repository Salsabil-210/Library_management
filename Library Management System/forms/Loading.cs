using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 525)
            {
                timer1.Stop();

                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
