using banqueV2bdd.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqueV2bdd
{
    // [SerializableAttribute]
    internal class Courant : Compte
    {
        private double decouvertAuto;

        public Courant(double decouvertAutorise,int n, Client c) : base(n, c)
        {
            this.decouvertAuto = decouvert;
        }

        public Courant()
        {
        }

        public void setDecouvert(double montantAutorise)
        {
            this.decouvertAuto = montantAutorise;
        }
        public double getDecouvertAutorise()
        {
            return this.decouvertAuto;
        }


        public bool setdecouvert(double mont)
        {
            try
            {
                if (-mont > solde)
                {
                    //return false;
                    throw new DecouvertException("Opération refusée, montant supérieur au solde");
                }
                return false;
            }
            catch(DecouvertException ex)
            {
                Console.WriteLine($"Erreur de retrait : {ex.Message}");
                decouvertAuto = mont;
                return true;
            }
        }

        public override bool débiter(double mont)
        {
            try
            {
                if (base.solde - mont < -decouvertAuto)

                {
                    throw new DebitException("Solde insuffisant pour effectuer le retrait.");
                }

                solde = solde - mont;
                return true;
            }
            
            catch (DebitException ex)
            {
                Console.WriteLine($"Erreur de retrait : {ex.Message}");

                return false;
            }
        }



       /*public override bool débiter(double mont)
        {
            if (base.solde - mont < -decouvertAuto)
            {
                return false;
            }
            else
            {
                solde = solde - mont;
                return true;
            }
        }*/


    }
}
