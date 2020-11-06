namespace ProjetApproProg
{ 
    /// <summary>
    /// La classe filtre est une classe mère pour les 3 types de filtres:
    /// Filtre par prix, par note et par condition.
    /// Un filtre contient un nom, une valeur et s'il à été sélectionné.
    /// </summary>
    public abstract class Filtre
    {
        #region Attributs

        private bool _estCoche;
        private string _nom;
        private int _objType;

        #endregion

        #region GetSet

        public int ObjType
        {
            get { return _objType; }
            set { _objType = value; }
        }
        public bool EstCoche
        {
            get { return _estCoche; }
            set { _estCoche = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        #endregion

        #region Constructeurs
        protected Filtre(bool pEstCoche, string pNom)
        {
            EstCoche = pEstCoche;
            Nom = pNom;
        }

        public Filtre()
        {
            
        }

        #endregion
    }
}
