using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Beast_Blitz.Client.Models;

namespace Beast_Blitz.Client.Controllers
{
    public class WorldController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
        
        public IActionResult Battle()
        {
            return View();
        }
    }
}
