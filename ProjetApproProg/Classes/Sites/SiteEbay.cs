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
    public class SiteEbay : Site
    {
        private const string urlDeBase = "https://www.ebay.com/sch/i.html?_nkw=";

        #region Constructeur
        public SiteEbay(bool pEstCoche) : base(pEstCoche)
        {
        }

        #endregion

        #region Méthodes

        public override void ConstruireURL(string pRecherche)
        {
            List<Filtre> lstFiltres = Gestionnaire.LstFiltresCoches;
            string filtres = "";
            if (lstFiltres.Count != 0)
            {
                foreach (Filtre filtre in lstFiltres)
                {
                    switch (filtre.Nom)
                    {
                        case "Condition":
                            filtres += "&LH_ItemCondition=";
                            FiltreCondition filtreCondition = (FiltreCondition) filtre;
                            switch (filtreCondition.Condition)
                            {
                                case Condition.Neuf:
                                    filtres += "3";
                                    break;
                                case Condition.RemisANeuf:
                                    filtres += "2500";
                                    break;
                                case Condition.Usagee:
                                    filtres += "4";
                                    break;
                            }

                            break;
                        case "Note":
                            // Pas une option sur ebay... À faire plus tard
                            break;
                        case "Prix":
                            FiltrePrix filtrePrix = (FiltrePrix) filtre;
                            filtres += String.Format("&_udlo={0}&_udhi={1}", filtrePrix.PrixDebut, filtrePrix.PrixFin);
                            break;
                    }
                }
            }
            string URL = urlDeBase + pRecherche + filtres;
            UrlRecherche = URL;
        }

        public override List<Produit> Scrap()
        {
            
            List<HtmlNode> lstLiProduits = ObtenirPage().QuerySelector("ul[class='srp-results srp-list clearfix']").QuerySelectorAll("li[class*='s-item']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string urlImage = produit.QuerySelector("img[class*='s-item__image-img']").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("h3[class*='s-item__title']").InnerText.Trim();
                    string prix = produit.QuerySelector("div[class*='item__detail--primary']").QuerySelector("span").InnerText.Trim();
                    lstProduits.Add(new Produit(urlImage, titre, prix));
                }
                catch
                {
                    continue;
                }
            }

            return lstProduits;
        }

        #endregion
    }
}