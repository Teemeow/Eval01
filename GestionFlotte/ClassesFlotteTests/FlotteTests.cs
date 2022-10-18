using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class FlotteTests
    {
        [TestMethod()]
        public void AjouterVehiculeTest()
        {
            Flotte maFlotte = new Flotte();
            Vehicule v1 = new Vehicule("AA-125-BB", "Essence", 7);
            Vehicule v2 = new Vehicule("AA-12-BB", "Essence", 7);
            Vehicule v3 = new Vehicule("AA-125-BBB", "Essence", 7);
            Vehicule v4 = new Vehicule("A-125-BB", "Essence", 7);
            Vehicule v5 = new Vehicule("AA-125BB", "Essence", 7);
            Vehicule v6 = new Vehicule("xxAA-125-BBB", "Essence", 7);
            Vehicule v7 = new Vehicule("AA-125-BBBxx", "Essence", 7);

            // l'immatriculation est valide, le véhicule est ajouté
            Assert.AreEqual(true, maFlotte.AjouterVehicule(v1));
            Assert.AreEqual(1, maFlotte.GetLesVehicules().Count);

            // l'immatriculation n'est pas valide, l'ajout n'est pas possible
            Assert.AreEqual(false, maFlotte.AjouterVehicule(v2));
            Assert.AreEqual(1, maFlotte.GetLesVehicules().Count);
            Assert.AreEqual(false, maFlotte.AjouterVehicule(v3));
            Assert.AreEqual(1, maFlotte.GetLesVehicules().Count);
            Assert.AreEqual(false, maFlotte.AjouterVehicule(v4));
            Assert.AreEqual(1, maFlotte.GetLesVehicules().Count);
            Assert.AreEqual(false, maFlotte.AjouterVehicule(v5));
            Assert.AreEqual(1, maFlotte.GetLesVehicules().Count);
            Assert.AreEqual(false, maFlotte.AjouterVehicule(v6));
            Assert.AreEqual(1, maFlotte.GetLesVehicules().Count);
            Assert.AreEqual(false, maFlotte.AjouterVehicule(v7));
            Assert.AreEqual(1, maFlotte.GetLesVehicules().Count);

        }
        [TestMethod()]
        public void NbVehiculesTourismeTest()
        {
            Flotte maFlotte = new Flotte();
            Tourisme v1 = new Tourisme("AA-125-BB", "Essence", 7, 4, new Modele("Fiat500", "Fiat", 15000));
            Tourisme v2 = new Tourisme("CY-345-SS", "Diesel", 8, 5, new Modele("Peugeot2008", "Peugeot", 20000));
            Utilitaire v3 = new Utilitaire("DD-789-TY", "Diesel", 5, 1200, 1700, 4);
            maFlotte.AjouterVehicule(v1);
            maFlotte.AjouterVehicule(v2);
            maFlotte.AjouterVehicule(v3);
            Assert.AreEqual(2, maFlotte.NbVehiculesTourisme());
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            Flotte maFlotte = new Flotte();
            // entretien à prévoir pour v1
            Tourisme v1 = new Tourisme("AA-125-BB", "Essence", 7, 4, new Modele("Fiat500", "Fiat", 15000));
            v1.AjouterEntretien(new Entretien(new DateTime(2021, 07, 01), 14000, "RAS"));
            v1.SetKmActuel(30000);
            maFlotte.AjouterVehicule(v1);

            // pas d'entretien pour v2
            Tourisme v2 = new Tourisme("CY-345-SS", "Diesel", 8, 5, new Modele("Peugeot2008", "Peugeot", 20000));
            v2.AjouterEntretien(new Entretien(new DateTime(2021, 07, 01), 14000, "RAS"));
            v2.SetKmActuel(30000);
            maFlotte.AjouterVehicule(v2);

            // entretien à prévoir pour v3
            Utilitaire v3 = new Utilitaire("AB-124-ZZ", "Essence", 7, 1800, 1200, 3);
            v3.AjouterEntretien(new Entretien(new DateTime(2021, 07, 01), 14000, "RAS"));
            maFlotte.AjouterVehicule(v3);

            List<Vehicule> entretiensAPrevoir = new List<Vehicule> { v1, v3 };
            CollectionAssert.AreEqual(entretiensAPrevoir, maFlotte.PrevoirEntretien());

        }
    }
}