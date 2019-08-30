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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-J7GRRQ81;Initial Catalog=sozlukselcan;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                komut.CommandText = "Delete From SozlukCeviri where [Turkce]=('" + textBox1.Text + "')";
            }
            else if (radioButton2.Checked)
            {

                komut.CommandText = "Delete From SozlukCeviri where [İngilizce]=('" + textBox2.Text + "')";
            }

            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
                textBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
