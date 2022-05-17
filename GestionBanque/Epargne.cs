using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque
{
    public class Epargne : Compte
    {
        private DateTime _dateDernierRetrait;

        public DateTime DateDernierRetrait
        {
            get { return _dateDernierRetrait; }
            set { _dateDernierRetrait = value; }
        }

        protected override double CalculInteret()
        {
            // solde = 130
            // 4.5%;
            return Solde / 100 * 4.5;
        }

        public override void Retrait(double montant)
        {
            if(Solde >= montant)
            {
                DateDernierRetrait = DateTime.Now;
                base.Retrait(montant);
            }
        }
    }
}
