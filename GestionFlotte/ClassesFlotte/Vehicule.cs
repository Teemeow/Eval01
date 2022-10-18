using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte
{
    public class Vehicule
    {
        private string immat;   // numero d'immatriculation du véhicule
        private string energie; // Essence, Diesel, Electrique,...
        private int puissance;  // puissance fiscale en nombre de cv
        private int kmActuel;   // kilométrage relevé au compteur
        private List<Entretien> lesEntretiens;  // liste des entretiens réalisés sur le véhicule

        /// <summary>
        /// Constructeur de la classe Vehicule
        /// </summary>
        public Vehicule(string uneImmat, string uneEnergie, int unePuissance)
        {
            this.immat = uneImmat;
            this.energie = uneEnergie;
            this.puissance = unePuissance;
            this.kmActuel = 0;
            this.lesEntretiens = new List<Entretien>();
        }

        /// <summary>
        /// retourne le numéro d'immatriculation du véhicule
        /// </summary>
        /// <returns>immatriculation du véhicule</returns>
        public string GetImmat()
        {
            return this.immat;
        }

        /// <summary>
        /// retourne le kilométrage actuel du véhicule
        /// </summary>
        /// <returns>kilometrage actuel du véhicule</returns>
        public int GetKmActuel()
        {
            return this.kmActuel;
        }

        /// <summary>
        /// définit le kilométrage actuel du véhicule
        /// </summary>
        /// <param name="unKilometrage">kilométrage relevé au compteur</param>
        public void SetKmActuel(int unKilometrage)
        {
            this.kmActuel = unKilometrage;
        }

        /// <summary>
        /// Ajoute un entretien au véhicule
        /// </summary>
        /// <param name="unEntretien">objet Entretien à ajouter</param>
        public void AjouterEntretien(Entretien unEntretien)
        {
            this.lesEntretiens.Add(unEntretien);

        }

        /// <summary>
        /// retourne le dernier entretien effectué sur le véhicule ou null si aucun entretien n'a été réalisé
        /// </summary>
        /// <returns>objet Entretien ou null</returns>
        public Entretien GetDernierEntretien()
        {
            Entretien E = null;
            if (this.lesEntretiens.Count == 0)
                E = null;
            else
                E = this.lesEntretiens[this.lesEntretiens.Count - 1];
                return E;
        }

        /// <summary>
        /// Retourne un booléen indiquant si le vehicule est à entretenir ou non
        /// Méthode virtuelle redéfinie dans les classes dérivées
        /// </summary>
        /// <returns>true si un entretien est à prévoir ou false dans le cas contraire</returns>
        public virtual bool PrevoirEntretien()
        {
            return false;
        }
    }
}
