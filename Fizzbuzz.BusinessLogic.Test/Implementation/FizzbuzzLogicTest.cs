using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fizzbuzz.BusinessLogic.Implementation;
using Fizzbuzz.BusinessLogic.Interface;
using Moq;

namespace Fizzbuzz.BusinessLogic.Test.Implementation
{
    class FizzbuzzLogicTest
    {
        private IEnumerable<IRule> _rules;
        private Mock<IDateTimeProvider> _dateTimeProvider;

        [SetUp]
        public void Setup()
        {
            _rules = new List<IRule>() { new Mock<IRule>().Object, new Mock<IRule>().Object };
            _dateTimeProvider = new Mock<IDateTimeProvider>();
        }

        [Test]
        public void GetFizzBuzzList_QueryNumberIsTen_ReturnsListOfStringOfSizeTen()
        {
            // Arrange
            var FizzbuzzLogic = new FizzbuzzLogic(_rules, _dateTimeProvider.Object);

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
            var FizzbuzzLogic = new FizzbuzzLogic(_rules, _dateTimeProvider.Object);

            // Act
            var Result = FizzbuzzLogic.GetFizzBuzzList(15, DayOfWeek.Monday);

            // Assert
            Assert.AreEqual(15, Result.Count);
            Assert.IsAssignableFrom<List<string>>(Result);
        }
    }
}
