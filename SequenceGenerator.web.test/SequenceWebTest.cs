using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceGeneratorWeb.Controllers;
using SequenceGeneratorWeb.Models;
using System.Web;
using System.Net;
using System.Web.Mvc;
using SequenceGnerator;

namespace SequenceGenerator.web.test
{
    [TestClass]
    public class SequenceWebTest
    {
        [TestMethod]
        public void Index_Returning_simple_view()
        {
            var controller = new SequenceController();


            var result = controller.Index(new SequenceGeneratorModel());


            
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var viewResult = result as ViewResult;
            Assert.IsTrue(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual("Index", viewResult.ViewName);
        }
        [TestMethod]
        public void Index_Does_Nothing_If_The_MaxValue_Is_Not_Known()
        {
            // Arrange
            var controller = new SequenceController(null);
            var model = new SequenceGeneratorModel()
            {
                EndValue = null
            };

            // Act
            var result = controller.Index(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(model.Results == null);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var viewResult = result as ViewResult;
            Assert.AreEqual("Index", viewResult.ViewName);
        }
        [TestMethod]
        public void Index_Returns_A_Model_With_Results()
        {
            // Arrange
            var controller = new SequenceController(new[] { new AllNumberSequence() });
            var model = new SequenceGeneratorModel()
            {
                EndValue = 5
            };

            // Act
            var result = controller.Index(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(model.Results != null);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var viewResult = result as ViewResult;
            Assert.IsTrue(viewResult.ViewData.ModelState.IsValid);
            Assert.AreEqual("Index", viewResult.ViewName);
        }
    }
}
