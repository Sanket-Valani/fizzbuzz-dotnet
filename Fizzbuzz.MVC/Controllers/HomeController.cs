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
        private IDateTimeProvider _dateTimeProvider;

        public HomeController(IFizzbuzzLogic _fizzbuzzLogic, IDateTimeProvider _dateTimeProvider)
        {
            this._fizzbuzzLogic = _fizzbuzzLogic;
            this._dateTimeProvider = _dateTimeProvider;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Result(FizzbuzzModel FizzbuzzModel, int? page)
        {
            int QueryNumber = Int32.Parse(FizzbuzzModel.InputString);
            DayOfWeek CurrentDay = _dateTimeProvider.GetCurrentDay();
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
            DayOfWeek CurrentDay = _dateTimeProvider.GetCurrentDay();
            int pageNumber = page ?? 1;
            fizzbuzzModel.OutputList = (PagedList<string>)_fizzbuzzLogic.GetFizzBuzzList(QueryNumber, CurrentDay).ToPagedList(pageNumber, 10);

            return View(fizzbuzzModel);
        }
    }
}