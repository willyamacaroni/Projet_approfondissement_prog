using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetApproProg.Classes;

namespace ProjetApproProg
{
    static class Gestionnaire
    {
        public static List<Filtre> RetrieveFiltres(FormFiltres pFormFiltres)
        {
            List<Filtre> lstFiltres = new List<Filtre>();

            pFormFiltres.ShowDialog();
            FiltreCondition filtreCondition = new FiltreCondition(pFormFiltres.ChkCondition.Checked, pFormFiltres.ChkCondition.Text);
            FiltreNote filtreNote = new FiltreNote(pFormFiltres.ChkNote.Checked, pFormFiltres.ChkNote.Text);
            FiltrePrix filtrePrix = new FiltrePrix(pFormFiltres.ChkPrix.Checked, pFormFiltres.ChkPrix.Text);

            lstFiltres.Add(filtreCondition);
            lstFiltres.Add(filtreNote);
            lstFiltres.Add(filtrePrix);


            return lstFiltres;
        }

        public static List<Site> RetrieveSites(FormSites pFormSites)
        {
            List<Site> lstSites = new List<Site>();

            pFormSites.ShowDialog();

            SiteAmazon amazon = new SiteAmazon(pFormSites.ChkAmazon.Checked, pFormSites.ChkAmazon.Text, "");
            SiteBestBuy bestBuy = new SiteBestBuy(pFormSites.ChkBestBuy.Checked, pFormSites.ChkBestBuy.Text, "");
            SiteEbay ebay = new SiteEbay(pFormSites.ChkEbay.Checked, pFormSites.ChkEbay.Text, "");
            SiteMikeComputerShop mikeComputerShop = new SiteMikeComputerShop(pFormSites.ChkMikeShop.Checked, pFormSites.ChkMikeShop.Text, "");
            SiteNewEgg newEgg = new SiteNewEgg(pFormSites.ChkNewEgg.Checked, pFormSites.ChkNewEgg.Text, "");
            SiteWalmart walmart = new SiteWalmart(pFormSites.ChkWalmart.Checked, pFormSites.ChkWalmart.Text, "");

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
