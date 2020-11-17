using System;
using System.Windows.Forms;
using ProjetApproProg.Classes;
using ProjetApproProg.Affichage_Produit;

namespace ProjetApproProg.Forms
{
    public partial class FormProduits : Form
    {
        private bool estCollapsed = true;
        
        public FormProduits()
        {
            InitializeComponent();
            AfficherProduits();
        }

        private void AfficherProduits()
        {
            flwPrincipal.Controls.Clear();
            foreach (Produit produit in Gestionnaire.LstProduits)
            {
                flwPrincipal.Controls.Add(new AffichageProduit(produit));
            }

            this.lblNbProduits.Text = "Produits: " + flwPrincipal.Controls.Count;
        }

        private void btnOrdonner_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (estCollapsed)
            {
                pnlOrdonner.Height += 10;
                if (pnlOrdonner.Height >= 400)
                {
                    pnlOrdonner.Height = 400;
                    timer1.Stop();
                    estCollapsed = false;
                }
            }
            else
            {
                pnlOrdonner.Height -= 10;
                if (pnlOrdonner.Height <= 65)
                {
                    pnlOrdonner.Height = 65;
                    timer1.Stop();
                    estCollapsed = true;
                }

            }
        }

        private void btnExporterProduits_Click(object sender, EventArgs e)
        {
            if (Gestionnaire.LstProduits.Count != 0)
            {
                Gestionnaire.ExporterProduits();
            }
            else
            {
                MessageBox.Show("Aucun produit à enregistrer.",
                    "Attention!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void flwPrincipal_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.lblNbProduits.Text = "Produits: " + flwPrincipal.Controls.Count;
        }

        private void btnPrixCroissant_Click(object sender, EventArgs e)
        {
            Gestionnaire.OrdonnerSelonPrixCroissant();
            AfficherProduits();
        }

        private void btnPrixDecroissant_Click(object sender, EventArgs e)
        {
            Gestionnaire.OrdonnerSelonPrixDecroissant();
            AfficherProduits();
        }

        private void btnTitreCroissant_Click(object sender, EventArgs e)
        {
            Gestionnaire.OrdonnerSelonTitreCroissant();
            AfficherProduits();
        }

        private void btnTitreDecroissant_Click(object sender, EventArgs e)
        {
            Gestionnaire.OrdonnerSelonTitreDecroissant();
            AfficherProduits();
        }

        private void btnSiteCroissant_Click(object sender, EventArgs e)
        {
            Gestionnaire.OrdonnerSelonSiteCroissant();
            AfficherProduits();
        }

        private void btnSiteDecroissant_Click(object sender, EventArgs e)
        {
            Gestionnaire.OrdonnerSelonSiteDecroissant();
            AfficherProduits();
        }
    }
}
