namespace ProjetApproProg.Classes
{
    /// <summary>
    /// La classe produit permet de représenter un produit trouvé par la recherche.
    /// Un produit est composé d'une image, d'un titre/description et d'un prix.
    /// </summary>
    public class Produit
    {

        #region Attributs

        private string _urlImage;
        private string _titre;
        private string _prix;
        

        #endregion

        #region Get/Sets
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
        #endregion

        #region Constructeur

        public Produit(string pUrlImage, string pTitre, string pPrix)
        {
            UrlImage = pUrlImage;
            Titre = pTitre;
            Prix = pPrix;
        }
        

        #endregion

    }
}
