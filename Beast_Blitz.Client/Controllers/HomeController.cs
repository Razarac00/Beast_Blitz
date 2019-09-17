using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Beast_Blitz.Client.Models;
using Microsoft.AspNetCore.Http;

namespace Beast_Blitz.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
                ViewBag.UserLevel = 2;
            return View();
        }

        public IActionResult Privacy()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
                ViewBag.UserLevel = 2;
            return View();
        }

        public IActionResult Tutorial()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
                ViewBag.UserLevel = 2;
            return View();
        }

        public IActionResult Faq()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
                ViewBag.UserLevel = 2;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
