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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-J7GRRQ81;Initial Catalog=sozlukselcan;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
       
        DataSet ds = new DataSet();
        public void Yukle()
        {

            SqlDataAdapter adaptor = new SqlDataAdapter("Select * from SozlukCeviri", baglanti);
                ds = new DataSet();
             ds.Clear();
               adaptor.Fill(ds, "SozlukCeviri");
            dataGridView1.DataSource = ds.Tables["SozlukCeviri"];
            adaptor.Dispose();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu =$"UPDATE SozlukCeviri set Turkce='{textBox2.Text}',İngilizce=' { textBox3.Text  }',trcumle=' {textBox4.Text }',engcumle=' {textBox5.Text }' where Id=" + textBox1.Text;

            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


            Yukle();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir;
            satir = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
