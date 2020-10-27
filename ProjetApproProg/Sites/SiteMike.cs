using HtmlAgilityPack;

namespace ProjetApproProg
{
    /// <summary>
    /// La classe site est désignée à décrire un site à chercher.
    /// Elle est décrite par un nom, une URL et si le site est coché.
    /// </summary>
    public class SiteMike : Site

    {
        #region Constructeur

        public SiteMike(bool pEstCoche, string pNom, string pUrl) : base(pEstCoche, pNom, pUrl)
        {

        }

        #endregion

        #region Méthodes

        public override (string, HtmlNode) ObtenirPage(string pRecherche)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
