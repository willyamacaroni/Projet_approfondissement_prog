using System.Drawing;
using System.Windows.Forms;

namespace ProjetApproProg
{

    public partial class FormSites : Form
    {
        #region CheckBoxes

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
            Gestionnaire.CocherSites(this);
        }
        #endregion
    }
}
