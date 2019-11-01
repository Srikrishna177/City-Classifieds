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
using System.IO;

namespace WindowsFormsApp8
{
    public partial class Form4 : Form
    {

        int a;
        String reqid,una;
        public Form4(String un)
        {
            InitializeComponent();
            una = un;
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
                MySqlConnection con = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
                MySqlCommand cmd1 = new MySqlCommand("select count(username) from details where username='" + una + "'", con); 
                con.Open();
                MySqlDataReader read1 = cmd1.ExecuteReader();
                if (read1.Read())
                {
                    a = int.Parse(read1[0].ToString());
                }
                read1.Close();
                a++;
                reqid = "requestid" + a.ToString();
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                MySqlCommand cmd2 = new MySqlCommand("insert into details(cityname,facility,name,location,rating,website,requestid,username,image) values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + bunifuCustomTextbox3.Text + "','" + bunifuCustomTextbox4.Text + "','" + bunifuCustomTextbox5.Text + "','" + bunifuCustomTextbox6.Text + "','" + reqid +"','"+una+"','"+img+"')", con);
                MessageBox.Show("DATA INSERTED");
                cmd2.ExecuteNonQuery();
                con.Close();
           
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "F:/Software development/WindowsFormsApp8";
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                string picpath = of.FileName.ToString();
                pictureBox1.ImageLocation = picpath; ;

            }
        }

        
    }
}
