using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte
{
    public class Entretien
    {
        private DateTime dateEntretien; // date de l'entretien
        private int kmEntretien;        // kilométrage du véhicule au moment de l'entretien
        private string commentaire;     // commentaire 

        /// <summary>
        /// Constructeur de la classe Entretien
        /// </summary>
        /// <param name="uneDate"></param>
        /// <param name="unKilometrage"></param>
        /// <param name="unCommentaire"></param>
        public Entretien(DateTime uneDate, int unKilometrage, string unCommentaire)
        {
            this.dateEntretien = uneDate;
            this.kmEntretien = unKilometrage;
            this.commentaire = unCommentaire;
        }

        /// <summary>
        /// retourne la date de l'entretien
        /// </summary>
        /// <returns>date de l'entretien</returns>
        public DateTime GetDateEntretien()
        {
            return this.dateEntretien;
        }

        /// <summary>
        /// retourne le kilométrage du véhicule au moment de l'entretien
        /// </summary>
        /// <returns>kilométrage du véhicule</returns>
        public int GetKmEntretien()
        {
            return this.kmEntretien;
        }
    }
}
