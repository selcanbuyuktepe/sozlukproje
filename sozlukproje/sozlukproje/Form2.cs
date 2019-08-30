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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-J7GRRQ81;Initial Catalog=sozlukselcan;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Clear();

            baglanti.Open();

            komut.CommandText = "SELECT * FROM SozlukCeviri WHERE [Turkce] LIKE '" + textBox1.Text + "%'";
            komut.Connection = baglanti;
            da = new SqlDataAdapter(komut);
            da.Fill(ds, "SozlukCeviri");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SozlukCeviri";
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
