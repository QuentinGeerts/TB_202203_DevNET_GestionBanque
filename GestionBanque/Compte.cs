using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque
{
    public abstract class Compte: ICustomer, IBanker
    {
        #region fields
        private string _numero;
        private double _solde;
        private Personne _titulaire;
        #endregion

        #region properties
        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public double Solde
        {
            get { return _solde; }
            //private set { _solde = value; }
        }
        public Personne Titulaire
        {
            get { return _titulaire; }
            set { _titulaire = value; }
        }
        #endregion

        #region methods
        public virtual void Retrait(double montant)
        {
            _solde -= montant;
        }
        public void Depot(double montant)
        {
            _solde += montant;
        }

        public void AppliquerInteret()
        {
            _solde += CalculInteret();
        }

        protected abstract double CalculInteret();
        #endregion
    }
}
