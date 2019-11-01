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

namespace WindowsFormsApp9
{
    public partial class Form4 : Form
    {
        String un;
        public Form4(String usern)
        {
            InitializeComponent();
            un = usern;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=db4free.net;Port=3306;Database=srikrishna;Username=srikrish;password=987654321;old guids=true");
            con.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand cmd1 = new MySqlCommand("insert into details(cityname,facility,name,location,rating,website,requestid,reqstatus,username,image) values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + bunifuCustomTextbox3.Text + "','" + bunifuCustomTextbox4.Text + "','" + bunifuCustomTextbox5.Text + "','" + bunifuCustomTextbox6.Text + "','" + "nill" + "','" + 1 + "','" + un + "','"+img+"')", con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Data Inserted");
            con.Close();
        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
