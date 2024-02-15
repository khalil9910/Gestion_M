using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Gestion_M
{
    class Db
    {
        public void remplirCombp(string column, string id, string table, ComboBox combo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string req = "select " + column + "," + id + " from " + table;
                DataSet ds = new DataSet();
                SqlDataAdapter dr = new SqlDataAdapter(req, con);
                dr.Fill(ds, table);
                combo.DataSource = ds.Tables[table];
                combo.DisplayMember = column;
                combo.ValueMember = id;
            }



        }
        public void comn(string column, string table, ComboBox combo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string req = "SELECT DISTINCT " + column + " FROM " + table;
                SqlCommand command = new SqlCommand(req, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    combo.Items.Add(reader[column].ToString());
                }

                reader.Close();
            }
        }






        private string connectionString = "Data Source=.;Initial Catalog=Gestion_M;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connexion à la base de données SQL Server réussie.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la connexion à la base de données : " + ex.Message);
            }
            finally
            {
             
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return connection;
        }
    }

}


