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
    }
}
