using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozlukproje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-J7GRRQ81;Initial Catalog=sozlukselcan;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {

            komut.CommandText = "insert into SozlukCeviri values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
