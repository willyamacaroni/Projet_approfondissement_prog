using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace ProjetApproProg
{
    public partial class FormVideo : Form
    {
        public FormVideo()
        {
            InitializeComponent();
        }

        private void FormVideo_Load(object sender, EventArgs e)
        {
            string filename = "videoTuto.mp4";
            string path = Path.GetFullPath(filename);

            string url = new Uri(path).AbsoluteUri;
            wmpVideo.URL = path;
            wmpVideo.Ctlcontrols.play();

            
        }

        private void FormVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }
    }
}
