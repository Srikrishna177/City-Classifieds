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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection con2 = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
            MySqlCommand cmd3 = new MySqlCommand("select status,password from login where username='" + bunifuCustomTextbox1.Text + "'", con2);
            con2.Open();
            MySqlDataReader read3 = cmd3.ExecuteReader();
            if (read3.Read())
            {
                if (int.Parse(read3[0].ToString()) == 1)
                {
                    if (bunifuCustomTextbox2.Text == read3[1].ToString())
                    {
                        Form2 f2 = new Form2(bunifuCustomTextbox1.Text);
                        this.Hide();
                        f2.Show();
                    }
                    else
                    {
                        bunifuThinButton21.Text = "Not Successful";
                    }
                }
                else
                {
                    bunifuThinButton21.Text = "not an admin";
                }
            }
            else
            {
                bunifuThinButton21.Text = "Admin does not exist";
            }
            con2.Close();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            MySqlConnection con1 = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
            MySqlCommand cmd2 = new MySqlCommand("insert into login(username,password,status) values('" + bunifuCustomTextbox1.Text + "','" + bunifuCustomTextbox2.Text + "','" + 1 + "')", con1);
            con1.Open();
            bunifuThinButton21.Visible = false;
            bunifuThinButton23.Visible = true;
            cmd2.ExecuteNonQuery();
            con1.Close();

        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            bunifuThinButton22.Visible = true;
            bunifuThinButton21.Visible = true;
            bunifuThinButton23.Visible = false;
        }
    }
}

