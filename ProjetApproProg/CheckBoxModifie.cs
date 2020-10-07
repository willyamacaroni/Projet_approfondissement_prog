using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetApproProg
{
    public class CheckBoxModifie : Control
    {
        #region Attributs
        private Label _label;

        private string _textLabel = "My Checkbox";

        private Color _couleurFondText = Color.Transparent;

        private Color _couleurPoliceText = Color.Black;

        private Font _policeText = new Font("Century Gothic", 9);

        private bool _bEstCoche = false;

        private Color _couleurCrochet = Color.Black;

        private Color _couleurRectBordure = Color.Black;

        private Color _couleurRectFond = Color.White;

        private Color _couleurRectBordureHighlight = Color.FromArgb(255, 0, 120, 250);

        private Color _couleurRectFondHighlight = Color.White;

        private int _tailleRectangle = 15;

        private int _tailleBordureRect = 1;

        private bool _mouseOver = false;

        #endregion

        #region GetSet

        public bool EstCoche
        {
            get { return _bEstCoche; }
            set { _bEstCoche = value; }
        }

        public string TextLabel
        {
            get { return _textLabel; }
            set
            {
                if (_textLabel != value)
                {
                    _textLabel = value;
                    RefreshLabel();
                }
            }
        }

        public Color CouleurCrochet
        {
            get { return _couleurCrochet; }
            set
            {
                if (_couleurCrochet != value)
                {
                    _couleurCrochet = value;
                    Invalidate();
                }
            }
        }

        public Color CouleurFondText
        {
            get { return _couleurFondText; }
            set
            {
                if (_couleurFondText != value)
                {
                    _couleurFondText = value;
                    RefreshLabel();
                }
            }
        }

        public Color CouleurPoliceText
        {
            get { return _couleurPoliceText; }
            set
            {
                if (_couleurPoliceText != value)
                {
                    _couleurPoliceText = value;
                    RefreshLabel();
                }
            }
        }

        public Font PoliceText
        {
            get { return _policeText; }
            set
            {
                if (_policeText != value)
                {
                    _policeText = value;
                    RefreshLabel();
                }
            }
        }

        public Color CouleurRectBordure
        {
            get { return _couleurRectBordure; }
            set
            {
                if (_couleurRectBordure != value)
                {
                    _couleurRectBordure = value;
                    Invalidate();
                }
            }
        }

        public Color CouleurRectFond
        {
            get { return _couleurRectFond; }
            set
            {
                if (_couleurRectFond != value)
                {
                    _couleurRectFond = value;
                    Invalidate();
                }
            }
        }

        public Color CouleurRectBordureHighlight
        {
            get { return _couleurRectBordureHighlight; }
            set
            {
                if (_couleurRectBordureHighlight != value)
                {
                    _couleurRectBordureHighlight = value;
                    Invalidate();
                }
            }
        }

        public Color CouleurRectFondHighlight
        {
            get { return _couleurRectFondHighlight; }
            set
            {
                if (_couleurRectFondHighlight != value)
                {
                    _couleurRectFond = value;
                    Invalidate();
                }
            }
        }

        public int TailleRectangle
        {
            get { return _tailleRectangle; }
            set
            {
                if (_tailleRectangle != value)
                {
                    _tailleRectangle = value;
                    RefreshLabel();
                    Invalidate();
                }
            }
        }

        public int TailleBordureRect
        {
            get { return _tailleBordureRect; }
            set
            {
                if (_tailleBordureRect != value)
                {
                    _tailleBordureRect = value;
                    RefreshLabel();
                    Invalidate();
                }
            }
        }

        #endregion

        #region Constructeur
        public CheckBoxModifie()
        {
            this.Size = new Size(112, 17);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

            _label = new Label()
            {
                Font = PoliceText,
                Text = TextLabel,
                Size = this.Size,
                Location = new Point(TailleRectangle + 32, ((int)(this.Height / 2) - (PoliceText.Height / 2)))
            };

            Controls.Add(_label);

            CreerEventSouris();
        }

        #endregion

        #region Overrides

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            AfficherRectangle(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RefreshLabel();
        }

        private void CreerEventSouris()
        {
            MouseEnter += (sender, e) =>
            {
                OnCustomMouseEnter(e);
            };

            MouseLeave += (sender, e) =>
            {
                OnCustomMouseLeave(e);
            };

            MouseClick += (sender, e) =>
            {
                _bEstCoche = !_bEstCoche;
                Invalidate();
            };

            _label.MouseEnter += (sender, e) =>
            {
                OnCustomMouseEnter(e);
            };

            _label.MouseLeave += (sender, e) =>
            {
                OnCustomMouseLeave(e);
            };

            _label.MouseClick += (sender, e) =>
            {
                _bEstCoche = !_bEstCoche;
                Invalidate();
            };

        }

        private void OnCustomMouseEnter(EventArgs e)
        {
            _mouseOver = true;
            Invalidate();
        }

        private void OnCustomMouseLeave(EventArgs e)
        {
            _mouseOver = false;
            Invalidate();
        }

        #endregion

        #region CustomEvents

        private void AfficherRectangle(PaintEventArgs e)
        {
            
            Point pointDepart = new Point(
                (_label.Location.X - (TailleRectangle + TailleBordureRect)) / 2,
                Height / 2 - TailleRectangle / 2);
            
            Rectangle checkBox = new Rectangle(pointDepart, new Size(TailleRectangle, TailleRectangle));

            Color couleurFond = _mouseOver ? CouleurRectFondHighlight : CouleurRectFond;

            Color couleurBordure = _mouseOver ? CouleurRectBordureHighlight : CouleurRectBordure;

            using (SolidBrush brush = new SolidBrush(couleurFond))
            {
                e.Graphics.FillRectangle(brush, checkBox);
            }

            using (Pen pen = new Pen(couleurBordure, TailleBordureRect))
            {
                e.Graphics.DrawRectangle(pen, checkBox);
            }

            if (_bEstCoche)
            {
                Point pointCrochet = new Point(
                    (_label.Location.X - (TailleRectangle + TailleBordureRect)) / 2,
                    Height / 2 - (int)(TailleRectangle * 0.6) / 2);

                using (Font police = new Font("Wingdings", (int)(TailleRectangle * 0.6)))
                {
                    e.Graphics.DrawString("ü", police, new SolidBrush(CouleurCrochet), pointCrochet);
                }
            }
        }

        private void RefreshLabel()
        {
            if (_label == null) { return; }

            _label.Font = PoliceText;
            _label.Text = TextLabel;
            _label.ForeColor = CouleurPoliceText;
            _label.BackColor = CouleurFondText;
            _label.Size = this.Size;
            _label.Location = new Point(TailleRectangle + 32, ((int)(this.Height / 2) - (PoliceText.Height / 2)));

        }

        #endregion
    }
}
