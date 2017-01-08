using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sdvcWebapp.Models;
using sdvcWebapp.Repository;

namespace sdvcWebapp.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: /Home/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
