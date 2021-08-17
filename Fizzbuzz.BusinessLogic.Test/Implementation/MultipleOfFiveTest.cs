using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fizzbuzz.BusinessLogic.Test.Implementation
{
    class MultipleOfFiveTest
    {
        [Test]
        public void IsMultiple_InputIsMultipleOfFive_ReturnsTrue()
        {
            // Arrange
            var MultipleOfFive = new MultipleOfFive();

            // Act
            var Result = MultipleOfFive.IsMultiple(10);

            // Assert
            Assert.IsTrue(Result);
        }

        [Test]
        public void IsMultiple_InputIsNotMultipleOfFive_ReturnsFalse()
        {
            // Arrange
            var MultipleOfFive = new MultipleOfFive();

            // Act
            var Result = MultipleOfFive.IsMultiple(7);

            // Assert
            Assert.IsFalse(Result);
        }

        [Test]
        public void GetString_CurrentDayIsWednesday_ReturnsWuzz()
        {
            // Arrange
            var MultipleOfFive = new MultipleOfFive();

            // Act
            var Result = MultipleOfFive.GetString(DayOfWeek.Wednesday);

            // Assert
            string Expected = "Wuzz";
            Assert.AreEqual(Expected, Result);
        }

        [Test]
        public void GetString_CurrentDayIsNotWednesday_ReturnsBuzz()
        {
            // Arrange
            var MultipleOfFive = new MultipleOfFive();

            // Act
            var Result = MultipleOfFive.GetString(DayOfWeek.Monday);

            // Assert
            string Expected = "Buzz";
            Assert.AreEqual(Expected, Result);
        }
    }
}
