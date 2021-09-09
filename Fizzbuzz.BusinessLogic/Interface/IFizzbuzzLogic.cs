using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.BusinessLogic.Interface
{
    public interface IFizzbuzzLogic
    {
        IList<string> GetFizzBuzzList(int QueryNumber);
    }
}
