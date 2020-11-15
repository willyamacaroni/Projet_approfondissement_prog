using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetApproProg.Affichage_Produit;
using ProjetApproProg.Classes;

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
            foreach (Produit produit in Gestionnaire.LstProduits)
            {
                flwPrincipal.Controls.Add(new AffichageProduit(produit));
            }
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
            Gestionnaire.ExporterProduits();
        }
    }
}
