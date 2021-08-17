using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.BusinessLogic.Interface;

namespace Fizzbuzz.BusinessLogic.Implementation
{
    public class MultipleOfThree : IRule
    {
        public bool IsMultiple(int Number)
        {
            return (Number % 3 == 0);
        }
        public string GetString(DayOfWeek CurrentDay)
        {
            return CurrentDay.Equals(DayOfWeek.Wednesday) ? "Wizz" : "Fizz";
        }
    }
}
