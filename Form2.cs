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

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection con3 = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
                con3.Open();
                MySqlDataAdapter read4 = new MySqlDataAdapter("select name,location,rating,website from details where facility='" + comboBox2.Text + "' and cityname='"+comboBox1.Text+"' and reqstatus='"+1+"'", con3);
                DataTable ds = new DataTable();
                read4.Fill(ds);
                dataGridView1.DataSource = ds;
                con3.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }
    }
}
