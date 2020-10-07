using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetApproProg
{
    public partial class FormFiltres : Form
    {
        #region CheckBoxes
        public CheckBoxModifie ChkCondition
        {
            get { return chkCond; }
            set { chkCond = value; }
        }

        public CheckBoxModifie ChkNote
        {
            get { return chkNote; }
            set { chkNote = value; }
        }

        public CheckBoxModifie ChkPrix
        {
            get { return chkPrix; }
            set { chkPrix = value; }
        }

        #endregion

        #region ValeursChamps

        public TextBox TxtPrixA
        {
            get { return txtPrixA; }
            set { txtPrixA = value; }
        }

        public TextBox TxtPrixDe
        {
            get { return txtPrixDe; }
            set { txtPrixDe = value; }
        }

        public ComboBox CmbCondition
        {
            get { return cmbCondition; }
            set { cmbCondition = value; }
        }

        public NoteEtoiles NoteEtoiles
        {
            get { return noteEtoiles; }
            set { noteEtoiles = value; }
        }

        #endregion

        #region Constructeur
        public FormFiltres()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 49, 29, 63);
            this.btnOK.BackColor = Color.FromArgb(255 * 80 / 100, 226, 62, 87);
            this.btnCancel.BackColor = Color.FromArgb(255 * 80 / 100, 226, 62, 87);
            this.cmbCondition.SelectedIndex = 0;
        }
        #endregion

        #region Events
        private void txtPrixDe_Enter(object sender, EventArgs e)
        {
            if (this.txtPrixDe.Text.Equals("De:"))
            {
                this.txtPrixDe.Text = String.Empty;
                this.txtPrixDe.ForeColor = Color.Black;
            }
        }

        private void txtPrixDe_Leave(object sender, EventArgs e)
        {
            if (this.txtPrixDe.Text.Equals(""))
            {
                this.txtPrixDe.Text = "De:";
                this.txtPrixDe.ForeColor = Color.LightGray;
            }
        }

        private void txtPrixA_Enter(object sender, EventArgs e)
        {
            if (this.txtPrixA.Text.Equals("À:"))
            {
                this.txtPrixA.Text = String.Empty;
                this.txtPrixA.ForeColor = Color.Black;
            }
        }

        private void txtPrixA_Leave(object sender, EventArgs e)
        {
            if (this.txtPrixA.Text.Equals(""))
            {
                this.txtPrixA.Text = "À:";
                this.txtPrixA.ForeColor = Color.LightGray;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Gestionnaire.RecupererFiltres(this);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
