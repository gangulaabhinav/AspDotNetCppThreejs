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
        [DllImport("CppLibrary.dll", EntryPoint = "mixed_mode_addition", CallingConvention = CallingConvention.StdCall)]
        public static extern int Sum(int x, int y);

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cpp()
        {
            ViewBag.Title = "Cpp";
            int x = 3;
            int y = 5;
            Hello();
            ViewBag.Message = "From C++: " + "Sum(" + x + "+" + y + ")=" + Sum(x, y);
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}