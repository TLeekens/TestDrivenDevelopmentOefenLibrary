using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentOefenLibrary;

namespace TestDrivenDevelopmentOefenLibraryTest
{
    [TestClass]
    public class VeilingTest
    {
        private Veiling veiling;
        [TestInitialize]
        public void Initialize()
        {
            veiling = new Veiling();
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void DoeBodMetEenNegatiefBodWerptEenArgumentException()
        {
            veiling.DoeBod(-1.0m);
        }
        [TestMethod]
        public void AlsNogGeenBodWerdIngevoerdIsHetHoogsteBodNul()
        {
            Assert.AreEqual(decimal.Zero, veiling.HoogsteBod());
        }
        [TestMethod]
        public void NaEenEnkelBodIsHetHoogsteBodHetBedragVanDatEneBod()
        {
            decimal bedrag = 100.0m;
            veiling.DoeBod(bedrag);
            Assert.AreEqual(bedrag, veiling.HoogsteBod());
        }
        [TestMethod]
        public void NaMeerdereBodenIsHetHoogsteBodHetHoogsteBedrag()
        {
            decimal hoogsteBedrag = 200.0m;
            veiling.DoeBod(100.0m);
            veiling.DoeBod(hoogsteBedrag);
            veiling.DoeBod(150.0m);
            Assert.AreEqual(hoogsteBedrag, veiling.HoogsteBod());
        }
    }
}
