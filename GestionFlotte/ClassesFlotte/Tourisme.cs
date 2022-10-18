using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte
{
    public class Tourisme : Vehicule
    {
        private int nbPlaces;       // nombre de places du vehicule de tourisme
        private Modele leModele;    // modèle du véhicule de tourisme (object Modele)

        /// <summary>
        /// Constructeur de la classe Tourisme
        /// </summary>
        public Tourisme(string uneImmat, string uneEnergie, int unePuissance, int unNombrePlaces, Modele unModele)
            : base(uneImmat, uneEnergie, unePuissance)
        {
            this.nbPlaces = unNombrePlaces;
            this.leModele = unModele;
        }

        /// <summary>
        /// Retourne un booléen indiquant si le vehicule de tourisme est à entretenir ou non
        /// un véhicule de tourisme doit être révisé tous les 2 ans 
        /// ou selon la fréquence kilométrique fonction du modèle de véhicule
        /// </summary>
        /// <returns>true si un entretien est à prévoir ou false dans le cas contraire</returns>
        public override bool PrevoirEntretien()
        {
            bool prevoirEnt = false;
            DateTime dateDernEnt = base.GetDernierEntretien().GetDateEntretien();
            DateTime dateActuelle = DateTime.Now;
            TimeSpan diffDates = dateActuelle.Subtract(dateDernEnt);

            //Kilomètres parcouru depuis le dernier entretien
            int kmParcouru = this.GetKmActuel() - this.GetDernierEntretien().GetKmEntretien();

            if (diffDates.Days >= 720 || kmParcouru > this.leModele.GetFrequenceEnt())
                prevoirEnt = true;
            return prevoirEnt;
        }
    }
}
