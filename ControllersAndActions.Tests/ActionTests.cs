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
            //ViewResult result = (ViewResult)target.Index();
            RedirectToRouteResult result = target.Redirect();
            //Assert
            //Assert.AreEqual("", result.ViewName);

            //Assert.AreEqual("Hello", result.ViewBag.Message);

            //Assert.IsTrue(result.Permanent);
            //Assert.AreEqual("/Example/Index", result.Url);

            Assert.IsFalse(result.Permanent);
            Assert.AreEqual("Example", result.RouteValues["controller"]);
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("MyID", result.RouteValues["ID"]);
        }

        [TestMethod]
        public void ControllerStatusCodeTest()
        {
            // Arrange - create the controller
            ExampleController target = new ExampleController();
            // Act - call the action method
            HttpStatusCodeResult result = target.StatusCode();
            // Assert - check the result
            Assert.AreEqual(401, result.StatusCode);
        }.

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
