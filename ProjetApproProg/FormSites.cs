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
    public partial class FormSites : Form
    {
        public FormSites()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 65, 55, 80);
            this.btnOK.BackColor = Color.FromArgb(255 * 80 / 100, 30, 180, 125);
            this.btnCancel.BackColor = Color.FromArgb(255 * 80 / 100, 30, 180, 125);
        }
    }
}
