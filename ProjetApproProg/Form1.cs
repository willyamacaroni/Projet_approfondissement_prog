using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetApproProg
{
    public partial class frmPrincipal : Form
    {
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
    }
}
