namespace ProjetApproProg
{
    #region Enum

    /// <summary>
    /// Les trois conditions proposés en filtration.
    /// </summary>
    enum Condition
    {
        Neuf,
        RemisANeuf,
        Usagee
    }
    #endregion

    #region Classe

    /// <summary>
    /// La classe FiltreCondition est un filtre qui détient comme valeur une condition.
    /// La condition est celle sélectionnée par l'utilisateur.
    /// </summary>
    class FiltreCondition : Filtre
    {
        #region Attributs

        private Condition _condition;

        #endregion

        #region GetSet
        public Condition Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        #endregion

        #region Constructeurs
        public FiltreCondition(bool pEstCoche, string pNom, Condition pCondition) : base(pEstCoche, pNom)
        {
            Condition = pCondition;
            ObjType = 0;
        }

        public FiltreCondition()
        {
            ObjType = 0;
        }

        #endregion

    }
    #endregion
}
