using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarSearchEngine.Controllers;
using System;
using System.Threading.Tasks;

namespace StarUnitTests.APITests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public async Task TestAPICall()
        {
            API.Request.API aPI = new API.Request.API();
            var response = await aPI.TestRequest();
        }


        [TestMethod]
        public void CheckGetdataresultsnotnullvalue()
        {
            // Arrange
            var controller = new SearchController(userRepository: null);

            //ACT
            var result = controller.GetUser("James");

            //ASSERT
            Assert.IsNotNull(result);

        }

    }
}
