using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;



namespace Gestion_M
{
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }

        private void Facture_Load(object sender, EventArgs e)
        {

        }
        public void ShowReport(ReportDocument reportDocument)
        {
            crystalReportViewer2.ReportSource = reportDocument;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
