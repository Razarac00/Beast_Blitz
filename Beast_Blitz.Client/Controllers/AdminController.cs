using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Beast_Blitz.Client.Models;
using Beast_Blitz.Domain.Models;
using Beast_Blitz.Domain.Abstracts;
using Beast_Blitz.Data;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Beast_Blitz.Client.Controllers
{
    public class AdminController : Controller
    {
        Beast_Blitz_DbContext _db = new Beast_Blitz_DbContext();
        public IActionResult Dashboard()
        {
            ViewBag.Admins = _db.Admins.ToList();
            ViewBag.Armors = _db.Armors.ToList();
            ViewBag.Bosses = _db.Bosses.ToList();
            ViewBag.Elements = _db.Elements.ToList();
            ViewBag.Enemies = _db.Enemies.ToList();
            ViewBag.Foods = _db.Foods.ToList();
            ViewBag.Hats = _db.Hats.ToList();
            ViewBag.Potions = _db.Potions.ToList();
            ViewBag.Shops = _db.Shops.ToList();
            ViewBag.Species = _db.Species.ToList();
            ViewBag.Treats = _db.Treats.ToList();
            
            return View();
        }

        [HttpGet]
        public IActionResult AddNewSpecies()
        {
            ViewBag.Elements = _db.Elements.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewSpecies(Species species, IFormFile file)
        {
            if (file == null | file.Length == 0)  
            { 
                ViewBag.Error = "An item needs an image sprite!";
                return View();
            }

            var path = Path.Combine(  
                Directory.GetCurrentDirectory(), "wwwroot/img/",   
                file.FileName);
                
            using (var stream = new FileStream(path, FileMode.Create))  
            {  
                await file.CopyToAsync(stream);
            }
            
            _db.Species.Add(species);
            _db.SaveChanges();

            ViewData["Confirmation"] = $"New species '{species.Name}' added successfully.";

            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        public IActionResult AddNewElement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewElement(Element element)
        {
            if(ModelState.IsValid)
            {
                _db.Elements.Add(element);
                _db.SaveChanges();

                ViewData["Confirmation"] = $"New element '{element.Name}' added successfully.";

                return RedirectToAction("Dashboard");
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddNewShop()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewShop(Shop shop)
        {
            if(ModelState.IsValid)
            {
                _db.Shops.Add(shop);
                _db.SaveChanges();

                ViewData["Confirmation"] = $"New shop '{shop.Name}' added successfully.";

                return RedirectToAction("Dashboard");
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddNewItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewItem(IFormFile file, string name, int cost, int defense, string discriminator, string potionAmount, string potionStat, int happiness)
        {
            if (file == null | file.Length == 0)  
            { 
                ViewBag.Error = "An item needs an image sprite!";
                return View();
            }

            var path = Path.Combine(  
                Directory.GetCurrentDirectory(), "wwwroot/img/",   
                file.FileName);
                
            using (var stream = new FileStream(path, FileMode.Create))  
            {  
                await file.CopyToAsync(stream);
            }
            
            switch(discriminator)
            {
                case "Armor":
                    var newArmor = new Armor(name, cost, file.FileName, defense);
                    _db.Armors.Add(newArmor);
                    _db.SaveChanges();
                    break;
                case "Food":
                    // var newFood = new Food(name, cost, file.FileName, defense);
                    // _db.Foods.Add(newFood);
                    // _db.SaveChanges();
                    break;
                case "Hat":
                    // var newHat = new Hat(name, cost, file.FileName, happiness);
                    // _db.Hats.Add(newHat);
                    // _db.SaveChanges();
                    break;
                case "Potion":
                    // var newPotion = new Potion(name, cost, file.FileName, potionStat, potionAmount);
                    // _db.Potions.Add(newPotion);
                    // _db.SaveChanges();
                    break;
                case "Treat":
                    // var newTreat = new Treat(name, cost, file.FileName, happiness);
                    // _db.Treats.Add(newTreat);
                    // _db.SaveChanges();
                    break;
            }
                
            ViewData["Confirmation"] = $"New item '{name}' added successfully.";
            
            return View();
        }

        [HttpGet]
        public IActionResult AddToShop()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToShop(Item item, Shop shop)
        {
            if(ModelState.IsValid)
            {
                var thisShop = _db.Shops.Single(s => s.LocationID == shop.LocationID);
                thisShop.Inventory.Add(item);

                _db.SaveChanges();

                ViewData["Confirmation"] = $"Item '{item.Name}' successfully added to shop {shop.Name}.";

                return RedirectToAction("Dashboard");
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddNewLocation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewLocation(Location location)
        {
            if(ModelState.IsValid)
            {
                _db.Locations.Add(location);
                _db.SaveChanges();

                ViewData["Confirmation"] = $"New location '{location.Name}' added successfully.";

                return RedirectToAction("Dashboard");
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddNewEnemy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewEnemy(Enemy enemy)
        {
            if(ModelState.IsValid)
            {
                _db.Enemies.Add(enemy);
                _db.SaveChanges();

                ViewData["Confirmation"] = $"New enemy {enemy.Species.Name} added successfully.";

                return RedirectToAction("Dashboard");
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddNewAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewAdmin(Admin newAdmin)
        {
            if(ModelState.IsValid)
            {
                _db.Admins.Add(newAdmin);
                _db.SaveChanges();

                ViewData["Confirmation"] = $"Admin '{newAdmin.Username}' added successfully.";
                return RedirectToAction("Dashboard");
            }

            return View();
        }
    }
}
