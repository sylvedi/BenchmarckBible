using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenchmarckBible.Controllers
{
    public class BibleController : Controller
    {
        // GET: Bible
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string book, int chapter = 1)
        {
            ViewBag.Message = "Genesis " + book;
            ViewBag.NumTimes = chapter;

            return View();
        }
    }
}