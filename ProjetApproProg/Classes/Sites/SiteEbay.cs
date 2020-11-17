using System;
using System.Linq;
using HtmlAgilityPack;
using ProjetApproProg.Classes;
using System.Collections.Generic;
using Fizzler.Systems.HtmlAgilityPack;

namespace ProjetApproProg
{
    /// <summary>
    /// La classe site est désignée à décrire un site à chercher.
    /// Elle est décrite par un nom, une URL et si le site est coché.
    /// </summary>
    public class SiteEbay : Site
    {
        private const string urlDeBase = "https://www.ebay.com/sch/i.html?_nkw=";

        #region Constructeurs
        public SiteEbay(bool pEstCoche) : base(pEstCoche)
        {
            Nom = "Ebay";
            ObjType = 1;
        }

        public SiteEbay()
        {
            ObjType = 1;
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

            HtmlNode page = null;
            try
            {
                page = ObtenirPage();
            }
            catch (NullReferenceException)
            {
                return null;
            }

            List<HtmlNode> lstLiProduits = page.QuerySelectorAll("li div[class*='s-item__wrapper']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string url = produit.QuerySelector("a").GetAttributeValue("href", "").Trim();
                    string urlImage = produit.QuerySelector("img").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("h3").InnerText.Trim();
                    string prix = produit.QuerySelector("span[class='s-item__price']").InnerText.Trim();
                    lstProduits.Add(new Produit(url, urlImage, titre, prix, "Ebay"));
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