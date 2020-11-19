using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using ProjetApproProg.Classes;
using System.Collections.Generic;

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
        private string _nom;
        private int _objType;


        #endregion
        
        #region GetSet
        public int ObjType
        {
            get { return _objType; }
            set { _objType = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

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
        
        #region Constructeurs
        public Site(bool pEstCoche)
        {
            EstCoche = pEstCoche;
        }

        public Site()
        {

        }

        #endregion

        #region Méthodes


        /// <summary>
        /// Permet d'obtenir une page html sous forme de HtmlNode à
        /// partir de l'URL appartenant à l'objet site qui appelle la méthode.
        /// </summary>
        /// <returns>Retourne le HtmlNode (page web)</returns>
        protected HtmlNode ObtenirPage()
        {

            HtmlNode page = null;

            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("--headless");

            FirefoxDriverService services = FirefoxDriverService.CreateDefaultService();
            services.HideCommandPromptWindow = true;

            FirefoxProfile profile = new FirefoxProfile();
            profile.EnableNativeEvents = true;
            profile.SetPreference("network.cookie.cookieBehavior", 0);

            using (IWebDriver driver = new FirefoxDriver(services, options))
            {
                driver.Navigate().GoToUrl(UrlRecherche);

                HtmlDocument doc = new HtmlDocument();

                doc.LoadHtml(driver.PageSource);

                page = doc.DocumentNode.SelectSingleNode("//body");
            }

            return page;
        }

        /// <summary>
        /// Permet de construire l'URL selon les paramètres de recherche (Filtres + Recherche).
        /// Celle-ci est gardé en mémoire dans l'attribut _urlRecherche
        /// </summary>
        /// <param name="pRecherche">Recherche que l'utilisateur a entré dans la barre de recherche</param>
        public abstract void ConstruireURL(string pRecherche);

        /// <summary>
        /// Sera implanté dans les classes enfants.
        /// Permet d'obtenir les produits de la page html retourné par la méthode ObtenirPage().
        /// </summary>
        /// <returns>Retourne une liste d'objets produit</returns>
        public abstract List<Produit> Scrap();

        #endregion
    }
}
