using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fizzbuzz.BusinessLogic.Test.Implementation
{
    class FizzbuzzLogicTest
    {


        [Test]
        public void GetFizzBuzzList_QueryNumberIsTen_ReturnsListOfStringOfSizeTen()
        {
            // Arrange
            var FizzbuzzLogic = new FizzbuzzLogic();

            // Act
            var Result = FizzbuzzLogic.GetFizzBuzzList(10, DayOfWeek.Monday);

            // Assert
            Assert.AreEqual(10, Result.Count);
            Assert.IsAssignableFrom<List<string>>(Result);
        }

        [Test]
        public void GetFizzBuzzList_QueryNumberIsFifteen_ReturnsListOfStringOfSizeFifteen()
        {
            // Arrange
            var FizzbuzzLogic = new FizzbuzzLogic();

            // Act
            var Result = FizzbuzzLogic.GetFizzBuzzList(15, DayOfWeek.Monday);

            // Assert
            Assert.AreEqual(15, Result.Count);
            Assert.IsAssignableFrom<List<string>>(Result);
        }
    }
}
