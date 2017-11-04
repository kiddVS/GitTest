﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using docker1.Models;

namespace docker1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string s = "test";
            string str = "dev分支修改2";
            string str2 = "dev分支修改2";
            return Content("Hello YiChe");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
