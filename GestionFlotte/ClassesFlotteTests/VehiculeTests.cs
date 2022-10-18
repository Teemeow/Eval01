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
    public class VehiculeTests
    {
        [TestMethod()]
        public void GetDernierEntretienTest()
        {
            Vehicule veh = new Vehicule("AA-123-BB", "Essence", 8);
            Entretien ent1 = new Entretien(new DateTime(2020, 10, 01), 12000, "RAS");
            Entretien ent2 = new Entretien(new DateTime(2021, 05, 10), 28000, "usure freins");

            // Aucun entretien pour le véhicule 
            Assert.AreEqual(null, veh.GetDernierEntretien());

            // Ajout d'un entretien, le dernier entretien du véhicule est ent1 
            veh.AjouterEntretien(ent1);
            Assert.AreEqual(ent1, veh.GetDernierEntretien());

            // Ajout d'un entretien, le dernier entretien du véhicule est ent2
            veh.AjouterEntretien(ent2);
            Assert.AreEqual(ent2, veh.GetDernierEntretien());
        }

        
    }
}