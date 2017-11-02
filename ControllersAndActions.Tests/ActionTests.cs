using System.Web.Mvc;
using ControllersAndActions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void ControllerTest()
        {
            //Arrange
            ExampleController target = new ExampleController();
            //Act
            ViewResult result = (ViewResult)target.Index();
            //Assert
            Assert.AreEqual("", result.ViewName);
        }

        [TestMethod]
        public void ViewSelectionTest()
        {
            //Arrange
            ExampleController target = new ExampleController();
            //Act
            ViewResult result = (ViewResult)target.Index();
            //Assert
            Assert.AreEqual("", result.ViewName);
            Assert.IsInstanceOfType(result.ViewData.Model, typeof(System.DateTime));
        }
    }
}
