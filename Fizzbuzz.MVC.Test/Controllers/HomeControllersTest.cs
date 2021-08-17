using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PagedList;

namespace Fizzbuzz.MVC.Test.Controllers
{
    class HomeControllersTest
    {
        [Test]
        public void Result_FizzbuzzModelWithInputStringTenAndPageNumberOne_ReturnViewResultWithInputStringAndOutputListOfPagedListType()
        {
            // Arrange
            var HomeController = new HomeController();
            var DummyModel = new FizzbuzzModel
            {
                inputString = "10"
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
            var HomeController = new HomeController();
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
