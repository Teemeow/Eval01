using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte
{
    public class Modele
    {
        private string nom;     // nom du modèle
        private string marque;  // marque du modèle
        private int frequenceEntretien; // fréquence kilométrique entre 2 entretiens
                                        // Ex : 10000 signifie tous les 10000 km

        /// <summary>
        /// constructeur de la classe Modele
        /// </summary>
        public Modele(string unNom, string uneMarque, int uneFrequence)
        {
            this.nom = unNom;
            this.marque = uneMarque;
            this.frequenceEntretien = uneFrequence;
        }

        /// <summary>
        /// retourne la fréquence kilometrique entre 2 entretiens
        /// </summary>
        /// <returns>fréquence kilométrique</returns>
        public int GetFrequenceEnt()
        {
            return this.frequenceEntretien;
        }
    }
}
