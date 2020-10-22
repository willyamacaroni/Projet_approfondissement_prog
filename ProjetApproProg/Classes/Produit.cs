using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetApproProg.Classes
{
    public class Produit
    {
        private string _urlImage;
        private string _titre;
        private string _prix;

        public Produit(string pUrlImage, string pTitre, string pPrix)
        {
            _urlImage = pUrlImage;
            _titre = pTitre;
            _prix = pPrix;
        }

    }
}
