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
    public partial class AjouterClient : Form
    {
        public AjouterClient()
        {
            InitializeComponent();
        }
        Db db = new Db();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AffNotification(string type, string Message)
        {
            ToastForm Tost = new ToastForm(type, Message);
            Tost.Show();
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string valeurNom = Inp_Nom_Client.Text;
            string valeurPrenom = Inp_Prenom_Client.Text;
            string valeurEmail = Inp_Email_Client.Text;
            string valeurTelephone = Inp_Telephone_Client.Text;

            if (string.IsNullOrEmpty(valeurNom) && string.IsNullOrEmpty(valeurPrenom) && string.IsNullOrEmpty(valeurEmail) && string.IsNullOrEmpty(valeurTelephone))
            {
                AffNotification("Error", "Tous les champs sont vides.");
            }
            else
            {
                // Connexion à la base de données
                using (SqlConnection con = db.GetConnection())
                {
                    // Vérifier si la connexion est fermée
                    if (con.State == ConnectionState.Closed)
                    {
                        // Ouvrir la connexion
                        con.Open();
                    }

                    // Commande SQL d'insertion avec des paramètres pour éviter les attaques par injection SQL
                    string sqlInsertQuery = "INSERT INTO Client (nom, prenom, email, telephone) VALUES (@Nom, @Prenom, @Email, @Telephone)";

                    // Création de la commande SQL
                    using (SqlCommand command = new SqlCommand(sqlInsertQuery, con))
                    {
                        // Ajout des valeurs des paramètres
                        command.Parameters.AddWithValue("@Nom", valeurNom);
                        command.Parameters.AddWithValue("@Prenom", valeurPrenom);
                        command.Parameters.AddWithValue("@Email", valeurEmail);
                        command.Parameters.AddWithValue("@Telephone", valeurTelephone);

                        // Exécution de la commande SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Vérification si des lignes ont été affectées (c'est-à-dire si l'insertion a réussi)
                        if (rowsAffected > 0)
                        {
                            AffNotification("Succes", "Données ajoutées avec succès à la base de données");
                        }
                        else
                        {
                            AffNotification("Error", "Erreur lors de l'ajout des données à la base de données.");
                        }
                    }
                }
            }
        }

    }
}
