namespace ProjetApproProg.Classes
{
    class FiltreNote : Filtre
    {
        private int _note;

        public int Note
        {
            get { return _note; }
            set { _note = value; }
        }

        public FiltreNote(bool pIsChecked, string pNom, int pNote) : base(pIsChecked, pNom)
        {
            Note = pNote;
        }
    }
}
