using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id = 1)
        {
            return View(id);
        }

        public IActionResult Blank()
        {
            return View();
        }        
    }
}
