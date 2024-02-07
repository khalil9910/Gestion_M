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
        public Form1()
        {
            InitializeComponent();
        }
        Db db = new Db();

        private void Form1_Load(object sender, EventArgs e)
        {
           DisplayCategories();
            //timer1.Start();
         
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
            AjouterCategorie fr = new AjouterCategorie();
            fr.ShowDialog();
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

                int categoryId = Convert.ToInt32(selectedRow.Cells["idCat"].Value); // Assuming "CategoryID" is the name of the column containing the category ID

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
                            DisplayCategories(); // Refresh the DataGridView
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
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à supprimer.");
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }
    }
}