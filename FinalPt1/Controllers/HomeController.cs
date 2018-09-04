using FinalPt1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalPt1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About(NumbersViewModel model)
        {
            model.Sum =model.A + model.B;
            ViewBag.Sum = model.Sum;
            return View(model);
            //return RedirectToAction("Result");
        }
        public ActionResult Result()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}