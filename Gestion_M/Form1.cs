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
<<<<<<< HEAD

=======
>>>>>>> 0e619fbb6a8356cc568c9fd2dc4d2747ad3a1a07
namespace Gestion_M
{
    public partial class Form1 : Form
    {
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
        }
        Db db = new Db();
<<<<<<< HEAD
        private Timer timer;
        private void Form1_Load(object sender, EventArgs e)
        {

          


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            ChargerDonneesDansDataGridView();
        }






        public void ChargerDonneesDansDataGridView()
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

                        // Liaison du DataGridView (GV_CLIENT) au DataSet
                        GV_CLINET.DataSource = ds;
                        GV_CLINET.DataMember = "Client";
                    }
=======


        private void Form1_Load(object sender, EventArgs e)
        {
            ChargerCategories();
           



        }

       public void ChargerCategories()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des catégories : " + ex.Message);
>>>>>>> 0e619fbb6a8356cc568c9fd2dc4d2747ad3a1a07
                }
            }
        }


        //private void AffNotification(string type , string Message)
        //{
        //    ToastForm Tost = new ToastForm(type, Message);
        //    Tost.Show();
        //}




        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AjouterClient fr = new AjouterClient();
            fr.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

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

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}