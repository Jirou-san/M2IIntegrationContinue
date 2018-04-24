using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InteContinu.Biblio;
namespace Tests
{
    [TestClass]
    public class CalculTest
    {
        [TestMethod]
        public void GetInt()
        {
            Assert.IsNotNull(Calcul.GetInt("20"));
            Assert.AreEqual(Calcul.GetInt("40"), 40);
            Assert.AreEqual(Calcul.GetInt("50"), 50);
            Assert.AreEqual(Calcul.GetInt("1000"), 1000);
        }

        [TestMethod]
        public void Operations()
        {
            Assert.AreNotEqual(Calcul.Opérations(Calcul.GetInt("20"), Calcul.GetInt("15"), '+'), 0);
            Assert.AreEqual(Calcul.Opérations(Calcul.GetInt("20"), Calcul.GetInt("15"), '+'), 35);
            Assert.AreEqual(Calcul.Opérations(Calcul.GetInt("2"), Calcul.GetInt("5"), '*'), 10);
            Assert.AreEqual(Calcul.Opérations(Calcul.GetInt("20"), Calcul.GetInt("2"), '/'), 10);
            Assert.AreEqual(Calcul.Opérations(Calcul.GetInt("100"), Calcul.GetInt("1000"), '-'), -900);

        }
    }
}
