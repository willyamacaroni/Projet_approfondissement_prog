using HtmlAgilityPack;

namespace ProjetApproProg
{
    /// <summary>
    /// La classe site est désignée à décrire un site à chercher.
    /// Elle est décrite par un nom, une URL et si le site est coché.
    /// </summary>
    public abstract class Site
    {
        #region Attributs

        private bool _estCoche;
        private string _nom;
        private string _url;

        #endregion
        
        #region Constructeur
        public Site(bool pEstCoche, string pNom, string pUrl)
        {
            EstCoche = pEstCoche;
            Nom = pNom;
            Url = pUrl;
        }

        #endregion

        #region GetSet
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

        #endregion

        #region Méthodes

        public abstract (string, HtmlNode) ObtenirPage(string pRecherche);

        #endregion
    }
}
