using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqueV2bdd
{
    //[SerializableAttribute] //préciser que nos classe sont serialisable
    internal abstract class Compte
    {
        protected int num;
        protected Client proprio;
        protected double solde;
        protected double decouvert;


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
                return "N° Compte : " + num + " " + " N° Cli : "+ proprio + " " + " " + solde + " euros";

        }

        public Client Propriétaire
        {
            get { return proprio; }
        }




        public void crediter(double mont)
        {
            solde = solde + mont;
        }

        /*public bool setdecouvert(double mont)
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
        }*/

        public abstract bool débiter(double mont);

    }

}
