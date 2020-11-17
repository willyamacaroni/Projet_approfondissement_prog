namespace ProjetApproProg.Classes
{
    /// <summary>
    /// La classe produit permet de représenter un produit trouvé par la recherche.
    /// Un produit est composé d'une image, d'un titre/description et d'un prix.
    /// </summary>
    public class Produit
    {

        #region Attributs

        private string _url;
        private string _urlImage;
        private string _titre;
        private string _prix;
        private string _site;
        

        #endregion

        #region Get/Sets

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public string UrlImage
        {
            get { return _urlImage; }
            set { _urlImage = value; }
        }

        public string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }

        public string Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }
        public string Site
        {
            get { return _site; }
            set { _site = value; }
        }

        #endregion

        #region Constructeur

        public Produit(string pUrl, string pUrlImage, string pTitre, string pPrix, string pSite)
        {
            Url = pUrl;
            UrlImage = pUrlImage;
            Titre = pTitre;
            Prix = pPrix;
            Site = pSite;
        }
        

        #endregion

    }
}
