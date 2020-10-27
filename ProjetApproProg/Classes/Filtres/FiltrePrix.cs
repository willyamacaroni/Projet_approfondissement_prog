namespace ProjetApproProg.Classes
{

    /// <summary>
    /// La classe FiltrePrix à pour valeur un étandu prix.
    /// L'étandu inscrit par l'utilisateur.
    /// </summary>
    class FiltrePrix : Filtre
    {
        #region Attributs

        private string _prixDebut;
        private string _prixFin;

        #endregion

        #region GetSet
        public string PrixDebut
        {
            get { return _prixDebut; }
            set
            {
                /* # Validation avant assingation #
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

        #endregion

        #region Constructeur
        public FiltrePrix(bool pEstCoche, string pNom, string pPrixDebut, string pPrixFin) : base(pEstCoche, pNom)
        {

            PrixDebut = pPrixDebut;
            PrixFin = pPrixFin;
        }

        #endregion
    }
}
