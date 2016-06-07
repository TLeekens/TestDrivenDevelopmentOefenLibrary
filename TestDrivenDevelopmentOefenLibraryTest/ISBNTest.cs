using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentOefenLibrary;

namespace TestDrivenDevelopmentOefenLibraryTest
{
    [TestClass]
    public class ISBNTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNegatiefNummerWerptArgumentException()
        {
            new ISBN(-9789027439642);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMetTwaalfCijfersWerptArgumentException()
        {
            new ISBN(123456789012);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMetVeertienCijfersWerptArgumentException()
        {
            new ISBN(12345678901234);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenNummerMetDertienCijfersMetFoutEindCijferWerptArgumentException()
        {
            new ISBN(9789027439643);
        }

        [TestMethod]
        public void BijEenCorrectISBNNummerGeeftDeToStringDatzelfdeNummerAlsEenStringTerug()
        {
            long nummer = 9789027439642;
            Assert.AreEqual(nummer.ToString(), new ISBN(nummer).ToString());
        }

        [TestMethod]
        public void BijEenCorrectISBNNummerMetNulAchteraanGeeftDeToStringDatzelfdeNummerAlsEenStringTerug()
        {
            long nummer = 9789227439640;
            Assert.AreEqual(nummer.ToString(), new ISBN(nummer).ToString());
        }
    }
}
