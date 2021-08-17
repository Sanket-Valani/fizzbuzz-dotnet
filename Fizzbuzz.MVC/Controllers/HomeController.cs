using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fizzbuzz.MVC.Models;
using Fizzbuzz.BusinessLogic.Implementation;
using PagedList;

namespace Fizzbuzz.MVC.Controllers
{
    public class HomeController : Controller
    {
        private FizzbuzzLogic _fizzbuzzLogic = new FizzbuzzLogic();
        private DateTimeProvider _dayTimeProvider = new DateTimeProvider();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(FizzbuzzModel FizzbuzzModel, int? page)
        {
            int QueryNumber = Int32.Parse(FizzbuzzModel.InputString);
            DayOfWeek CurrentDay = _dayTimeProvider.GetCurrentDay();
            int pageNumber = page ?? 1;
            FizzbuzzModel.OutputList = (PagedList<string>)_fizzbuzzLogic.GetFizzBuzzList(QueryNumber, CurrentDay).ToPagedList(pageNumber, 10);

            return View(FizzbuzzModel);
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
                InputString = inputString
            };
            DayOfWeek CurrentDay = _dayTimeProvider.GetCurrentDay();
            int pageNumber = page ?? 1;
            fizzbuzzModel.OutputList = (PagedList<string>)_fizzbuzzLogic.GetFizzBuzzList(QueryNumber, CurrentDay).ToPagedList(pageNumber, 10);

            return View(fizzbuzzModel);
        }
    }
}