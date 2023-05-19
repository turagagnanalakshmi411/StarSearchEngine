using StarSearchEngine.Controllers;
 

namespace Unittests
{
    [TestClass]
    public class UnitTest1
    {
           
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

        [TestMethod]
        public void CheckGetdataresultsreturnsValue() { 
            // Arrange
            var controller = new SearchController(userRepository: null);

            //ACT
            var result = controller.GetUser("James");

            //ASSERT
            Assert.IsTrue(result.Count() > 0);

        }
    }
}