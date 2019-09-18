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
        public IActionResult Index(int uid)
        {
            if(uid != 0 | TempData["UserId"] != null)
            {
                ViewBag.UserLevel = 2;
                
            }
            if(TempData["UserId"] == null)
            {
                TempData["UserId"] = uid;
            }
            return View();
        }

        public IActionResult Privacy(int uid)
        {
            if(uid != 0)
                ViewBag.UserLevel = 2;
            TempData["UserId"] = uid;
            return View();
        }

        public IActionResult Tutorial(int uid)
        {
            if(uid != 0)
                ViewBag.UserLevel = 2;
            TempData["UserId"] = uid;
            return View();
        }

        public IActionResult Faq(int uid)
        {
            if(uid != 0)
                ViewBag.UserLevel = 2;
            TempData["UserId"] = uid;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int uid)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
