using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Beast_Blitz.Client.Models;
using Beast_Blitz.Data;
using Microsoft.AspNetCore.Http;

namespace Beast_Blitz.Client.Controllers
{
    public class WorldController : Controller
    {
        Beast_Blitz_DbContext _db = new Beast_Blitz_DbContext();
        public IActionResult Shops(int uid)
        {
            if(uid == 0)
                return RedirectToAction("Index", "Home");
            ViewBag.UserLevel = 2;
            TempData["UserId"] = uid;
            return View(_db.Shops.ToList());
        }

        public IActionResult Shop(int shopId, int uid)
        {
            if(uid == 0)
                return RedirectToAction("Index", "Home");
            ViewBag.UserLevel = 2;
            TempData["UserId"] = uid;
            // var thisShop = _db.Shops.FirstOrDefault(s => s.LocationID == shopId);
            
            // if(thisShop == null)
            //     return RedirectToAction("Shops");

            return View();
        }
        
        public IActionResult Battle(int uid)
        {
            if(uid == 0)
                return RedirectToAction("Index", "Home");
            TempData["UserId"] = uid;
            ViewBag.UserLevel = 2;
            return View();
        }
    }
}
