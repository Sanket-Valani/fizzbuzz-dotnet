using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.BusinessLogic.Interface;

namespace Fizzbuzz.BusinessLogic.Implementation
{
    public class MultipleOfFiveRule : IRule
    {
        public bool IsMultiple(int Number)
        {
            return (Number % 5 == 0);
        }
        public string GetCurrentDayString(DayOfWeek CurrentDay)
        {
            return CurrentDay.Equals(DayOfWeek.Wednesday) ? "Wuzz" : "Buzz";
        }
    }
}
