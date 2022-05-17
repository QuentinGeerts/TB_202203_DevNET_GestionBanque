using System;
using System.Collections.Generic;

namespace GestionBanque
{
    public class Banque
    {
        #region fields
        private string _nom;
        // ce champs permettra de stocker les comptes de la banque
        private Dictionary<string, Compte> _comptes = new ();
        #endregion

        #region properties
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        // indexeur
        public Compte this[string numero]
        {
            get 
            {
                // si mon dictionnaire contient le numero demandé 
                // retourne le compte dont le numero est le numero demandé
                if(_comptes.ContainsKey(numero))
                {
                    return _comptes[numero];
                }
                else
                {
                    // declencher une erreur
                    return null;
                }
            }
        } 
        #endregion

        #region methods
        public void Ajouter(Compte compte)
        {
            // verifier si le numero de compte n'existe pas déjà
            if(!_comptes.ContainsKey(compte.Numero))
            {
                _comptes.Add(compte.Numero, compte);
            }
            else
            {
                //declencher une erreur si le numero existe déjà
            }
        }

        public void Retirer(string numero)
        {
            if(_comptes.ContainsKey(numero))
            {
                 _comptes.Remove(numero);
            }
            else
            {
                // declencher une erreur
            }
        } 
        #endregion

    }
}
