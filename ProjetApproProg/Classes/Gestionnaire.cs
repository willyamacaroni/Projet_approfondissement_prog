using ProjetApproProg.Classes;
using System.Collections.Generic;

namespace ProjetApproProg
{
    static class Gestionnaire
    {
        public static List<Filtre> RetrieveFiltres(FormFiltres pFormFiltres)
        {
            List<Filtre> lstFiltres = new List<Filtre>();

            pFormFiltres.ShowDialog();
            FiltreCondition filtreCondition = new FiltreCondition(pFormFiltres.ChkCondition.EstCoche, pFormFiltres.ChkCondition.TextLabel);
            FiltreNote filtreNote = new FiltreNote(pFormFiltres.ChkNote.EstCoche, pFormFiltres.ChkNote.TextLabel);
            FiltrePrix filtrePrix = new FiltrePrix(pFormFiltres.ChkPrix.EstCoche, pFormFiltres.ChkPrix.TextLabel);

            lstFiltres.Add(filtreCondition);
            lstFiltres.Add(filtreNote);
            lstFiltres.Add(filtrePrix);


            return lstFiltres;
        }

        public static List<Site> RetrieveSites(FormSites pFormSites)
        {
            List<Site> lstSites = new List<Site>();

            pFormSites.ShowDialog();

            SiteAmazon amazon = new SiteAmazon(pFormSites.ChkAmazon.EstCoche, pFormSites.ChkAmazon.TextLabel, "");
            SiteBestBuy bestBuy = new SiteBestBuy(pFormSites.ChkBestBuy.EstCoche, pFormSites.ChkBestBuy.TextLabel, "");
            SiteEbay ebay = new SiteEbay(pFormSites.ChkEbay.EstCoche, pFormSites.ChkEbay.TextLabel, "");
            SiteMikeComputerShop mikeComputerShop = new SiteMikeComputerShop(pFormSites.ChkMikeShop.EstCoche, pFormSites.ChkMikeShop.TextLabel, "");
            SiteNewEgg newEgg = new SiteNewEgg(pFormSites.ChkNewEgg.EstCoche, pFormSites.ChkNewEgg.TextLabel, "");
            SiteWalmart walmart = new SiteWalmart(pFormSites.ChkWalmart.EstCoche, pFormSites.ChkWalmart.TextLabel, "");

            lstSites.Add(amazon);
            lstSites.Add(bestBuy);
            lstSites.Add(ebay);
            lstSites.Add(mikeComputerShop);
            lstSites.Add(newEgg);
            lstSites.Add(walmart);

            return lstSites;

        }
    }
}
