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
            if (LstFiltres != null)
            {
                foreach (Filtre filtre in LstFiltres)
                {
                    if (filtre.EstCoche)
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
        }

        #endregion
    }
}
