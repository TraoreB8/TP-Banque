using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static banqueV2bdd.Modele.Connexion;



namespace banqueV2bdd.DAL
{
    internal class ClientDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "banqueV2";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        public static List<Client> getClient(Client cl)
        {
            try
            {
                List<Client> list = new List<Client>();
                Client leclient = new Client();
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from client where idClient = " + cl.Numero + "+1");

                MySqlDataReader reader1 = Ocom.ExecuteReader();



                while (reader1.Read())
                {

                    int _unId = (int)reader1.GetValue(0);
                    string _unNom = (string)reader1.GetValue(1);
                    string _unPrenom = (string)reader1.GetValue(2);
                    string _uneAdresse = (string)reader1.GetValue(3);

                    leclient = new Client(_unId, _unNom, _unPrenom, _uneAdresse);

                    //Chaque objet ajouter inséré dans la liste
                    list.Add(leclient);
                }
                reader1.Close();

                maConnexionSql.closeConnection();


                return (list);

            }

            catch (Exception unClient)
            {

                throw (unClient);
            }
        }

        public static void DeleteClient(Client cl)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("delete from client  where idClient = " + cl.Numero);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
    }
}