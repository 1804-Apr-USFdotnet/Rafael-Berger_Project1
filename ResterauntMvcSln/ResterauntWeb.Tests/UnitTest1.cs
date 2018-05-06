using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResterauntWeb.Controllers;

namespace ResterauntWeb.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            RestaurantsController prodController = new RestaurantsController(); // ToDo  - mock  DbContext and pass that in

            // Act
            var result = prodController.RestList() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        //    Assert.IsNotNull(result.Model); // add additional checks on the Model
            Assert.IsTrue(string.IsNullOrEmpty(result.ViewName) || result.ViewName == "RestList");


        }
    }
}
