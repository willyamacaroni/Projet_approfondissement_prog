using System.Collections.Generic;
using System.Linq;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using ProjetApproProg.Classes;

namespace ProjetApproProg
{
    /// <summary>
    /// La classe site est désignée à décrire un site à chercher.
    /// Elle est décrite par un nom, une URL et si le site est coché.
    /// </summary>
    public class SiteBestBuy : Site
    {
        private const string urlDeBase = "https://www.bestbuy.ca/fr-ca/chercher?search=";

        #region Constructeur
        public SiteBestBuy(bool pEstCoche) : base(pEstCoche)
        {
           
        }

        #endregion

        #region Méthodes

        public override void ConstruireURL(string pRecherche)
        {
            throw new System.NotImplementedException();
        }

        #region Overrides of Site

        protected override List<Produit> Scrap()
        {

            List<HtmlNode> lstLiProduits = ObtenirPage().QuerySelector("ul[class='srp-results srp-list clearfix']").QuerySelectorAll("li[class*='s-item']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                string urlImage = produit.QuerySelector("img[class*='s-item__image-img']").GetAttributeValue("src", "").Trim();
                string titre = produit.QuerySelector("h3[class*='s-item__title']").InnerText.Trim();
                string prix = produit.QuerySelector("div[class*='item__detail--primary']").QuerySelector("span").InnerText.Trim();
                lstProduits.Add(new Produit(urlImage, titre, prix));
            }

            return lstProduits;


        }

        #endregion

        #endregion
    }
}
