using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentOefenLibrary;
using Moq;

namespace TestDrivenDevelopmentOefenLibraryTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private Mock<IOpbrengstDAO> opbrengstMockFactory;
        private Mock<IKostDAO> kostMockFactory;
        private IOpbrengstDAO opbrengstDAO;
        private IKostDAO kostDAO;
        private WinstService winstService;

        [TestInitialize]
        public void Initialize()
        {
            opbrengstMockFactory = new Mock<IOpbrengstDAO>();
            opbrengstDAO = opbrengstMockFactory.Object;
            opbrengstMockFactory.Setup(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst()).Returns(2000.0m);
            kostMockFactory = new Mock<IKostDAO>();
            kostDAO = kostMockFactory.Object;
            kostMockFactory.Setup(eenKostDAO => eenKostDAO.TotaleKost()).Returns(1000.0m);
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }
        [TestMethod]
        public void PropertyWinstGeeftVerschilVanTotaleOpbrengstEnTotaleKost()
        {
            Assert.AreEqual(1000.0m, winstService.Winst);
            opbrengstMockFactory.Verify(eenOpbrengstDAO => eenOpbrengstDAO.TotaleOpbrengst());
            kostMockFactory.Verify(eenKostDAO => eenKostDAO.TotaleKost());
        }
    }
}
