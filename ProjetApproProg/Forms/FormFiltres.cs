﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetApproProg
{
    public partial class FormFiltres : Form
    {
        public CheckBox ChkCondition
        {
            get { return chkCondition; }
            set { chkCondition = value; }
        }

        public CheckBox ChkNote
        {
            get { return chkNote; }
            set { chkNote = value; }
        }

        public CheckBox ChkPrix
        {
            get { return chkPrix; }
            set { chkPrix = value; }
        }

        public FormFiltres()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 49, 29, 63);
            this.btnOK.BackColor = Color.FromArgb(255 * 80 / 100, 226, 62, 87);
            this.btnCancel.BackColor = Color.FromArgb(255 * 80 / 100, 226, 62, 87);
        }

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
    }
}