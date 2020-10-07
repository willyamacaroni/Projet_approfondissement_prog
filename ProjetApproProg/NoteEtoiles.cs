using System.Drawing;
using System.Windows.Forms;
using ProjetApproProg;

namespace ProjetApproProg
{
    public class NoteEtoiles : Control
    {

        #region Attributs
        private TableLayoutPanel _lytPrincipal;
        private PictureBox pct1;
        private PictureBox pct2;
        private PictureBox pct3;
        private PictureBox pct4;
        private PictureBox pct5;
        private int _iEtoileCochee = 1;
        #endregion

        #region GetSet

        public int EtoileCochee
        {
            get { return _iEtoileCochee; }
            set { _iEtoileCochee = value; }
        }

        #endregion

        #region Constructeur
        public NoteEtoiles()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            CreerEvenements();
        }
        #endregion

        #region Méthodes

        private void CreerEvenements()
        {
            pct1.MouseClick += (sender, e) =>
            {
                _iEtoileCochee = 1;
                Reset();
            };

            pct2.MouseClick += (sender, e) =>
            {
                _iEtoileCochee = 2;
                Reset();
                pct1.Image = Resources.iconEtoilePleine;
                pct2.Image = Resources.iconEtoilePleine;
            };

            pct3.MouseClick += (sender, e) =>
            {
                _iEtoileCochee = 3;
                Reset();
                pct1.Image = Resources.iconEtoilePleine;
                pct2.Image = Resources.iconEtoilePleine;
                pct3.Image = Resources.iconEtoilePleine;
            };

            pct4.MouseClick += (sender, e) =>
            {
                _iEtoileCochee = 4;
                Reset();
                pct1.Image = Resources.iconEtoilePleine;
                pct2.Image = Resources.iconEtoilePleine;
                pct3.Image = Resources.iconEtoilePleine;
                pct4.Image = Resources.iconEtoilePleine;
            };

            pct5.MouseClick += (sender, e) =>
            {
                _iEtoileCochee = 5;
                Reset();
                pct1.Image = Resources.iconEtoilePleine;
                pct2.Image = Resources.iconEtoilePleine;
                pct3.Image = Resources.iconEtoilePleine;
                pct4.Image = Resources.iconEtoilePleine;
                pct5.Image = Resources.iconEtoilePleine;
            };

        }

        private void Reset()
        {
            pct2.Image = Resources.iconEtoileVide;
            pct3.Image = Resources.iconEtoileVide;
            pct4.Image = Resources.iconEtoileVide;
            pct5.Image = Resources.iconEtoileVide;
        }

        #endregion

        #region Initialisation Des Composantes

        private void InitializeComponent()
        {
            this._lytPrincipal = new TableLayoutPanel();
            this.pct1 = new PictureBox();
            this.pct2 = new PictureBox();
            this.pct3 = new PictureBox();
            this.pct4 = new PictureBox();
            this.pct5 = new PictureBox();
            this._lytPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct5)).BeginInit();
            this.SuspendLayout();
            // 
            // _lytPrincipal
            // 
            this._lytPrincipal.ColumnCount = 5;
            this._lytPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this._lytPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this._lytPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this._lytPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this._lytPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this._lytPrincipal.Controls.Add(this.pct5, 4, 0);
            this._lytPrincipal.Controls.Add(this.pct4, 3, 0);
            this._lytPrincipal.Controls.Add(this.pct3, 2, 0);
            this._lytPrincipal.Controls.Add(this.pct2, 1, 0);
            this._lytPrincipal.Controls.Add(this.pct1, 0, 0);
            this._lytPrincipal.Dock = DockStyle.Fill;
            this._lytPrincipal.Location = new Point(0, 0);
            this._lytPrincipal.Name = "_lytPrincipal";
            this._lytPrincipal.RowCount = 1;
            this._lytPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this._lytPrincipal.Size = new Size(1000, 200);
            this._lytPrincipal.TabIndex = 0;
            // 
            // pct1
            // 
            this.pct1.Dock = DockStyle.Fill;
            this.pct1.Image = Resources.iconEtoilePleine;
            this.pct1.Location = new Point(3, 3);
            this.pct1.Name = "pct1";
            this.pct1.Size = new Size(194, 194);
            this.pct1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct1.TabIndex = 0;
            this.pct1.TabStop = false;
            // 
            // pct2
            // 
            this.pct2.Dock = DockStyle.Fill;
            this.pct2.Image = Resources.iconEtoileVide;
            this.pct2.Location = new Point(203, 3);
            this.pct2.Name = "pct2";
            this.pct2.Size = new Size(194, 194);
            this.pct2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct2.TabIndex = 1;
            this.pct2.TabStop = false;
            // 
            // pct3
            // 
            this.pct3.Dock = DockStyle.Fill;
            this.pct3.Image = Resources.iconEtoileVide;
            this.pct3.Location = new Point(403, 3);
            this.pct3.Name = "pct3";
            this.pct3.Size = new Size(194, 194);
            this.pct3.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct3.TabIndex = 2;
            this.pct3.TabStop = false;
            // 
            // pct4
            // 
            this.pct4.Dock = DockStyle.Fill;
            this.pct4.Image = Resources.iconEtoileVide;
            this.pct4.Location = new Point(603, 3);
            this.pct4.Name = "pct4";
            this.pct4.Size = new Size(194, 194);
            this.pct4.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct4.TabIndex = 3;
            this.pct4.TabStop = false;
            // 
            // pct5
            // 
            this.pct5.Dock = DockStyle.Fill;
            this.pct5.Image = Resources.iconEtoileVide;
            this.pct5.Location = new Point(803, 3);
            this.pct5.Name = "pct5";
            this.pct5.Size = new Size(194, 194);
            this.pct5.SizeMode = PictureBoxSizeMode.Zoom;
            this.pct5.TabIndex = 4;
            this.pct5.TabStop = false;
            // 
            // UserControl1
            // 
            //this.AutoScaleDimensions = new SizeF(8F, 16F);
            //this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this._lytPrincipal);
            this.Name = "NoteEtoiles";
            this.Size = new Size(1000, 200);
            this._lytPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct5)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

    }
}
