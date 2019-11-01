using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        String usern;
        public Form2(String user)
        {
            InitializeComponent();
            usern = user;
            bunifuCustomLabel1.Text = bunifuCustomLabel1.Text +  user;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            this.Hide();
            f3.Show();

        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4(usern);
            this.Hide();
            f4.Show();
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }
    }
}
