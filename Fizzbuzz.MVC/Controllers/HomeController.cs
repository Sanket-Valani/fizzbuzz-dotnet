using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fizzbuzz.MVC.Models;
using Fizzbuzz.BusinessLogic.Interface;
using PagedList;

namespace Fizzbuzz.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IFizzbuzzLogic _fizzbuzzLogic;

        public HomeController(IFizzbuzzLogic _fizzbuzzLogic)
        {
            this._fizzbuzzLogic = _fizzbuzzLogic;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Result(string inputString, int? page)
        {
            if (inputString == null)
            {
                return RedirectToAction("Index", "Home");
            }
            int QueryNumber = Int32.Parse(inputString);
            FizzbuzzModel fizzbuzzModel = new FizzbuzzModel
            {
                InputString = QueryNumber
            };
            int pageNumber = page ?? 1;
            fizzbuzzModel.OutputList = (PagedList<string>)_fizzbuzzLogic.GetFizzBuzzList(QueryNumber).ToPagedList(pageNumber, 10);

            return View(fizzbuzzModel);
        }
    }
}