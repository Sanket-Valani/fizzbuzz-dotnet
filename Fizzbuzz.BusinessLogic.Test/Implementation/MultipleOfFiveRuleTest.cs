using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fizzbuzz.BusinessLogic.Implementation;


namespace Fizzbuzz.BusinessLogic.Test.Implementation
{
    class MultipleOfFiveRuleTest
    {
        [Test]
        public void IsMultiple_InputIsMultipleOfFive_ReturnsTrue()
        {
            // Arrange
            var MultipleOfFiveRule = new MultipleOfFiveRule();

            // Act
            var Result = MultipleOfFiveRule.IsMultiple(10);

            // Assert
            Assert.IsTrue(Result);
        }

        [Test]
        public void IsMultiple_InputIsNotMultipleOfFive_ReturnsFalse()
        {
            // Arrange
            var MultipleOfFiveRule = new MultipleOfFiveRule();

            // Act
            var Result = MultipleOfFiveRule.IsMultiple(7);

            // Assert
            Assert.IsFalse(Result);
        }

        [Test]
        public void GetString_CurrentDayIsWednesday_ReturnsWuzz()
        {
            // Arrange
            var MultipleOfFiveRule = new MultipleOfFiveRule();

            // Act
            var Result = MultipleOfFiveRule.GetCurrentDayString(DayOfWeek.Wednesday);

            // Assert
            string Expected = "Wuzz";
            Assert.AreEqual(Expected, Result);
        }

        [Test]
        public void GetString_CurrentDayIsNotWednesday_ReturnsBuzz()
        {
            // Arrange
            var MultipleOfFiveRule = new MultipleOfFiveRule();

            // Act
            var Result = MultipleOfFiveRule.GetCurrentDayString(DayOfWeek.Monday);

            // Assert
            string Expected = "Buzz";
            Assert.AreEqual(Expected, Result);
        }
    }
}
