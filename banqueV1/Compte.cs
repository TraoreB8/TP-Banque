using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqueV1
{
    internal class Compte
    {
        private int num;
        private Client proprio;
        private double solde;
        private double decouvert;


        public Compte()
        {

        }

        public Compte(int n, Client c)
        {
            num = n;
            solde = 0;
            proprio = c;
        }


        public int Numero
        {
            get
            { return num; }
        }



        public override string ToString()
        {
            
                return num + " " + proprio + " " + " " + decouvert + " "+ solde + " euros";
            

        }

        public Client Propriétaire
        {
            get { return proprio; }
        }




        public void crediter(double mont)
        {
            solde = solde + mont;
        }

        public bool setdecouvert(double mont)
        {
            if (-mont  > solde)
            {
                return false;
            }
            else
            {
                decouvert = mont;
                return true;
            }
        }

        public bool débiter(double mont)
        {
            if (solde - mont < -decouvert)
            {
                return false;
            }
            else
            {
                solde = solde - mont;
                return true;
            }
        }

    }

}
