using System;
using System.Linq;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        private static List<Produit> ScrapEbay(HtmlNode pHtml)
        {
            List<HtmlNode> lstLiProduits = pHtml.QuerySelector("ul[class='srp-results srp-list clearfix']").QuerySelectorAll("li[class*='s-item']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string urlImage = produit.QuerySelector("img[class*='s-item__image-img']").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("h3[class*='s-item__title']").InnerText.Trim();
                    string prix = produit.QuerySelector("div[class*='item__detail--primary']").QuerySelector("span").InnerText.Trim();
                    lstProduits.Add(new Produit(urlImage, titre, prix));
                }
                catch
                {
                    continue;
                }
            }

            return lstProduits;
        }

        private static List<Produit> ScrapWalmart(HtmlNode pHtml)
        {

            List<HtmlNode> lstLiProduits = pHtml.QuerySelectorAll("div[data-product-id]").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string urlImage = produit.QuerySelector("img[data-automation]").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("p[data-automation*='name']").InnerText.Trim();
                    string prix = produit.QuerySelector("span[data-automation*='current-price']").InnerText.Trim();
                    lstProduits.Add(new Produit(urlImage, titre, prix));
                }
                catch
                {
                    continue;
                }
            }

            return lstProduits;

        }

        private static List<Produit> ScrapMikeshop(HtmlNode pHtml)
        {

            List<HtmlNode> lstLiProduits = pHtml.QuerySelectorAll("div[class*='row catalog-product']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string urlImage = produit.QuerySelector("img[class*='product-img']").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("span[itemprop*='name']").InnerText.Trim();
                    string prix = produit.QuerySelector("span[class*='product-price']").InnerText.Trim();
                    lstProduits.Add(new Produit(urlImage, titre, prix));
                }
                catch
                {
                    continue;
                }
            }

            return lstProduits;

        }

        private static List<Produit> ScrapAmazon(HtmlNode pHtml)
        {

            //List<HtmlNode> lstLiProduits = page.QuerySelectorAll("div[data-component-type='s-search-result']").ToList();
            List<HtmlNode> lstLiProduits = pHtml.QuerySelectorAll("div[class*='sg-col-4-of-24']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string urlImage = produit.QuerySelector("img[class='s-image']").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("span[class*='a-']").InnerText.Trim();
                    string prix = produit.QuerySelector("div[span*='a-offscreen']").InnerText.Trim();
                    lstProduits.Add(new Produit(urlImage, titre, prix));
                }
                catch
                {
                    continue;
                }
            }

            return lstProduits;

        }

        private static List<Produit> ScrapBestbuy(HtmlNode pHtml)
        {

            List<HtmlNode> lstLiProduits = pHtml.QuerySelector("ul[class='srp-results srp-list clearfix']").QuerySelectorAll("li[class*='s-item']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                string urlImage = produit.QuerySelector("img[class*='s-item__image-img']").GetAttributeValue("src", "").Trim();
                string titre = produit.QuerySelector("h3[class*='s-item__title']").InnerText.Trim();
                string prix = produit.QuerySelector("div[class*='item__detail--primary']").QuerySelector("span").InnerText.Trim();
                lstProduits.Add(new Produit(urlImage, titre, prix));
            }

            return lstProduits;

        }

        private static List<Produit> ScrapNewegg(HtmlNode pHtml)
        {

            List<HtmlNode> lstLiProduits = pHtml.QuerySelectorAll("div[class='item-container']").ToList();

            List<Produit> lstProduits = new List<Produit>();

            foreach (HtmlNode produit in lstLiProduits)
            {
                try
                {
                    string urlImage = produit.QuerySelector("img").GetAttributeValue("src", "").Trim();
                    string titre = produit.QuerySelector("a[class*='item-title']").InnerText.Trim();
                    string prix = produit.QuerySelector("li[class*='price-current']").InnerText.Trim();
                    lstProduits.Add(new Produit(urlImage, titre, prix));
                }
                catch
                {
                    continue;
                }
            }

            return lstProduits;

        }
    }
}
