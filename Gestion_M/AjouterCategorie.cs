using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Gestion_M
{
    public partial class AjouterCategorie : Form
    {
        Db db = new Db();
        public AjouterCategorie()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string nomCategorie = Inp_Nom_Client.Text;

            if (!string.IsNullOrWhiteSpace(nomCategorie))
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    try
                    {
                       
                        string query = "INSERT INTO Categorie (libelle) VALUES (@libelle)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@libelle", nomCategorie);

                      
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Catégorie ajoutée avec succès !");
                            Inp_Nom_Client.Clear();
                     
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'ajout de la catégorie.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout de la catégorie : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom de catégorie.");
            }
           
        }



        private void AjouterCategorie_Load(object sender, EventArgs e)
        {

        }
    }
}
    
