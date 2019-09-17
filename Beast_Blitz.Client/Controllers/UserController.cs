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
using Microsoft.EntityFrameworkCore;

namespace Beast_Blitz.Client.Controllers
{
    public class UserController : Controller
    {
        Beast_Blitz_DbContext _db = new Beast_Blitz_DbContext();
        public IActionResult Profile()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
                return RedirectToAction("Register");

            var thisUser = _db.Players
                .Where(p => p.UserID == HttpContext.Session.GetInt32("UserId"))
                .Include(p => p.Pets)
                .ThenInclude(pe => pe.Species)
                .First();
            return View(thisUser);
        }

        public IActionResult Team()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
                return RedirectToAction("Register");

            var thisUser = _db.Players.Where(p => p.UserID == HttpContext.Session.GetInt32("UserId"))
                .Include(p => p.Pets)
                .ThenInclude(pe => pe.Species)
                .First();
            return View(thisUser);
        }

        public IActionResult Pet(int petId)
        {
            var thisUser = _db.Players
                .Include(u => u.Pets)
                .ThenInclude(pe => pe.Species)
                .Single(u => u.UserID == HttpContext.Session.GetInt32("UserId"));
            var thisPet = thisUser.Pets
                .Where(p => p.MonsterID == petId)
                .FirstOrDefault();
            if(thisPet == null)
                return RedirectToAction("Team");
            return View(thisPet);
        }

        public IActionResult Inventory()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
                return RedirectToAction("Register");
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
                var thisPet = _db.Pets.Last();

                thisPlayer.AddNewPet(thisPet);
                _db.SaveChanges();

                HttpContext.Session.SetInt32("UserId", thisPlayer.UserID);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            var thisUser = _db.Users.Where(u => u.Username == Username && u.Password == Password).FirstOrDefault();
            if(thisUser != null)
            {
                HttpContext.Session.SetInt32("UserId", thisUser.UserID);
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Register");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
