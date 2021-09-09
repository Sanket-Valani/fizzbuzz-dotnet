using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace Fizzbuzz.MVC.Models
{
    public class FizzbuzzModel
    {
        public int InputString { get; set; }
        public PagedList<string> OutputList { get; set; }
    }
}