using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Radcc.Data.Persistence;
using Radcc.Mvc.Admin.Controllers;
using System.Security.Claims;
using System.Security.Principal;

namespace Radcc.Tests.Controllers.Api
{
    [TestClass]
    public class NewsArticlesControllerTests
    {
        private NewsArticlesController _controller;
        public NewsArticlesControllerTests()
        {
           

            var principle = new GenericPrincipal(identity, null);

            var mockUoW = new Mock<IUnitOfWork>();
            var controller = new NewsArticlesController(mockUoW.Object);
            controller.User = principle;
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
