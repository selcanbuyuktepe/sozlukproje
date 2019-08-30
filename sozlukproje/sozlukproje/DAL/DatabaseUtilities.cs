using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozlukproje.DAL
{
    class DatabaseUtilities
    {
        private static string DbName = "sozlukselcan";
        private static string DbPath = "";

        private SqlConnection Baglanti = new SqlConnection();
        private SqlCommand Komut = new SqlCommand();
        private SqlDataAdapter adtr = new SqlDataAdapter();
        private DataSet ds = new DataSet();
      

        public DataTable GetTableBySQL(string sqlSorgu)
        {
            Baglanti.ConnectionString = GetConnectionString();
            Komut.CommandText = sqlSorgu;
            Komut.Connection = Baglanti;

            adtr.SelectCommand = Komut;
            adtr.Fill(ds);
            Baglanti.Open();
            var table = ds.Tables[0];
            Baglanti.Close();
            return table;
        }
        public void CommandExcuteBySQLWithParameters(string sqlSorgu, List<Parameters> parameters)
        {
            Baglanti.ConnectionString = GetConnectionString();
            Baglanti.Open();
            Komut.CommandText = sqlSorgu;

            foreach (var parameter in parameters)
            {
                Komut.Parameters.AddWithValue(parameter.Name, parameter.Value);
            }
            Komut.Connection = Baglanti;
            Komut.ExecuteNonQuery();
            Baglanti.Close();


        }
        private string GetConnectionString()
        {
            return $"Data Source = LAPTOP - J7GRRQ81; Initial Catalog = { DbName }; Integrated Security = True";
            //return $" Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog={DbName};Integrated Security=True";
        }

    }

}

