using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.BusinessLogic.Interface
{
    public interface IRule
    {
        bool IsMultiple(int Number);
        string GetString(DayOfWeek CurrentDay);
    }
}
