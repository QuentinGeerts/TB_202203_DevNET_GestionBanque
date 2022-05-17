using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque
{
    public class Personne
    {

        #region fields
        private string _nom;
        private string _prenom;
        private DateTime _dateNaissance; 
        #endregion

        #region Properties
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }
        #endregion

        #region ctors

        #endregion

        #region methods

        #endregion
    }
}
