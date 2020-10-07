namespace ProjetApproProg.Classes
{
    enum Condition
    {
        Neuf = 0,
        RemisANeuf,
        Usagee
    }
    class FiltreCondition : Filtre
    {
        private Condition _condition;

        public Condition Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        public FiltreCondition(bool pIsChecked, string pNom, Condition pCondition) : base(pIsChecked, pNom)
        {
            Condition = pCondition;
        }
    }
}
