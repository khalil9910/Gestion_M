using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gestion_M
{
    public partial class AjouterClient : Form
    {

        Db db = new Db();
        public AjouterClient()
        {
            InitializeComponent();
        }
        public string Nom_clinet
        {
            get { return Inp_Nom_Client.Text; }
            set { Inp_Nom_Client.Text = value; }
        }

        public string Prenom_clinet
        {
            get { return Inp_Prenom_Client.Text; }
            set { Inp_Prenom_Client.Text = value; }
        }

        public string Email_clinet
        {
            get { return Inp_Email_Client.Text; }
            set { Inp_Email_Client.Text = value; }
        }

        public string Telephone_clinet
        {
            get { return Inp_Telephone_Client.Text; }
            set { Inp_Telephone_Client.Text = value; }
        }
        public string label_clinet
        {
            get { return lbl_id_clinet.Text; }
            set { lbl_id_clinet.Text = value; }
        }
        public void Hidelbl_id_clinet(bool val)
        {
            lbl_id_clinet.Visible = val;
           
        }
        public void renameboutton(bool val)
        {

            Modifier_CLIENT.Text = "Modifier";
            Modifier_CLIENT.Visible = val;

        }
        public void buttonClents()
        {
            guna2Button3.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RefreshClient()
        {

            Form1 existingForm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();


            if (existingForm1 != null)
            {
                existingForm1.AfficherDonneesClients();
            }
        }
        private void AffNotification(string type, string Message)
        {
            ToastForm Tost = new ToastForm(type, Message);
            Tost.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Hidelbl_id_clinet(false);
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
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Client (nom, prenom, email, telephone) VALUES (@Nom, @Prenom, @Email, @Telephone)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nom", valeurNom);
                        command.Parameters.AddWithValue("@Prenom", valeurPrenom);
                        command.Parameters.AddWithValue("@Email", valeurEmail);
                        command.Parameters.AddWithValue("@Telephone", valeurTelephone);
                        command.ExecuteNonQuery();
                    }

                }
                Form1 existingForm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                existingForm1?.AfficherDonneesClients();
                AffNotification("Succes", "Enregistre avec succes ");
               
            }


        }

        private void AjouterClient_Load(object sender, EventArgs e)
        {

        }

        private void Inp_Nom_Client_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Modifier_CLIENT_Click(object sender, EventArgs e)
        {
            int id_clinet = Convert.ToInt32(lbl_id_clinet.Text);

            string valeurNom = Inp_Nom_Client.Text;
            string valeurPrenom = Inp_Prenom_Client.Text;
            string valeurEmail = Inp_Email_Client.Text;
            string valeurTelephone = Inp_Telephone_Client.Text; ;
            Update(valeurNom, valeurPrenom, valeurEmail, valeurTelephone, id_clinet);
        }

        public void Update(string nom, string prenom, string email, string telephone, int id)
        {
          
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Client SET nom = @Nom, prenom = @Prenom, email = @Email, telephone = @Telephone WHERE idClient = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nom", nom);
                command.Parameters.AddWithValue("@Prenom", prenom);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Telephone", telephone);
                command.Parameters.AddWithValue("@ID", id);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Form1 existingForm1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    existingForm1?.AfficherDonneesClients();
                    AffNotification("Succes", "Enregistrement mis à jour avec succès !");
                   

                }
                else
                {
                    AffNotification("Error", "La mise à jour a échoué !");
                }
            }
        }

        private void Inp_Email_Client_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inp_Telephone_Client_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inp_Prenom_Client_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_clinet_Click(object sender, EventArgs e)
        {

        }
    }
}
