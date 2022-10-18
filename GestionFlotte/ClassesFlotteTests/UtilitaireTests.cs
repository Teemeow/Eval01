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
    public class UtilitaireTests
    {
        [TestMethod()]
        public void ChargeUtileTest()
        {
            Utilitaire U = new Utilitaire("A", "electrique", 30, 3000, 2000, 300);
            Assert.AreEqual(1000, U.ChargeUtile());
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            Utilitaire U = new Utilitaire("A", "electrique", 30, 3000, 2000, 300);
            U.AjouterEntretien(new Entretien(new DateTime(2022, 05, 09), 2000, "no comment"));
            Assert.AreEqual(false, U.PrevoirEntretien());

            U.AjouterEntretien(new Entretien(new DateTime(2017, 05, 09), 2000, "no comment"));
            Assert.AreEqual(true, U.PrevoirEntretien());
        }
    }
}