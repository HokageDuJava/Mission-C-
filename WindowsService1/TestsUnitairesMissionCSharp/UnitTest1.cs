using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsService1;

namespace TestsUnitairesMissionCSharp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAnneeMoisPrecedent()
        {
            GestionDate gestionDate = new GestionDate();
            Assert.AreEqual("201611", gestionDate.getAnneeMoisPrecedent());

        }
    }
}
