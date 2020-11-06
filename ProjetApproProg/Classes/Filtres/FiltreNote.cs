namespace ProjetApproProg
{
    /// <summary>
    /// La classe FiltreNote à pour valeur une note.
    /// La note sélectionnée par l'utilisateur.
    /// </summary>
    class FiltreNote : Filtre
    {
        #region Attributs

        private int _note;

        #endregion

        #region GetSet
        public int Note
        {
            get { return _note; }
            set { _note = value; }
        }

        #endregion

        #region Contructeurs
        public FiltreNote(bool pEstCoche, string pNom, int pNote) : base(pEstCoche, pNom)
        {
            Note = pNote;
            ObjType = 1;
        }

        public FiltreNote()
        {
            ObjType = 1;
        }

        #endregion
    }
}
