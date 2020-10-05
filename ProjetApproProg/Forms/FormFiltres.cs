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
    }
}
