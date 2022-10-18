using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassesFlotte
{
    public class Flotte
    {
        private List<Vehicule> lesVehicules;    // liste des véhicules

        /// <summary>
        /// Constructeur de la classe Flotte
        /// </summary>
        public Flotte()
        {
            this.lesVehicules = new List<Vehicule>();
        }

        /// <summary>
        /// Ajoute un véhicule à la flotte de véhicules 
        /// après vérification de la validité du numéro d'immatriculation
        /// </summary>
        /// <param name="unVehicule">objet Vehicule à ajouter</param>
        /// <returns>true si ajout du véhicule effectué ou false dans le cas contraire</returns>
        public bool AjouterVehicule(Vehicule unVehicule)
        {
            string pattern = @"";
            bool match = Regex.IsMatch(unVehicule.GetImmat(), pattern);
            if (match)
            {
                this.lesVehicules.Add(unVehicule);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Retourne la liste des véhicules de la flotte
        /// </summary>
        /// <returns>Liste des véhicules</returns>
        public List<Vehicule> GetLesVehicules()
        {
            return this.lesVehicules;
        }

        /// <summary>
        /// Retourne la liste des véhicules qui sont à entretenir
        /// </summary>
        /// <returns>liste des vehicules à entretenir</returns>
        public List<Vehicule> PrevoirEntretien()
        {
            // TODO
            return null;
        }

        /// <summary>
        /// Retourne le nombre de vehicules de tourisme dans la flotte
        /// </summary>
        /// <returns>nombre de véhicules de tourisme</returns>
        public int NbVehiculesTourisme()
        {
            // TODO
            return 0;
        }

    }
}
