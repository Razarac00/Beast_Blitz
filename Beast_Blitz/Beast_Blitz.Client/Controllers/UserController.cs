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
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Pet()
        {
            return View();
        }

        public IActionResult Inventory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string thisUser)
        {
            if(ModelState.IsValid)
            {
                HttpContext.Session.SetInt32("UserId", 1);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
