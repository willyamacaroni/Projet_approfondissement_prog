using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProjetApproProg.Classes;

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
            this.btnImpListe.BackColor = btnCote;
            this.btnImpParam.BackColor = btnCote;
            this.btnFavoris.BackColor = btnCote;
            this.btnSaveParam.BackColor = btnCote;
            this.btnFiltres.BackColor = btnOptions;
            this.btnSites.BackColor = btnOptions;

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
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Title = "Enregistrer un fichier de paramètres";
                // SFD.Filter = "Fichier JSON (*.JSON)|*.JSON| Fichier CSV (*.CSV)|*.CSV";
                SFD.Filter = "Fichier JSON (*.JSON)|*.JSON";

                if (SFD.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter writer = new StreamWriter(File.Create(SFD.FileName)))
                    {
                        FiltreCondition filtreCond = (FiltreCondition)Gestionnaire.LstFiltres[0];
                        FiltreNote filtreNote = (FiltreNote)Gestionnaire.LstFiltres[1];
                        FiltrePrix filtrePrix = (FiltrePrix) Gestionnaire.LstFiltres[2];

                        writer.WriteLine(JsonConvert.SerializeObject(filtreCond));
                        writer.WriteLine("@");
                        writer.WriteLine(JsonConvert.SerializeObject(filtreNote));
                        writer.WriteLine("@");
                        writer.WriteLine(JsonConvert.SerializeObject(filtrePrix));
                        writer.WriteLine("@");
                        writer.WriteLine(JsonConvert.SerializeObject(Gestionnaire.LstSites));
                    }

                }
            }

            MessageBox.Show("Vos paramètres ont été enregistrés avec succès!",
                "Succès!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnImpParam_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Title = "Ouvrir un fichier de paramètres";
                // OFD.Filter = "Fichier JSON (*.JSON)|*.JSON| Fichier CSV (*.CSV)|*.CSV";
                OFD.Filter = "Fichier JSON (*.JSON)|*.JSON";

                if (OFD.ShowDialog() == DialogResult.OK)
                {

                    using (StreamReader lecteur = new StreamReader(File.OpenRead(OFD.FileName)))
                    {
                        string rawJson = lecteur.ReadToEnd();
                        string[] filtresEtSites = rawJson.Split('@');

                        FiltreCondition filtreCond = JsonConvert.DeserializeObject<FiltreCondition>(filtresEtSites[0].Trim());
                        FiltreNote filtreNote = JsonConvert.DeserializeObject<FiltreNote>(filtresEtSites[1].Trim());
                        FiltrePrix filtrePrix = JsonConvert.DeserializeObject<FiltrePrix>(filtresEtSites[2].Trim());
                        
                        List<Site> lstSites = JsonConvert.DeserializeObject<List<Site>>(filtresEtSites[3].Trim());
                        
                        List<Filtre> lstFiltres = new List<Filtre>();
                        lstFiltres.Add(filtreCond);
                        lstFiltres.Add(filtreNote);
                        lstFiltres.Add(filtrePrix);
                        
                        Gestionnaire.LstFiltres = lstFiltres;
                        Gestionnaire.LstSites = lstSites;
                    }
                }
            }
        }

        #endregion
    }
}
