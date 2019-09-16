using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Beast_Blitz.Domain.Models;
using Microsoft.AspNetCore.Http;
using Beast_Blitz.Domain.Abstracts;

namespace Beast_Blitz.Client.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Pet(int petId)
        {
            //if User.Pets.Where(p => p.PetId == petId) == null
            //return RedirectToAction("Team");
            
            //fetch pet by pet id and pass to view
            return View();
        }

        public IActionResult Inventory()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Player newPlayer, Pet newPet)
        {
            if(ModelState.IsValid)
            {
                //add to db
                HttpContext.Session.SetInt32("UserId", 1);
                return RedirectToAction("Index", "Home");
            }

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
