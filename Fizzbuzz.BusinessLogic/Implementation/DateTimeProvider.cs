using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.BusinessLogic.Interface;

namespace Fizzbuzz.BusinessLogic.Implementation
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DayOfWeek GetCurrentDay()
        {
            return DateTime.Today.DayOfWeek;
        }
    }
}
