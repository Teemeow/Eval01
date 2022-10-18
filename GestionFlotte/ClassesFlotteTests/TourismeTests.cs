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
    public class TourismeTests
    {
        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            // cas 1 : le véhicule a dépassé les 15000 km depuis le dernier entretien
            Tourisme vt1 = new Tourisme("AA-125-BB", "Essence", 7, 4, new Modele("Fiat500", "Fiat", 15000));
            vt1.AjouterEntretien(new Entretien(new DateTime(2021, 07, 01), 14000, "RAS"));
            vt1.SetKmActuel(30000);
            Assert.AreEqual(true, vt1.PrevoirEntretien());

            // Cas 2 : le dernier entretien date de plus de 2 ans
            Tourisme vt2 = new Tourisme("AA-125-BB", "Essence", 7, 4, new Modele("Fiat500", "Fiat", 15000));
            vt2.AjouterEntretien(new Entretien(new DateTime(2020, 07, 01), 14000, "RAS"));
            vt2.SetKmActuel(25000);
            Assert.AreEqual(true, vt2.PrevoirEntretien());

            // Cas 3 : le véhicule n'a pas parcouru 15000 km depuis le dernier entretien et
            // le dernier entretien a moins de 2 ans
            Tourisme vt3 = new Tourisme("AA-125-BB", "Essence", 7, 4, new Modele("Fiat500", "Fiat", 15000));
            vt3.AjouterEntretien(new Entretien(new DateTime(2021, 07, 01), 14000, "RAS"));
            vt3.SetKmActuel(25000);
            Assert.AreEqual(false, vt3.PrevoirEntretien());
        }
    }
}