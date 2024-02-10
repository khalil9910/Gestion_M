using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;

namespace Gestion_M
{
    class Db
    {
      
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
                // Ensure connection is closed before returning
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return connection;
        }
    }
}


