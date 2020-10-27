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
        private string _urlRecherche;

        #endregion
        
        #region Constructeur
        public Site(bool pEstCoche)
        {
            EstCoche = pEstCoche;
        }

        #endregion

        #region GetSet
        public bool EstCoche
        {
            get { return _estCoche; }
            set { _estCoche = value; }
        }

        public string UrlRecherche
        {
            get { return _urlRecherche; }
            set { _urlRecherche = value; }
        }

        #endregion

        #region Méthodes

        public HtmlNode ObtenirPage()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(UrlRecherche, "GET");
            HtmlNode page = doc.DocumentNode.SelectSingleNode("//body");
            return page;
        }
        public abstract void ConstruireURL(string pRecherche);


        #endregion
    }
}
