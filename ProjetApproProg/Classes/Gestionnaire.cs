using ProjetApproProg.Classes;
using System.Collections.Generic;

namespace ProjetApproProg
{
    public static class Gestionnaire
    {
        static List<Filtre> _lstFiltres;
        static List<Site> _lstSites;

        public static List<Filtre> LstFiltres
        {
            get { return _lstFiltres; }
            set { _lstFiltres = value; }
        }

        public static List<Site> LstSites
        {
            get { return _lstSites; }
            set { _lstSites = value; }
        }

        public static void RecupererFiltres(FormFiltres pFormFiltres)
        {
            List<Filtre> lstFiltres = new List<Filtre>();

            FiltreCondition filtreCondition = new FiltreCondition(pFormFiltres.ChkCondition.EstCoche, pFormFiltres.ChkCondition.TextLabel);
            FiltreNote filtreNote = new FiltreNote(pFormFiltres.ChkNote.EstCoche, pFormFiltres.ChkNote.TextLabel);
            FiltrePrix filtrePrix = new FiltrePrix(pFormFiltres.ChkPrix.EstCoche, pFormFiltres.ChkPrix.TextLabel);

            lstFiltres.Add(filtreCondition);
            lstFiltres.Add(filtreNote);
            lstFiltres.Add(filtrePrix);

            LstFiltres = lstFiltres;
        }

        public static void RecupererSites(FormSites pFormSites)
        {
            List<Site> lstSites = new List<Site>();

            Site amazon = new Site(pFormSites.ChkAmazon.EstCoche, pFormSites.ChkAmazon.TextLabel, "");
            Site bestBuy = new Site(pFormSites.ChkBestBuy.EstCoche, pFormSites.ChkBestBuy.TextLabel, "");
            Site ebay = new Site(pFormSites.ChkEbay.EstCoche, pFormSites.ChkEbay.TextLabel, "");
            Site mikeComputerShop = new Site(pFormSites.ChkMikeShop.EstCoche, pFormSites.ChkMikeShop.TextLabel, "");
            Site newEgg = new Site(pFormSites.ChkNewEgg.EstCoche, pFormSites.ChkNewEgg.TextLabel, "");
            Site walmart = new Site(pFormSites.ChkWalmart.EstCoche, pFormSites.ChkWalmart.TextLabel, "");

            lstSites.Add(amazon);
            lstSites.Add(bestBuy);
            lstSites.Add(ebay);
            lstSites.Add(mikeComputerShop);
            lstSites.Add(newEgg);
            lstSites.Add(walmart);

            LstSites = lstSites;
        }
    }
}
