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
      
        public string TextBoxText
        {
            get { return Inp_Nom_Categorie.Text; }
            set { Inp_Nom_Categorie.Text = value; }
        }
      

        public string label
        {
            get { return id.Text; }
            set { id.Text = value; }
        }
        public AjouterCategorie()
        {
            InitializeComponent();
         

        }
        public void HideLabel()
        {
            id.Visible = false;
        }
        public void button()
        {
            modofierBtn.Visible = false;
        }
        public void buttonEr()
        {
            btn_enrejerstrer.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RefreshCategories()
        {
           
            Form1 existingForm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        
            if (existingForm1 != null)
            {
                existingForm1.LoadCategories();
            }
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string nomCategorie = Inp_Nom_Categorie.Text;

            if (!string.IsNullOrWhiteSpace(nomCategorie))
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO Categorie (libelle) VALUES (@libelle)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@libelle", nomCategorie);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Catégorie ajoutée avec succès!");
                            Form1 existingForm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                            existingForm1?.LoadCategories(); 
                            Inp_Nom_Categorie.Clear();
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
       


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string nomCategorie = Inp_Nom_Categorie.Text;
            int categoryId = Convert.ToInt32(id.Text);

            if (!string.IsNullOrWhiteSpace(nomCategorie))
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        connection.Open(); 

                        string query = "UPDATE Categorie SET libelle = @libelle WHERE idCat = @categorie_id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@libelle", nomCategorie);
                        command.Parameters.AddWithValue("@categorie_id", categoryId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Catégorie mise à jour avec succès!");
                            Form1 existingForm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                            existingForm1?.LoadCategories();
                            Inp_Nom_Categorie.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la mise à jour de la catégorie.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la mise à jour de la catégorie : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom de catégorie.");
            }
        }









    }






}


    
