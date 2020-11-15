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
    public class SiteWalmart : Site
    {
        private const string urlDeBase = "https://www.walmart.com/search/?query=";

        #region Constructeurs
        public SiteWalmart(bool pEstCoche) : base (pEstCoche)
        {
            Nom = "Walmart";
            ObjType = 5;
        }

        public SiteWalmart()
        {
            ObjType = 5;
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
                        case "Condition":
                            filtres += "";
                            FiltreCondition filtreCondition = (FiltreCondition)filtre;
                            switch (filtreCondition.Condition)
                            {
                                case Condition.Neuf:
                                    filtres += "&facet=condition%3ANew";
                                    break;
                                case Condition.RemisANeuf:
                                    filtres += "&facet=condition%3ARefurbished";
                                    break;
                                case Condition.Usagee:
                                    filtres += "&facet=condition%3AUsed";
                                    break;
                            }
                            break;
                        case "Note":
                            filtres += "&sfacet=customer_rating%";
                            FiltreNote filtreNote = (FiltreNote)filtre;
                            switch (filtreNote.Note)
                            {
                                case 1:
                                    filtres += "3A1+-+1.9+Stars";
                                    break;
                                case 2:
                                    filtres += "3A2+-+2.9+Stars";
                                    break;
                                case 3:
                                    filtres += "3A3+-+3.9+Stars";
                                    break;
                                case 4:
                                    filtres += "3A4+-+4.9+Stars";
                                    break;
                                case 5:
                                    filtres += "3A4+-+5+Stars";
                                    break;
                            }
                            break;
                        case "Prix":
                            FiltrePrix filtrePrix = (FiltrePrix)filtre;
                            filtres += String.Format("&max_price={1}&min_price={0}", filtrePrix.PrixDebut, filtrePrix.PrixFin);
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

            List<HtmlNode> lstLiProduits = page.QuerySelectorAll("div[data-product-id]").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string urlImage = produit.QuerySelector("img[data-automation]").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("p[data-automation*='name']").InnerText.Trim();
                    string prix = produit.QuerySelector("span[data-automation*='current-price']").InnerText.Trim();
                    lstProduits.Add(new Produit(urlImage, titre, prix, "Walmart"));
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
