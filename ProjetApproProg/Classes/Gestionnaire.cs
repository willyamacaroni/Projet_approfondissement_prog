using System;
using ProjetApproProg.Classes;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace ProjetApproProg
{
    /// <summary>
    /// La classe Gestionnaire est une classe statique qui sert à la gestion de l'application.
    /// Elle détient une liste des filtres et une liste des sites.
    /// Ces listes servent principalement à la sauvegarde de données.
    /// La classe Gestion regroupe les méthodes nécessaires à la récupération de données et à leur gestion.
    /// </summary>
    public static class Gestionnaire
    {
        #region Attributs

        static List<Filtre> _lstFiltres;
        static List<Site> _lstSites;

        #endregion

        #region GetSet
        public static List<Filtre> LstFiltres
        {
            get { return _lstFiltres; }
            set
            {
                _lstFiltres = value;
            }
        }

        public static List<Site> LstSites
        {
            get { return _lstSites; }
            set
            {
                _lstSites = value;

            }
        }

        #endregion

        #region Méthodes

        #region Recuperer

        /// <summary>
        /// La méthode RecupererFiltres permet de récupérer les données de chaque filtre.
        /// Elle est utile à la sauvegarde de données et à la gestion des filtres.
        /// </summary>
        /// <param name="pFormFiltres">Le formFiltres qui contient les filtres à récupérer.</param>
        public static void RecupererFiltres(FormFiltres pFormFiltres)
        {
            List<Filtre> lstFiltres = new List<Filtre>();

            FiltreCondition filtreCondition = new FiltreCondition(
                pFormFiltres.ChkCondition.EstCoche,
                pFormFiltres.ChkCondition.TextLabel.Substring(0, pFormFiltres.ChkCondition.TextLabel.Length - 1),
                (Condition)pFormFiltres.CmbCondition.SelectedIndex);
            FiltreNote filtreNote = new FiltreNote(
                pFormFiltres.ChkNote.EstCoche,
                pFormFiltres.ChkNote.TextLabel.Substring(0, pFormFiltres.ChkNote.TextLabel.Length - 1),
                pFormFiltres.NoteEtoiles.EtoileCochee);
            FiltrePrix filtrePrix = new FiltrePrix(
                pFormFiltres.ChkPrix.EstCoche,
                pFormFiltres.ChkPrix.TextLabel.Substring(0, pFormFiltres.ChkPrix.TextLabel.Length - 1),
                pFormFiltres.TxtPrixDe.Text,
                pFormFiltres.TxtPrixA.Text);

            lstFiltres.Add(filtreCondition);
            lstFiltres.Add(filtreNote);
            lstFiltres.Add(filtrePrix);

            LstFiltres = lstFiltres;
        }

        /// <summary>
        /// La méthode RecupererSites permet de récupérer les données de chaque site.
        /// Elle est utile à la sauvegarde de données et à la gestion des sites.
        /// </summary>
        /// <param name="pFormSites">Le formSites qui contient les sites à récupérer.</param>
        public static void RecupererSites(FormSites pFormSites)
        {
            List<Site> lstSites = new List<Site>();

            Site amazon = new Site(
                pFormSites.ChkAmazon.EstCoche,
                pFormSites.ChkAmazon.TextLabel,
                "");
            Site bestBuy = new Site(
                pFormSites.ChkBestBuy.EstCoche,
                pFormSites.ChkBestBuy.TextLabel,
                "");
            Site ebay = new Site(
                pFormSites.ChkEbay.EstCoche,
                pFormSites.ChkEbay.TextLabel,
                "");
            Site mikeComputerShop = new Site(
                pFormSites.ChkMikeShop.EstCoche,
                pFormSites.ChkMikeShop.TextLabel,
                "");
            Site newEgg = new Site(
                pFormSites.ChkNewEgg.EstCoche,
                pFormSites.ChkNewEgg.TextLabel,
                "");
            Site walmart = new Site(
                pFormSites.ChkWalmart.EstCoche,
                pFormSites.ChkWalmart.TextLabel,
                "");

            lstSites.Add(amazon);
            lstSites.Add(bestBuy);
            lstSites.Add(ebay);
            lstSites.Add(mikeComputerShop);
            lstSites.Add(newEgg);
            lstSites.Add(walmart);

            LstSites = lstSites;
        }

        #endregion

        #region Cocher

        /// <summary>
        /// La méthode CocherSites permet la persistence des données et la mise à jour de celles-ci.
        /// Elle permet de cocher ce que l'utilisateur avait coché précédemment ou selon des paramètres importés.
        /// </summary>
        /// <param name="pFormSites">Le formSites qui contient les sites à chocher.</param>
        public static void CocherSites(FormSites pFormSites)
        {
            if (LstSites != null)
            {
                foreach (Site site in LstSites)
                {
                    if (site.EstCoche)
                    {
                        switch (site.Nom)
                        {
                            case "Amazon":
                                pFormSites.ChkAmazon.EstCoche = true;
                                break;
                            case "Best Buy":
                                pFormSites.ChkBestBuy.EstCoche = true;
                                break;
                            case "Ebay":
                                pFormSites.ChkEbay.EstCoche = true;
                                break;
                            case "Mike's Shop":
                                pFormSites.ChkMikeShop.EstCoche = true;
                                break;
                            case "NewEgg":
                                pFormSites.ChkNewEgg.EstCoche = true;
                                break;
                            case "Walmart":
                                pFormSites.ChkWalmart.EstCoche = true;
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// La méthode CocherFiltres permet la persistence des données et la mise à jour de celles-ci.
        /// Elle permet de cocher ce que l'utilisateur avait coché précédemment ou selon des paramètres importés.
        /// Elle permet aussi de remettre les valeurs précédemment entrées par l'utilisateur.
        /// </summary>
        /// <param name="pFormFiltres">Le formFiltres qui contient les filtres à chocher et les champs à remplir.</param>
        public static void CocherFiltres(FormFiltres pFormFiltres)
        {
            List<Filtre> lstFiltesCochees = ObtenirFiltresCocheeSeulement();
            if (lstFiltesCochees.Count > 0)
            {
                foreach (Filtre filtre in lstFiltesCochees)
                {
                    switch (filtre.Nom)
                        {
                            case "Condition":
                                FiltreCondition filtreCondition = (FiltreCondition)filtre;
                                pFormFiltres.ChkCondition.EstCoche = true;
                                pFormFiltres.CmbCondition.SelectedIndex = (int)filtreCondition.Condition;
                                break;
                            case "Note":
                                FiltreNote filtreNote = (FiltreNote)filtre;
                                pFormFiltres.ChkNote.EstCoche = true;
                                pFormFiltres.NoteEtoiles.EtoileCochee = filtreNote.Note;
                                break;
                            case "Prix":
                                FiltrePrix filtrePrix = (FiltrePrix)filtre;
                                pFormFiltres.ChkPrix.EstCoche = true;
                                pFormFiltres.TxtPrixDe.Text = filtrePrix.PrixDebut;
                                pFormFiltres.TxtPrixA.Text = filtrePrix.PrixFin;
                                break;
                        }
                }
            }
        }

        #endregion

        static List<Filtre> ObtenirFiltresCocheeSeulement()
        {
            List<Filtre> lstFiltesCoches = new List<Filtre>();
            if (LstFiltres != null)
            {
                foreach (Filtre filtre in LstFiltres)
                {
                    if (filtre.EstCoche)
                    {
                        lstFiltesCoches.Add(filtre);
                    }
                }
            }

            return lstFiltesCoches;

        }

        public static string ObtenirUrlEbay(string recherche)
        {
            List<Filtre> lstFiltresCochee = ObtenirFiltresCocheeSeulement();
            string URLEbayDeBase = "https://www.ebay.com/sch/i.html?_nkw=";
            string filtres = "";
            if (lstFiltresCochee.Count != 0)
            {
                foreach (Filtre filtre in lstFiltresCochee)
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
                            FiltrePrix filtrePrix = (FiltrePrix)filtre;
                            filtres += String.Format("&_udlo={0}&_udhi={1}",filtrePrix.PrixDebut,filtrePrix.PrixFin);
                            break;
                    }
                }
            }

            string URLEbayFinal = URLEbayDeBase + recherche + filtres;
            return URLEbayFinal;
        }

        public static string ObtenirUrlAmazon(string recherche)
        {
            List<Filtre> lstFiltresCochee = ObtenirFiltresCocheeSeulement();
            string URLAmazonDeBase = "https://www.amazon.ca/s?k=";
            string filtres = "";
            bool peutAvoirFiltreNote = true;
            bool peutAvoirFiltrePrix = true;
            if (lstFiltresCochee.Count != 0)
            {
                foreach (Filtre filtre in lstFiltresCochee)
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
                                FiltreNote filtreNote = (FiltreNote) filtre;
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
                                FiltrePrix filtrePrix = (FiltrePrix) filtre;
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
            
            string URLAmazonFinal = URLAmazonDeBase + recherche + filtres;
            return URLAmazonFinal;
        }

        public static string ObtenirUrlNewEgg(string recherche)
        {
            List<Filtre> lstFiltresCochee = ObtenirFiltresCocheeSeulement();
            string URLNewEggDeBase = "https://www.newegg.com/p/pl?d=";
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

            string URLNewEgg = URLNewEggDeBase + recherche + filtres;
            return URLNewEgg;
        }

        public static string ObtenirUrlMikeComputerShop(string recherche)
        {
            List<Filtre> lstFiltresCochee = ObtenirFiltresCocheeSeulement();
            string URLNewEggDeBase = "https://mikescomputershop.com/catalog/?q=";
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

            string URLMikeComputerShop = URLNewEggDeBase + recherche + filtres;
            return URLMikeComputerShop;
        }

        public static string ObtenirUrlWalmart(string recherche)
        {
            List<Filtre> lstFiltresCochee = ObtenirFiltresCocheeSeulement();
            string URLWalmartDeBase = "https://www.walmart.com/search/?query=";
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

            string URLWalmartFinal = URLWalmartDeBase + recherche + filtres;
            return URLWalmartFinal;
        }



        public static void ObtenirPageAPartirDeURL(string URL)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = web.Load(URL);
        }

        #endregion
    }
}
