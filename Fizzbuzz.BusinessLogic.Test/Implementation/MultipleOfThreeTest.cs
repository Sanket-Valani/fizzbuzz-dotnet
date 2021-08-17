using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fizzbuzz.BusinessLogic.Test.Implementation
{
    class MultipleOfThreeTest
    {
        [Test]
        public void IsMultiple_InputIsMultipleOfThree_ReturnsTrue()
        {
            // Arrange
            var MultipleOfThree = new MultipleOfThree();

            // Act
            var Result = MultipleOfThree.IsMultiple(3);

            // Assert
            Assert.IsTrue(Result);
        }

        [Test]
        public void IsMultiple_InputIsNotMultipleOfThree_ReturnsFalse()
        {
            // Arrange
            var MultipleOfThree = new MultipleOfThree();

            // Act
            var Result = MultipleOfThree.IsMultiple(4);

            // Assert
            Assert.IsFalse(Result);
        }

        [Test]
        public void GetString_CurrentDayIsWednesday_ReturnsWizz()
        {
            // Arrange
            var MultipleOfThree = new MultipleOfThree();

            // Act
            var Result = MultipleOfThree.GetString(DayOfWeek.Wednesday);

            // Assert
            string Expected = "Wizz";
            Assert.AreEqual(Expected, Result);
        }

        [Test]
        public void GetString_CurrentDayIsNotWednesday_ReturnsFizz()
        {
            // Arrange
            var MultipleOfThree = new MultipleOfThree();

            // Act
            var Result = MultipleOfThree.GetString(DayOfWeek.Monday);

            // Assert
            string Expected = "Fizz";
            Assert.AreEqual(Expected, Result);
        }
    }
}
