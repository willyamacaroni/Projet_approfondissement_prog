namespace ProjetApproProg
{ 
    public abstract class Filtre
    {
        private bool _estCoche;
        private string _nom;

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

        protected Filtre(bool pIsChecked, string pNom)
        {
            EstCoche = pIsChecked;
            Nom = pNom;
        }
    }
}
