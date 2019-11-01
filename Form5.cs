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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            MySqlConnection con4 = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
            con4.Open();
            MySqlDataAdapter read5 = new MySqlDataAdapter("select * from details", con4);
            DataTable dtbl = new DataTable();
            read5.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con4.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con5 = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
            con5.Open();
            MySqlDataAdapter read6 = new MySqlDataAdapter("update details set reqstatus='"+1.ToString()+"'where id='"+textBox1.Text+"'", con5);
            DataTable dtbl = new DataTable();
            read6.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con5.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con5 = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
            con5.Open();
            MySqlDataAdapter read6 = new MySqlDataAdapter("update details set reqstatus='" + 2.ToString() + "'where id='" + textBox1.Text + "'", con5);
            DataTable dtbl = new DataTable();
            read6.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con5.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
