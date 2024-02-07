using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_M
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Db db;

        public Form1()
        {
            InitializeComponent();
            // Initialisez le Timer
            timer = new Timer();
            // Définissez l'intervalle du Timer en millisecondes (par exemple, 5000 pour 5 secondes)
            timer.Interval = 1000;
            // Abonnez-vous à l'événement Tick du Timer
            timer.Tick += Timer_Tick;
            // Démarrez le Timer
            timer.Start();
            db = new Db();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ChargerDonneesDansDataGridView();
        }

        public void ChargerDonneesDansDataGridView()
        {
            try
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

                    // Commande SQL de sélection des données de la table Client
                    string sqlSelectQuery = "SELECT nom, prenom, email, telephone FROM Client";

                    // Création de la commande SQL
                    using (SqlCommand command = new SqlCommand(sqlSelectQuery, con))
                    {
                        // Création d'un DataAdapter pour récupérer les données
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Création d'un DataSet pour stocker les données
                            DataSet ds = new DataSet();

                            // Remplir le DataSet avec les données de la table Client
                            adapter.Fill(ds, "Client");

                            // Liaison du DataGridView (GV_CLINET) au DataSet
                            GV_CLINET.DataSource = ds.Tables["Client"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChargerCategories();
        }

        public void ChargerCategories()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    // Créer la commande SQL pour sélectionner toutes les catégories
                    string query = "SELECT * FROM Categorie";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Remplir un DataSet avec les résultats de la requête
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Categorie");

                    // Lier le DataGridView avec le DataSet
                    dataGridViewCategories.DataSource = dataSet.Tables["Categorie"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des catégories : " + ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AjouterClient fr = new AjouterClient();
            fr.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AjouterProduit fr = new AjouterProduit();
            fr.ShowDialog();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            AjouterCategorie fr = new AjouterCategorie();
            fr.ShowDialog();
        }
    }
}
