using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fizzbuzz.BusinessLogic.Implementation;


namespace Fizzbuzz.BusinessLogic.Test.Implementation
{
    class MultipleOfThreeRuleTest
    {
        [Test]
        public void IsMultiple_InputIsMultipleOfThree_ReturnsTrue()
        {
            // Arrange
            var MultipleOfThreeRule = new MultipleOfThreeRule();

            // Act
            var Result = MultipleOfThreeRule.IsMultiple(3);

            // Assert
            Assert.IsTrue(Result);
        }

        [Test]
        public void IsMultiple_InputIsNotMultipleOfThree_ReturnsFalse()
        {
            // Arrange
            var MultipleOfThreeRule = new MultipleOfThreeRule();

            // Act
            var Result = MultipleOfThreeRule.IsMultiple(4);

            // Assert
            Assert.IsFalse(Result);
        }

        [Test]
        public void GetString_CurrentDayIsWednesday_ReturnsWizz()
        {
            // Arrange
            var MultipleOfThreeRule = new MultipleOfThreeRule();

            // Act
            var Result = MultipleOfThreeRule.GetCurrentDayString(DayOfWeek.Wednesday);

            // Assert
            string Expected = "Wizz";
            Assert.AreEqual(Expected, Result);
        }

        [Test]
        public void GetString_CurrentDayIsNotWednesday_ReturnsFizz()
        {
            // Arrange
            var MultipleOfThreeRule = new MultipleOfThreeRule();

            // Act
            var Result = MultipleOfThreeRule.GetCurrentDayString(DayOfWeek.Monday);

            // Assert
            string Expected = "Fizz";
            Assert.AreEqual(Expected, Result);
        }
    }
}
