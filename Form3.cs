using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection con3 = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
            con3.Open();
            MySqlDataAdapter read4 = new MySqlDataAdapter("select name,location,rating,website from details where facility ='" + comboBox2.Text + "'", con3);
            DataTable dtbl = new DataTable();
            read4.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con3.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
