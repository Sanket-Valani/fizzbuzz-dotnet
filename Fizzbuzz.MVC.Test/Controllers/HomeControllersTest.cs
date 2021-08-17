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
        private Mock<IFizzbuzzLogic> _fizzbuzzLogic;
        private Mock<IDateTimeProvider> _dateTimeProvider;

        [SetUp]
        public void Setup()
        {
            _fizzbuzzLogic = new Mock<IFizzbuzzLogic>();
            _fizzbuzzLogic.Setup(x => x.GetFizzBuzzList(It.IsAny<int>(), It.IsAny<DayOfWeek>())).Returns(new List<string>());
            _dateTimeProvider = new Mock<IDateTimeProvider>();
        }

        [Test]
        public void Result_FizzbuzzModelWithInputStringTenAndPageNumberOne_ReturnViewResultWithInputStringAndOutputListOfPagedListType()
        {
            // Arrange
            var HomeController = new HomeController(_fizzbuzzLogic.Object, _dateTimeProvider.Object);
            var DummyModel = new FizzbuzzModel
            {
                InputString = "10"
            };
            var page = 1;

            // Act
            var ViewResult = HomeController.Result(DummyModel, page) as ViewResult;
            var FizzbuzzModel = ViewResult.Model as FizzbuzzModel;

            // Assert
            string ExpectedInputString = "10";

            Assert.AreEqual(ExpectedInputString, FizzbuzzModel.InputString);
            Assert.IsAssignableFrom<PagedList<string>>(FizzbuzzModel.OutputList);

        }

        [Test]
        public void Result_InputStringTenAndPageNumberOne_ReturnViewResultWithInputStringAndOutputListOfPagedListType()
        {
            // Arrange
            var HomeController = new HomeController(_fizzbuzzLogic.Object, _dateTimeProvider.Object);
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
