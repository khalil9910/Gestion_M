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
    
    public partial class AjouterProduit : Form
    {
        Db db = new Db();
        public AjouterProduit()
        {
         
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterProduit_Load(object sender, EventArgs e)
        {

           db. remplirCombp("libelle", "idCat", "Categorie", categoryComboBox);
            db.remplirCombp("nom", "idClient", "Client", client);


            db.comn("typeProblem", "Produit", type);








        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            }

        }
    }

