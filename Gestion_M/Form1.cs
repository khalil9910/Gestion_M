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
                      //timer1.Start();

        }

        private void SearchCategory(string searchTerm)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open(); // Open the connection

                    string query = "SELECT * FROM Categorie WHERE libelle LIKE @searchTerm";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Assuming you have a DataGridView named dgvCategories to display the results
                    Categorie.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la recherche de catégories : " + ex.Message);
                }
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
            // AjouterCategorie fr = new AjouterCategorie();
            // btmo.visible = false;
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
                            this.Categorie.Rows.RemoveAt(index); // Remove the row from DataGridView
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
            // form2.ShowDialog();
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
    }
    }