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
            LoadProblems();

            // DisplayCategories();
            //AfficherDonneesClients();
            LoadClients();
            AfficherDonneesProduit();
            LoadCategories();
            AfficherDonneesProduitStatus();

        }

        public void AfficherDonneesProduitStatus()
        {
            string query = "SELECT * FROM Produit WHERE status = 'Terminé'";
            DataTable dt = new DataTable();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dt);

                    maintenance.DataSource = null;
                    maintenance.Rows.Clear();
                    maintenance.Columns.Clear();
                    maintenance.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }


        private void ReloadDataGridView(DateTime selectedDate)
        {
            string query = "SELECT c.nom AS Nom_Client, cat.libelle AS Nom_Categorie,p.idP,p.status,p.marque,p.details,p.prix,p.typeProblem,p.dateFin,p.dateCreation " +
                               "FROM Produit p " +
                               "INNER JOIN Client c ON p.idClient = c.idClient " +
                               "INNER JOIN Categorie cat ON p.idCat = cat.idCat WHERE CONVERT(date, dateCreation) = @selectedDate";

            using (SqlConnection connection = db.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedDate", selectedDate.Date);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DatagreadView_Produit.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
                    }
                }
            }
        }


        public void AfficherDonneesProduit()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                string query = "SELECT  c.nom AS Nom_Client, cat.libelle AS Nom_Categorie,p.idP,p.status,p.marque,p.details,p.prix,p.typeProblem,p.dateFin,p.dateCreation " +
                               "FROM Produit p " +
                               "INNER JOIN Client c ON p.idClient = c.idClient " +
                               "INNER JOIN Categorie cat ON p.idCat = cat.idCat";

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
                    //MessageBox.Show("Erreur lors de la recherche de catégories : " + ex.Message);
                    LoadClients();
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
        public void LoadClients()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT idClient,nom ,prenom,email,telephone FROM Client WHERE Visible = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DataGridClient.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des clients : " + ex.Message);
            }
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
                        string query = "UPDATE Client SET Visible = 0 WHERE idClient = @ClientId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ClientId", entityId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client caché avec succès!");
                            DataGridClient.Rows.RemoveAt(index);
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la cachée du client.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la cachée du client : " + ex.Message);
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
                MessageBox.Show("Veuillez sélectionner un client à cacher.");
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
            DateTime selectedDate = date.Value.Date;


            ReloadDataGridView(selectedDate);
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //timer1.Start();
        }
        public void LoadCategories()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT idCat, libelle FROM Categorie WHERE Visible = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        Categorie.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des catégories : " + ex.Message);
            }
        }


        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (Categorie.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Categorie.SelectedRows[0];
                int index = selectedRow.Index;

                int categoryId = Convert.ToInt32(selectedRow.Cells["idCat"].Value);

                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir cacher cette catégorie?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = db.GetConnection())
                        {
                            connection.Open();
                            string query = "UPDATE Categorie SET Visible = 0 WHERE idCat = @CategoryId";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@CategoryId", categoryId);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Catégorie cachée avec succès!");

                                    Categorie.Rows.RemoveAt(index);
                                }
                                else
                                {
                                    MessageBox.Show("La catégorie n'a pas été trouvée.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la cachée de la catégorie : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à cacher.");
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


        private void LoadProblems()
        {
            string query = "SELECT DISTINCT typeProblem FROM Produit";

            using (SqlConnection connection = db.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Probelem.Items.Add(reader["typeProblem"].ToString());
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
                    }
                }
            }
        }

        private void ReloadDataGridView(string selectedProblem)
        {
            string query = "SELECT * FROM Produit WHERE typeProblem = @selectedProblem";

            using (SqlConnection connection = db.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedProblem", selectedProblem);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DatagreadView_Produit.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
                    }
                }
            }
        }

        private void LoadStatusForProblem(string selectedProblem)
        {
            Status.Items.Clear();

            if (selectedProblem.Equals("TOUS", StringComparison.OrdinalIgnoreCase))
            {
                ReloadDataGridView("TOUS", "TOUS");
                return;
            }

            string query = "SELECT DISTINCT status FROM Produit WHERE typeProblem = @selectedProblem";

            using (SqlConnection connection = db.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedProblem", selectedProblem);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Status.Items.Add(reader["status"].ToString());
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
                    }
                }
            }
        }



        private void ReloadDataGridView(string selectedStatus, string selectedProblem)
        {
            string query;
            if (selectedStatus.Equals("TOUS", StringComparison.OrdinalIgnoreCase))
            {
                query = "SELECT c.nom AS Nom_Client, cat.libelle AS Nom_Categorie,p.idP,p.status,p.marque,p.details,p.prix,p.typeProblem,p.dateFin,p.dateCreation " +
                        "FROM Produit p " +
                        "INNER JOIN Client c ON p.idClient = c.idClient " +
                        "INNER JOIN Categorie cat ON p.idCat = cat.idCat "
                        ;
            }
            else
            {
                query = "SELECT c.nom AS Nom_Client, cat.libelle AS Nom_Categorie,p.idP,p.status,p.marque,p.details,p.prix,p.typeProblem,p.dateFin,p.dateCreation " +
                        "FROM Produit p " +
                        "INNER JOIN Client c ON p.idClient = c.idClient " +
                        "INNER JOIN Categorie cat ON p.idCat = cat.idCat " +
                        "WHERE status = @status AND typeProblem = @selectedProblem";
            }

            using (SqlConnection connection = db.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@status", selectedStatus);
                    command.Parameters.AddWithValue("@selectedProblem", selectedProblem);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DatagreadView_Produit.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
                    }
                }
            }
        }


        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Probelem.SelectedItem != null)
            {
                string selectedProblem = Probelem.SelectedItem.ToString();
                LoadStatusForProblem(selectedProblem);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Status.SelectedItem != null && Probelem.SelectedItem != null)
            {
                string selectedStatus = Status.SelectedItem.ToString();
                string selectedProblem = Probelem.SelectedItem.ToString();
                ReloadDataGridView(selectedStatus, selectedProblem);
            }
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
                LoadCategories();
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
                // MessageBox.Show("Veuillez entrer un terme de recherche.");
                LoadClients();
            }
        }

        AjouterProduit ajouterp = new AjouterProduit();

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (DatagreadView_Produit.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = DatagreadView_Produit.SelectedRows[0];

                    if (selectedRow.Cells["idP"].Value != null &&
                        selectedRow.Cells["Nom_Client"].Value != null &&
                        selectedRow.Cells["Nom_Categorie"].Value != null &&
                        selectedRow.Cells["status"].Value != null &&
                        selectedRow.Cells["marque"].Value != null &&
                        selectedRow.Cells["dateCreation"].Value != null &&
                        selectedRow.Cells["dateFin"].Value != null &&
                        selectedRow.Cells["details"].Value != null &&
                        selectedRow.Cells["prix"].Value != null &&
                        selectedRow.Cells["typeProblem"].Value != null)
                    {
                        int idP = Convert.ToInt32(selectedRow.Cells["idP"].Value);
                        string idClient = selectedRow.Cells["Nom_Client"].Value.ToString();
                        string idCat = selectedRow.Cells["Nom_Categorie"].Value.ToString();
                        string status = selectedRow.Cells["status"].Value.ToString();
                        string marque = selectedRow.Cells["marque"].Value.ToString();
                        DateTime datecreation = Convert.ToDateTime(selectedRow.Cells["dateCreation"].Value);
                        DateTime datefin = Convert.ToDateTime(selectedRow.Cells["dateFin"].Value);
                        string details = selectedRow.Cells["details"].Value.ToString();
                        float prix;
                        float.TryParse(selectedRow.Cells["prix"].Value.ToString(), out prix);
                        string typeProblem = selectedRow.Cells["typeProblem"].Value.ToString();

                        using (SqlConnection connection = db.GetConnection())
                        {
                            string query = "SELECT c.nom AS Nom_Client, cat.libelle AS Nom_Categorie, p.idP, p.status, p.marque, p.details, p.prix, p.typeProblem, p.dateFin, p.dateCreation " +
                                           "FROM Produit p " +
                                           "INNER JOIN Client c ON p.idClient = c.idClient " +
                                           "INNER JOIN Categorie cat ON p.idCat = cat.idCat " +
                                           "WHERE p.idP = @idP";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@idP", idP);

                                connection.Open();

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        status = reader["status"].ToString();
                                        marque = reader["marque"].ToString();
                                        datecreation = (DateTime)reader["dateCreation"];
                                        datefin = (DateTime)reader["dateFin"];
                                        details = reader["details"].ToString();
                                        float.TryParse(reader["prix"].ToString(), out prix);
                                        typeProblem = reader["typeProblem"].ToString();
                                        idClient = reader["Nom_Client"].ToString();
                                        idCat = reader["Nom_Categorie"].ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Produit non trouvé dans la base de données.");
                                        return;
                                    }
                                }
                            }
                        }

                        AjouterProduit ajouterp = new AjouterProduit();
                        ajouterp.status = status;
                        ajouterp.marque = marque;
                        ajouterp.details = details;
                        ajouterp.idP = idP.ToString();
                        ajouterp.idClient = idClient;
                        ajouterp.idCat = idCat;
                        ajouterp.status = status;
                        ajouterp.marque = marque;
                        ajouterp.dateFin = datefin.ToString();
                        ajouterp.details = details;
                        ajouterp.prix = prix.ToString();
                        ajouterp.mofifiervisible();
                        ajouterp.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Une ou plusieurs colonnes sélectionnées contiennent des valeurs nulles.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération : " + ex.Message);
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

        private void imprimer_Click(object sender, EventArgs e)
        {
            using (Facture f = new Facture())
            {
                f.ShowDialog();

                using (SqlConnection connection = db.GetConnection())
                {
                    if (maintenance.SelectedRows.Count > 0)
                    {
                        int selectedRowIndex = maintenance.SelectedRows[0].Index;
                        string idProduit = maintenance.Rows[selectedRowIndex].Cells["idP"].Value.ToString();

                        string query = "SELECT p.idP, p.marque, p.prix, c.nom AS Nom_Client " +
                                       "FROM Produit p " +
                                       "INNER JOIN Client c ON p.idClient = c.idClient " +
                                       "WHERE p.idP = @idProduit";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idProduit", idProduit);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Produit");

                        if (ds.Tables["Produit"].Rows.Count > 0)
                        {
                            FactutreClient cr = new FactutreClient();
                            cr.SetDataSource(ds);
                            f.ShowReport(cr);
                        }
                        else
                        {
                            MessageBox.Show("No client information found for the selected ID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a row in the DataGridView first.");
                    }
                }
            }
        }



    }
}

    