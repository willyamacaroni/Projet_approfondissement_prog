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
            this.BackColor = Color.FromArgb(25, 20, 30);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.txtRecherche.Text = String.Empty;
            this.txtRecherche.ForeColor = Color.Black;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

        }
    }
}
