using System.Linq;
using HtmlAgilityPack;
using System.Collections.Generic;
using Fizzler.Systems.HtmlAgilityPack;

namespace ProjetApproProg.Classes
{
    public static class Scrapper
    {

        public static List<Produit> _lesProduits;

        public static List<Produit> Scrap(List<(string pSite, HtmlNode pPage)> pLesPages)
        {

            List<Produit> lstProduitsTotal = new List<Produit>();
            foreach ((string pSite, HtmlNode pHtml) page in pLesPages)
            {
                List<Produit> lstProduitsSelonSite = new List<Produit>();
                
                switch (page.pSite)
                {
                    case "Ebay":
                        lstProduitsSelonSite = ScrapEbay(page.pHtml);
                        break;
                    case "Walmart":
                        lstProduitsSelonSite = ScrapWalmart(page.pHtml);
                        break;
                    case "Mikeshop":
                        lstProduitsSelonSite = ScrapMikeshop(page.pHtml);
                        break;
                    case "Amazon":
                        lstProduitsSelonSite = ScrapAmazon(page.pHtml);
                        break;
                    case "Bestbuy":
                        lstProduitsSelonSite = ScrapBestbuy(page.pHtml);
                        break;
                    case "Newegg":
                        lstProduitsSelonSite = ScrapNewegg(page.pHtml);
                        break;
                }

                lstProduitsTotal = lstProduitsTotal.Concat(lstProduitsSelonSite).ToList();
            }
            
            return lstProduitsTotal;
        }



    }
}
