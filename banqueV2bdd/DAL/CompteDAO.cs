using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using banqueV2bdd.Modele;
using static banqueV2bdd.Modele.Connexion;

namespace banqueV2bdd.DAL
{
    public class CompteDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "banqueV2";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        public static List<Compte> getCompte(Client cl)
        {
            try
            {
                List<Compte> listcompte = new List<Compte>();
                Compte lecompte = new Courant();
                Compte lecompte1 = new Epargne();
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from compte_courant where idClient = " + cl.Numero + "+1");
                Ocom = maConnexionSql.reqExec("Select * from compte_epargne where idClient = " + cl.Numero + "+1");

                MySqlDataReader reader1 = Ocom.ExecuteReader();
                MySqlDataReader reader2 = Ocom.ExecuteReader();



                while (reader1.Read())
                {

                    int _unNum = (int)reader1.GetValue(0);
                    double _decouvert = (double)reader1.GetValue(1);
                    Client idClient = (Client)reader1.GetValue(2);

                    lecompte = new Courant(_decouvert,_unNum,idClient);

                    //Chaque objet ajouter inséré dans la liste
                    listcompte.Add(lecompte);
                }
                reader1.Close();

                while (reader2.Read())
                {

                    int _unNum = (int)reader2.GetValue(0);
                    double _tauxinteret = (double)reader2.GetValue(1);


                    lecompte1 = new Epargne(_tauxinteret);

                    //Chaque objet ajouter inséré dans la liste
                    listcompte.Add(lecompte);
                }
                reader2.Close();

                maConnexionSql.closeConnection();


                return (listcompte);

            }

            catch (Exception unCompte)
            {

                throw (unCompte);
            }



        }
    }
}
