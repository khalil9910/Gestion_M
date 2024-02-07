using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_M
{
    public partial class AjouterClient : Form
    {
        public AjouterClient()
        {
            InitializeComponent();
        }

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
                AffNotification("Succes", "Tous les champs sont vides.");

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
    }
}
