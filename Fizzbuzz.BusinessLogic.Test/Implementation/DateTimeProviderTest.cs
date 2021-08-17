using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fizzbuzz.BusinessLogic.Test.Implementation
{
    class DateTimeProviderTest
    {
        [Test]
        public void GetDay_CheckForCurrentDay_ReturnsCurrentDay()
        {
            // Arrange
            var DateTimeProvider = new DateTimeProvider();

            // Act
            var Result = DateTimeProvider.GetCurrentDay();

            // Assert
            DayOfWeek Expected = DateTime.Today.DayOfWeek;
            Assert.AreEqual(Expected, Result);
        }
    }
}
