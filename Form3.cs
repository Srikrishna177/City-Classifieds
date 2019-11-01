using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form3 : Form
    {
        String un; 
        public Form3(String uname)
        {
           
            InitializeComponent();
            un = uname;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(un);
            this.Hide();
            f4.Show();
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }
    }
}
