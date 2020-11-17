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
    public class SiteNewEgg : Site
    {
        private const string urlDeBase = "https://www.newegg.com/p/pl?d=";

        #region Constructeurs
        public SiteNewEgg(bool pEstCoche) : base(pEstCoche)
        {
            Nom = "NewEgg";
            ObjType = 2;
        }

        public SiteNewEgg()
        {
            ObjType = 2;
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
                            filtres += "&N=";
                            FiltreCondition filtreCondition = (FiltreCondition)filtre;
                            switch (filtreCondition.Condition)
                            {
                                case Condition.Neuf:
                                    filtres += "4814";
                                    break;
                                case Condition.RemisANeuf:
                                    filtres += "4016";
                                    break;
                                case Condition.Usagee:
                                    filtres += "4823";
                                    break;
                            }
                            break;
                        case "Note":
                            if (filtres.Contains("&N="))
                                filtres += "%20";
                            else
                                filtres += "&N=";
                            FiltreNote filtreNote = (FiltreNote) filtre;
                            switch (filtreNote.Note)
                            {
                                case 1:
                                    filtres += "4111";
                                    break;
                                case 2:
                                    filtres += "4112";
                                    break;
                                case 3:
                                    filtres += "4113";
                                    break;
                                case 4:
                                    filtres += "4114";
                                    break;
                                case 5:
                                    filtres += "4115";
                                    break;
                            }
                            break;
                        case "Prix":
                            FiltrePrix filtrePrix = (FiltrePrix)filtre;
                            filtres += String.Format("&LeftPriceRange={0}+{1}", filtrePrix.PrixDebut, filtrePrix.PrixFin);
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

            List<HtmlNode> lstLiProduits = page.QuerySelectorAll("div[class='item-cell'] div[class='item-container']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string url = produit.QuerySelector("a").GetAttributeValue("href", "").Trim();
                    string urlImage = produit.QuerySelector("img").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("a[class='item-title']").InnerText.Trim();
                    string prix = "$" + produit.QuerySelector("li[class*='price-current'] strong").InnerText.Trim() + produit.QuerySelector("li[class*='price-current'] sup").InnerText.Trim();
                    lstProduits.Add(new Produit(url, urlImage, titre, prix, this.Nom));
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
