using System.Linq;
using ProjetApproProg.Classes;
using System.Collections.Generic;

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

        private static List<Filtre> _lstFiltres;
        private static List<Filtre> _lstFiltresCoches;
        private static List<Site> _lstSites;
        private static List<Site> _lstSitesCoches;
        private static List<Produit> _lstProduits;


        #endregion

        #region GetSet
        public static List<Filtre> LstFiltresCoches
        {
            get { return _lstFiltresCoches; }
            set { _lstFiltresCoches = value; }
        }

        public static List<Site> LstSitesCoches
        {
            get { return _lstSitesCoches; }
            set { _lstSitesCoches = value; }
        }

        public static List<Produit> LstProduits
        {
            get { return _lstProduits; }
            set { _lstProduits = value; }
        }


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
            LstFiltres.Clear();

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

            LstFiltres.Add(filtreCondition);
            LstFiltres.Add(filtreNote);
            LstFiltres.Add(filtrePrix);

            RecupererFiltresCoches();
        }

        /// <summary>
        /// La méthode RecupererSites permet de récupérer les données de chaque site.
        /// Elle est utile à la sauvegarde de données et à la gestion des sites.
        /// </summary>
        /// <param name="pFormSites">Le formSites qui contient les sites à récupérer.</param>
        public static void RecupererSites(FormSites pFormSites)
        {
            if (LstSites != null)
                LstSites.Clear();

            SiteAmazon amazon = new SiteAmazon(
                pFormSites.ChkAmazon.EstCoche);
            SiteBestBuy bestBuy = new SiteBestBuy(
                pFormSites.ChkBestBuy.EstCoche);
            SiteEbay ebay = new SiteEbay(
                pFormSites.ChkEbay.EstCoche);
            SiteMike mikeComputerShop = new SiteMike(
                pFormSites.ChkMikeShop.EstCoche);
            SiteNewEgg newEgg = new SiteNewEgg(
                pFormSites.ChkNewEgg.EstCoche);
            SiteWalmart walmart = new SiteWalmart(
                pFormSites.ChkWalmart.EstCoche);

            LstSites.Add(amazon);
            LstSites.Add(bestBuy);
            LstSites.Add(ebay);
            LstSites.Add(mikeComputerShop);
            LstSites.Add(newEgg);
            LstSites.Add(walmart);

            RecupererSitesCoches();
        }



        /// <summary>
        /// La méthode RecupererFiltres permet de récupérer les données de chaque filtre.
        /// Elle est utile à la sauvegarde de données et à la gestion des filtres.
        /// </summary>
        /// <param name="pFormFiltres">Le formFiltres qui contient les filtres à récupérer.</param>
        private static void RecupererFiltresCoches()
        {
            LstFiltresCoches.Clear();

            foreach (Filtre filtre in LstFiltres)
            {
                if (filtre.EstCoche)
                {
                    LstFiltresCoches.Add(filtre);
                }
            }
        }

        /// <summary>
        /// La méthode RecupererSites permet de récupérer les données de chaque site.
        /// Elle est utile à la sauvegarde de données et à la gestion des sites.
        /// </summary>
        /// <param name="pFormSites">Le formSites qui contient les sites à récupérer.</param>
        private static void RecupererSitesCoches()
        {
            LstSitesCoches.Clear();

            foreach (Site site in LstSites)
            {
                if (site.EstCoche)
                {
                    LstSitesCoches.Add(site);
                }
            }
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
            if (LstSitesCoches != null)
            {
                foreach (Site site in LstSitesCoches)
                {
                    switch (site.Nom)
                    {
                        case "Amazon":
                            pFormSites.ChkAmazon.EstCoche = true;
                            break;
                        case "BestBuy":
                            pFormSites.ChkBestBuy.EstCoche = true;
                            break;
                        case "Ebay":
                            pFormSites.ChkEbay.EstCoche = true;
                            break;
                        case "MikeShop":
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

        /// <summary>
        /// La méthode CocherFiltres permet la persistence des données et la mise à jour de celles-ci.
        /// Elle permet de cocher ce que l'utilisateur avait coché précédemment ou selon des paramètres importés.
        /// Elle permet aussi de remettre les valeurs précédemment entrées par l'utilisateur.
        /// </summary>
        /// <param name="pFormFiltres">Le formFiltres qui contient les filtres à chocher et les champs à remplir.</param>
        public static void CocherFiltres(FormFiltres pFormFiltres)
        {
            if (LstFiltresCoches != null)
            {
                foreach (Filtre filtre in LstFiltresCoches)
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

        public static void Rechercher(string pRecherche)
        {
            LstProduits = new List<Produit>();
            foreach (Site siteCoche in LstSites)
            {
                siteCoche.ConstruireURL(pRecherche);
                LstProduits = LstProduits.Concat(siteCoche.Scrap()).ToList();
            }
        }

        #endregion
    }
}
