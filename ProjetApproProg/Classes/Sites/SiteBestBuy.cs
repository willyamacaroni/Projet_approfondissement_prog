﻿using System.Collections.Generic;
using HtmlAgilityPack;
using ProjetApproProg.Classes;

namespace ProjetApproProg
{
    /// <summary>
    /// La classe site est désignée à décrire un site à chercher.
    /// Elle est décrite par un nom, une URL et si le site est coché.
    /// </summary>
    public class SiteBestBuy : Site
    {
        private const string urlDeBase = "";

        #region Constructeurs
        public SiteBestBuy(bool pEstCoche) : base(pEstCoche)
        {
            Nom = "BestBuy";
            ObjType = 1;
        }

        public SiteBestBuy()
        {
            ObjType = 1;
        }

        #endregion

        #region Méthodes

        public override void ConstruireURL(string pRecherche)
        {
            throw new System.NotImplementedException();
        }

        public override List<Produit> Scrap()
        {
            throw new System.NotImplementedException();
        }

        #endregion

    }
}
