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
        public IActionResult Shops()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
                return RedirectToAction("Index", "Home");
            ViewBag.UserLevel = 2;
            return View(_db.Shops.ToList());
        }

        public IActionResult Shop(int shopId)
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
                return RedirectToAction("Index", "Home");
            ViewBag.UserLevel = 2;
            // var thisShop = _db.Shops.FirstOrDefault(s => s.LocationID == shopId);
            
            // if(thisShop == null)
            //     return RedirectToAction("Shops");

            return View();
        }
        
        public IActionResult Battle()
        {
            if(HttpContext.Session.GetInt32("UserId") == null)
                return RedirectToAction("Index", "Home");
            ViewBag.UserLevel = 2;
            return View();
        }
    }
}
