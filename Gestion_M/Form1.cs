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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Gestion_M
{
    public partial class Form1 : Form
    {
        public AjouterCategorie form2;
     
        public Form1()
        {
            form2 = new AjouterCategorie();

            InitializeComponent();
           

        }
        Db db = new Db();



       
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayCategories();
            AfficherDonneesClients();
            AfficherDonneesProduit();



        }

        public void AfficherDonneesProduit()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                string query = "SELECT * FROM Produit";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DatagreadView_Produit.DataSource = table;

            }

        }

        private void SearchClient(string searchTerm)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Client WHERE nom LIKE @searchTerm";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    DataGridClient.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la recherche de catégories : " + ex.Message);
                }
            }
        }


        private void SearchCategory(string searchTerm)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open(); 

                    string query = "SELECT * FROM Categorie WHERE libelle LIKE @searchTerm";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                   
                    Categorie.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la recherche de catégories : " + ex.Message);
                }
            }
        }

        public void AfficherDonneesClients()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                string query = "SELECT * FROM Client";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridClient.DataSource = table;

            }

        }
        public void DisplayCategories()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                string query = "SELECT * FROM Categorie";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                Categorie.DataSource = table;
              
            }
        }

        private void AffNotification(string type, string Message)
        {
            ToastForm Tost = new ToastForm(type, Message);
            Tost.Show();
        }




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

            if (DataGridClient.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridClient.SelectedRows[0];
                int index = selectedRow.Index;

                int entityId = Convert.ToInt32(selectedRow.Cells["idClient"].Value);

                using (SqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        string query = "DELETE FROM Client  WHERE idClient  = @Client ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Client", entityId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client supprimée avec succès!");
                            DataGridClient.Rows.RemoveAt(index);
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la suppression de Client.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'entité :"+ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entité à supprimer.");
            }
        }
        AjouterClient AjouterClient = new AjouterClient();

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AjouterClient.buttonClents();
            AjouterClient.renameboutton(true);

            if (DataGridClient.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow2 = DataGridClient.SelectedRows[0];
                    string Id_client = selectedRow2.Cells["idClient"].Value.ToString();
                    string Nom_client = selectedRow2.Cells["nom"].Value.ToString();
                    string Prenom_client = selectedRow2.Cells["prenom"].Value.ToString();
                    string Email_client = selectedRow2.Cells["email"].Value.ToString();
                    string Telephone_client = selectedRow2.Cells["telephone"].Value.ToString();

                    int id_conversion = int.Parse(Id_client);
                

                    using (SqlConnection connection = db.GetConnection())
                    {
                        string query = "SELECT nom, prenom, email, telephone FROM Client WHERE idClient = @idClient";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idClient", id_conversion);

                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    Nom_client = reader["nom"].ToString();
                                    Prenom_client = reader["prenom"].ToString();
                                    Email_client = reader["email"].ToString();
                                    Telephone_client = reader["telephone"].ToString();
                                }
                            }
                        }
                    }

                    AjouterClient.label_clinet = Id_client;
                    AjouterClient.Nom_clinet = Nom_client;
                    AjouterClient.Prenom_clinet = Prenom_client;
                    AjouterClient.Email_clinet = Email_client;
                    AjouterClient.Telephone_clinet = Telephone_client;
                    AjouterClient.buttonClents();
                    AjouterClient.ShowDialog();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération de la catégorie : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à modifier.");
            }
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AjouterClient fr = new AjouterClient();
            fr.renameboutton(false);
            fr.ShowDialog();
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AjouterProduit fr = new AjouterProduit();

            fr.cmdstatusvisible();
           
            fr.ShowDialog();
            fr.comobosta();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
       
            form2.HideLabel();
            form2.button();


            form2.ShowDialog();
            
            

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //timer1.Start();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (Categorie.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Categorie.SelectedRows[0];
                int index = selectedRow.Index;

                int categoryId = Convert.ToInt32(selectedRow.Cells["idCat"].Value);

                using (SqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        string query = "DELETE FROM Categorie WHERE idCat = @idCat";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idCat", categoryId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Catégorie supprimée avec succès!");
                            this.Categorie.Rows.RemoveAt(index); 
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la suppression de la catégorie.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression de la catégorie : " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à supprimer.");
            }
        }



        private void guna2Button10_Click(object sender, EventArgs e)
        {
            form2.buttonEr();
        
            if (Categorie.SelectedRows.Count > 0)
            {
                try
                {
                    
                    DataGridViewRow selectedRow = Categorie.SelectedRows[0];
                    string categoryId = selectedRow.Cells["idCat"].Value.ToString();
                    string categoryName = selectedRow.Cells["libelle"].Value.ToString();

                    
                    using (SqlConnection connection = db.GetConnection())
                    {
                        string query = "SELECT libelle FROM Categorie WHERE idCat = @idCat";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idCat", categoryId);

                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                   
                                    categoryName = reader["libelle"].ToString();
                                }
                            }
                        }
                    }

                   
                    AjouterCategorie form2 = new AjouterCategorie();
                    form2.TextBoxText = categoryName;
                    form2.label = categoryId;
                    form2.buttonEr();
                    form2.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération de la catégorie : " + ex.Message);
                }
            }
            else
            {
               
                MessageBox.Show("Veuillez sélectionner une catégorie à modifier.");
            }
           
        }



        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void tabPage4_Click(object sender, EventArgs e)
            {

            }

            private void guna2Button9_Click_1(object sender, EventArgs e)
            {
            }

        private void Categorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            string searchTerm = textRecherch.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                SearchCategory(searchTerm);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un terme de recherche.");
            }
        }
        private void DataGridClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void recherch_Click(object sender, EventArgs e)
        {
            string searchTerm = rrcherch.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                SearchClient(searchTerm);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un terme de recherche.");
            }
        }
        
        AjouterProduit ajouterp = new AjouterProduit();

        private void btn_modifier_Click(object sender, EventArgs e)
        {

            if (DatagreadView_Produit.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow2 = DatagreadView_Produit.SelectedRows[0];
                    int idP, idClient, idCat;
                    string status, marque, details, typeProblem;
                    DateTime datecreation, datefin;
                    float prix;

                    if (selectedRow2.Cells["idP"].Value != null && selectedRow2.Cells["idClient"].Value != null &&
                        selectedRow2.Cells["idCat"].Value != null && selectedRow2.Cells["status"].Value != null &&
                        selectedRow2.Cells["marque"].Value != null && selectedRow2.Cells["dateCreation"].Value != null &&
                        selectedRow2.Cells["dateFin"].Value != null && selectedRow2.Cells["details"].Value != null &&
                        selectedRow2.Cells["prix"].Value != null && selectedRow2.Cells["typeProblem"].Value != null)
                    {
                        idP = Convert.ToInt32(selectedRow2.Cells["idP"].Value);
                        idClient = Convert.ToInt32(selectedRow2.Cells["idClient"].Value);
                        idCat = Convert.ToInt32(selectedRow2.Cells["idCat"].Value);
                        status = selectedRow2.Cells["status"].Value.ToString();
                        marque = selectedRow2.Cells["marque"].Value.ToString();
                        datecreation = Convert.ToDateTime(selectedRow2.Cells["dateCreation"].Value);
                        datefin = Convert.ToDateTime(selectedRow2.Cells["dateFin"].Value);
                        details = selectedRow2.Cells["details"].Value.ToString();
                        float.TryParse(selectedRow2.Cells["prix"].Value.ToString(), out prix);
                        typeProblem = selectedRow2.Cells["typeProblem"].Value.ToString();

                        using (SqlConnection connection = db.GetConnection())
                        {
                            string query = "SELECT idP,idClient,idCat,status,marque,dateCreation,dateFin,details,prix,typeProblem FROM Produit WHERE idP = @idP";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@idP", idP);

                                connection.Open();

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        idP = (int)reader["idP"];
                                        idClient = (int)reader["idClient"];
                                        idCat = (int)reader["idCat"];
                                        status = reader["status"].ToString();
                                        marque = reader["marque"].ToString();
                                        datecreation = (DateTime)reader["dateCreation"];
                                        datefin = (DateTime)reader["dateFin"];
                                        details = reader["details"].ToString();
                                        float.TryParse(reader["prix"].ToString(), out prix);
                                        typeProblem = reader["typeProblem"].ToString();
                                    }
                                }
                            }
                        }

                        // Assuming `ajouterp` is an instance of your class where you want to assign these values
                        ajouterp.status = status;
                        ajouterp.marque = marque;
                        ajouterp.details = details;
                        ajouterp.idP = Convert.ToString(idP);
                        ajouterp.idClient = Convert.ToString(idClient);
                        ajouterp.idCat = Convert.ToString(idCat);
                        ajouterp.status = status;
                        ajouterp.marque = marque;
                        ajouterp.dateFin = Convert.ToString(datefin);
                        ajouterp.details = details;
                        ajouterp.prix = Convert.ToString(prix);
                        ajouterp.mofifiervisible();
                        ajouterp.ShowDialog();
                        // assign other properties as needed
                    }
                    else
                    {
                        MessageBox.Show("Une ou plusieurs colonnes sélectionnées contiennent des valeurs nulles.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération de la catégorie : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à modifier.");
            }

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (DatagreadView_Produit.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DatagreadView_Produit.SelectedRows[0];
                int index = selectedRow.Index;

                int entityId = Convert.ToInt32(selectedRow.Cells["idP"].Value);

                using (SqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        string query = "DELETE FROM Produit  WHERE idP  = @Produit ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Produit", entityId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produit supprimée avec succès!");
                            DatagreadView_Produit.Rows.RemoveAt(index);
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la suppression de Produit.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'entité :" + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entité à supprimer.");
            }
        }
    }




        
    }
    