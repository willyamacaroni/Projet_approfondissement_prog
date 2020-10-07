namespace ProjetApproProg
{
    public class Site
    {

        private bool _estCoche;
        private string _nom;
        private string _url;

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

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public Site(bool pEstCoche, string pNom, string pUrl)
        {
            EstCoche = pEstCoche;
            Nom = pNom;
            Url = pUrl;
        }
    }
}
