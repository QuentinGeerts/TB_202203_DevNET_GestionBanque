using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque
{
    public class Courant : Compte
    {
        #region fields
        private double _ligneCredit;
        #endregion

        #region properties
        public double LigneCredit
        {
            get { return _ligneCredit; }
            set
            {
                if (value >= 0)
                {
                    _ligneCredit = value;
                }
                else
                {
                    // déclencher une erreur
                }
            }
        }

        protected override double CalculInteret()
        {
            if(Solde >= 0)
            {
                return Solde / 100 * 3;
            }
            else
            {
                return Solde / 100 * 9.75;
            }
        }
        #endregion

        #region methods
        public override void Retrait(double montant)
        {
            if(Solde + LigneCredit >= montant)
            {
                // methode originale du parent
                base.Retrait(montant);
            }
        }
        #endregion
    }
}
