using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentOefenLibrary;

namespace TestDrivenDevelopmentOefenLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private IOpbrengstDAO opbrengstDAO;
        private IKostDAO kostDAO;
        private WinstService winstService;

        [TestInitialize]
        public void Initialize()
        {
            opbrengstDAO = new OpbrengstDAOStub();
            kostDAO = new KostDAOStub();
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }
        [TestMethod]
        public void PropertyWinstGeeftVerschilVanTotaleOpbrengstEnTotaleKost()
        {
            Assert.AreEqual(1000.0m, winstService.Winst);
        }
    }
}
