using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PagedList;
using System.Web.Mvc;
using Fizzbuzz.MVC.Models;
using Fizzbuzz.MVC.Controllers;
using Fizzbuzz.BusinessLogic.Interface;
using Moq;

namespace Fizzbuzz.MVC.Test.Controllers
{
    class HomeControllersTest
    {
        private Mock<IFizzbuzzLogic> FizzbuzzLogic;

        [SetUp]
        public void Setup()
        {
            FizzbuzzLogic = new Mock<IFizzbuzzLogic>();
            FizzbuzzLogic.Setup(x => x.GetFizzBuzzList(It.IsAny<int>())).Returns(new List<string>());
        }

        [Test]
        public void Result_InputStringTenAndPageNumberOne_ReturnViewResultWithInputStringAndOutputListOfPagedListType()
        {
            // Arrange
            var HomeController = new HomeController(FizzbuzzLogic.Object);
            var inputString = "10";
            var page = 1;

            // Act
            var ViewResult = HomeController.Result(inputString, page) as ViewResult;
            var FizzbuzzModel = ViewResult.Model as FizzbuzzModel;

            // Assert
            string ExpectedInputString = "10";

            Assert.AreEqual(ExpectedInputString, FizzbuzzModel.InputString);
            Assert.IsAssignableFrom<PagedList<string>>(FizzbuzzModel.OutputList);
        }
    }
}
