using System;
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
    public class SiteMike : Site
    {
        private const string urlDeBase = "https://mikescomputershop.com/catalog/?q=";

        #region Constructeurs

        public SiteMike(bool pEstCoche) : base(pEstCoche)
        {
            Nom = "MikeShop";
            ObjType = 3;
        }

        public SiteMike()
        {
            ObjType = 3;
        }

        #endregion

        #region Méthodes

        public override void ConstruireURL(string pRecherche)
        {
           List<Filtre> lstFiltresCochee = Gestionnaire.LstFiltresCoches;
            string filtres = "";
            if (lstFiltresCochee.Count != 0)
            {
                foreach (Filtre filtre in lstFiltresCochee)
                {
                    switch (filtre.Nom)
                    {
                        //Mike Computer Shop n'offre pas les filtres "Condition" et "Note"
                        case "Prix":
                            FiltrePrix filtrePrix = (FiltrePrix)filtre;
                            filtres += String.Format("&p={0}-{1}", filtrePrix.PrixDebut, filtrePrix.PrixFin);
                            break;
                    }
                }
            }

            string URL = urlDeBase + pRecherche + filtres;
            UrlRecherche = URL;

        }


        public override List<Produit> Scrap()
        {
            HtmlNode page = null;
            try
            {
                page = ObtenirPage();
            }
            catch (NullReferenceException)
            {
                return null;
            }

            List<HtmlNode> lstLiProduits = page.QuerySelectorAll("div[class*='row catalog-product']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string urlImage = produit.QuerySelector("img[class*='product-img']").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("span[itemprop*='name']").InnerText.Trim();
                    string prix = produit.QuerySelector("span[class*='product-price']").InnerText.Trim();
                    lstProduits.Add(new Produit(urlImage, titre, prix));
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return lstProduits;

        }

        #endregion
    }
}
