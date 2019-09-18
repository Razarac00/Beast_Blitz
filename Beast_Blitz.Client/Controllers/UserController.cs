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
        public IActionResult Profile(int uid)
        {
            if(uid == 0)
                return RedirectToAction("Register");
            ViewBag.UserLevel = 2;

            var thisUser = _db.Players
                .Where(p => p.UserID == uid)
                .Include(p => p.Pets)
                .ThenInclude(pe => pe.Species)
                .First();
            TempData["UserId"] = uid;
            return View(thisUser);
        }

        public IActionResult Team(int uid)
        {
            if(uid == 0)
                return RedirectToAction("Register");
            ViewBag.UserLevel = 2;

            var thisUser = _db.Players.Where(p => p.UserID == uid)
                .Include(p => p.Pets)
                .ThenInclude(pe => pe.Species)
                .First();
        
            TempData["UserId"] = uid;
            return View(thisUser);
        }

        public IActionResult Pet(int petId, int uid)
        {
            var thisUser = _db.Players
                .Include(u => u.Pets)
                .ThenInclude(pe => pe.Species)
                .Single(u => u.UserID == uid);

            TempData["UserId"] = uid;
            
            var thisPet = thisUser.Pets
                .Where(p => p.MonsterID == petId)
                .FirstOrDefault();
            if(thisPet == null)
            {
                return RedirectToAction("Team");
            }
            ViewBag.UserLevel = 2;

            return View(thisPet);
        }

        public IActionResult Inventory(int uid)
        {
            if(uid == 0)
                return RedirectToAction("Register");
            TempData["UserId"] = uid;
            ViewBag.UserLevel = 2;
            return View();
        }

        [HttpGet]
        public IActionResult Register(int uid)
        {
            if(uid != 0)
                return RedirectToAction("Index", "Home");
            TempData["UserId"] = uid;
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

                TempData["UserId"] = thisPlayer.UserID;
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
                TempData["UserId"] = thisUser.UserID;
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Register");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
