using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InteContinu.Biblio;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(Calcul.GetInt("20"));
            Assert.AreEqual(Calcul.GetInt("40"), 40);
            Assert.AreEqual(Calcul.GetInt("50"), 50);
            Assert.AreEqual(Calcul.GetInt("1000"), 1000);
        }
    }
}
