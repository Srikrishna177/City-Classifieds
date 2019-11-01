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
    public partial class Form5 : Form
    {
       
        public Form5()
        {
            InitializeComponent();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection con1=new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
            MySqlCommand cmd2 = new MySqlCommand("select password from login where username='"+textBox2.Text+"'",con1);
            con1.Open();
            MySqlDataReader read2 = cmd2.ExecuteReader();
            if(read2.Read())
            {
                if(textBox1.Text==read2[0].ToString())
                {
                    Form3 f3 = new Form3(textBox2.Text);
                    this.Hide();
                    f3.Show();
                      
                }
                else
                {
                    bunifuFlatButton1.Text = "Password not found";
                }                       
            }
            else
            {
               //do nothing
            }
         con1.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
                MySqlConnection con1 = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
                MySqlCommand cmd2 = new MySqlCommand("insert into login(username,password,status) values('" + textBox2.Text + "','" + textBox1.Text + "','"+int.Parse(0.ToString())+"')", con1);
                con1.Open();
                bunifuFlatButton1.Visible = false;
                cmd2.ExecuteNonQuery();
                con1.Close();
            
           
        }
    }
}
