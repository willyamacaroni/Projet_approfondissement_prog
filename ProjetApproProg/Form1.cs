using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetApproProg
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 65, 55, 80);
            this.lytPanneauPrincipal.BackColor = Color.FromArgb(255/2, 0, 0, 0);
            this.pnlTop.BackColor = Color.FromArgb(255 * 80 / 100, 30, 165, 180);
            this.pnlOptions.BackColor = Color.FromArgb(255 * 80 / 100, 30, 165, 180);
            this.btnImpListe.BackColor = Color.FromArgb(255 * 80 / 100, 30, 165, 180);
            this.btnImpParam.BackColor = Color.FromArgb(255 * 80 / 100, 30, 165, 180);
            this.btnFavoris.BackColor = Color.FromArgb(255 * 80 / 100, 30, 185, 100);
            this.btnSaveParam.BackColor = Color.FromArgb(255 * 80 / 100, 30, 165, 180);
            this.btnFiltres.BackColor = Color.FromArgb(255 * 80 / 100, 30, 180, 125);
            this.btnSites.BackColor = Color.FromArgb(255 * 80 / 100, 30, 180, 125);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.txtRecherche.Text.Equals("Rechercher..."))
            {
                this.txtRecherche.Text = String.Empty;
                this.txtRecherche.ForeColor = Color.Black;
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

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
