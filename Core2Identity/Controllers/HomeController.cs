﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core2Identity.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }

        [Authorize(Roles ="Admin")]
        public IActionResult Sample()
        {
            return View();
        }


    }
}
