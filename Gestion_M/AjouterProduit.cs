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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gestion_M
{

    public partial class AjouterProduit : Form
    {
        Db db = new Db();
        public AjouterProduit()
        {

            InitializeComponent();
        }
        public string idClient
        {
            get { return Cmd_Client.Text; }
            set { Cmd_Client.SelectedValue = value; }
        }
        public string idP
        {
            get { return lbl_id_produit.Text; }
            set { lbl_id_produit.Text = value; }
        }
        public string idCat
        {
            get { return cmd_categorie.Text; }
            set { cmd_categorie.Text = value; }
        }
        public string status
        {
            get { return Cmd_status.Text; }
            set { Cmd_status.Text = value; }
        }
        public string marque
        {
            get { return text_marque.Text; }
            set { text_marque.Text = value; }
        }
        public string dateFin
        {
            get { return text_date.Text; }
            set { text_date.Text = value; }
        }

        public string details
        {
            get { return text_details.Text; }
            set { text_details.Text = value; }
        }
        public string prix
        {
            get { return text_prix.Text; }
            set { text_prix.Text = value; }
        }
        public string typeProblem
        {
            get { return text_type.Text; }
            set { text_type.Text = value; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void comobosta()
        {
            Cmd_status.Visible = false;
        }
        public void cmdstatusvisible()
        {
            Cmd_status.Visible = false;
            lbl_status.Visible = false;
            modofierBtn.Visible = false;



        }
        public void mofifiervisible()
        {
            Cmd_status.Visible = true;
            lbl_status.Visible = true;
            modofierBtn.Visible = true;
            Enregistrer_produit.Visible = false;
        }
        private void AjouterProduit_Load(object sender, EventArgs e)
        {

            //db.remplirCombp("libelle", "idCat", "Categorie", cmd_categorie);
            //db.remplirCombp("nom", "idClient", "Client", Cmd_Client);
            Client_Cmd();
            Categorei_Cmd();



            // db.comn("typeProblem", "Produit", text_type);








        }



        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Client_Cmd()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT idClient, nom FROM Client";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();

                    Cmd_Client.DataSource = dataTable;
                    Cmd_Client.DisplayMember = "nom";
                    Cmd_Client.ValueMember = "idClient";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }


        private void Categorei_Cmd()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "select idCat,libelle from Categorie";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    reader.Close();

                    cmd_categorie.DataSource = dataTable;
                    cmd_categorie.DisplayMember = "libelle";
                    cmd_categorie.ValueMember = "idCat";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        public void load()
        {
            Form1 fr = new Form1();
            fr.Refresh();
        }

        private void Enregistrer_produit_Click(object sender, EventArgs e)
        {
            string textdeting = text_details.Text;
            int idClient = (int)Cmd_Client.SelectedValue;
            int cmdCat = (int)cmd_categorie.SelectedValue;

            string marque = text_marque.Text;
            string date = text_date.Text;
            string prix = text_prix.Text;
            string type = text_type.Text;


            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "insert into Produit values(@idClient, @idCat, @status, @marque, getDate(), @dateFin, @details, @prix, @typeProblem)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@idClient", idClient);
                    command.Parameters.AddWithValue("@idCat", cmdCat);
                    command.Parameters.AddWithValue("@status", "En cours");
                    command.Parameters.AddWithValue("@marque", marque);
                    command.Parameters.AddWithValue("@dateFin", date);
                    command.Parameters.AddWithValue("@details", textdeting);
                    command.Parameters.AddWithValue("@prix", prix);
                    command.Parameters.AddWithValue("@typeProblem", type);
                    int rowsAffected = command.ExecuteNonQuery();
                    Form1 existingForm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    existingForm1?.AfficherDonneesProduit();
                    Form1 ton = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    ton?.Refresh();
                    Form1 ton1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    ton1?.AfficherDonneesProduitStatus();
                    AffNotification("Succes", "Enregistre avec succes ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
        private void AffNotification(string type, string Message)
        {
            ToastForm Tost = new ToastForm(type, Message);
            Tost.Show();
        }

        private void modofierBtn_Click(object sender, EventArgs e)
        {
            int idP = Convert.ToInt32(lbl_id_produit.Text);
            int idClient = (int)Cmd_Client.SelectedValue;
            int idCat = (int)cmd_categorie.SelectedValue;
            string marque = text_marque.Text;
            string status = Cmd_status.Text;
            DateTime date = Convert.ToDateTime( text_date.Text);
            string details = text_details.Text;
            float prix = Convert.ToInt32( text_prix.Text);
            string typeProblem = text_type.Text;





            Update(idP,idClient, idCat, status, marque, date, details, prix, typeProblem);
        }
        

        public void Update(int idP, int  idClient, int idCat,string status,  string marque, DateTime dateFin,string details,float prix,string typeProblem)
        {

            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Produit SET idClient = @idClient, idCat = @idCat, status = @status, marque = @marque, dateFin = @dateFin, prix = @prix, details = @details, typeProblem = @typeProblem WHERE idP = @idP";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idClient", idClient); 
                command.Parameters.AddWithValue("@idCat", idCat);
                command.Parameters.AddWithValue("@marque", marque);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@dateFin", dateFin);
                command.Parameters.AddWithValue("@details", details);
                command.Parameters.AddWithValue("@prix", prix);
                command.Parameters.AddWithValue("@typeProblem", typeProblem);
                command.Parameters.AddWithValue("@idP", idP); 
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Form1 existingForm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    existingForm1?.AfficherDonneesProduit();
                    Form1 ton = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    ton?.Refresh();
                    Form1 ton1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    ton1?.AfficherDonneesProduitStatus();

                    AffNotification("Succes", "Enregistrement mis à jour avec succès !");
                    

                }
                else
                {
                    AffNotification("Error", "La mise à jour a échoué !");
                }
            }

        }
    }
} 
    

