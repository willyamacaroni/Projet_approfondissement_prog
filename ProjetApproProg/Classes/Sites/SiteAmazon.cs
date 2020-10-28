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
    public class SiteAmazon : Site
    {
        private const string urlDeBase = "https://www.amazon.ca/s?k=";

        #region Constructeur
        public SiteAmazon(bool pEstCoche) : base(pEstCoche)
        {
            Nom = "Amazon";
        }
        #endregion

        #region Méthodes

        public override void ConstruireURL(string pRecherche)
        {
            List<Filtre> lstFiltres = Gestionnaire.LstFiltres;
            string filtres = "";
            bool peutAvoirFiltreNote = true;
            bool peutAvoirFiltrePrix = true;
            if (lstFiltres.Count != 0)
            {
                foreach (Filtre filtre in lstFiltres)
                {
                    switch (filtre.Nom)
                    {
                        case "Condition":
                            FiltreCondition filtreCondition = (FiltreCondition)filtre;
                            switch (filtreCondition.Condition)
                            {
                                case Condition.Neuf:
                                    //Cette option est celle "de base" sur amazon
                                    break;
                                case Condition.RemisANeuf:
                                    filtres += "&i=specialty-aps&srs=17351028011";
                                    peutAvoirFiltrePrix = false;
                                    break;
                                case Condition.Usagee:
                                    filtres += "&i=warehouse-deals";
                                    peutAvoirFiltreNote = false;
                                    break;
                            }
                            break;
                        case "Note":
                            if (peutAvoirFiltreNote)
                            {
                                FiltreNote filtreNote = (FiltreNote)filtre;
                                switch (filtreNote.Note)
                                {
                                    case 1:
                                        filtres += "&rh=p_72%3A11192167011";
                                        break;
                                    case 2:
                                        filtres += "&rh=p_72%3A11192168011";
                                        break;
                                    case 3:
                                        filtres += "&rh=p_72%3A11192169011";
                                        break;
                                    case 4:
                                        filtres += "&rh=p_72%3A11192170011";
                                        break;
                                    case 5:
                                        filtres += "&rh=p_72%3A11192170011";
                                        break;
                                }
                            }
                            break;
                        case "Prix":
                            if (peutAvoirFiltrePrix)
                            {
                                FiltrePrix filtrePrix = (FiltrePrix)filtre;
                                double prixDebut = Convert.ToDouble(filtrePrix.PrixDebut);
                                double prixFin = Convert.ToDouble(filtrePrix.PrixFin);
                                prixDebut = Math.Round(prixDebut);
                                prixFin = Math.Round(prixFin);
                                filtres += String.Format("&rh=p_36%3A{0}-{1}", prixDebut * 100, prixFin * 100);
                            }
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

            List<HtmlNode> lstLiProduits = page.QuerySelectorAll("div[class*='sg-col-4-of-24']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string urlImage = produit.QuerySelector("img[class='s-image']").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("span[class*='a-']").InnerText.Trim();
                    string prix = produit.QuerySelector("span[class*='a-offscreen']").InnerText.Trim();
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
