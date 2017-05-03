using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    class GestionDate
    {


        private int moisCourant;
        private int jourCourant;



        /// <summary>
        /// Retourne le mois courant
        /// </summary>
        /// <returns>int</returns>

        public int getMoisCourant()
        {

            DateTime now = DateTime.Now;
            moisCourant = now.Month;
            return moisCourant;

        }


        public int getJourCourant()
        {

            DateTime now = DateTime.Now;
            jourCourant = now.Day;
            return jourCourant;

        }

        public string getMoisFiche(string date)
        {
            return date.Substring(4, 2);
        }

        /// <summary>
        /// Retourne le mois précédent
        /// </summary>
        /// <returns>moisPrecedent</returns>
        public DateTime getMoisPrecedent()
        {
            DateTime today = DateTime.Today;
            DateTime datePrecedente = today.AddMonths(-1);

            return datePrecedente;

        }

        public string getAnneeMoisPrecedent()
        {
            DateTime today = DateTime.Today;
            DateTime datePrecedente = today.AddMonths(-1);
            string anneePrecedente = datePrecedente.Year.ToString();
            string moisPrecedent = datePrecedente.Month.ToString();
            string AnneeMois = anneePrecedente + "" + moisPrecedent;
            return AnneeMois;
        }


    }
}
