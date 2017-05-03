using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsService1
{
    class ConnexionSql
    {
        private static MySqlConnection Cn = null;


        //Constructor 
        private ConnexionSql(string serveur, string bdd, string user, string mdp)
        {
            //déclaration d'une chaîne de connexion
            string connectionString;


            connectionString = "SERVER=" + serveur + ";" + "DATABASE=" + bdd + ";" + "UID=" + user + ";" + "PASSWORD=" + mdp;

            //instanciation
            Cn = new MySqlConnection(connectionString);
        }



        public static MySqlConnection getInstance(string serveur, string bdd, string user, string mdp)
        {
            if (null == Cn)
            { // Premier appel
              //  ConnexionSql.Initialize(unProvider, uneDataBase);

                new ConnexionSql(serveur, bdd, user, mdp);

            }
            return Cn;
        }



        //open connection to database
        public static void OpenConnection()
        {
            Cn.Open();
        }


        //Close connection
        public static void CloseConnection()
        {
            Cn.Close();
        }


    }
}
