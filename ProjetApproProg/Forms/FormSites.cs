using System.Drawing;
using System.Windows.Forms;

namespace ProjetApproProg
{

    public partial class FormSites : Form
    {
        #region CheckBoxes
        public CheckBoxModifie ChkMikeShop
        {
            get { return chkMikeShop; }
            set { chkMikeShop = value; }
        }

        public CheckBoxModifie ChkAmazon
        {
            get { return chkAmazon; }
            set { chkAmazon = value; }
        }

        public CheckBoxModifie ChkNewEgg
        {
            get { return chkNewEgg; }
            set { chkNewEgg = value; }
        }

        public CheckBoxModifie ChkBestBuy
        {
            get { return chkBestBuy; }
            set { chkBestBuy = value; }
        }

        public CheckBoxModifie ChkEbay
        {
            get { return chkEbay; }
            set { chkEbay = value; }
        }

        public CheckBoxModifie ChkWalmart
        {
            get { return chkWalmart; }
            set { chkWalmart = value; }
        }
        #endregion

        #region Constructeur
        public FormSites()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 49, 29, 63);
            this.btnOK.BackColor = Color.FromArgb(255 * 80 / 100, 226, 62, 87);
            this.btnCancel.BackColor = Color.FromArgb(255 * 80 / 100, 226, 62, 87);
        }
        #endregion

        #region Events
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            Gestionnaire.RecupererSites(this);
            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void FormSites_Load(object sender, System.EventArgs e)
        {
            CocherSites();
        }
        #endregion

        #region Méthodes

        /// <summary>
        /// La méthode CocherSites permet la persistence des données et la mise à jour de celles-ci.
        /// Elle permet de cocher ce que l'utilisateur avait coché précédemment ou selon des paramètres importés.
        /// </summary>
        /// <param name="pFormSites">Le formSites qui contient les sites à chocher.</param>
        private void CocherSites()
        {
            if (Gestionnaire.LstSitesCoches.Count > 0)
            {
                foreach (Site site in Gestionnaire.LstSitesCoches)
                {
                    switch (site.Nom)
                    {
                        case "Amazon":
                            this.ChkAmazon.EstCoche = true;
                            break;
                        case "BestBuy":
                            this.ChkBestBuy.EstCoche = true;
                            break;
                        case "Ebay":
                            this.ChkEbay.EstCoche = true;
                            break;
                        case "MikeShop":
                            this.ChkMikeShop.EstCoche = true;
                            break;
                        case "NewEgg":
                            this.ChkNewEgg.EstCoche = true;
                            break;
                        case "Walmart":
                            this.ChkWalmart.EstCoche = true;
                            break;
                    }
                }
            }
        }

        #endregion
    }
}
