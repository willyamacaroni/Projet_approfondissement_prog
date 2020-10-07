using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetApproProg.Classes
{
    class FiltrePrix : Filtre
    {
        private string _prixDebut;
        private string _prixFin;

        public string PrixDebut
        {
            get { return _prixDebut; }
            set
            {
                /*
                if (value == "" || value == "De:")
                    _prixDebut = "0";

                bool contientLettre = false;
                foreach (char c in value)
                {
                    if (!(Char.IsDigit(c)))
                        contientLettre = true;
                }

                if (!contientLettre)
                    _prixDebut = value;
                */
                _prixDebut = value;
            }
        }

        public string PrixFin
        {
            get { return _prixFin; }
            set
            {
                /*
                if (value == "" || value == "À:")
                    _prixDebut = "0";
                bool contientLettre = false;
                foreach (char c in value)
                {
                    if (!(Char.IsDigit(c)))
                        contientLettre = true;
                }
                
                if (!contientLettre)
                    _prixFin = value;
                */
                _prixFin = value;
            }
        }

        public FiltrePrix(bool pIsChecked, string pNom, string pPrixDebut, string pPrixFin) : base(pIsChecked, pNom)
        {

            PrixDebut = pPrixDebut;
            PrixFin = pPrixFin;
        }
    }
}
