using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetApproProg
{
    abstract class Site
    {

        private bool _isChecked;
        private string _nom;
        private string _url;

        public bool IsChecked
        {
            get { return _isChecked; }
            set { _isChecked = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        protected Site(bool pIsChecked, string pNom, string pUrl)
        {
            IsChecked = pIsChecked;
            Nom = pNom;
            Url = pUrl;
        }
    }
}
