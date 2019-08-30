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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-J7GRRQ81;Initial Catalog=sozlukselcan;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label2.Enabled = false;

            komut.CommandText = "SELECT *  FROM SozlukCeviri";
            komut.Connection = baglanti;

            da = new SqlDataAdapter(komut);
            da.Fill(ds, "SozlukCeviri");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SozlukCeviri";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arama = textBox1.Text;
            bool kelimeyok = true;

            if (textBox1.Text != "")
            {
                baglanti.Open();
                komut.CommandText = " Select * From SozlukCeviri";
                komut.Connection = baglanti;
                SqlDataReader oku = komut.ExecuteReader();

                if (radioButton1.Checked)
                {
                    while (oku.Read())
                    {
                        if (arama == oku[0].ToString())
                        {
                            label2.Text = oku[1].ToString();
                            kelimeyok = false;
                        }
                    }
                }

                if (radioButton2.Checked)
                {
                    while (oku.Read())
                    {
                        if (arama == oku[1].ToString())
                        {
                            label2.Text = oku[0].ToString();
                            kelimeyok = false;
                        }
                    }
                }

                oku.Close();
                baglanti.Close();

                if (kelimeyok)
                    MessageBox.Show("Aradığınız kelime bulunmamaıştır...");
            }
            else
                MessageBox.Show("Lütfen değer girdikten sonra arama butonuna basınız...");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            label2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            label2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
    }
}
