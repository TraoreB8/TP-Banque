using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banqueV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //déclarer et construire deux clients


                Client c1 = new Client(1,"Dupont","Toto","Creteil");
                Client c2 = new Client(2, "Abadala", "Momo", "Creteil");
                Client c3 = new Client(3, "Lucas", "Todd", "Creteil");



                //afficher toutes les informations sur les deux clients
                Console.WriteLine("Information concernant le Client 1 :");
                Console.WriteLine(c1);
                Console.WriteLine();

                Console.WriteLine("Information concernant le Client 2 :");
                Console.WriteLine(c2);
                Console.WriteLine();

                Console.WriteLine("Information concernant le Client 3 :");
                Console.WriteLine(c3);
                Console.WriteLine();


                // déclarer et construire trois comptes


                Compte compte1 = new Compte(10, c1);
                Compte compte2 = new Compte(11, c2);
                Compte compte3 = new Compte(12, c3);


                // créditez les comptes
                Console.WriteLine("Créditer les comptes : ");
                compte1.crediter(80);
                compte2.setdecouvert(10);
                compte2.crediter(15);

                compte3.crediter(70);

                Console.WriteLine("Affichage des comptes créditer : ");
                Console.WriteLine(compte1);
                Console.WriteLine(compte2);
                Console.WriteLine(compte3);


                Console.WriteLine();


                Console.WriteLine("Débiter les comptes : ");
                compte1.débiter(5);
                compte2.débiter(25);
                compte3.débiter(50);


                Console.WriteLine();


                Console.WriteLine("Affichage des comptes après avoir débiter: ");
                Console.WriteLine(compte1);
                Console.WriteLine(compte2);
                Console.WriteLine(compte3);

                //accordez un découvert de 15 à toto et de 15 à momo sur leur compte courant

                if (compte1.setdecouvert(14)) { Console.WriteLine("Reussi"); }
                else
                {
                    Console.WriteLine("ERROR");
                }
                if (compte2.setdecouvert(5)) { Console.WriteLine("Reussi"); }
                else
                {
                    Console.WriteLine("ERROR");
                }
                if (compte3.setdecouvert(10)) { Console.WriteLine("Reussi"); }
                else
                {
                    Console.WriteLine("ERROR");
                }

                //Modifiez le découvert de momo sur son compte courant, pour qu'il soit de 5 (normalement là aussi, on devrait avoir un message d'erreur)

                //écrivez toute autre instruction qui vous parait utile pour tester les différentes méthodes de vos classes

            }
        }
    }
}
