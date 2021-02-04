using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.InteropServices;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        [DllImport("CppLibrary.dll")]
        public static extern void Hello();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cpp()
        {
            ViewBag.Title = "Cpp";
            ViewBag.Message = "Calling Hello() from CppLibrary.dll";
            Hello();
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}