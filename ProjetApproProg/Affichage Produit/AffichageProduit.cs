using System;
using System.Windows.Forms;
using ProjetApproProg.Classes;
using System.Collections.Generic;

namespace ProjetApproProg.Affichage_Produit
{
    public partial class AffichageProduit : UserControl
    {

        private Produit _produit;

        private List<Produit> _lstPorduits;

        private List<Produit> LstProduit
        {
            get { return _lstPorduits; }
            set { _lstPorduits = value; }
        }

        private Produit Produit
        {
            get { return _produit; }
            set { _produit = value; }
        }

        private PictureBox PctImagePoduit
        {
            get { return pctImagePoduit; }
            set { pctImagePoduit = value; }
        }

        private Label LblPrix
        {
            get { return lblPrix; }
            set { lblPrix = value; }
        }

        private Label LblTitre
        {
            get { return lblTitre; }
            set { lblTitre = value; }
        }

        private Label LblSite
        {
            get { return lblSite; }
            set { lblSite = value; }
        }

        public AffichageProduit(Produit pProduit)
        {
            InitializeComponent();
            Produit = pProduit;
            LblTitre.Text = Produit.Titre;
            LblPrix.Text = Produit.Prix;
            lblSite.Text += Produit.Site;
            PctImagePoduit.Load(Produit.UrlImage.Replace(".webp", ".jpg"));
        }

        private void btnSupprProduit_Click(object sender, EventArgs e)
        {
            Gestionnaire.LstProduits.Remove(Produit);
            Parent.Controls.Remove(this);
            Dispose();
        }

        private void btnOuvrirPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Produit.Url);
        }
    }
}
