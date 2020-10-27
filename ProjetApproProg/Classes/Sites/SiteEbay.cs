using System;
using System.Collections.Generic;
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
        private const string nom = "Ebay";

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

        #endregion
    }
}