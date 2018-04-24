using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InteContinu.Test
{
    [TestClass]
    public class CalculTest
    {
        [TestMethod]
        public void GetInt()
        {
            Assert.IsNotNull(Biblio.Calcul.GetInt("20"));
            Assert.AreEqual(Biblio.Calcul.GetInt("40"), 40);
            Assert.AreEqual(Biblio.Calcul.GetInt("50"), 50);
            Assert.AreEqual(Biblio.Calcul.GetInt("1000"), 1000);
        }
    }
}
