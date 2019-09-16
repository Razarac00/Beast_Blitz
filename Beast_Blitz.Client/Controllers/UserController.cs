using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Beast_Blitz.Domain.Models;
using Microsoft.AspNetCore.Http;
using Beast_Blitz.Domain.Abstracts;
using Beast_Blitz.Data;

namespace Beast_Blitz.Client.Controllers
{
    public class UserController : Controller
    {
        Beast_Blitz_DbContext _db = new Beast_Blitz_DbContext();
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
        public IActionResult Register(Player newPlayer, Pet newPet, string speciesName)
        {
            if(ModelState.IsValid)
            {
                //add to db
                var thisSpecies = _db.Species.FirstOrDefault(s => s.Name == speciesName);
                if(thisSpecies == null)
                {
                    ModelState.AddModelError("Name", "Species does not exist!");
                    return View();
                }

                newPet.Species = thisSpecies;
                _db.Pets.Add(newPet);
                _db.Players.Add(newPlayer);
                _db.SaveChanges();

                var thisPlayer = _db.Players.Single(p => p.Username == newPlayer.Username);

                HttpContext.Session.SetInt32("UserId", thisPlayer.UserID);
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
