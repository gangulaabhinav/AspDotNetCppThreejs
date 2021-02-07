using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCppThreejs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Cpp()
        {
            ViewBag.Title = "Cpp";
            ViewBag.Message = "Placeholder for message from Cpp dll call.";
            return View();
        }
        public ActionResult Three()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
