using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Controllers;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Model;
using System.Web.Http.Results;

namespace BannerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetBanner()
        {
            // Arrange
              
            var controller = new BannerController();
            controller.Request = new HttpRequestMessage();

            // Act
            var response = controller.GetBanner("10");

            // Assert
            BannerModel banner;
            Assert.IsTrue(response.TryGetContentValue<BannerModel>(out banner));
            Assert.AreEqual(10, banner.Id);
        }

        [TestMethod]
        public void PostBanner()
        {
            // Arrange

            var controller = new BannerController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            // Act
            var response = controller.GetBanner("10");
            var actionResult = controller.PostBanner(new BannerModel { Id = "Banner1", Html = "Product1" ,createdOn = DateTime.Now, ModifiedOn = DateTime.Now });

            // Assert
            BannerModel banner;
            Assert.IsTrue(response.TryGetContentValue<BannerModel>(out banner));
            Assert.AreEqual(10, banner.Id);
        }


    }
}
