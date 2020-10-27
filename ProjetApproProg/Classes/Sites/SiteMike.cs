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
    public class SiteMike : Site
    {
        private const string urlDeBase = "https://mikescomputershop.com/catalog/?q=";
        private const string nom = "Mikeshop";

        #region Constructeur

        public SiteMike(bool pEstCoche) : base(pEstCoche)
        {

        }

        #endregion

        #region Méthodes

        public override void ConstruireURL(string pRecherche)
        {
           List<Filtre> lstFiltresCochee = Gestionnaire.LstFiltresCoches();
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

        #endregion
    }
}
