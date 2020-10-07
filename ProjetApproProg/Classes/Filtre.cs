namespace ProjetApproProg
{ 
    abstract class Filtre
    {
        private bool _isChecked;
        private string _nom;

        public bool IsChecked
        {
            get { return _isChecked; }
            set { _isChecked = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        protected Filtre(bool pIsChecked, string pNom)
        {
            IsChecked = pIsChecked;
            Nom = pNom;
        }
    }
}
