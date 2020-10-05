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
        public CheckBox ChkMikeShop
        {
            get { return chkMikeShop; }
            set { chkMikeShop = value; }
        }

        public CheckBox ChkAmazon
        {
            get { return chkAmazon; }
            set { chkAmazon = value; }
        }

        public CheckBox ChkNewEgg
        {
            get { return chkNewEgg; }
            set { chkNewEgg = value; }
        }

        public CheckBox ChkBestBuy
        {
            get { return chkBestBuy; }
            set { chkBestBuy = value; }
        }

        public CheckBox ChkEbay
        {
            get { return chkEbay; }
            set { chkEbay = value; }
        }

        public CheckBox ChkWalmart
        {
            get { return chkWalmart; }
            set { chkWalmart = value; }
        }

        public FormSites()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 49, 29, 63);
            this.btnOK.BackColor = Color.FromArgb(255 * 80 / 100, 226, 62, 87);
            this.btnCancel.BackColor = Color.FromArgb(255 * 80 / 100, 226, 62, 87);
        }
    }
}
