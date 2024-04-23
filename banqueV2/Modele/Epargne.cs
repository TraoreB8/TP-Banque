using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqueV2
{
    [SerializableAttribute]
    internal class Epargne : Compte
    {
        public double tauxInteret;

        public Epargne(double tInterets) : base()
        {
            this.tauxInteret = tInterets;
        }

        public double getTaux()
        {
            return this.tauxInteret;
        }


        public double calculerInterets()
        {
            double taux = base.solde + tauxInteret / 100;
            base.solde += taux;
            return (solde);
        }

        public override bool débiter(double mont)
        {
            throw new NotImplementedException();
        }


    }
}
