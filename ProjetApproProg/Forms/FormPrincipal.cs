﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetApproProg.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjetApproProg
{
    public partial class frmPrincipal : Form
    {
        #region Constructeur

        public frmPrincipal()
        {
            InitializeComponent();
            Color btnCote = Color.FromArgb(255 * 80 / 100, 136, 48, 78);
            Color btnOptions = Color.FromArgb(255 * 80 / 100, 226, 62, 87);
            Color backColor = Color.FromArgb(255 / 2, 82, 37, 70);
            this.BackColor = Color.FromArgb(255, 49, 29, 63);
            this.lytPanneauPrincipal.BackColor = backColor;
            this.pnlTop.BackColor = backColor;
            this.pnlOptions.BackColor = backColor;
            this.btnSaveProd.BackColor = btnCote;
            this.btnImpProd.BackColor = btnCote;
            this.btnImpParam.BackColor = btnCote;
            this.btnSaveParam.BackColor = btnCote;
            this.btnFiltres.BackColor = btnOptions;
            this.btnSites.BackColor = btnOptions;
            Gestionnaire.LstFiltres = new List<Filtre>();
            Gestionnaire.LstSites = new List<Site>();

        }
        #endregion

        #region Events
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.txtRecherche.Text.Equals("Rechercher..."))
            {
                this.txtRecherche.Text = String.Empty;
                this.txtRecherche.ForeColor = Color.Black;
            }
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (this.txtRecherche.Text.Equals(""))
            {
                this.txtRecherche.Text = "Rechercher...";
                this.txtRecherche.ForeColor = Color.LightGray;
            }
        }

        private void btnSites_Click(object sender, EventArgs e)
        {

            FormSites frmSites = new FormSites();

            if (frmSites.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnFiltres_Click(object sender, EventArgs e)
        {
            FormFiltres frmFiltres = new FormFiltres();

            if (frmFiltres.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnSaveParam_Click(object sender, EventArgs e)
        {
            Gestionnaire.ExporterParamteres();
        }

        private void btnImpParam_Click(object sender, EventArgs e)
        {
            Gestionnaire.ImporterParametres();
        }
        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            if (Gestionnaire.LstProduits != null)
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
            else
            {
                MessageBox.Show("Aucun produit à enregistrer.",
                    "Attention!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnImpProd_Click(object sender, EventArgs e)
        {
            Gestionnaire.ImporterProduits();
        }

        private async void btnRecherche_Click(object sender, EventArgs e)
        {
            this.pbChargeRecherche.Visible = true;
            this.btnRecherche.Enabled = false;
            this.txtRecherche.Enabled = false;
            
            await Task.Run(() => Gestionnaire.Rechercher(this.txtRecherche.Text));

            this.pbChargeRecherche.Visible = false;
            this.btnRecherche.Enabled = true;
            this.txtRecherche.Enabled = true;

            if (Gestionnaire.LstProduits.Count > 0)
            {
                FormProduits frmProduits = new FormProduits();

                if (frmProduits.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        #endregion

        private void btnTuto_Click(object sender, EventArgs e)
        {
            FormVideo formVideo = new FormVideo();
            if (formVideo.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
