using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentOefenLibrary;

namespace TestDrivenDevelopmentOefenLibraryTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ConstructorMetLegeStringWerptArgumentException()
        {
            new Woord(string.Empty);
        }

        [TestMethod]
        public void IsPalindroomMetIngevoerdPalindroomMetOnevenAantalLettersGeeftTrue()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }

        [TestMethod]
        public void IsPalindroomMetIngevoerdPalindroomMetEvenAantalLettersGeeftTrue()
        {
            Assert.IsTrue(new Woord("neen").IsPalindroom());
        }

        [TestMethod]
        public void IsPalindroomMetIngevoerdNietPalindroomGeeftFalse()
        {
            Assert.IsFalse(new Woord("vork").IsPalindroom());
        }
    }
}
