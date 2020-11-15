﻿using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using ProjetApproProg.Classes;
using System.Collections.Generic;
using ProjetApproProg.Forms;

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
                RecupererFiltresCoches();
            }
        }

        public static List<Site> LstSites
        {
            get { return _lstSites; }
            set
            {
                _lstSites = value;
                RecupererSitesCoches();
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
            LstFiltres = new List<Filtre>();

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
            LstSites = new List<Site>();

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
            LstFiltresCoches = new List<Filtre>();

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
            LstSitesCoches = new List<Site>();

            foreach (Site site in LstSites)
            {
                if (site.EstCoche)
                {
                    LstSitesCoches.Add(site);
                }
            }
        }

        #endregion

        #region Rechercher
        /// <summary>
        /// La méthode rechercher permet de retourner une liste de produits à
        /// partir de la recherche entrée par l'utilisateur.
        /// </summary>
        /// <param name="pRecherche">Les termes de recherche entrés par l'utilisateur.</param>
        public static void Rechercher(string pRecherche)
        {
            LstProduits = new List<Produit>();
            foreach (Site siteCoche in LstSitesCoches)
            {
                siteCoche.ConstruireURL(pRecherche);
                LstProduits = LstProduits.Concat(siteCoche.Scrap()).ToList();
            }

            FormProduits frmProduits = new FormProduits();

            if (frmProduits.ShowDialog() == DialogResult.OK)
            {

            }
        }
        #endregion

        #region Ordonner

        public static List<Produit> OrdonnerSelonPrixCroissant(List<Produit> pLstProduits)
        {
            List<Produit> lstOrdonner = new List<Produit>();
            pLstProduits = pLstProduits.OrderBy(x => x.Prix).ToList();
            lstOrdonner = pLstProduits;
            return lstOrdonner;
        }
        public static List<Produit> OrdonnerSelonPrixDecroissant(List<Produit> pLstProduits)
        {
            List<Produit> lstOrdonner = new List<Produit>();
            pLstProduits = pLstProduits.OrderBy(x => x.Prix).ToList();
            for (int i = pLstProduits.Count - 1; i >= 0; i++)
            {
                lstOrdonner.Add(pLstProduits[i]);
            }
            return lstOrdonner;
        }
        public static List<Produit> OrdonnerSelonTitreCroissant(List<Produit> pLstProduits)
        {
            List<Produit> lstOrdonner = new List<Produit>();
            pLstProduits = pLstProduits.OrderBy(x => x.Titre).ToList();
            lstOrdonner = pLstProduits;
            return lstOrdonner;
        }
        public static List<Produit> OrdonnerSelonTitreDecroissant(List<Produit> pLstProduits)
        {
            List<Produit> lstOrdonner = new List<Produit>();
            pLstProduits = pLstProduits.OrderBy(x => x.Titre).ToList();
            for (int i = pLstProduits.Count - 1; i >= 0; i++)
            {
                lstOrdonner.Add(pLstProduits[i]);
            }
            return lstOrdonner;
        }
        public static List<Produit> OrdonnerSelonSiteCroissant(List<Produit> pLstProduits)
        {
            List<Produit> lstOrdonner = new List<Produit>();
            pLstProduits = pLstProduits.OrderBy(x => x.Site).ToList();
            lstOrdonner = pLstProduits;
            return lstOrdonner;
        }
        public static List<Produit> OrdonnerSelonSiteDecroissant(List<Produit> pLstProduits)
        {
            List<Produit> lstOrdonner = new List<Produit>();
            pLstProduits = pLstProduits.OrderBy(x => x.Site).ToList();
            for (int i = pLstProduits.Count - 1; i >= 0; i++)
            {
                lstOrdonner.Add(pLstProduits[i]);
            }
            return lstOrdonner;
        }

        #endregion

        #region Sauvegarde

        #region Paramètres

        public static void ExporterParamteres()
        {
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Title = "Enregistrer un fichier de paramètres";
                SFD.Filter = "Fichier JSON (*.JSON)|*.JSON";

                if (SFD.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter writer = new StreamWriter(File.Create(SFD.FileName)))
                    {
                        writer.WriteLine(JsonConvert.SerializeObject(LstFiltres));
                        writer.WriteLine(JsonConvert.SerializeObject(LstSites));
                    }

                }
            }

            MessageBox.Show("Vos paramètres ont été enregistrés avec succès!",
                "Succès!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void ImporterParametres()
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Title = "Ouvrir un fichier de paramètres";
                OFD.Filter = "Fichier JSON (*.JSON)|*.JSON";

                if (OFD.ShowDialog() == DialogResult.OK)
                {

                    using (StreamReader lecteur = new StreamReader(File.OpenRead(OFD.FileName)))
                    {
                        string rawJson = lecteur.ReadToEnd();
                        string[] filtresEtSites = rawJson.Split('\n');

                        JsonConverter[] filtreConverters = { new FiltreConverter() };
                        JsonConverter[] siteConverters = { new SiteConverter() };

                        try
                        {
                            LstFiltres = JsonConvert.DeserializeObject<List<Filtre>>(filtresEtSites[0].Trim(), new JsonSerializerSettings() { Converters = filtreConverters });
                            LstSites = JsonConvert.DeserializeObject<List<Site>>(filtresEtSites[1].Trim(), new JsonSerializerSettings() { Converters = siteConverters });
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Fichier de paramètres non valide.",
                                "Erreur!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        
                    }
                }
            }
        }
        

        #endregion

        #region Produits

        public static void ImporterProduits()
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Title = "Ouvrir une liste de produits";
                OFD.Filter = "Fichier JSON (*.JSON)|*.JSON";

                if (OFD.ShowDialog() == DialogResult.OK)
                {

                    using (StreamReader lecteur = new StreamReader(File.OpenRead(OFD.FileName)))
                    {
                        string rawJson = lecteur.ReadToEnd();

                        try
                        {
                            LstProduits = JsonConvert.DeserializeObject<List<Produit>>(rawJson.Trim());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Fichier de produits non valide.",
                                "Erreur!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }

            FormProduits frmProduits = new FormProduits();
            if (frmProduits.ShowDialog() == DialogResult.OK)
            {

            }
        }

        public static void ExporterProduits()
        {
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Title = "Enregistrer une liste de produits";
                SFD.Filter = "Fichier JSON (*.JSON)|*.JSON";

                if (SFD.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter writer = new StreamWriter(File.Create(SFD.FileName)))
                    {
                        writer.WriteLine(JsonConvert.SerializeObject(LstProduits));
                    }

                }
            }

            MessageBox.Show("Vos produits ont été enregistrés avec succès!",
                "Succès!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        #endregion

        #endregion

        #region Cocher

        public static void CocherFiltres(FormFiltres pFormFiltres)
        {
            if (LstFiltresCoches.Count > 0)
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


        /// <summary>
        /// La méthode CocherSites permet la persistence des données et la mise à jour de celles-ci.
        /// Elle permet de cocher ce que l'utilisateur avait coché précédemment ou selon des paramètres importés.
        /// </summary>
        /// <param name="pFormSites">Le formSites qui contient les sites à chocher.</param>
        public static void CocherSites(FormSites pFormSites)
        {
            if (LstSitesCoches.Count > 0)
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

        #endregion

        #endregion
    }
}
