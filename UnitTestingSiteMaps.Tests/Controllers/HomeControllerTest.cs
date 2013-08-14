using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingSiteMaps;
using UnitTestingSiteMaps.Controllers;
using Moq;
using MvcSiteMapProvider;
using MvcSiteMapProvider.Loader;

namespace UnitTestingSiteMaps.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Index_Post()
        {
            // Arrange
            HomeController controller = new HomeController();
            var collection = new FormCollection();
            SiteMaps.Loader = new Mock<ISiteMapLoader>().Object;

            // Act
            ViewResult result = controller.Index(collection) as ViewResult;

            // Assert
            Assert.AreEqual("The cache was reset.", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
