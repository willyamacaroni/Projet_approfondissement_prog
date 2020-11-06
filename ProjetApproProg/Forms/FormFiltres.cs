using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetApproProg
{
    public partial class FormFiltres : Form
    {
        #region GetSetCheckBoxes
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
            // Le "De:" sert de placeholder,
            // on veut l'effacer quand on entre dans le champ
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

        private void FormFiltres_Load(object sender, EventArgs e)
        {
            CocherFiltres();
            
            if (!this.txtPrixDe.Text.Equals("De:"))
            {
                this.txtPrixDe.ForeColor = Color.Black;
            }

            if (!this.txtPrixA.Text.Equals("À:"))
            {
                this.txtPrixA.ForeColor = Color.Black;
            }
        }

        #endregion

        #region Méthodes

        private void CocherFiltres()
        {
            if (Gestionnaire.LstFiltresCoches.Count > 0)
            {
                foreach (Filtre filtre in Gestionnaire.LstFiltresCoches)
                {
                    switch (filtre.Nom)
                    {
                        case "Condition":
                            FiltreCondition filtreCondition = (FiltreCondition)filtre;
                            this.ChkCondition.EstCoche = true;
                            this.CmbCondition.SelectedIndex = (int)filtreCondition.Condition;
                            break;
                        case "Note":
                            FiltreNote filtreNote = (FiltreNote)filtre;
                            this.ChkNote.EstCoche = true;
                            this.NoteEtoiles.EtoileCochee = filtreNote.Note;
                            break;
                        case "Prix":
                            FiltrePrix filtrePrix = (FiltrePrix)filtre;
                            this.ChkPrix.EstCoche = true;
                            this.TxtPrixDe.Text = filtrePrix.PrixDebut;
                            this.TxtPrixA.Text = filtrePrix.PrixFin;
                            break;
                    }
                }
            }
        }

        #endregion
    }
}
