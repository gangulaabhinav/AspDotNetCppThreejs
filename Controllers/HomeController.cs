﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AspDotNetCppThreejs.Controllers
{
    public class HomeController : Controller
    {
        [DllImport("wwwroot/CppLibrary.dll")]
        public static extern void Hello();
        public IActionResult Index()
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
        public ActionResult Three()
        {
            return View();
        }
        public ActionResult CppThreejs()
        {
            return View(new AspDotNetCppThreejs.Models.CppThreejs());
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
