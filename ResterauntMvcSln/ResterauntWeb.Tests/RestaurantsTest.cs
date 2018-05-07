using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantData.Models;
using ResterauntWeb.Controllers;
using System.Collections.Generic;
using Rest.DAL;

namespace ResterauntWeb.Tests
{
    [TestClass]
    public class RestaurantsTest
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


        [TestMethod]
        public void TestSortByCity()
        {

            SortingFunctions sorting = new SortingFunctions();

            Restaurant rest1 = new Restaurant()
            {
             
                City = "Tampa"
            };
            Restaurant rest2 = new Restaurant()
            {
                City = "Los Angelas"

            };
            Restaurant rest3 = new Restaurant()
            {
                City = "Miami"

            };
            List<Restaurant> mockList = new List<Restaurant>()
            {
                rest1,
                rest2,
                rest3
            };
            List<Restaurant> ExpectedResult = new List<Restaurant>()
            {

                rest3
        
            };

          var ActualResult =  sorting.FilterByCity("Miami", mockList);
            CollectionAssert.AreEqual(ExpectedResult, ActualResult);

        }

        [TestMethod]
        public void TestSortByName()
        {


        }
        [TestMethod]
        public void TestSortByMostReviewed()
        {


        }
    }
}
