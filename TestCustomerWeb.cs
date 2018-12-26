using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestCostumerService;
using RestCostumerService.Controllers;
using RestCostumerService.Model;

namespace TestAfWebService
{
    [TestClass]
    public class TestCustomerWeb
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomerController controller = new CustomerController();
            int expected = 3;
            //Act
            var result = controller.GetAllCustomer();

            //Assert
            Assert.AreEqual(expected, result.Count());
        }
        //[TestMethod]
        //public void TestMethod2()
        //{
        //    //Arrange
        //    CustomerController controller = new CustomerController();
        //    var expected = 200;
        //    //Act
        //    var result = controller.Delete(2);
        //    var okresult = result as OkObjectResult;
        //    //Assert
        //    Assert.AreEqual(expected, okresult.StatusCode);
        //}
        //[TestMethod]
        //public void TestMethod3()
        //{
        //    //Arrange
        //    CustomerController controller = new CustomerController();
        //    var expected = 200;

        //    //Act
        //    var result = controller.Post(new Customer(0, "Michael", "Steinmejer", 1990));
        //    var okresult = result as OkObjectResult;
        //    //Assert
        //    Assert.AreEqual(expected, okresult.StatusCode);
        //}
        //[TestMethod]
        //public void TestMethod4()
        //{
        //    //Arrange
        //    CustomerController controller = new CustomerController();

        //    var expected = 200;

        //    //Act
        //    var result = controller.Put(1, new Customer(1, "Michael", "Steinmeister", 1990));
        //    var okresult = result as OkObjectResult;
        //    //Assert
        //    Assert.AreEqual(expected, okresult.StatusCode);
        //}
    }
}
